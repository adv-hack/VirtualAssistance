using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="BillOfMaterialRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBillOfMaterialModel : IModel<String>
    {
        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateTrainerModel> Trainers
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateResourceModel> Resources
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateRoomModel> Rooms
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PARENT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel MasterProduct
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PARENT_ID" field.
        /// </summary>
        System.String MasterProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ChildProduct
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        System.String ChildProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel AccomProduct
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        System.String AccomProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_REAL" field.
        /// </summary>
        System.Nullable<System.Byte> Real
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> Session
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ELEMENT" field.
        /// </summary>
        System.Nullable<System.Byte> Element
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_DAY" field.
        /// </summary>
        System.Nullable<System.Double> StartDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_DAY" field.
        /// </summary>
        System.Nullable<System.Double> EndDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> StartTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> EndTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_QUANTITY" field.
        /// </summary>
        System.Nullable<System.Double> Quantity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MANDATORY" field.
        /// </summary>
        System.Nullable<System.Byte> Mandatory
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CHARGEABLE" field.
        /// </summary>
        System.Nullable<System.Byte> Chargeable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INVOICE_PRINT" field.
        /// </summary>
        System.Nullable<System.Byte> InvoicePrint
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOM_ACT_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel ActType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_ACT_TYPE" field.
        /// </summary>
        System.String ActTypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_SALES" field.
        /// </summary>
        System.Nullable<System.Byte> ShowSales
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_NOTE" field.
        /// </summary>
        System.String ActNote
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MAIN_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> MainSession
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE_SUB" field.
        /// </summary>
        System.String TypeSub
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ROOM_LAYOUT" field.
        /// </summary>
        System.Nullable<System.Int32> RoomLayout
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INC_IN_BUDGET" field.
        /// </summary>
        System.Byte IncInBudget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TEACH_HRS" field.
        /// </summary>
        System.Nullable<System.Decimal> TeachHrs
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_STUD_WKS" field.
        /// </summary>
        System.Nullable<System.Decimal> StudWks
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_SESSION_NAME" field.
        /// </summary>
        System.String ActSessionName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_PREDELIV" field.
        /// </summary>
        System.Byte Predeliv
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CODE" field.
        /// </summary>
        System.String Code
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PSG_ID" field.
        /// </summary>
        Consensus.Learning.IProdSelectGroupModel PsgId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PSG_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PsgIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_REVENUE_SPLIT" field.
        /// </summary>
        System.Double ActRevenueSplit
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_HOURS_SPLIT" field.
        /// </summary>
        System.Double ActHoursSplit
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_EXP_OCCUPANCY" field.
        /// </summary>
        System.Nullable<System.Int32> ExpOccupancy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_ATT_LOG" field.
        /// </summary>
        System.Nullable<System.Byte> ShowAttLog
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateModel> Templates
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionModel> Sessions
        {
            get;
        }
    }
}
