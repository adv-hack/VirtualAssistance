using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="SystemmenusRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSystemMenuModel : LocalModel<SystemmenusRecord, Int32>, ISystemMenuModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SMENU_SMENU_ID" field.
        /// </summary>
        private LocalSystemMenuModel _parent;

        /// <summary>
        ///     The collection of <see cref="SystemMenuModel" /> instances that reference this <see cref="SystemMenuModel" />.
        /// </summary>
        private LocalCollection<LocalSystemMenuModel, ISystemMenuModel> _systemMenus;

        /// <summary>
        ///     The collection of <see cref="SystemMenuXRefModel" /> instances that reference this <see cref="SystemMenuModel" />.
        /// </summary>
        private LocalCollection<LocalSystemMenuXRefModel, ISystemMenuXRefModel> _modules;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemmenusRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.SystemMenu.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemmenusRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.SystemMenu.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemmenusRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.SystemMenu.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_URL" field.
        /// </summary>
        public String Page
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return this.ModifiedData.Group; }
            set { this.ModifiedData.Group = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_ICON" field.
        /// </summary>
        public String Icon
        {
            get { return this.ModifiedData.Icon; }
            set { this.ModifiedData.Icon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_RELATIVE_PATH" field.
        /// </summary>
        public String RelativePath
        {
            get { return this.ModifiedData.RelativePath; }
            set { this.ModifiedData.RelativePath = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SMENU_SMENU_ID" field.
        /// </summary>
        public LocalSystemMenuModel Parent
        {
            get
            {
                if (_parent == null && this.ParentId != null)
                    _parent = this.Provider.UserInterface.SystemMenu.FetchById(this.ParentId.Value);
                if (_parent == null)
                    _parent = this.Provider.UserInterface.SystemMenu.Create();
                
                return _parent;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMENU_SMENU_ID" field.
        /// </summary>
        public Int32? ParentId
        {
            get { return this.ModifiedData.SmenuId; }
            set
            {
                if (this.ModifiedData.SmenuId != value)
                     _parent = null;
                this.ModifiedData.SmenuId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SystemMenuModel" /> instances that reference this <see cref="SystemMenuModel" />.
        /// </summary>
        public LocalCollection<LocalSystemMenuModel, ISystemMenuModel> SystemMenus
        {
            get
            {
                if (_systemMenus == null)
                    _systemMenus = new LocalCollection<LocalSystemMenuModel, ISystemMenuModel>(this.Provider.UserInterface.SystemMenu.FetchAllByParentId(this.Id));
                
                return _systemMenus;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SystemMenuXRefModel" /> instances that reference this <see cref="SystemMenuModel" />.
        /// </summary>
        public LocalCollection<LocalSystemMenuXRefModel, ISystemMenuXRefModel> Modules
        {
            get
            {
                if (_modules == null)
                    _modules = new LocalCollection<LocalSystemMenuXRefModel, ISystemMenuXRefModel>(this.Provider.UserInterface.SystemMenuXRef.FetchAllBySystemMenuId(this.Id));
                
                return _modules;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSystemMenuModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSystemMenuModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSystemMenuModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSystemMenuModel(LocalProvider provider, SystemmenusRecord record) : base(provider, record)
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
            if (_parent != null)
            {
                _parent.Save();
                this.ModifiedData.SmenuId = _parent.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_systemMenus != null)
                _systemMenus.Execute(obj => obj.ParentId = this.Id).Execute(obj => obj.Save());
            if (_modules != null)
                _modules.Execute(obj => obj.SystemMenuId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "SMENU_NAME" field.
        /// </summary>
        System.String ISystemMenuModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_URL" field.
        /// </summary>
        System.String ISystemMenuModel.Page
        {
            get { return this.Page; }
            set { this.Page = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_GROUP" field.
        /// </summary>
        System.String ISystemMenuModel.Group
        {
            get { return this.Group; }
            set { this.Group = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_ICON" field.
        /// </summary>
        System.String ISystemMenuModel.Icon
        {
            get { return this.Icon; }
            set { this.Icon = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SMENU_RELATIVE_PATH" field.
        /// </summary>
        System.String ISystemMenuModel.RelativePath
        {
            get { return this.RelativePath; }
            set { this.RelativePath = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "SMENU_SMENU_ID" field.
        /// </summary>
        Consensus.UserInterface.ISystemMenuModel ISystemMenuModel.Parent
        {
            get { return this.Parent; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMENU_SMENU_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ISystemMenuModel.ParentId
        {
            get { return this.ParentId; }
            set { this.ParentId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SystemMenuModel" /> instances that reference this <see cref="!:SystemMenuModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.ISystemMenuModel> ISystemMenuModel.SystemMenus
        {
            get { return this.SystemMenus; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SystemMenuXRefModel" /> instances that reference this <see cref="!:SystemMenuModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.ISystemMenuXRefModel> ISystemMenuModel.Modules
        {
            get { return this.Modules; }
        }

        #endregion
    }
}
