using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="OpportunityRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOpportunityModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the client for the opp.
        /// </summary>
        Consensus.Sales.IOpportunityXrefModel ClientOppXref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the main sales person for the opp.
        /// </summary>
        Consensus.Sales.IOpportunityXrefModel SalesOppXref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_QUO_ID" field.
        /// </summary>
        System.String QuoId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel PromId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROM_ID" field.
        /// </summary>
        System.String PromIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_ENQ" field.
        /// </summary>
        System.Nullable<System.DateTime> DateEnq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_DATE_DEC" field.
        /// </summary>
        System.Nullable<System.DateTime> DateDec
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_VAL_POT" field.
        /// </summary>
        System.Nullable<System.Double> ValPot
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_PURCH" field.
        /// </summary>
        System.Nullable<System.Byte> ProbPurch
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_PROB_WIN" field.
        /// </summary>
        System.Nullable<System.Byte> ProbWin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_ROLL_QTY" field.
        /// </summary>
        System.Nullable<System.Double> RollQty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        Consensus.Common.ICodeModel ProdInterest
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_INTEREST" field.
        /// </summary>
        System.String ProdInterestCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_MEDIUM" field.
        /// </summary>
        Consensus.Common.ICodeModel Source
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_MEDIUM" field.
        /// </summary>
        System.String SourceCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel Activity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_ACT_ID" field.
        /// </summary>
        System.String ActivityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COMPETITOR" field.
        /// </summary>
        Consensus.Common.ICodeModel Competitor
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COMPETITOR" field.
        /// </summary>
        System.String CompetitorCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COMMIT" field.
        /// </summary>
        System.Nullable<System.Byte> Commit
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SALES_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel SalesType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SALES_TYPE" field.
        /// </summary>
        System.String SalesTypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel CourseId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_COURSE_ID" field.
        /// </summary>
        System.String CourseIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SERVICE" field.
        /// </summary>
        Consensus.Common.ICodeModel Service
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SERVICE" field.
        /// </summary>
        System.String ServiceCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel SearchGroup
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPP_SEARCH_GROUP" field.
        /// </summary>
        System.String SearchGroupCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPP_SY_TYPE" field.
        /// </summary>
        System.Int32 SyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityXrefModel> OpportunityXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityModel" /> instances that reference this <see cref="!:OpportunityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityModel> ActivityOpportunity
        {
            get;
        }
    }
}
