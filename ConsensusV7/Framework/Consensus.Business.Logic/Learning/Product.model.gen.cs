using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Membership;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductModel : LocalModel<ProductRecord, String>, IProductModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROD_DESCRIP" field.
        /// </summary>
        private LocalC4textModel _prodDescrip;

        /// <summary>
        ///     The value of the "PROD_TEXT1" field.
        /// </summary>
        private LocalC4textModel _prodContent;

        /// <summary>
        ///     The value of the "PROD_TEXT2" field.
        /// </summary>
        private LocalC4textModel _prodPrereq;

        /// <summary>
        ///     The value of the "PROD_TEXT3" field.
        /// </summary>
        private LocalC4textModel _prodObjective;

        /// <summary>
        ///     The value of the "PROD_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "PROD_CATEGORY" field.
        /// </summary>
        private LocalCodeModel _category;

        /// <summary>
        ///     The value of the "PROD_GROUP" field.
        /// </summary>
        private LocalCodeModel _group;

        /// <summary>
        ///     The value of the "PROD_REV_CODE" field.
        /// </summary>
        private LocalCodeModel _revCode;

        /// <summary>
        ///     The value of the "PROD_VAT_CODE" field.
        /// </summary>
        private LocalCodeModel _vatCode;

        /// <summary>
        ///     The value of the "PROD_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _proleId;

        /// <summary>
        ///     The value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _productManager;

        /// <summary>
        ///     The value of the "PROD_BKT_ID" field.
        /// </summary>
        private LocalBookingTermsModel _bookingTerms;

        /// <summary>
        ///     The value of the "PROD_LOC_ID" field.
        /// </summary>
        private LocalLocationModel _location;

        /// <summary>
        ///     The value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        private LocalPersonModel _authorPerson;

        /// <summary>
        ///     The value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        private LocalCodeModel _regBody;

        /// <summary>
        ///     The value of the "PROD_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _venue;

        /// <summary>
        ///     The value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        private LocalCodeModel _searchGroup;

        /// <summary>
        ///     The value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        private LocalCodeModel _defDelStat;

        /// <summary>
        ///     The value of the "PROD_PSH_ID" field.
        /// </summary>
        private LocalPayscheduleheaderModel _paymentSchedule;

        /// <summary>
        ///     The value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        private LocalC4textModel _productTrainingRules;

        /// <summary>
        ///     The value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        private LocalCodeModel _defMethDel;

        /// <summary>
        ///     The value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        private LocalCodeModel _classification;

        /// <summary>
        ///     The value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        private LocalCodeModel _gatewayAccId;

        /// <summary>
        ///     The value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        private LocalCodeModel _royaltyModel;

        /// <summary>
        ///     The collection of <see cref="TrainProdXrefModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalTrainProdXrefModel, ITrainProdXrefModel> _trainProductXref;

        /// <summary>
        ///     The collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> _billOfMaterials;

        /// <summary>
        ///     The collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> _bOMs;

        /// <summary>
        ///     The collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> _accomBOMs;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="RelatedProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalRelatedProductModel, IRelatedProductModel> _relatedProduct;

        /// <summary>
        ///     The collection of <see cref="ProductEventModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalProductEventModel, IProductEventModel> _productEvents;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="EventProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalEventProductModel, IEventProductModel> _productEP;

        /// <summary>
        ///     The collection of <see cref="ProdSelectGroupModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalProdSelectGroupModel, IProdSelectGroupModel> _selectGroupProduct;

        /// <summary>
        ///     The collection of <see cref="TemplateResourceModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalTemplateResourceModel, ITemplateResourceModel> _templateResources;

        /// <summary>
        ///     The collection of <see cref="SessionModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalSessionModel, ISessionModel> _sessionCourse;

        /// <summary>
        ///     The collection of <see cref="OpportunityModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityModel, IOpportunityModel> _oppProdId;

        /// <summary>
        ///     The collection of <see cref="PackProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalPackProductModel, IPackProductModel> _packProducts;

        /// <summary>
        ///     The collection of <see cref="PriceModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalPriceModel, IPriceModel> _prices;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> _prepayAccounts;

        /// <summary>
        ///     The collection of <see cref="ProfileProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalProfileProductModel, IProfileProductModel> _profileProducts;

        /// <summary>
        ///     The collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalActivityXrefModel, IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The collection of <see cref="MemberBomModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalMemberBomModel, IMemberBomModel> _parentProduct;

        /// <summary>
        ///     The collection of <see cref="MemberBomModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalMemberBomModel, IMemberBomModel> _gradeProduct;

        /// <summary>
        ///     The collection of <see cref="CommitteeModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        private LocalCollection<LocalCommitteeModel, ICommitteeModel> _commiteeProduct;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Product.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Product.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Product.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REF" field.
        /// </summary>
        public String Ref
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DESCRIP" field.
        /// </summary>
        public LocalC4textModel ProdDescrip
        {
            get
            {
                if (_prodDescrip == null && this.ProdDescripId != null)
                    _prodDescrip = this.Provider.Activities.C4text.FetchById(this.ProdDescripId);
                if (_prodDescrip == null)
                    _prodDescrip = this.Provider.Activities.C4text.Create();
                
                return _prodDescrip;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DESCRIP" field.
        /// </summary>
        public String ProdDescripId
        {
            get { return this.ModifiedData.Descrip; }
            set
            {
                if (this.ModifiedData.Descrip != value)
                     _prodDescrip = null;
                this.ModifiedData.Descrip = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT1" field.
        /// </summary>
        public LocalC4textModel ProdContent
        {
            get
            {
                if (_prodContent == null && this.ProdContentId != null)
                    _prodContent = this.Provider.Activities.C4text.FetchById(this.ProdContentId);
                if (_prodContent == null)
                    _prodContent = this.Provider.Activities.C4text.Create();
                
                return _prodContent;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT1" field.
        /// </summary>
        public String ProdContentId
        {
            get { return this.ModifiedData.Text1; }
            set
            {
                if (this.ModifiedData.Text1 != value)
                     _prodContent = null;
                this.ModifiedData.Text1 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT2" field.
        /// </summary>
        public LocalC4textModel ProdPrereq
        {
            get
            {
                if (_prodPrereq == null && this.ProdPrereqId != null)
                    _prodPrereq = this.Provider.Activities.C4text.FetchById(this.ProdPrereqId);
                if (_prodPrereq == null)
                    _prodPrereq = this.Provider.Activities.C4text.Create();
                
                return _prodPrereq;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT2" field.
        /// </summary>
        public String ProdPrereqId
        {
            get { return this.ModifiedData.Text2; }
            set
            {
                if (this.ModifiedData.Text2 != value)
                     _prodPrereq = null;
                this.ModifiedData.Text2 = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT3" field.
        /// </summary>
        public LocalC4textModel ProdObjective
        {
            get
            {
                if (_prodObjective == null && this.ProdObjectiveId != null)
                    _prodObjective = this.Provider.Activities.C4text.FetchById(this.ProdObjectiveId);
                if (_prodObjective == null)
                    _prodObjective = this.Provider.Activities.C4text.Create();
                
                return _prodObjective;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT3" field.
        /// </summary>
        public String ProdObjectiveId
        {
            get { return this.ModifiedData.Text3; }
            set
            {
                if (this.ModifiedData.Text3 != value)
                     _prodObjective = null;
                this.ModifiedData.Text3 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SY_PRODUCT" field.
        /// </summary>
        public Byte? SyProduct
        {
            get { return this.ModifiedData.SyProduct; }
            set { this.ModifiedData.SyProduct = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("PRTYP", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("PRTYP");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CATEGORY" field.
        /// </summary>
        public LocalCodeModel Category
        {
            get
            {
                if (_category == null && !String.IsNullOrEmpty(this.CategoryCode))
                    _category = this.Provider.Common.Code.FetchByTypeAndCode("PRCAT", this.CategoryCode);
                if (_category == null)
                    _category = this.Provider.Common.Code.Create("PRCAT");
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CATEGORY" field.
        /// </summary>
        public String CategoryCode
        {
            get { return this.ModifiedData.Category; }
            set
            {
                if (this.ModifiedData.Category != value)
                     _category = null;
                this.ModifiedData.Category = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GROUP" field.
        /// </summary>
        public LocalCodeModel Group
        {
            get
            {
                if (_group == null && !String.IsNullOrEmpty(this.GroupCode))
                    _group = this.Provider.Common.Code.FetchByTypeAndCode("PRGRP", this.GroupCode);
                if (_group == null)
                    _group = this.Provider.Common.Code.Create("PRGRP");
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GROUP" field.
        /// </summary>
        public String GroupCode
        {
            get { return this.ModifiedData.Group; }
            set
            {
                if (this.ModifiedData.Group != value)
                     _group = null;
                this.ModifiedData.Group = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PRICE" field.
        /// </summary>
        public Double? Price
        {
            get { return this.ModifiedData.Price; }
            set { this.ModifiedData.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BLOCK_PRICE" field.
        /// </summary>
        public Double? BlockPrice
        {
            get { return this.ModifiedData.BlockPrice; }
            set { this.ModifiedData.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_PRICE" field.
        /// </summary>
        public Double? SparePrice
        {
            get { return this.ModifiedData.SparePrice; }
            set { this.ModifiedData.SparePrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_PRICE" field.
        /// </summary>
        public Double? CostPrice
        {
            get { return this.ModifiedData.CostPrice; }
            set { this.ModifiedData.CostPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REV_CODE" field.
        /// </summary>
        public LocalCodeModel RevCode
        {
            get
            {
                if (_revCode == null && !String.IsNullOrEmpty(this.RevCodeCode))
                    _revCode = this.Provider.Common.Code.FetchByTypeAndCode("REVE", this.RevCodeCode);
                if (_revCode == null)
                    _revCode = this.Provider.Common.Code.Create("REVE");
                return _revCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REV_CODE" field.
        /// </summary>
        public String RevCodeCode
        {
            get { return this.ModifiedData.RevCode; }
            set
            {
                if (this.ModifiedData.RevCode != value)
                     _revCode = null;
                this.ModifiedData.RevCode = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_VAT_CODE" field.
        /// </summary>
        public LocalCodeModel VatCode
        {
            get
            {
                if (_vatCode == null && !String.IsNullOrEmpty(this.VatCodeCode))
                    _vatCode = this.Provider.Common.Code.FetchByTypeAndCode("VATCD", this.VatCodeCode);
                if (_vatCode == null)
                    _vatCode = this.Provider.Common.Code.Create("VATCD");
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_VAT_CODE" field.
        /// </summary>
        public String VatCodeCode
        {
            get { return this.ModifiedData.VatCode; }
            set
            {
                if (this.ModifiedData.VatCode != value)
                     _vatCode = null;
                this.ModifiedData.VatCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MIN_ATTEND" field.
        /// </summary>
        public Double? MinAttend
        {
            get { return this.ModifiedData.MinAttend; }
            set { this.ModifiedData.MinAttend = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MAX_ATTEND" field.
        /// </summary>
        public Double? MaxAttend
        {
            get { return this.ModifiedData.MaxAttend; }
            set { this.ModifiedData.MaxAttend = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COURSE_LEN" field.
        /// </summary>
        public Double? CourseLen
        {
            get { return this.ModifiedData.CourseLen; }
            set { this.ModifiedData.CourseLen = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_FLAG1" field.
        /// </summary>
        public Byte? CanChangeCostCode
        {
            get { return this.ModifiedData.SpareFlag1; }
            set { this.ModifiedData.SpareFlag1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ENTRY_DATE" field.
        /// </summary>
        public DateTime? EntryDate
        {
            get { return this.ModifiedData.EntryDate; }
            set { this.ModifiedData.EntryDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CODE" field.
        /// </summary>
        public String SchemeNo
        {
            get { return this.ModifiedData.Code; }
            set { this.ModifiedData.Code = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SELL_HINT" field.
        /// </summary>
        public String ProdSellHint
        {
            get { return this.ModifiedData.SellHint; }
            set { this.ModifiedData.SellHint = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TOP_LEVEL" field.
        /// </summary>
        public Byte? TopLevel
        {
            get { return this.ModifiedData.TopLevel; }
            set { this.ModifiedData.TopLevel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STATE" field.
        /// </summary>
        public Byte? State
        {
            get { return this.ModifiedData.State; }
            set { this.ModifiedData.State = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STOCKED" field.
        /// </summary>
        public Byte? Stocked
        {
            get { return this.ModifiedData.Stocked; }
            set { this.ModifiedData.Stocked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AV" field.
        /// </summary>
        public Double? QtyAv
        {
            get { return this.ModifiedData.QtyAv; }
            set { this.ModifiedData.QtyAv = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AC" field.
        /// </summary>
        public Double? QtyAc
        {
            get { return this.ModifiedData.QtyAc; }
            set { this.ModifiedData.QtyAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRN_TXT_ID" field.
        /// </summary>
        public String TrnTxtId
        {
            get { return this.ModifiedData.TrnTxtId; }
            set { this.ModifiedData.TrnTxtId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel ProleId
        {
            get
            {
                if (_proleId == null && this.ProleIdId != null)
                    _proleId = this.Provider.Contact.Role.FetchById(this.ProleIdId);
                if (_proleId == null)
                    _proleId = this.Provider.Contact.Role.Create();
                
                return _proleId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PROLE_ID" field.
        /// </summary>
        public String ProleIdId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _proleId = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel ProductManager
        {
            get
            {
                if (_productManager == null && this.ProductManagerId != null)
                    _productManager = this.Provider.Contact.Role.FetchById(this.ProductManagerId);
                if (_productManager == null)
                    _productManager = this.Provider.Contact.Role.Create();
                
                return _productManager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        public String ProductManagerId
        {
            get { return this.ModifiedData.ManProleId; }
            set
            {
                if (this.ModifiedData.ManProleId != value)
                     _productManager = null;
                this.ModifiedData.ManProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_BKT_ID" field.
        /// </summary>
        public LocalBookingTermsModel BookingTerms
        {
            get
            {
                if (_bookingTerms == null && this.BookingTermsId != null)
                    _bookingTerms = this.Provider.Finance.BookingTerms.FetchById(this.BookingTermsId);
                if (_bookingTerms == null)
                    _bookingTerms = this.Provider.Finance.BookingTerms.Create();
                
                return _bookingTerms;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_BKT_ID" field.
        /// </summary>
        public String BookingTermsId
        {
            get { return this.ModifiedData.BktId; }
            set
            {
                if (this.ModifiedData.BktId != value)
                     _bookingTerms = null;
                this.ModifiedData.BktId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_LOC_ID" field.
        /// </summary>
        public LocalLocationModel Location
        {
            get
            {
                if (_location == null && this.LocationId != null)
                    _location = this.Provider.Contact.Location.FetchById(this.LocationId);
                if (_location == null)
                    _location = this.Provider.Contact.Location.Create();
                
                return _location;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_LOC_ID" field.
        /// </summary>
        public String LocationId
        {
            get { return this.ModifiedData.LocId; }
            set
            {
                if (this.ModifiedData.LocId != value)
                     _location = null;
                this.ModifiedData.LocId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_WEB" field.
        /// </summary>
        public Byte? Web
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "prod_quantity" field.
        /// </summary>
        public Double? ProdQuantity
        {
            get { return this.ModifiedData.ProdQuantity; }
            set { this.ModifiedData.ProdQuantity = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        public LocalPersonModel AuthorPerson
        {
            get
            {
                if (_authorPerson == null && this.AuthorPersonId != null)
                    _authorPerson = this.Provider.Contact.Person.FetchById(this.AuthorPersonId);
                if (_authorPerson == null)
                    _authorPerson = this.Provider.Contact.Person.Create();
                
                return _authorPerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        public String AuthorPersonId
        {
            get { return this.ModifiedData.AuthPnId; }
            set
            {
                if (this.ModifiedData.AuthPnId != value)
                     _authorPerson = null;
                this.ModifiedData.AuthPnId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ISBN" field.
        /// </summary>
        public String Isbn
        {
            get { return this.ModifiedData.Isbn; }
            set { this.ModifiedData.Isbn = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PAGE_COUNT" field.
        /// </summary>
        public Int32? PageCount
        {
            get { return this.ModifiedData.PageCount; }
            set { this.ModifiedData.PageCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FREQ" field.
        /// </summary>
        public Int32? Freq
        {
            get { return this.ModifiedData.Freq; }
            set { this.ModifiedData.Freq = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        public LocalCodeModel RegBody
        {
            get
            {
                if (_regBody == null && !String.IsNullOrEmpty(this.RegBodyCode))
                    _regBody = this.Provider.Common.Code.FetchByTypeAndCode("REGBO", this.RegBodyCode);
                if (_regBody == null)
                    _regBody = this.Provider.Common.Code.Create("REGBO");
                return _regBody;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        public String RegBodyCode
        {
            get { return this.ModifiedData.RegBodyId1; }
            set
            {
                if (this.ModifiedData.RegBodyId1 != value)
                     _regBody = null;
                this.ModifiedData.RegBodyId1 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REG_BODY_ID_2" field.
        /// </summary>
        public String RegBodyRef
        {
            get { return this.ModifiedData.RegBodyId2; }
            set { this.ModifiedData.RegBodyId2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_KEYWORDS" field.
        /// </summary>
        public String Keywords
        {
            get { return this.ModifiedData.Keywords; }
            set { this.ModifiedData.Keywords = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD" field.
        /// </summary>
        public Int32? CutOffPeriod
        {
            get { return this.ModifiedData.CutPrd; }
            set { this.ModifiedData.CutPrd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED" field.
        /// </summary>
        public Byte? Funded
        {
            get { return this.ModifiedData.Funded; }
            set { this.ModifiedData.Funded = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED_ORG_ID" field.
        /// </summary>
        public String FundingBody
        {
            get { return this.ModifiedData.FundedOrgId; }
            set { this.ModifiedData.FundedOrgId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QUAL_DEL" field.
        /// </summary>
        public Byte? QualDel
        {
            get { return this.ModifiedData.QualDel; }
            set { this.ModifiedData.QualDel = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Venue
        {
            get
            {
                if (_venue == null && this.VenueId != null)
                    _venue = this.Provider.Contact.Organisation.FetchById(this.VenueId);
                if (_venue == null)
                    _venue = this.Provider.Contact.Organisation.Create();
                
                return _venue;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ORG_ID" field.
        /// </summary>
        public String VenueId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _venue = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CALC_COMMISSION" field.
        /// </summary>
        public Byte? CalcCommission
        {
            get { return this.ModifiedData.CalcCommission; }
            set { this.ModifiedData.CalcCommission = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEF_TRAINEE_DAYS" field.
        /// </summary>
        public Decimal? DefTraineeDays
        {
            get { return this.ModifiedData.DefTraineeDays; }
            set { this.ModifiedData.DefTraineeDays = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_ELIGIBLE" field.
        /// </summary>
        public Byte? GrantEligible
        {
            get { return this.ModifiedData.GrantEligible; }
            set { this.ModifiedData.GrantEligible = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        public Decimal? GrantValueAvailable
        {
            get { return this.ModifiedData.GrantValueAvailable; }
            set { this.ModifiedData.GrantValueAvailable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_1" field.
        /// </summary>
        public Decimal? Breakeven1
        {
            get { return this.ModifiedData.Breakeven1; }
            set { this.ModifiedData.Breakeven1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_2" field.
        /// </summary>
        public Decimal? Breakeven2
        {
            get { return this.ModifiedData.Breakeven2; }
            set { this.ModifiedData.Breakeven2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_COURSEWARE" field.
        /// </summary>
        public Byte? ExtCourseware
        {
            get { return this.ModifiedData.ExtCourseware; }
            set { this.ModifiedData.ExtCourseware = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CONTINGENCY" field.
        /// </summary>
        public Int32? Contingency
        {
            get { return this.ModifiedData.Contingency; }
            set { this.ModifiedData.Contingency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return this.ModifiedData.Cost; }
            set { this.ModifiedData.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIVERY_DAY" field.
        /// </summary>
        public Int32? DeliveryDay
        {
            get { return this.ModifiedData.DeliveryDay; }
            set { this.ModifiedData.DeliveryDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return this.ModifiedData.ExtUrl; }
            set { this.ModifiedData.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NONE_CHARGEABLE" field.
        /// </summary>
        public Byte NoneChargeable
        {
            get { return this.ModifiedData.NoneChargeable; }
            set { this.ModifiedData.NoneChargeable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESIG_LETTERS" field.
        /// </summary>
        public String DesigLetters
        {
            get { return this.ModifiedData.DesigLetters; }
            set { this.ModifiedData.DesigLetters = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXPIRY_DATE" field.
        /// </summary>
        public DateTime? ExpiryDate
        {
            get { return this.ModifiedData.ExpiryDate; }
            set { this.ModifiedData.ExpiryDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_INV_ZERO_VAL" field.
        /// </summary>
        public Int32 InvZeroVal
        {
            get { return this.ModifiedData.InvZeroVal; }
            set { this.ModifiedData.InvZeroVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCLUDE_TRAIN_HISTORY" field.
        /// </summary>
        public Byte ExcludeTrainHistory
        {
            get { return this.ModifiedData.ExcludeTrainHistory; }
            set { this.ModifiedData.ExcludeTrainHistory = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_TYPE" field.
        /// </summary>
        public Byte StartDateType
        {
            get { return this.ModifiedData.StartDateType; }
            set { this.ModifiedData.StartDateType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_FIXED" field.
        /// </summary>
        public DateTime? StartDateFixed
        {
            get { return this.ModifiedData.StartDateFixed; }
            set { this.ModifiedData.StartDateFixed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET" field.
        /// </summary>
        public Int32 StartDateOffset
        {
            get { return this.ModifiedData.StartDateOffset; }
            set { this.ModifiedData.StartDateOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET_TYPE" field.
        /// </summary>
        public String StartDateOffsetType
        {
            get { return this.ModifiedData.StartDateOffsetType; }
            set { this.ModifiedData.StartDateOffsetType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_TYPE" field.
        /// </summary>
        public Byte EndDateType
        {
            get { return this.ModifiedData.EndDateType; }
            set { this.ModifiedData.EndDateType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_FIXED" field.
        /// </summary>
        public DateTime? EndDateFixed
        {
            get { return this.ModifiedData.EndDateFixed; }
            set { this.ModifiedData.EndDateFixed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET" field.
        /// </summary>
        public Int32 EndDateOffset
        {
            get { return this.ModifiedData.EndDateOffset; }
            set { this.ModifiedData.EndDateOffset = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET_TYPE" field.
        /// </summary>
        public String EndDateOffsetType
        {
            get { return this.ModifiedData.EndDateOffsetType; }
            set { this.ModifiedData.EndDateOffsetType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESC_EDITABLE" field.
        /// </summary>
        public Byte DescEditable
        {
            get { return this.ModifiedData.DescEditable; }
            set { this.ModifiedData.DescEditable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_AUTHOR_NAME" field.
        /// </summary>
        public String AuthorName
        {
            get { return this.ModifiedData.AuthorName; }
            set { this.ModifiedData.AuthorName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREPAY_UNITS" field.
        /// </summary>
        public Int32? PrepayUnits
        {
            get { return this.ModifiedData.PrepayUnits; }
            set { this.ModifiedData.PrepayUnits = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIV_METHOD" field.
        /// </summary>
        public String DelivMethod
        {
            get { return this.ModifiedData.DelivMethod; }
            set { this.ModifiedData.DelivMethod = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        public LocalCodeModel SearchGroup
        {
            get
            {
                if (_searchGroup == null && !String.IsNullOrEmpty(this.SearchGroupCode))
                    _searchGroup = this.Provider.Common.Code.FetchByTypeAndCode("PSGRP", this.SearchGroupCode);
                if (_searchGroup == null)
                    _searchGroup = this.Provider.Common.Code.Create("PSGRP");
                return _searchGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        public String SearchGroupCode
        {
            get { return this.ModifiedData.SearchGroup; }
            set
            {
                if (this.ModifiedData.SearchGroup != value)
                     _searchGroup = null;
                this.ModifiedData.SearchGroup = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        public LocalCodeModel DefDelStat
        {
            get
            {
                if (_defDelStat == null && !String.IsNullOrEmpty(this.DefDelStatCode))
                    _defDelStat = this.Provider.Common.Code.FetchByTypeAndCode("CDES", this.DefDelStatCode);
                if (_defDelStat == null)
                    _defDelStat = this.Provider.Common.Code.Create("CDES");
                return _defDelStat;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        public String DefDelStatCode
        {
            get { return this.ModifiedData.DefElemSt; }
            set
            {
                if (this.ModifiedData.DefElemSt != value)
                     _defDelStat = null;
                this.ModifiedData.DefElemSt = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SHORT_DESC" field.
        /// </summary>
        public String ProductSummary
        {
            get { return this.ModifiedData.ShortDesc; }
            set { this.ModifiedData.ShortDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONECLICK_CHECKOUT" field.
        /// </summary>
        public Byte OneclickCheckout
        {
            get { return this.ModifiedData.OneclickCheckout; }
            set { this.ModifiedData.OneclickCheckout = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BOOKER_ONLY" field.
        /// </summary>
        public Byte BookerOnly
        {
            get { return this.ModifiedData.BookerOnly; }
            set { this.ModifiedData.BookerOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEPT" field.
        /// </summary>
        public String Dept
        {
            get { return this.ModifiedData.Dept; }
            set { this.ModifiedData.Dept = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SKU" field.
        /// </summary>
        public String Sku
        {
            get { return this.ModifiedData.Sku; }
            set { this.ModifiedData.Sku = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_CODE" field.
        /// </summary>
        public String JobCode
        {
            get { return this.ModifiedData.JobCode; }
            set { this.ModifiedData.JobCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_ANALY_CODE" field.
        /// </summary>
        public String JobAnalyCode
        {
            get { return this.ModifiedData.JobAnalyCode; }
            set { this.ModifiedData.JobAnalyCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_TYPE" field.
        /// </summary>
        public String JobType
        {
            get { return this.ModifiedData.JobType; }
            set { this.ModifiedData.JobType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_PARENT" field.
        /// </summary>
        public String JobParent
        {
            get { return this.ModifiedData.JobParent; }
            set { this.ModifiedData.JobParent = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PSH_ID" field.
        /// </summary>
        public LocalPayscheduleheaderModel PaymentSchedule
        {
            get
            {
                if (_paymentSchedule == null && this.PaymentScheduleId != null)
                    _paymentSchedule = this.Provider.Finance.Payscheduleheader.FetchById(this.PaymentScheduleId.Value);
                if (_paymentSchedule == null)
                    _paymentSchedule = this.Provider.Finance.Payscheduleheader.Create();
                
                return _paymentSchedule;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PSH_ID" field.
        /// </summary>
        public Int32? PaymentScheduleId
        {
            get { return this.ModifiedData.PshId; }
            set
            {
                if (this.ModifiedData.PshId != value)
                     _paymentSchedule = null;
                this.ModifiedData.PshId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_IMAGE" field.
        /// </summary>
        public String Image
        {
            get { return this.ModifiedData.Image; }
            set { this.ModifiedData.Image = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONLINE_SCHE" field.
        /// </summary>
        public String OnlineSchedule
        {
            get { return this.ModifiedData.OnlineSche; }
            set { this.ModifiedData.OnlineSche = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_URL_NAME" field.
        /// </summary>
        public String UrlName
        {
            get { return this.ModifiedData.UrlName; }
            set { this.ModifiedData.UrlName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRAIN_PROV" field.
        /// </summary>
        public Byte? TrainProv
        {
            get { return this.ModifiedData.TrainProv; }
            set { this.ModifiedData.TrainProv = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_LICENSED" field.
        /// </summary>
        public Byte Licensed
        {
            get { return this.ModifiedData.Licensed; }
            set { this.ModifiedData.Licensed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEL_CLOSE_DAYS" field.
        /// </summary>
        public Int32 DelCloseDays
        {
            get { return this.ModifiedData.DelCloseDays; }
            set { this.ModifiedData.DelCloseDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        public LocalC4textModel ProductTrainingRules
        {
            get
            {
                if (_productTrainingRules == null && this.ProductTrainingRulesId != null)
                    _productTrainingRules = this.Provider.Activities.C4text.FetchById(this.ProductTrainingRulesId);
                if (_productTrainingRules == null)
                    _productTrainingRules = this.Provider.Activities.C4text.Create();
                
                return _productTrainingRules;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        public String ProductTrainingRulesId
        {
            get { return this.ModifiedData.TrnRulesTxt; }
            set
            {
                if (this.ModifiedData.TrnRulesTxt != value)
                     _productTrainingRules = null;
                this.ModifiedData.TrnRulesTxt = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        public LocalCodeModel DefMethDel
        {
            get
            {
                if (_defMethDel == null && !String.IsNullOrEmpty(this.DefMethDelCode))
                    _defMethDel = this.Provider.Common.Code.FetchByTypeAndCode("TLTOD", this.DefMethDelCode);
                if (_defMethDel == null)
                    _defMethDel = this.Provider.Common.Code.Create("TLTOD");
                return _defMethDel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        public String DefMethDelCode
        {
            get { return this.ModifiedData.DefMethDel; }
            set
            {
                if (this.ModifiedData.DefMethDel != value)
                     _defMethDel = null;
                this.ModifiedData.DefMethDel = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        public LocalCodeModel Classification
        {
            get
            {
                if (_classification == null && !String.IsNullOrEmpty(this.ClassificationCode))
                    _classification = this.Provider.Common.Code.FetchByTypeAndCode("CIMAG", this.ClassificationCode);
                if (_classification == null)
                    _classification = this.Provider.Common.Code.Create("CIMAG");
                return _classification;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        public String ClassificationCode
        {
            get { return this.ModifiedData.CodeImage; }
            set
            {
                if (this.ModifiedData.CodeImage != value)
                     _classification = null;
                this.ModifiedData.CodeImage = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        public LocalCodeModel GatewayAccId
        {
            get
            {
                if (_gatewayAccId == null && !String.IsNullOrEmpty(this.GatewayAccIdCode))
                    _gatewayAccId = this.Provider.Common.Code.FetchByTypeAndCode("GATAC", this.GatewayAccIdCode);
                if (_gatewayAccId == null)
                    _gatewayAccId = this.Provider.Common.Code.Create("GATAC");
                return _gatewayAccId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        public String GatewayAccIdCode
        {
            get { return this.ModifiedData.GatewayAccId; }
            set
            {
                if (this.ModifiedData.GatewayAccId != value)
                     _gatewayAccId = null;
                this.ModifiedData.GatewayAccId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        public LocalCodeModel RoyaltyModel
        {
            get
            {
                if (_royaltyModel == null && !String.IsNullOrEmpty(this.RoyaltyModelCode))
                    _royaltyModel = this.Provider.Common.Code.FetchByTypeAndCode("ROYMO", this.RoyaltyModelCode);
                if (_royaltyModel == null)
                    _royaltyModel = this.Provider.Common.Code.Create("ROYMO");
                return _royaltyModel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        public String RoyaltyModelCode
        {
            get { return this.ModifiedData.RoyaltyModel; }
            set
            {
                if (this.ModifiedData.RoyaltyModel != value)
                     _royaltyModel = null;
                this.ModifiedData.RoyaltyModel = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD_TIME" field.
        /// </summary>
        public Byte? CutOffTime
        {
            get { return this.ModifiedData.CutPrdTime; }
            set { this.ModifiedData.CutPrdTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GIFTAID" field.
        /// </summary>
        public Byte? Giftaid
        {
            get { return this.ModifiedData.Giftaid; }
            set { this.ModifiedData.Giftaid = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainProdXrefModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalTrainProdXrefModel, ITrainProdXrefModel> TrainProductXref
        {
            get
            {
                if (_trainProductXref == null)
                    _trainProductXref = new LocalCollection<LocalTrainProdXrefModel, ITrainProdXrefModel>(this.Provider.Contact.TrainProdXref.FetchAllByProductId(this.Id));
                
                return _trainProductXref;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> BillOfMaterials
        {
            get
            {
                if (_billOfMaterials == null)
                    _billOfMaterials = new LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel>(this.Provider.Learning.BillOfMaterial.FetchAllByMasterProductId(this.Id));
                
                return _billOfMaterials;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> BOMs
        {
            get
            {
                if (_bOMs == null)
                    _bOMs = new LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel>(this.Provider.Learning.BillOfMaterial.FetchAllByChildProductId(this.Id));
                
                return _bOMs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> AccomBOMs
        {
            get
            {
                if (_accomBOMs == null)
                    _accomBOMs = new LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel>(this.Provider.Learning.BillOfMaterial.FetchAllByAccomProductId(this.Id));
                
                return _accomBOMs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByProductId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="RelatedProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalRelatedProductModel, IRelatedProductModel> RelatedProduct
        {
            get
            {
                if (_relatedProduct == null)
                    _relatedProduct = new LocalCollection<LocalRelatedProductModel, IRelatedProductModel>(this.Provider.Learning.RelatedProduct.FetchAllByRelatedProdIdId(this.Id));
                
                return _relatedProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductEventModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalProductEventModel, IProductEventModel> ProductEvents
        {
            get
            {
                if (_productEvents == null)
                    _productEvents = new LocalCollection<LocalProductEventModel, IProductEventModel>(this.Provider.Learning.ProductEvent.FetchAllByProductId(this.Id));
                
                return _productEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByProductId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalEventProductModel, IEventProductModel> ProductEP
        {
            get
            {
                if (_productEP == null)
                    _productEP = new LocalCollection<LocalEventProductModel, IEventProductModel>(this.Provider.Learning.EventProduct.FetchAllByProductId(this.Id));
                
                return _productEP;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProdSelectGroupModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalProdSelectGroupModel, IProdSelectGroupModel> SelectGroupProduct
        {
            get
            {
                if (_selectGroupProduct == null)
                    _selectGroupProduct = new LocalCollection<LocalProdSelectGroupModel, IProdSelectGroupModel>(this.Provider.Learning.ProdSelectGroup.FetchAllByProdIdId(this.Id));
                
                return _selectGroupProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TemplateResourceModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalTemplateResourceModel, ITemplateResourceModel> TemplateResources
        {
            get
            {
                if (_templateResources == null)
                    _templateResources = new LocalCollection<LocalTemplateResourceModel, ITemplateResourceModel>(this.Provider.Learning.TemplateResource.FetchAllByResourceId(this.Id));
                
                return _templateResources;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalSessionModel, ISessionModel> SessionCourse
        {
            get
            {
                if (_sessionCourse == null)
                    _sessionCourse = new LocalCollection<LocalSessionModel, ISessionModel>(this.Provider.Learning.Session.FetchAllByProductId(this.Id));
                
                return _sessionCourse;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityModel, IOpportunityModel> OppProdId
        {
            get
            {
                if (_oppProdId == null)
                    _oppProdId = new LocalCollection<LocalOpportunityModel, IOpportunityModel>(this.Provider.Sales.Opportunity.FetchAllByProductId(this.Id));
                
                return _oppProdId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalPackProductModel, IPackProductModel> PackProducts
        {
            get
            {
                if (_packProducts == null)
                    _packProducts = new LocalCollection<LocalPackProductModel, IPackProductModel>(this.Provider.Document.PackProduct.FetchAllByProductId(this.Id));
                
                return _packProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PriceModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalPriceModel, IPriceModel> Prices
        {
            get
            {
                if (_prices == null)
                    _prices = new LocalCollection<LocalPriceModel, IPriceModel>(this.Provider.Finance.Price.FetchAllByProductId(this.Id));
                
                return _prices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllByProductIdId(this.Id));
                
                return _invoiceLines;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> PrepayAccounts
        {
            get
            {
                if (_prepayAccounts == null)
                    _prepayAccounts = new LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel>(this.Provider.Finance.PrepayAccount.FetchAllByProductId(this.Id));
                
                return _prepayAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProfileProductModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalProfileProductModel, IProfileProductModel> ProfileProducts
        {
            get
            {
                if (_profileProducts == null)
                    _profileProducts = new LocalCollection<LocalProfileProductModel, IProfileProductModel>(this.Provider.Common.ProfileProduct.FetchAllByProductId(this.Id));
                
                return _profileProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalActivityXrefModel, IActivityXrefModel> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new LocalCollection<LocalActivityXrefModel, IActivityXrefModel>(this.Provider.Activities.ActivityXref.FetchAllByProductId(this.Id));
                
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberBomModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalMemberBomModel, IMemberBomModel> ParentProduct
        {
            get
            {
                if (_parentProduct == null)
                    _parentProduct = new LocalCollection<LocalMemberBomModel, IMemberBomModel>(this.Provider.Membership.MemberBom.FetchAllByProdParentIdId(this.Id));
                
                return _parentProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberBomModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalMemberBomModel, IMemberBomModel> GradeProduct
        {
            get
            {
                if (_gradeProduct == null)
                    _gradeProduct = new LocalCollection<LocalMemberBomModel, IMemberBomModel>(this.Provider.Membership.MemberBom.FetchAllByGradeProdId(this.Id));
                
                return _gradeProduct;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CommitteeModel" /> instances that reference this <see cref="ProductModel" />.
        /// </summary>
        public LocalCollection<LocalCommitteeModel, ICommitteeModel> CommiteeProduct
        {
            get
            {
                if (_commiteeProduct == null)
                    _commiteeProduct = new LocalCollection<LocalCommitteeModel, ICommitteeModel>(this.Provider.Membership.Committee.FetchAllByProdIdId(this.Id));
                
                return _commiteeProduct;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProductModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProductModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProductModel(LocalProvider provider, ProductRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_category != null)
            {
                _category.Save();
                this.ModifiedData.Category = _category.Value1;
            }
            if (_group != null)
            {
                _group.Save();
                this.ModifiedData.Group = _group.Value1;
            }
            if (_revCode != null)
            {
                _revCode.Save();
                this.ModifiedData.RevCode = _revCode.Value1;
            }
            if (_vatCode != null)
            {
                _vatCode.Save();
                this.ModifiedData.VatCode = _vatCode.Value1;
            }
            if (_regBody != null)
            {
                _regBody.Save();
                this.ModifiedData.RegBodyId1 = _regBody.Value1;
            }
            if (_searchGroup != null)
            {
                _searchGroup.Save();
                this.ModifiedData.SearchGroup = _searchGroup.Value1;
            }
            if (_defDelStat != null)
            {
                _defDelStat.Save();
                this.ModifiedData.DefElemSt = _defDelStat.Value1;
            }
            if (_defMethDel != null)
            {
                _defMethDel.Save();
                this.ModifiedData.DefMethDel = _defMethDel.Value1;
            }
            if (_classification != null)
            {
                _classification.Save();
                this.ModifiedData.CodeImage = _classification.Value1;
            }
            if (_gatewayAccId != null)
            {
                _gatewayAccId.Save();
                this.ModifiedData.GatewayAccId = _gatewayAccId.Value1;
            }
            if (_royaltyModel != null)
            {
                _royaltyModel.Save();
                this.ModifiedData.RoyaltyModel = _royaltyModel.Value1;
            }
            if (_prodDescrip != null)
            {
                _prodDescrip.Save();
                this.ModifiedData.Descrip = _prodDescrip.Id == null && this.ModifiedData.Descrip != null ? "" : _prodDescrip.Id;
            }
            if (_prodContent != null)
            {
                _prodContent.Save();
                this.ModifiedData.Text1 = _prodContent.Id == null && this.ModifiedData.Text1 != null ? "" : _prodContent.Id;
            }
            if (_prodPrereq != null)
            {
                _prodPrereq.Save();
                this.ModifiedData.Text2 = _prodPrereq.Id == null && this.ModifiedData.Text2 != null ? "" : _prodPrereq.Id;
            }
            if (_prodObjective != null)
            {
                _prodObjective.Save();
                this.ModifiedData.Text3 = _prodObjective.Id == null && this.ModifiedData.Text3 != null ? "" : _prodObjective.Id;
            }
            if (_proleId != null)
            {
                _proleId.Save();
                this.ModifiedData.ProleId = _proleId.Id == null && this.ModifiedData.ProleId != null ? "" : _proleId.Id;
            }
            if (_productManager != null)
            {
                _productManager.Save();
                this.ModifiedData.ManProleId = _productManager.Id == null && this.ModifiedData.ManProleId != null ? "" : _productManager.Id;
            }
            if (_bookingTerms != null)
            {
                _bookingTerms.Save();
                this.ModifiedData.BktId = _bookingTerms.Id == null && this.ModifiedData.BktId != null ? "" : _bookingTerms.Id;
            }
            if (_location != null)
            {
                _location.Save();
                this.ModifiedData.LocId = _location.Id == null && this.ModifiedData.LocId != null ? "" : _location.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_authorPerson != null)
            {
                _authorPerson.Save();
                this.ModifiedData.AuthPnId = _authorPerson.Id == null && this.ModifiedData.AuthPnId != null ? "" : _authorPerson.Id;
            }
            if (_venue != null)
            {
                _venue.Save();
                this.ModifiedData.OrgId = _venue.Id == null && this.ModifiedData.OrgId != null ? "" : _venue.Id;
            }
            if (_paymentSchedule != null)
            {
                _paymentSchedule.Save();
                this.ModifiedData.PshId = _paymentSchedule.Id;
            }
            if (_productTrainingRules != null)
            {
                _productTrainingRules.Save();
                this.ModifiedData.TrnRulesTxt = _productTrainingRules.Id == null && this.ModifiedData.TrnRulesTxt != null ? "" : _productTrainingRules.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_trainProductXref != null)
                _trainProductXref.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_billOfMaterials != null)
                _billOfMaterials.Execute(obj => obj.MasterProductId = this.Id).Execute(obj => obj.Save());
            if (_bOMs != null)
                _bOMs.Execute(obj => obj.ChildProductId = this.Id).Execute(obj => obj.Save());
            if (_accomBOMs != null)
                _accomBOMs.Execute(obj => obj.AccomProductId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_relatedProduct != null)
                _relatedProduct.Execute(obj => obj.RelatedProdIdId = this.Id).Execute(obj => obj.Save());
            if (_productEvents != null)
                _productEvents.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_elements != null)
                _elements.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_productEP != null)
                _productEP.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_selectGroupProduct != null)
                _selectGroupProduct.Execute(obj => obj.ProdIdId = this.Id).Execute(obj => obj.Save());
            if (_templateResources != null)
                _templateResources.Execute(obj => obj.ResourceId = this.Id).Execute(obj => obj.Save());
            if (_sessionCourse != null)
                _sessionCourse.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_oppProdId != null)
                _oppProdId.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_packProducts != null)
                _packProducts.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_prices != null)
                _prices.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.ProductIdId = this.Id).Execute(obj => obj.Save());
            if (_prepayAccounts != null)
                _prepayAccounts.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_profileProducts != null)
                _profileProducts.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_activityXRefs != null)
                _activityXRefs.Execute(obj => obj.ProductId = this.Id).Execute(obj => obj.Save());
            if (_parentProduct != null)
                _parentProduct.Execute(obj => obj.ProdParentIdId = this.Id).Execute(obj => obj.Save());
            if (_gradeProduct != null)
                _gradeProduct.Execute(obj => obj.GradeProdId = this.Id).Execute(obj => obj.Save());
            if (_commiteeProduct != null)
                _commiteeProduct.Execute(obj => obj.ProdIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the academic code.
        /// </summary>
        Consensus.Learning.IProductEventModel IProductModel.ActiveProductEvent
        {
            get { return this.ActiveProductEvent; }
        }

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.IBillOfMaterialModel IProductModel.MainSession
        {
            get { return this.MainSession; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REF" field.
        /// </summary>
        System.String IProductModel.Ref
        {
            get { return this.Ref; }
            set { this.Ref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NAME" field.
        /// </summary>
        System.String IProductModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DESCRIP" field.
        /// </summary>
        Consensus.Activities.IC4textModel IProductModel.ProdDescrip
        {
            get { return this.ProdDescrip; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DESCRIP" field.
        /// </summary>
        System.String IProductModel.ProdDescripId
        {
            get { return this.ProdDescripId; }
            set { this.ProdDescripId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT1" field.
        /// </summary>
        Consensus.Activities.IC4textModel IProductModel.ProdContent
        {
            get { return this.ProdContent; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT1" field.
        /// </summary>
        System.String IProductModel.ProdContentId
        {
            get { return this.ProdContentId; }
            set { this.ProdContentId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT2" field.
        /// </summary>
        Consensus.Activities.IC4textModel IProductModel.ProdPrereq
        {
            get { return this.ProdPrereq; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT2" field.
        /// </summary>
        System.String IProductModel.ProdPrereqId
        {
            get { return this.ProdPrereqId; }
            set { this.ProdPrereqId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT3" field.
        /// </summary>
        Consensus.Activities.IC4textModel IProductModel.ProdObjective
        {
            get { return this.ProdObjective; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT3" field.
        /// </summary>
        System.String IProductModel.ProdObjectiveId
        {
            get { return this.ProdObjectiveId; }
            set { this.ProdObjectiveId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SY_PRODUCT" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.SyProduct
        {
            get { return this.SyProduct; }
            set { this.SyProduct = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TYPE" field.
        /// </summary>
        System.String IProductModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.Category
        {
            get { return this.Category; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CATEGORY" field.
        /// </summary>
        System.String IProductModel.CategoryCode
        {
            get { return this.CategoryCode; }
            set { this.CategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.Group
        {
            get { return this.Group; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GROUP" field.
        /// </summary>
        System.String IProductModel.GroupCode
        {
            get { return this.GroupCode; }
            set { this.GroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.Price
        {
            get { return this.Price; }
            set { this.Price = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BLOCK_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.BlockPrice
        {
            get { return this.BlockPrice; }
            set { this.BlockPrice = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.SparePrice
        {
            get { return this.SparePrice; }
            set { this.SparePrice = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.CostPrice
        {
            get { return this.CostPrice; }
            set { this.CostPrice = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_CODE" field.
        /// </summary>
        System.String IProductModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.RevCode
        {
            get { return this.RevCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REV_CODE" field.
        /// </summary>
        System.String IProductModel.RevCodeCode
        {
            get { return this.RevCodeCode; }
            set { this.RevCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_VAT_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.VatCode
        {
            get { return this.VatCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_VAT_CODE" field.
        /// </summary>
        System.String IProductModel.VatCodeCode
        {
            get { return this.VatCodeCode; }
            set { this.VatCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MIN_ATTEND" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.MinAttend
        {
            get { return this.MinAttend; }
            set { this.MinAttend = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MAX_ATTEND" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.MaxAttend
        {
            get { return this.MaxAttend; }
            set { this.MaxAttend = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COURSE_LEN" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.CourseLen
        {
            get { return this.CourseLen; }
            set { this.CourseLen = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_FLAG1" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.CanChangeCostCode
        {
            get { return this.CanChangeCostCode; }
            set { this.CanChangeCostCode = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ENTRY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IProductModel.EntryDate
        {
            get { return this.EntryDate; }
            set { this.EntryDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CODE" field.
        /// </summary>
        System.String IProductModel.SchemeNo
        {
            get { return this.SchemeNo; }
            set { this.SchemeNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SELL_HINT" field.
        /// </summary>
        System.String IProductModel.ProdSellHint
        {
            get { return this.ProdSellHint; }
            set { this.ProdSellHint = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TOP_LEVEL" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.TopLevel
        {
            get { return this.TopLevel; }
            set { this.TopLevel = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STATE" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.State
        {
            get { return this.State; }
            set { this.State = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STOCKED" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.Stocked
        {
            get { return this.Stocked; }
            set { this.Stocked = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AV" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.QtyAv
        {
            get { return this.QtyAv; }
            set { this.QtyAv = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AC" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.QtyAc
        {
            get { return this.QtyAc; }
            set { this.QtyAc = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRN_TXT_ID" field.
        /// </summary>
        System.String IProductModel.TrnTxtId
        {
            get { return this.TrnTxtId; }
            set { this.TrnTxtId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IProductModel.ProleId
        {
            get { return this.ProleId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PROLE_ID" field.
        /// </summary>
        System.String IProductModel.ProleIdId
        {
            get { return this.ProleIdId; }
            set { this.ProleIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IProductModel.ProductManager
        {
            get { return this.ProductManager; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        System.String IProductModel.ProductManagerId
        {
            get { return this.ProductManagerId; }
            set { this.ProductManagerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_BKT_ID" field.
        /// </summary>
        Consensus.Finance.IBookingTermsModel IProductModel.BookingTerms
        {
            get { return this.BookingTerms; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_BKT_ID" field.
        /// </summary>
        System.String IProductModel.BookingTermsId
        {
            get { return this.BookingTermsId; }
            set { this.BookingTermsId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel IProductModel.Location
        {
            get { return this.Location; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_LOC_ID" field.
        /// </summary>
        System.String IProductModel.LocationId
        {
            get { return this.LocationId; }
            set { this.LocationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_WEB" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.Web
        {
            get { return this.Web; }
            set { this.Web = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "prod_quantity" field.
        /// </summary>
        System.Nullable<System.Double> IProductModel.ProdQuantity
        {
            get { return this.ProdQuantity; }
            set { this.ProdQuantity = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IProductModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        System.String IProductModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IProductModel.AuthorPerson
        {
            get { return this.AuthorPerson; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        System.String IProductModel.AuthorPersonId
        {
            get { return this.AuthorPersonId; }
            set { this.AuthorPersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ISBN" field.
        /// </summary>
        System.String IProductModel.Isbn
        {
            get { return this.Isbn; }
            set { this.Isbn = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PAGE_COUNT" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.PageCount
        {
            get { return this.PageCount; }
            set { this.PageCount = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FREQ" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.Freq
        {
            get { return this.Freq; }
            set { this.Freq = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.RegBody
        {
            get { return this.RegBody; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        System.String IProductModel.RegBodyCode
        {
            get { return this.RegBodyCode; }
            set { this.RegBodyCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REG_BODY_ID_2" field.
        /// </summary>
        System.String IProductModel.RegBodyRef
        {
            get { return this.RegBodyRef; }
            set { this.RegBodyRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_KEYWORDS" field.
        /// </summary>
        System.String IProductModel.Keywords
        {
            get { return this.Keywords; }
            set { this.Keywords = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.CutOffPeriod
        {
            get { return this.CutOffPeriod; }
            set { this.CutOffPeriod = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.Funded
        {
            get { return this.Funded; }
            set { this.Funded = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED_ORG_ID" field.
        /// </summary>
        System.String IProductModel.FundingBody
        {
            get { return this.FundingBody; }
            set { this.FundingBody = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QUAL_DEL" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.QualDel
        {
            get { return this.QualDel; }
            set { this.QualDel = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IProductModel.Venue
        {
            get { return this.Venue; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ORG_ID" field.
        /// </summary>
        System.String IProductModel.VenueId
        {
            get { return this.VenueId; }
            set { this.VenueId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CALC_COMMISSION" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.CalcCommission
        {
            get { return this.CalcCommission; }
            set { this.CalcCommission = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEF_TRAINEE_DAYS" field.
        /// </summary>
        System.Nullable<System.Decimal> IProductModel.DefTraineeDays
        {
            get { return this.DefTraineeDays; }
            set { this.DefTraineeDays = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_ELIGIBLE" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.GrantEligible
        {
            get { return this.GrantEligible; }
            set { this.GrantEligible = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        System.Nullable<System.Decimal> IProductModel.GrantValueAvailable
        {
            get { return this.GrantValueAvailable; }
            set { this.GrantValueAvailable = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_1" field.
        /// </summary>
        System.Nullable<System.Decimal> IProductModel.Breakeven1
        {
            get { return this.Breakeven1; }
            set { this.Breakeven1 = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_2" field.
        /// </summary>
        System.Nullable<System.Decimal> IProductModel.Breakeven2
        {
            get { return this.Breakeven2; }
            set { this.Breakeven2 = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_COURSEWARE" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.ExtCourseware
        {
            get { return this.ExtCourseware; }
            set { this.ExtCourseware = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CONTINGENCY" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.Contingency
        {
            get { return this.Contingency; }
            set { this.Contingency = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> IProductModel.Cost
        {
            get { return this.Cost; }
            set { this.Cost = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIVERY_DAY" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.DeliveryDay
        {
            get { return this.DeliveryDay; }
            set { this.DeliveryDay = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_URL" field.
        /// </summary>
        System.String IProductModel.ExtUrl
        {
            get { return this.ExtUrl; }
            set { this.ExtUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NONE_CHARGEABLE" field.
        /// </summary>
        System.Byte IProductModel.NoneChargeable
        {
            get { return this.NoneChargeable; }
            set { this.NoneChargeable = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESIG_LETTERS" field.
        /// </summary>
        System.String IProductModel.DesigLetters
        {
            get { return this.DesigLetters; }
            set { this.DesigLetters = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXPIRY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IProductModel.ExpiryDate
        {
            get { return this.ExpiryDate; }
            set { this.ExpiryDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_INV_ZERO_VAL" field.
        /// </summary>
        System.Int32 IProductModel.InvZeroVal
        {
            get { return this.InvZeroVal; }
            set { this.InvZeroVal = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCLUDE_TRAIN_HISTORY" field.
        /// </summary>
        System.Byte IProductModel.ExcludeTrainHistory
        {
            get { return this.ExcludeTrainHistory; }
            set { this.ExcludeTrainHistory = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_TYPE" field.
        /// </summary>
        System.Byte IProductModel.StartDateType
        {
            get { return this.StartDateType; }
            set { this.StartDateType = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_FIXED" field.
        /// </summary>
        System.Nullable<System.DateTime> IProductModel.StartDateFixed
        {
            get { return this.StartDateFixed; }
            set { this.StartDateFixed = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET" field.
        /// </summary>
        System.Int32 IProductModel.StartDateOffset
        {
            get { return this.StartDateOffset; }
            set { this.StartDateOffset = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET_TYPE" field.
        /// </summary>
        System.String IProductModel.StartDateOffsetType
        {
            get { return this.StartDateOffsetType; }
            set { this.StartDateOffsetType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_TYPE" field.
        /// </summary>
        System.Byte IProductModel.EndDateType
        {
            get { return this.EndDateType; }
            set { this.EndDateType = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_FIXED" field.
        /// </summary>
        System.Nullable<System.DateTime> IProductModel.EndDateFixed
        {
            get { return this.EndDateFixed; }
            set { this.EndDateFixed = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET" field.
        /// </summary>
        System.Int32 IProductModel.EndDateOffset
        {
            get { return this.EndDateOffset; }
            set { this.EndDateOffset = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET_TYPE" field.
        /// </summary>
        System.String IProductModel.EndDateOffsetType
        {
            get { return this.EndDateOffsetType; }
            set { this.EndDateOffsetType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESC_EDITABLE" field.
        /// </summary>
        System.Byte IProductModel.DescEditable
        {
            get { return this.DescEditable; }
            set { this.DescEditable = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_AUTHOR_NAME" field.
        /// </summary>
        System.String IProductModel.AuthorName
        {
            get { return this.AuthorName; }
            set { this.AuthorName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREPAY_UNITS" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.PrepayUnits
        {
            get { return this.PrepayUnits; }
            set { this.PrepayUnits = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIV_METHOD" field.
        /// </summary>
        System.String IProductModel.DelivMethod
        {
            get { return this.DelivMethod; }
            set { this.DelivMethod = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.SearchGroup
        {
            get { return this.SearchGroup; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        System.String IProductModel.SearchGroupCode
        {
            get { return this.SearchGroupCode; }
            set { this.SearchGroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.DefDelStat
        {
            get { return this.DefDelStat; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        System.String IProductModel.DefDelStatCode
        {
            get { return this.DefDelStatCode; }
            set { this.DefDelStatCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SHORT_DESC" field.
        /// </summary>
        System.String IProductModel.ProductSummary
        {
            get { return this.ProductSummary; }
            set { this.ProductSummary = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONECLICK_CHECKOUT" field.
        /// </summary>
        System.Byte IProductModel.OneclickCheckout
        {
            get { return this.OneclickCheckout; }
            set { this.OneclickCheckout = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BOOKER_ONLY" field.
        /// </summary>
        System.Byte IProductModel.BookerOnly
        {
            get { return this.BookerOnly; }
            set { this.BookerOnly = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEPT" field.
        /// </summary>
        System.String IProductModel.Dept
        {
            get { return this.Dept; }
            set { this.Dept = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SKU" field.
        /// </summary>
        System.String IProductModel.Sku
        {
            get { return this.Sku; }
            set { this.Sku = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_CODE" field.
        /// </summary>
        System.String IProductModel.JobCode
        {
            get { return this.JobCode; }
            set { this.JobCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_ANALY_CODE" field.
        /// </summary>
        System.String IProductModel.JobAnalyCode
        {
            get { return this.JobAnalyCode; }
            set { this.JobAnalyCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_TYPE" field.
        /// </summary>
        System.String IProductModel.JobType
        {
            get { return this.JobType; }
            set { this.JobType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_PARENT" field.
        /// </summary>
        System.String IProductModel.JobParent
        {
            get { return this.JobParent; }
            set { this.JobParent = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PSH_ID" field.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderModel IProductModel.PaymentSchedule
        {
            get { return this.PaymentSchedule; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PSH_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IProductModel.PaymentScheduleId
        {
            get { return this.PaymentScheduleId; }
            set { this.PaymentScheduleId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_IMAGE" field.
        /// </summary>
        System.String IProductModel.Image
        {
            get { return this.Image; }
            set { this.Image = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONLINE_SCHE" field.
        /// </summary>
        System.String IProductModel.OnlineSchedule
        {
            get { return this.OnlineSchedule; }
            set { this.OnlineSchedule = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_URL_NAME" field.
        /// </summary>
        System.String IProductModel.UrlName
        {
            get { return this.UrlName; }
            set { this.UrlName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRAIN_PROV" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.TrainProv
        {
            get { return this.TrainProv; }
            set { this.TrainProv = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_LICENSED" field.
        /// </summary>
        System.Byte IProductModel.Licensed
        {
            get { return this.Licensed; }
            set { this.Licensed = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEL_CLOSE_DAYS" field.
        /// </summary>
        System.Int32 IProductModel.DelCloseDays
        {
            get { return this.DelCloseDays; }
            set { this.DelCloseDays = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        Consensus.Activities.IC4textModel IProductModel.ProductTrainingRules
        {
            get { return this.ProductTrainingRules; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        System.String IProductModel.ProductTrainingRulesId
        {
            get { return this.ProductTrainingRulesId; }
            set { this.ProductTrainingRulesId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.DefMethDel
        {
            get { return this.DefMethDel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        System.String IProductModel.DefMethDelCode
        {
            get { return this.DefMethDelCode; }
            set { this.DefMethDelCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.Classification
        {
            get { return this.Classification; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        System.String IProductModel.ClassificationCode
        {
            get { return this.ClassificationCode; }
            set { this.ClassificationCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.GatewayAccId
        {
            get { return this.GatewayAccId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        System.String IProductModel.GatewayAccIdCode
        {
            get { return this.GatewayAccIdCode; }
            set { this.GatewayAccIdCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        Consensus.Common.ICodeModel IProductModel.RoyaltyModel
        {
            get { return this.RoyaltyModel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        System.String IProductModel.RoyaltyModelCode
        {
            get { return this.RoyaltyModelCode; }
            set { this.RoyaltyModelCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD_TIME" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.CutOffTime
        {
            get { return this.CutOffTime; }
            set { this.CutOffTime = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GIFTAID" field.
        /// </summary>
        System.Nullable<System.Byte> IProductModel.Giftaid
        {
            get { return this.Giftaid; }
            set { this.Giftaid = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainProdXrefModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainProdXrefModel> IProductModel.TrainProductXref
        {
            get { return this.TrainProductXref; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> IProductModel.BillOfMaterials
        {
            get { return this.BillOfMaterials; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> IProductModel.BOMs
        {
            get { return this.BOMs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> IProductModel.AccomBOMs
        {
            get { return this.AccomBOMs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventModel> IProductModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RelatedProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IRelatedProductModel> IProductModel.RelatedProduct
        {
            get { return this.RelatedProduct; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductEventModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductEventModel> IProductModel.ProductEvents
        {
            get { return this.ProductEvents; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IProductModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventProductModel> IProductModel.ProductEP
        {
            get { return this.ProductEP; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProdSelectGroupModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProdSelectGroupModel> IProductModel.SelectGroupProduct
        {
            get { return this.SelectGroupProduct; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateResourceModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateResourceModel> IProductModel.TemplateResources
        {
            get { return this.TemplateResources; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionModel> IProductModel.SessionCourse
        {
            get { return this.SessionCourse; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> IProductModel.OppProdId
        {
            get { return this.OppProdId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackProductModel> IProductModel.PackProducts
        {
            get { return this.PackProducts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PriceModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPriceModel> IProductModel.Prices
        {
            get { return this.Prices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> IProductModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> IProductModel.PrepayAccounts
        {
            get { return this.PrepayAccounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileProductModel> IProductModel.ProfileProducts
        {
            get { return this.ProfileProducts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> IProductModel.ActivityXRefs
        {
            get { return this.ActivityXRefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberBomModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberBomModel> IProductModel.ParentProduct
        {
            get { return this.ParentProduct; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberBomModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberBomModel> IProductModel.GradeProduct
        {
            get { return this.GradeProduct; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeModel> IProductModel.CommiteeProduct
        {
            get { return this.CommiteeProduct; }
        }

        #endregion
    }
}
