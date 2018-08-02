using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="EventProductRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IEventProductModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.ISessionXrefModel SessionXrefMaster
        {
            get;
        }

        System.Boolean IsModified
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "EP_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel Event
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_COURSE_ID" field.
        /// </summary>
        System.String EventId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "EP_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "EP_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel Notes
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_NOTES" field.
        /// </summary>
        System.String NotesId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_QTY" field.
        /// </summary>
        System.Nullable<System.Int32> Qty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_DELEGATE_QTY" field.
        /// </summary>
        System.Nullable<System.Int32> DelegateQty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_PREDELIV" field.
        /// </summary>
        System.Byte Predeliv
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:EventProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionXrefModel> EPSessionXref
        {
            get;
        }
    }
}
