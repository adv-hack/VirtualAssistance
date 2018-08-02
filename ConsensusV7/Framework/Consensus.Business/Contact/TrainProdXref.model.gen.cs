using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TrainProdXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITrainProdXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_FROM" field.
        /// </summary>
        System.String RcvFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_RCV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RcvDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        Consensus.Contact.ITrainerModel Trainer
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_TRAIN_ID" field.
        /// </summary>
        System.String TrainerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_LOC_ID" field.
        /// </summary>
        System.String LocId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TPXREF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TPXREF_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_STATUS" field.
        /// </summary>
        System.String Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_GRADE" field.
        /// </summary>
        System.String Grade
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TPXREF_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> Cost
        {
            get;
            set;
        }
    }
}
