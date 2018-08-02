using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="C4textRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalC4textModel
    {
        #region properties
        /// <summary>
        /// The resolved name of the user that created the record
        /// </summary>
        public string AddByName
        {
            get
            {
                int iAddBy;
                if (int.TryParse(AddBy, out iAddBy))
                {
                    LocalUserAccountModel user = this.Provider.Security.UserAccount.FetchById(iAddBy);
                    if (user != null && user.Person != null)
                    {
                        return user.Person.FirstName + " " + user.Person.Surname;
                    }
                }
                return AddBy;
            }
        }

        /// <summary>
        /// The resolved name of the user that last updated the record.
        /// </summary>
        public string ModByName
        {
            get
            {
                int iModBy;
                if (int.TryParse(ModBy, out iModBy))
                {
                    LocalUserAccountModel user = this.Provider.Security.UserAccount.FetchById(iModBy);
                    if (user != null && user.Person != null)
                    {
                        return user.Person.FirstName + " " + user.Person.Surname;
                    }
                }
                return ModBy;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Provides denormalisation of the C4Text data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            if (this.Html != null)
                this.Body = this.Html.HtmlToText();
        }

        #endregion
    }
}
