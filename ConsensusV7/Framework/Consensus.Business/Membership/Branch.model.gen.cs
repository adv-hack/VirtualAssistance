using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="BranchRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBranchModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "BR_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BR_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BR_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BR_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel Category
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_CATEGORY" field.
        /// </summary>
        System.String CategoryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BR_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel Group
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_GROUP" field.
        /// </summary>
        System.String GroupCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BR_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel Region
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_REGION" field.
        /// </summary>
        System.String RegionCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_WEB" field.
        /// </summary>
        System.Byte Web
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_EXT_URL" field.
        /// </summary>
        System.String ExtUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BranchXrefModel" /> instances that reference this <see cref="!:BranchModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IBranchXrefModel> BranchXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:BranchModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeModel> CommiteeBranch
        {
            get;
        }
    }
}
