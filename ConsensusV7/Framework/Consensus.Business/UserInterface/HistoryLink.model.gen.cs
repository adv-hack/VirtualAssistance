using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="HistorylinkRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IHistoryLinkModel : IModel<Int32>
    {
        #region properties

        System.Boolean IsModified
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_MOD_DATE" field.
        /// </summary>
        System.DateTime ModDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HL_USER_ID" field.
        /// </summary>
        Consensus.Security.IUserAccountModel User
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HL_USER_ID" field.
        /// </summary>
        System.Int32 UserId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HL_ICON" field.
        /// </summary>
        System.String Icon
        {
            get;
            set;
        }

        #endregion

        #region methods

        void SaveAndCleanUp();

        #endregion
    }
}
