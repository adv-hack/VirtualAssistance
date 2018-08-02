using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectModel : LocalModel<ScreenObjectRecord, Int32>, IScreenObjectModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ScreenObjectDisplayModel" /> instances that reference this <see cref="ScreenObjectModel" />.
        /// </summary>
        private LocalCollection<LocalScreenObjectDisplayModel, IScreenObjectDisplayModel> _displayRules;

        /// <summary>
        ///     The collection of <see cref="ScreenObjectEntryModel" /> instances that reference this <see cref="ScreenObjectModel" />.
        /// </summary>
        private LocalCollection<LocalScreenObjectEntryModel, IScreenObjectEntryModel> _entries;

        /// <summary>
        ///     The collection of <see cref="ScreenObjectColumnModel" /> instances that reference this <see cref="ScreenObjectModel" />.
        /// </summary>
        private LocalCollection<LocalScreenObjectColumnModel, IScreenObjectColumnModel> _columns;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObject.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObject.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ScreenObjectRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.ScreenObject.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_URL" field.
        /// </summary>
        public String Url
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_CONTROL" field.
        /// </summary>
        public String Control
        {
            get { return this.ModifiedData.Control; }
            set { this.ModifiedData.Control = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ICON" field.
        /// </summary>
        public String Icon
        {
            get { return this.ModifiedData.Icon; }
            set { this.ModifiedData.Icon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_EXPRESSION" field.
        /// </summary>
        public String ValidatorExpression
        {
            get { return this.ModifiedData.ValidatorExpression; }
            set { this.ModifiedData.ValidatorExpression = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_MESSAGE" field.
        /// </summary>
        public String ValidatorMessage
        {
            get { return this.ModifiedData.ValidatorMessage; }
            set { this.ModifiedData.ValidatorMessage = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_CRITICAL" field.
        /// </summary>
        public Boolean ValidatorCritical
        {
            get { return this.ModifiedData.ValidatorCritical; }
            set { this.ModifiedData.ValidatorCritical = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_MAX_LENGTH" field.
        /// </summary>
        public Int32 MaximumLength
        {
            get { return this.ModifiedData.MaxLength; }
            set { this.ModifiedData.MaxLength = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_TEXT" field.
        /// </summary>
        public String OffText
        {
            get { return this.ModifiedData.OffText; }
            set { this.ModifiedData.OffText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_COLOUR" field.
        /// </summary>
        public String OffColour
        {
            get { return this.ModifiedData.OffColour; }
            set { this.ModifiedData.OffColour = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_TEXT" field.
        /// </summary>
        public String OnText
        {
            get { return this.ModifiedData.OnText; }
            set { this.ModifiedData.OnText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_COLOUR" field.
        /// </summary>
        public String OnColour
        {
            get { return this.ModifiedData.OnColour; }
            set { this.ModifiedData.OnColour = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_DEFAULT" field.
        /// </summary>
        public String Default
        {
            get { return this.ModifiedData.Default; }
            set { this.ModifiedData.Default = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenObjectDisplayModel" /> instances that reference this <see cref="ScreenObjectModel" />.
        /// </summary>
        public LocalCollection<LocalScreenObjectDisplayModel, IScreenObjectDisplayModel> DisplayRules
        {
            get
            {
                if (_displayRules == null)
                    _displayRules = new LocalCollection<LocalScreenObjectDisplayModel, IScreenObjectDisplayModel>(this.Provider.UserInterface.ScreenObjectDisplay.FetchAllByScreenObjectId(this.Id));
                
                return _displayRules;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenObjectEntryModel" /> instances that reference this <see cref="ScreenObjectModel" />.
        /// </summary>
        public LocalCollection<LocalScreenObjectEntryModel, IScreenObjectEntryModel> Entries
        {
            get
            {
                if (_entries == null)
                    _entries = new LocalCollection<LocalScreenObjectEntryModel, IScreenObjectEntryModel>(this.Provider.UserInterface.ScreenObjectEntry.FetchAllByScreenObjectId(this.Id));
                
                return _entries;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenObjectColumnModel" /> instances that reference this <see cref="ScreenObjectModel" />.
        /// </summary>
        public LocalCollection<LocalScreenObjectColumnModel, IScreenObjectColumnModel> Columns
        {
            get
            {
                if (_columns == null)
                    _columns = new LocalCollection<LocalScreenObjectColumnModel, IScreenObjectColumnModel>(this.Provider.UserInterface.ScreenObjectColumn.FetchAllByScreenObjectId(this.Id));
                
                return _columns;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalScreenObjectModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalScreenObjectModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalScreenObjectModel(LocalProvider provider, ScreenObjectRecord record) : base(provider, record)
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
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_displayRules != null)
                _displayRules.Execute(obj => obj.ScreenObjectId = this.Id).Execute(obj => obj.Save());
            if (_entries != null)
                _entries.Execute(obj => obj.ScreenObjectId = this.Id).Execute(obj => obj.Save());
            if (_columns != null)
                _columns.Execute(obj => obj.ScreenObjectId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        Consensus.UserInterface.ScreenObjectVisibility IScreenObjectModel.Visibility
        {
            get { return this.Visibility; }
            set { this.Visibility = (Consensus.UserInterface.ScreenObjectVisibility)value; }
        }

        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        Consensus.UserInterface.ScreenObjectRequirement IScreenObjectModel.Requirement
        {
            get { return this.Requirement; }
            set { this.Requirement = (Consensus.UserInterface.ScreenObjectRequirement)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_URL" field.
        /// </summary>
        System.String IScreenObjectModel.Url
        {
            get { return this.Url; }
            set { this.Url = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_CONTROL" field.
        /// </summary>
        System.String IScreenObjectModel.Control
        {
            get { return this.Control; }
            set { this.Control = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_TITLE" field.
        /// </summary>
        System.String IScreenObjectModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ICON" field.
        /// </summary>
        System.String IScreenObjectModel.Icon
        {
            get { return this.Icon; }
            set { this.Icon = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_EXPRESSION" field.
        /// </summary>
        System.String IScreenObjectModel.ValidatorExpression
        {
            get { return this.ValidatorExpression; }
            set { this.ValidatorExpression = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_MESSAGE" field.
        /// </summary>
        System.String IScreenObjectModel.ValidatorMessage
        {
            get { return this.ValidatorMessage; }
            set { this.ValidatorMessage = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_CRITICAL" field.
        /// </summary>
        System.Boolean IScreenObjectModel.ValidatorCritical
        {
            get { return this.ValidatorCritical; }
            set { this.ValidatorCritical = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_MAX_LENGTH" field.
        /// </summary>
        System.Int32 IScreenObjectModel.MaximumLength
        {
            get { return this.MaximumLength; }
            set { this.MaximumLength = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_TEXT" field.
        /// </summary>
        System.String IScreenObjectModel.OffText
        {
            get { return this.OffText; }
            set { this.OffText = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_COLOUR" field.
        /// </summary>
        System.String IScreenObjectModel.OffColour
        {
            get { return this.OffColour; }
            set { this.OffColour = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_TEXT" field.
        /// </summary>
        System.String IScreenObjectModel.OnText
        {
            get { return this.OnText; }
            set { this.OnText = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_COLOUR" field.
        /// </summary>
        System.String IScreenObjectModel.OnColour
        {
            get { return this.OnColour; }
            set { this.OnColour = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_DEFAULT" field.
        /// </summary>
        System.String IScreenObjectModel.Default
        {
            get { return this.Default; }
            set { this.Default = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectDisplayModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectDisplayModel> IScreenObjectModel.DisplayRules
        {
            get { return this.DisplayRules; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectEntryModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectEntryModel> IScreenObjectModel.Entries
        {
            get { return this.Entries; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectColumnModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectColumnModel> IScreenObjectModel.Columns
        {
            get { return this.Columns; }
        }

        #endregion
    }
}
