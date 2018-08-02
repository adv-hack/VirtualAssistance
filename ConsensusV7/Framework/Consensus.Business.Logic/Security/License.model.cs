using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a software license.
    /// </summary>
    public partial class LocalLicenseModel
    {
        #region fields

        /// <summary>
        ///     The computed status of the software license.
        /// </summary>
        private LicenseStatus? _status;

        /// <summary>
        ///     The collection of enabled modules;
        /// </summary>
        private LicenseModuleState[] _modules;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of enabled modules;
        /// </summary>
        public LicenseModuleState[] Modules
        {
            get
            {
                if (_modules == null)
                {
                    LocalLicenseModuleModel[] databaseModules = this.Provider.Security.LicenseModule.FetchAllByLicenseId(this.Id).ToArray();
                    LicenseModules[] enumeratedModules = Enum.GetValues(typeof(LicenseModules)).OfType<LicenseModules>().Where(mod => LocalLicenseModel.IsSelectableModule(mod)).ToArray();
                    _modules = enumeratedModules.Select(mod => new LicenseModuleState() { Module = mod, Enabled = databaseModules.Any(licmod => licmod.Module == mod) }).ToArray();
                }
                return _modules;
            }
            set
            {
                _modules = value;
            }
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        public String StatusText
        {
            get { return this.Status.ToString(); }
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        public LicenseStatus Status
        {
            get
            {
                if (_status == null)
                {
                    Byte[] signature = this.ModifiedData.Signature == null ? null : this.ModifiedData.Signature.Reverse().SkipWhile(b => b == 0x00).Reverse().ToArray();

                    if (this.Active.Date > DateTime.Now.Date)
                        _status = LicenseStatus.Inactive;
                    else if (this.Expiry.HasValue && this.Expiry.Value.Date < DateTime.Now.Date)
                        _status = LicenseStatus.Expired;
                    else if (signature == null || signature.Length == 0)
                        _status = LicenseStatus.Revoked;
                    else if (this.ModifiedData.Signature == null || !LicenseKey.PublicKey.Verify(this.ComputeHash(), signature))
                        _status = LicenseStatus.Invalid;
                    else
                        _status = LicenseStatus.OK;
                }
                return _status.Value;
            }
        }

        /// <summary>
        ///     Gets the hexadecimal encoded hash of the license-protected data which is signed to verify the license.
        /// </summary>
        public String Verification
        {
            get { return String.Join("", this.ComputeHash().Select(b => b.ToString("x2"))); }
        }

        /// <summary>
        ///     Gets the digital signature for the license.
        /// </summary>
        public String Signature
        {
            get
            {
                return String.Join("", this.ModifiedData.Signature.Select(b => b.ToString("x2")));
            }
            set
            {
                List<Byte> result = new List<Byte>();
                if (!String.IsNullOrEmpty(value) && value.Length % 2 == 0)
                {
                    for (Int32 i = 0; i < value.Length; i += 2)
                    {
                        Byte parsedValue;
                        if (!Byte.TryParse(value.Substring(i, 2), out parsedValue))
                            return;

                        result.Add(parsedValue);
                    }
                    this.ModifiedData.Signature = result.ToArray();
                }
            }
        }

        #endregion
        
        #region methods

        /// <summary>
        ///     Saves the license key.
        /// </summary>
        public override void Save()
        {
            // Check whether vendor-authorisation is required.
            if (!this.IsPersisted || !this.ComputeHash().SequenceEqual(this.Provider.Security.License.FetchById(this.Id).ComputeHash()) || this.Status == LicenseStatus.Invalid)
            {
                // Obtain the required license key.
                LicenseKey licenseKey = LicenseKey.PrivateKey;
                if (licenseKey != null)
                    this.ModifiedData.Signature = licenseKey.Sign(this.ComputeHash());       
            }

            this._status = null;
            
            // Recompute the status and save if the license has not been invalidated.
            if (this.Status != LicenseStatus.Invalid)
            {
                base.Save();
                this.Provider.Security.License.Reset();
            }
        }

        /// <summary>
        ///     Executes after this <see cref="LocalLicenseModel"/> has been saved and is used to save the modules that have been selected/deselected.
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (_modules != null)
            {
                // Delete any modules that were enabled in the database but are no longer enabled in this License instance.
                LocalLicenseModuleModel[] dbModules = this.Provider.Security.LicenseModule.FetchAllByLicenseId(this.Id).Where(licmod => LocalLicenseModel.IsSelectableModule(licmod.Module) && !this.Modules.Any(mod => mod.Module == licmod.Module && mod.Enabled)).ToArray();
                dbModules.Execute(licmod => licmod.Delete());

                // Create new database modules for modules which are now enabled
                LicenseModules[] enabledModules = this.Modules.Where(mod => LocalLicenseModel.IsSelectableModule(mod.Module) && mod.Enabled && !dbModules.Any(licmod => mod.Module == licmod.Module)).Select(mod => mod.Module).ToArray();
                foreach (LicenseModules module in enabledModules)
                {
                    LocalLicenseModuleModel newEntry = this.Provider.Security.LicenseModule.Create();
                    newEntry.License = this.Id;
                    newEntry.Module = module;
                    newEntry.Save();
                }                    
            }
        }
        
        /// <summary>
        ///     Computes an SHA-512 cryptographic hash from the protected data held on the license.
        /// </summary>
        /// <returns>
        ///     An SHA-512 cryptographic hash which can be used to verify or sign the license.
        /// </returns>
        private Byte[] ComputeHash()
        {
            Byte[] hash;
            
            // Serialize the license information into a JSON object.
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Object objectDefinition = LocalLicenseModel.ConstructDefinition(this);
            String stringDefinition = serializer.Serialize(objectDefinition);
            Byte[] binaryDefinition = Encoding.ASCII.GetBytes(stringDefinition);

            // Compute a SHA-512 hash from the JSON object
            using (SHA512 hashAlgorithm = SHA512.Create())
                hash = hashAlgorithm.ComputeHash(binaryDefinition);

            return hash;
        }

        /// <summary>
        ///     Constructs a hashable object of the specified license.
        /// </summary>
        private static Dictionary<String, Object> ConstructDefinition(LocalLicenseModel model)
        {
            // Get the database-persisted non-selectable modules, plus the instance-persisted selectable modules.
            List<LicenseModules> modules = new List<LicenseModules>();
            modules.AddRange(model.Provider.Security.LicenseModule.FetchAllByLicenseId(model.Id).Select(licmod => licmod.Module).Where(mod => !IsSelectableModule(mod)));
            modules.AddRange(model.Modules.Where(mod => mod.Enabled).Select(mod => mod.Module));
            
            Dictionary<String, Object> definition = new Dictionary<String, Object>();
            definition.Add("Active", model.Active.ToString("yyyy-MM-dd"));
            definition.Add("Expiry", model.Expiry == null ? null : model.Expiry.Value.ToString("yyyy-MM-dd"));
            definition.Add("Limits", model.Limits.Select(LocalLicenseModel.ConstructDefinition));
            definition.Add("Modules", modules.Select(module => module.ConvertTo<Guid>()));
            return definition;
        }

        /// <summary>
        ///     Constructs a hashable object of the specified license limitation.
        /// </summary>
        private static Dictionary<String, Object> ConstructDefinition(LocalLicenseLimitModel model)
        {
            Dictionary<String, Object> definition = new Dictionary<String, Object>();
            definition.Add("Type", model.Type);
            definition.Add("Value", model.Value);
            return definition;
        }

        /// <summary>
        ///     Identifies whether a software module is selecteable within the user interface or via the API
        /// </summary>
        private static Boolean IsSelectableModule(LicenseModules module)
        {
            String moduleName = module.ToString();
            FieldInfo moduleInfo = typeof(LicenseModules).GetField(moduleName, BindingFlags.Public | BindingFlags.Static);
            BrowsableAttribute moduleAttr = moduleInfo.GetCustomAttributes().OfType<BrowsableAttribute>().FirstOrDefault();
            return (moduleAttr == null || moduleAttr.Browsable);
        }

        #endregion
    }
}
