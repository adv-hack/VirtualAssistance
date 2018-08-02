using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class TemplateTrainer : Proxy<ITemplateTrainerModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="TypeModel" /> member.
        /// </summary>
        private Consensus.Common.Code _typeModel;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="TrainerRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _trainerRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BillOfMaterial" /> member.
        /// </summary>
        private Consensus.Learning.BillOfMaterial _billOfMaterial;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "TXREF_TRAINER" field.
        /// </summary>
        public Consensus.Common.Code TypeModel
        {
            get
            {
                if (_typeModel == null && this.Model.TypeModel != null)
                    _typeModel = new Consensus.Common.Code(this.Model.TypeModel);
                if (_typeModel == null)
                    _typeModel = Consensus.Common.Code.Create();
                return _typeModel;
            }
        }

        public System.String TypeModelCode
        {
            get { return this.Model.TypeModelCode; }
            set { this.Model.TypeModelCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_KEY" field.
        /// </summary>
        public System.String ProfKey
        {
            get { return this.Model.ProfKey; }
            set { this.Model.ProfKey = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE" field.
        /// </summary>
        public System.String ProfValue
        {
            get { return this.Model.ProfValue; }
            set { this.Model.ProfValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE2" field.
        /// </summary>
        public System.String ProfValue2
        {
            get { return this.Model.ProfValue2; }
            set { this.Model.ProfValue2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_RATIO" field.
        /// </summary>
        public System.Int32 Ratio
        {
            get { return this.Model.Ratio; }
            set { this.Model.Ratio = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_TRAINER" field.
        /// </summary>
        public System.Nullable<System.Byte> Trainer
        {
            get { return this.Model.Trainer; }
            set { this.Model.Trainer = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role TrainerRole
        {
            get
            {
                if (_trainerRole == null && this.Model.TrainerRole != null)
                    _trainerRole = new Consensus.Contact.Role(this.Model.TrainerRole);
                if (_trainerRole == null)
                    _trainerRole = Consensus.Contact.Role.Create();
                return _trainerRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        public System.String TrainerRoleId
        {
            get { return this.Model.TrainerRoleId; }
            set { this.Model.TrainerRoleId = value; }
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
        internal TemplateTrainer(ITemplateTrainerModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateTrainerModel" /> instance.
        /// </returns>
        public static Consensus.Learning.TemplateTrainer Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateTrainer.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateTrainerModel" /> instance.
        /// </returns>
        public static Consensus.Learning.TemplateTrainer Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ITemplateTrainerModel model = provider.Learning.TemplateTrainer.Create();
            return model == null ? null : new Consensus.Learning.TemplateTrainer(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateTrainer> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateTrainer.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateTrainer> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ITemplateTrainerModel> collection = provider.Learning.TemplateTrainer.FetchAll();
            return collection.Select(model => new Consensus.Learning.TemplateTrainer(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.TemplateTrainer FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateTrainer.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.TemplateTrainer FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ITemplateTrainerModel model = provider.Learning.TemplateTrainer.FetchById(id);
            return model == null ? null : new Consensus.Learning.TemplateTrainer(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateTrainer.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.TemplateTrainer.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateTrainer> FetchAllByBillOfMaterialId(System.String billOfMaterialId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateTrainer.FetchAllByBillOfMaterialId(site,billOfMaterialId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateTrainer> FetchAllByBillOfMaterialId(ConsensusSite site, System.String billOfMaterialId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ITemplateTrainerModel> collection = provider.Learning.TemplateTrainer.FetchAllByBillOfMaterialId(billOfMaterialId);
            return collection.Select(model => new Consensus.Learning.TemplateTrainer(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerRoleId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="trainerRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateTrainer> FetchAllByTrainerRoleId(System.String trainerRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TemplateTrainer.FetchAllByTrainerRoleId(site,trainerRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerRoleId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="trainerRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.TemplateTrainer> FetchAllByTrainerRoleId(ConsensusSite site, System.String trainerRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ITemplateTrainerModel> collection = provider.Learning.TemplateTrainer.FetchAllByTrainerRoleId(trainerRoleId);
            return collection.Select(model => new Consensus.Learning.TemplateTrainer(model));
        }

        #endregion
    }
}
