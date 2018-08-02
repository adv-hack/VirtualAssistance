using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="CommitteeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommitteeModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "COM_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel Category
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_CATEGORY" field.
        /// </summary>
        System.String CategoryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel Group
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_GROUP" field.
        /// </summary>
        System.String GroupCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_DIS_ID" field.
        /// </summary>
        Consensus.Membership.IDistrictModel DisId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_DIS_ID" field.
        /// </summary>
        System.String DisIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ProdId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_PROD_ID" field.
        /// </summary>
        System.String ProdIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COM_BR_ID" field.
        /// </summary>
        Consensus.Membership.IBranchModel BrId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_BR_ID" field.
        /// </summary>
        System.String BrIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_EXT_URL" field.
        /// </summary>
        System.String ExtUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_SHOW_ON_ORG" field.
        /// </summary>
        System.Nullable<System.Byte> ShowOnOrg
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NO_PEOPLE" field.
        /// </summary>
        System.Nullable<System.Int32> NoPeople
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeXrefModel" /> instances that reference this <see cref="!:CommitteeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeXrefModel> CommitteeXrefCommitteeId
        {
            get;
        }
    }
}
