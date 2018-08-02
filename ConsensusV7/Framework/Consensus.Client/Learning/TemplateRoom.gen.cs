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
    public partial class TemplateRoom : Proxy<ITemplateRoomModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RoomType" /> member.
        /// </summary>
        private Consensus.Common.Code _roomType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BillOfMaterial" /> member.
        /// </summary>
        private Consensus.Learning.BillOfMaterial _billOfMaterial;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        public Consensus.Common.Code RoomType
        {
            get
            {
                if (_roomType == null && this.Model.RoomType != null)
                    _roomType = new Consensus.Common.Code(this.Model.RoomType);
                if (_roomType == null)
                    _roomType = Consensus.Common.Code.Create();
                return _roomType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        public System.String RoomTypeCode
        {
            get { return this.Model.RoomTypeCode; }
            set { this.Model.RoomTypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_BOM_ID" field.
        /// </summary>
        public Consensus.Learning.BillOfMaterial BillOfMaterial
        {
            get
            {
                if (_billOfMaterial == null && this.Model.BillOfMaterial != null)
                    _billOfMaterial = new Consensus.Learning.BillOfMaterial(this.Model.BillOfMaterial);
                if (_billOfMaterial == null)
                    _billOfMaterial = Consensus.Learning.BillOfMaterial.Create();
                return _billOfMaterial;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_BOM_ID" field.
        /// </summary>
        public System.String BillOfMaterialId
        {
            get { return this.Model.BillOfMaterialId; }
            set { this.Model.BillOfMaterialId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_QTY" field.
        /// </summary>
        public System.Nullable<System.Double> Qty
        {
            get { return this.Model.Qty; }
            set { this.Model.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_DEL_QTY" field.
        /// </summary>
        public System.Nullable<System.Double> DelQty
        {
            get { return this.Model.DelQty; }
            set { this.Model.DelQty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PER_DAY" field.
        /// </summary>
        public System.Nullable<System.Byte> PerDay
        {
            get { return this.Model.PerDay; }
            set { this.Model.PerDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_UNT_TYPE" field.
        /// </summary>
        public System.String UntType
        {
            get { return this.Model.UntType; }
            set { this.Model.UntType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_COST" field.
        /// </summary>
        public System.Decimal Cost
        {
            get { return this.Model.Cost; }
            set { this.Model.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_INC_IN_BUDGET" field.
        /// </summary>
        public System.Byte IncInBudget
        {
            get { return this.Model.IncInBudget; }
            set { this.Model.IncInBudget = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal TemplateRoom(ITemplateRoomModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateRoomModel" /> instance.
        /// </returns>
        public static Consensus.Learning.TemplateRoom Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateRoom.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateRoomModel" /> instance.
        /// </returns>
        public static Consensus.Learning.TemplateRoom Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ITemplateRoomModel model = provider.Learning.TemplateRoom.Create();
            return model == null ? null : new Consensus.Learning.TemplateRoom(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateRoomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateRoom> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateRoom.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateRoomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateRoom> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ITemplateRoomModel> collection = provider.Learning.TemplateRoom.FetchAll();
            return collection.Select(model => new Consensus.Learning.TemplateRoom(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateRoomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.TemplateRoom FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateRoom.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateRoomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.TemplateRoom FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ITemplateRoomModel model = provider.Learning.TemplateRoom.FetchById(id);
            return model == null ? null : new Consensus.Learning.TemplateRoom(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateRoom.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.TemplateRoom.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateRoomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateRoom> FetchAllByBillOfMaterialId(System.String billOfMaterialId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateRoom.FetchAllByBillOfMaterialId(site,billOfMaterialId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateRoomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateRoom> FetchAllByBillOfMaterialId(ConsensusSite site, System.String billOfMaterialId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ITemplateRoomModel> collection = provider.Learning.TemplateRoom.FetchAllByBillOfMaterialId(billOfMaterialId);
            return collection.Select(model => new Consensus.Learning.TemplateRoom(model));
        }

        #endregion
    }
}
