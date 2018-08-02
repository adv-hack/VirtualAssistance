using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="SystemmenusxrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSystemMenuXRefModel : LocalModel<SystemmenusxrefRecord, Int32>, ISystemMenuXRefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        private LocalSystemMenuModel _systemMenu;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemmenusxrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.SystemMenuXRef.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemmenusxrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.SystemMenuXRef.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SystemmenusxrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.SystemMenuXRef.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        public LocalSystemMenuModel SystemMenu
        {
            get
            {
                if (_systemMenu == null)
                    _systemMenu = this.Provider.UserInterface.SystemMenu.FetchById(this.SystemMenuId);
                if (_systemMenu == null)
                    _systemMenu = this.Provider.UserInterface.SystemMenu.Create();
                
                return _systemMenu;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        public Int32 SystemMenuId
        {
            get { return this.ModifiedData.SmenuId; }
            set
            {
                if (this.ModifiedData.SmenuId != value)
                     _systemMenu = null;
                this.ModifiedData.SmenuId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSystemMenuXRefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSystemMenuXRefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSystemMenuXRefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSystemMenuXRefModel(LocalProvider provider, SystemmenusxrefRecord record) : base(provider, record)
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
            if (_systemMenu != null)
            {
                _systemMenu.Save();
                this.ModifiedData.SmenuId = _systemMenu.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        Consensus.UserInterface.ISystemMenuModel ISystemMenuXRefModel.SystemMenu
        {
            get { return this.SystemMenu; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SMXREF_SMENU_ID" field.
        /// </summary>
        System.Int32 ISystemMenuXRefModel.SystemMenuId
        {
            get { return this.SystemMenuId; }
            set { this.SystemMenuId = (System.Int32)value; }
        }

        #endregion
    }
}
