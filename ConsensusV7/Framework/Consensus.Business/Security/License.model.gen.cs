using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a software license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseModel : IModel<Guid>
    {
        #region properties

        /// <summary>
        ///     Gets the collection of enabled modules;.
        /// </summary>
        Consensus.Security.LicenseModuleState[] Modules
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        System.String StatusText
        {
            get;
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        Consensus.Security.LicenseStatus Status
        {
            get;
        }

        /// <summary>
        ///     Gets the hexadecimal encoded hash of the license-protected data which is signed to verify the license.
        /// </summary>
        System.String Verification
        {
            get;
        }

        /// <summary>
        ///     Gets the digital signature for the license.
        /// </summary>
        System.String Signature
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_ACTIVE" field.
        /// </summary>
        System.DateTime Active
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_EXPIRY" field.
        /// </summary>
        System.Nullable<System.DateTime> Expiry
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LIC_OWNER" field.
        /// </summary>
        Consensus.Contact.IRoleModel Owner
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIC_OWNER" field.
        /// </summary>
        System.String OwnerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LicenseLimitModel" /> instances that reference this <see cref="!:LicenseModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.ILicenseLimitModel> Limits
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Saves the license key.
        /// </summary>
        void Save();

        #endregion
    }
}
