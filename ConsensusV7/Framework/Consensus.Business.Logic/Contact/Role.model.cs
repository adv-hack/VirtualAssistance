using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents A role held by a person.
    /// </summary>
    public partial class LocalRoleModel
    {
        #region fields

        /// <summary>
        ///     The persons home role.
        /// </summary>
        private LocalRoleModel _homeRole;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the persons home role.
        /// </summary>
        public LocalRoleModel HomeRole
        {
            get
            {
                if (_homeRole == null && !String.IsNullOrEmpty(this.OrganisationId))
                    _homeRole = this.Person.Roles.FirstOrDefault(role => !role.IsRoleDisabled && String.IsNullOrEmpty(role.OrganisationId));

                return _homeRole;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_FAX" field.
        /// </summary>
        public Boolean DoNotFax
        {
            get { return this.ModifiedData.DoNotFax.ConvertTo<Boolean>(); }
            set { this.ModifiedData.DoNotFax = value.ConvertTo<Byte>(); }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        public Boolean DoNotEmail
        {
            get { return this.ModifiedData.DoNotEmail.ConvertTo<Boolean>(); }
            set { this.ModifiedData.DoNotEmail = value.ConvertTo<Byte>(); }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_SWAP" field.
        /// </summary>
        public Boolean DoNotSwap
        {
            get { return this.ModifiedData.DoNotSwap.ConvertTo<Boolean>(); }
            set { this.ModifiedData.DoNotSwap = value.ConvertTo<Byte>(); }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_MAIL" field.
        /// </summary>
        public Boolean DoNotMail
        {
            get { return this.ModifiedData.DoNotMail.ConvertTo<Boolean>(); }
            set { this.ModifiedData.DoNotMail = value.ConvertTo<Byte>(); }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_USERNUM_1" field.
        /// </summary>
        public Boolean DoNotTelesale
        {
            get { return this.ModifiedData.Usernum1 == 1; }
            set { this.ModifiedData.Usernum1 = value ? 1: 0; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DIS_FLAG" field.
        /// </summary>
        public Boolean IsRoleDisabled
        {
            get { return this.ModifiedData.DisFlag.ConvertTo<Boolean>(); }
            set { this.ModifiedData.DisFlag = value.ConvertTo<Byte>(); }
        }

        //public override Boolean IsModified
        //{
        //    get { return base.IsModified || this.RoleCommunication.Any(x => x.IsModified); }
        //}

        #endregion

        #region methods

        /// <summary>
        ///     Initialises a new instance of the business model.
        /// </summary>
        protected override void Initialise()
        {
            LocalSellingCompanyModel defaultSellingCompany = this.Provider.Common.SellingCompany.FetchDefault();
            if (defaultSellingCompany != null)
                this.SellingCompanyId = defaultSellingCompany.Id;
        }

        protected internal override void Denormalise()
        {
            this.PersonName = this.Person.FullName;
        }

        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (_homeRole != null && _homeRole.IsModified)
            {
                _homeRole.PersonId = this.PersonId;
                _homeRole.OrganisationId = null;
                _homeRole.Save();
            }
        }

        #endregion
    }
}
