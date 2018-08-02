using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class BillOfMaterial : Proxy<IBillOfMaterialModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Trainers" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.TemplateTrainer, Consensus.Learning.ITemplateTrainerModel> _trainers;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Resources" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.TemplateResource, Consensus.Learning.ITemplateResourceModel> _resources;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Rooms" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.TemplateRoom, Consensus.Learning.ITemplateRoomModel> _rooms;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MasterProduct" /> member.
        /// </summary>
        private Consensus.Learning.Product _masterProduct;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ChildProduct" /> member.
        /// </summary>
        private Consensus.Learning.Product _childProduct;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AccomProduct" /> member.
        /// </summary>
        private Consensus.Learning.Product _accomProduct;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ActType" /> member.
        /// </summary>
        private Consensus.Common.Code _actType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PsgId" /> member.
        /// </summary>
        private Consensus.Learning.ProdSelectGroup _psgId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Templates" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Template, Consensus.Learning.ITemplateModel> _templates;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Sessions" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel> _sessions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        public Collection<Consensus.Learning.TemplateTrainer> Trainers
        {
            get
            {
                if (_trainers == null)
                    _trainers = new ProxyCollection<Consensus.Learning.TemplateTrainer, Consensus.Learning.ITemplateTrainerModel>(this.Model.Trainers, model => new Consensus.Learning.TemplateTrainer(model));
                return _trainers;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        public Collection<Consensus.Learning.TemplateResource> Resources
        {
            get
            {
                if (_resources == null)
                    _resources = new ProxyCollection<Consensus.Learning.TemplateResource, Consensus.Learning.ITemplateResourceModel>(this.Model.Resources, model => new Consensus.Learning.TemplateResource(model));
                return _resources;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="T:Consensus.Learning.ITemplateTrainerModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        public Collection<Consensus.Learning.TemplateRoom> Rooms
        {
            get
            {
                if (_rooms == null)
                    _rooms = new ProxyCollection<Consensus.Learning.TemplateRoom, Consensus.Learning.ITemplateRoomModel>(this.Model.Rooms, model => new Consensus.Learning.TemplateRoom(model));
                return _rooms;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PARENT_ID" field.
        /// </summary>
        public Consensus.Learning.Product MasterProduct
        {
            get
            {
                if (_masterProduct == null && this.Model.MasterProduct != null)
                    _masterProduct = new Consensus.Learning.Product(this.Model.MasterProduct);
                if (_masterProduct == null)
                    _masterProduct = Consensus.Learning.Product.Create();
                return _masterProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PARENT_ID" field.
        /// </summary>
        public System.String MasterProductId
        {
            get { return this.Model.MasterProductId; }
            set { this.Model.MasterProductId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        public Consensus.Learning.Product ChildProduct
        {
            get
            {
                if (_childProduct == null && this.Model.ChildProduct != null)
                    _childProduct = new Consensus.Learning.Product(this.Model.ChildProduct);
                if (_childProduct == null)
                    _childProduct = Consensus.Learning.Product.Create();
                return _childProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_SYLLABUS_ID" field.
        /// </summary>
        public System.String ChildProductId
        {
            get { return this.Model.ChildProductId; }
            set { this.Model.ChildProductId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        public Consensus.Learning.Product AccomProduct
        {
            get
            {
                if (_accomProduct == null && this.Model.AccomProduct != null)
                    _accomProduct = new Consensus.Learning.Product(this.Model.AccomProduct);
                if (_accomProduct == null)
                    _accomProduct = Consensus.Learning.Product.Create();
                return _accomProduct;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_RESOURCE_ID" field.
        /// </summary>
        public System.String AccomProductId
        {
            get { return this.Model.AccomProductId; }
            set { this.Model.AccomProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_REAL" field.
        /// </summary>
        public System.Nullable<System.Byte> Real
        {
            get { return this.Model.Real; }
            set { this.Model.Real = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SESSION" field.
        /// </summary>
        public System.Nullable<System.Byte> Session
        {
            get { return this.Model.Session; }
            set { this.Model.Session = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ELEMENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Element
        {
            get { return this.Model.Element; }
            set { this.Model.Element = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_DAY" field.
        /// </summary>
        public System.Nullable<System.Double> StartDay
        {
            get { return this.Model.StartDay; }
            set { this.Model.StartDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_DAY" field.
        /// </summary>
        public System.Nullable<System.Double> EndDay
        {
            get { return this.Model.EndDay; }
            set { this.Model.EndDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_START_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartTime
        {
            get { return this.Model.StartTime; }
            set { this.Model.StartTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_END_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndTime
        {
            get { return this.Model.EndTime; }
            set { this.Model.EndTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_QUANTITY" field.
        /// </summary>
        public System.Nullable<System.Double> Quantity
        {
            get { return this.Model.Quantity; }
            set { this.Model.Quantity = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MANDATORY" field.
        /// </summary>
        public System.Nullable<System.Byte> Mandatory
        {
            get { return this.Model.Mandatory; }
            set { this.Model.Mandatory = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CHARGEABLE" field.
        /// </summary>
        public System.Nullable<System.Byte> Chargeable
        {
            get { return this.Model.Chargeable; }
            set { this.Model.Chargeable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INVOICE_PRINT" field.
        /// </summary>
        public System.Nullable<System.Byte> InvoicePrint
        {
            get { return this.Model.InvoicePrint; }
            set { this.Model.InvoicePrint = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_ACT_TYPE" field.
        /// </summary>
        public Consensus.Common.Code ActType
        {
            get
            {
                if (_actType == null && this.Model.ActType != null)
                    _actType = new Consensus.Common.Code(this.Model.ActType);
                if (_actType == null)
                    _actType = Consensus.Common.Code.Create();
                return _actType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_ACT_TYPE" field.
        /// </summary>
        public System.String ActTypeCode
        {
            get { return this.Model.ActTypeCode; }
            set { this.Model.ActTypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_SALES" field.
        /// </summary>
        public System.Nullable<System.Byte> ShowSales
        {
            get { return this.Model.ShowSales; }
            set { this.Model.ShowSales = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_NOTE" field.
        /// </summary>
        public System.String ActNote
        {
            get { return this.Model.ActNote; }
            set { this.Model.ActNote = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_MAIN_SESSION" field.
        /// </summary>
        public System.Nullable<System.Byte> MainSession
        {
            get { return this.Model.MainSession; }
            set { this.Model.MainSession = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TYPE_SUB" field.
        /// </summary>
        public System.String TypeSub
        {
            get { return this.Model.TypeSub; }
            set { this.Model.TypeSub = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ROOM_LAYOUT" field.
        /// </summary>
        public System.Nullable<System.Int32> RoomLayout
        {
            get { return this.Model.RoomLayout; }
            set { this.Model.RoomLayout = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_INC_IN_BUDGET" field.
        /// </summary>
        public System.Byte IncInBudget
        {
            get { return this.Model.IncInBudget; }
            set { this.Model.IncInBudget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_TEACH_HRS" field.
        /// </summary>
        public System.Nullable<System.Decimal> TeachHrs
        {
            get { return this.Model.TeachHrs; }
            set { this.Model.TeachHrs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_STUD_WKS" field.
        /// </summary>
        public System.Nullable<System.Decimal> StudWks
        {
            get { return this.Model.StudWks; }
            set { this.Model.StudWks = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_SESSION_NAME" field.
        /// </summary>
        public System.String ActSessionName
        {
            get { return this.Model.ActSessionName; }
            set { this.Model.ActSessionName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_PREDELIV" field.
        /// </summary>
        public System.Byte Predeliv
        {
            get { return this.Model.Predeliv; }
            set { this.Model.Predeliv = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_CODE" field.
        /// </summary>
        public System.String Code
        {
            get { return this.Model.Code; }
            set { this.Model.Code = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BOM_PSG_ID" field.
        /// </summary>
        public Consensus.Learning.ProdSelectGroup PsgId
        {
            get
            {
                if (_psgId == null && this.Model.PsgId != null)
                    _psgId = new Consensus.Learning.ProdSelectGroup(this.Model.PsgId);
                if (_psgId == null)
                    _psgId = Consensus.Learning.ProdSelectGroup.Create();
                return _psgId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BOM_PSG_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PsgIdId
        {
            get { return this.Model.PsgIdId; }
            set { this.Model.PsgIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_REVENUE_SPLIT" field.
        /// </summary>
        public System.Double ActRevenueSplit
        {
            get { return this.Model.ActRevenueSplit; }
            set { this.Model.ActRevenueSplit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_ACT_HOURS_SPLIT" field.
        /// </summary>
        public System.Double ActHoursSplit
        {
            get { return this.Model.ActHoursSplit; }
            set { this.Model.ActHoursSplit = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_EXP_OCCUPANCY" field.
        /// </summary>
        public System.Nullable<System.Int32> ExpOccupancy
        {
            get { return this.Model.ExpOccupancy; }
            set { this.Model.ExpOccupancy = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BOM_SHOW_ATT_LOG" field.
        /// </summary>
        public System.Nullable<System.Byte> ShowAttLog
        {
            get { return this.Model.ShowAttLog; }
            set { this.Model.ShowAttLog = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Template> Templates
        {
            get
            {
                if (_templates == null)
                    _templates = new ProxyCollection<Consensus.Learning.Template, Consensus.Learning.ITemplateModel>(this.Model.Templates, model => new Consensus.Learning.Template(model));
                return _templates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:BillOfMaterialModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Session> Sessions
        {
            get
            {
                if (_sessions == null)
                    _sessions = new ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel>(this.Model.Sessions, model => new Consensus.Learning.Session(model));
                return _sessions;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal BillOfMaterial(IBillOfMaterialModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BillOfMaterialModel" /> instance.
        /// </returns>
        public static Consensus.Learning.BillOfMaterial Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BillOfMaterialModel" /> instance.
        /// </returns>
        public static Consensus.Learning.BillOfMaterial Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IBillOfMaterialModel model = provider.Learning.BillOfMaterial.Create();
            return model == null ? null : new Consensus.Learning.BillOfMaterial(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BillOfMaterialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BillOfMaterialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBillOfMaterialModel> collection = provider.Learning.BillOfMaterial.FetchAll();
            return collection.Select(model => new Consensus.Learning.BillOfMaterial(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BillOfMaterialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.BillOfMaterial FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BillOfMaterialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.BillOfMaterial FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IBillOfMaterialModel model = provider.Learning.BillOfMaterial.FetchById(id);
            return model == null ? null : new Consensus.Learning.BillOfMaterial(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.BillOfMaterial.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="masterProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="masterProductId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByMasterProductId(System.String masterProductId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.FetchAllByMasterProductId(site,masterProductId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="masterProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="masterProductId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByMasterProductId(ConsensusSite site, System.String masterProductId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBillOfMaterialModel> collection = provider.Learning.BillOfMaterial.FetchAllByMasterProductId(masterProductId);
            return collection.Select(model => new Consensus.Learning.BillOfMaterial(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="childProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="childProductId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByChildProductId(System.String childProductId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.FetchAllByChildProductId(site,childProductId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="childProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="childProductId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByChildProductId(ConsensusSite site, System.String childProductId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBillOfMaterialModel> collection = provider.Learning.BillOfMaterial.FetchAllByChildProductId(childProductId);
            return collection.Select(model => new Consensus.Learning.BillOfMaterial(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="accomProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="accomProductId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByAccomProductId(System.String accomProductId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.FetchAllByAccomProductId(site,accomProductId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="accomProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="accomProductId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByAccomProductId(ConsensusSite site, System.String accomProductId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBillOfMaterialModel> collection = provider.Learning.BillOfMaterial.FetchAllByAccomProductId(accomProductId);
            return collection.Select(model => new Consensus.Learning.BillOfMaterial(model));
        }

        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByPsgIdId(System.Nullable<System.Int32> psgIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BillOfMaterial.FetchAllByPsgIdId(site,psgIdId);
        }

        public static IEnumerable<Consensus.Learning.BillOfMaterial> FetchAllByPsgIdId(ConsensusSite site, System.Nullable<System.Int32> psgIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IBillOfMaterialModel> collection = provider.Learning.BillOfMaterial.FetchAllByPsgIdId(psgIdId);
            return collection.Select(model => new Consensus.Learning.BillOfMaterial(model));
        }

        #endregion
    }
}
