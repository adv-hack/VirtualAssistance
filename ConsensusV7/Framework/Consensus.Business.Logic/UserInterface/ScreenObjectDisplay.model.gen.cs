using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectDisplayRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectDisplayModel : LocalModel<ScreenObjectDisplayRecord, Int32>, IScreenObjectDisplayModel
    {
        #region fields

        /// <summary>
        ///     The value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        private LocalScreenObjectModel _screenObject;

        /// <summary>
        ///     The value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        private LocalUserPrincipalModel _principal;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectDisplayRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectDisplayRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectDisplayRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        public LocalScreenObjectModel ScreenObject
        {
            get
            {
                if (_screenObject == null)
                    _screenObject = this.Provider.UserInterface.ScreenObject.FetchById(this.ScreenObjectId);
                if (_screenObject == null)
                    _screenObject = this.Provider.UserInterface.ScreenObject.Create();
                
                return _screenObject;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        public Int32 ScreenObjectId
        {
            get { return this.ModifiedData.ObjId; }
            set
            {
                if (this.ModifiedData.ObjId != value)
                     _screenObject = null;
                this.ModifiedData.ObjId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        public LocalUserPrincipalModel Principal
        {
            get
            {
                if (_principal == null)
                    _principal = this.Provider.Security.UserPrincipal.FetchById(this.PrincipalId);
                if (_principal == null)
                    _principal = this.Provider.Security.UserPrincipal.Create();
                
                return _principal;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return this.ModifiedData.PrincipalId; }
            set
            {
                if (this.ModifiedData.PrincipalId != value)
                     _principal = null;
                this.ModifiedData.PrincipalId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJDIS_DISPLAY" field.
        /// </summary>
        public Byte Display
        {
            get { return this.ModifiedData.Display; }
            set { this.ModifiedData.Display = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenObjectDisplayModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenObjectDisplayModel(LocalProvider provider, ScreenObjectDisplayRecord record) : base(provider, record)
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
            if (_screenObject != null)
            {
                _screenObject.Save();
                this.ModifiedData.ObjId = _screenObject.Id;
            }
            if (_principal != null)
            {
                _principal.Save();
                this.ModifiedData.PrincipalId = _principal.Id;
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
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        Consensus.UserInterface.ScreenObjectVisibility IScreenObjectDisplayModel.Visibility
        {
            get { return this.Visibility; }
            set { this.Visibility = (Consensus.UserInterface.ScreenObjectVisibility)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenObjectModel IScreenObjectDisplayModel.ScreenObject
        {
            get { return this.ScreenObject; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        System.Int32 IScreenObjectDisplayModel.ScreenObjectId
        {
            get { return this.ScreenObjectId; }
            set { this.ScreenObjectId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        Consensus.Security.IUserPrincipalModel IScreenObjectDisplayModel.Principal
        {
            get { return this.Principal; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        System.Int32 IScreenObjectDisplayModel.PrincipalId
        {
            get { return this.PrincipalId; }
            set { this.PrincipalId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJDIS_DISPLAY" field.
        /// </summary>
        System.Byte IScreenObjectDisplayModel.Display
        {
            get { return this.Display; }
            set { this.Display = (System.Byte)value; }
        }

        #endregion
    }
}
