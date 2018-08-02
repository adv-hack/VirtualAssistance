using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AssociatesRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAssociateModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel AssociatedRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ASSOCIATE_ID" field.
        /// </summary>
        System.String AssociatedRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Role
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_PROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_TYPE" field.
        /// </summary>
        System.Byte TypeNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ASSO_TYPE_NAME" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ASSO_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }
    }
}
