using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LettmplttypeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLetterTemplateTypeModel : LocalModel<LettmplttypeRecord, String>, ILetterTemplateTypeModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="LetterTemplateModel" /> instances that reference this <see cref="LetterTemplateTypeModel" />.
        /// </summary>
        private LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel> _letterTemplates;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LettmplttypeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.LetterTemplateType.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LettmplttypeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.LetterTemplateType.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LettmplttypeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.LetterTemplateType.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LetterTemplateModel" /> instances that reference this <see cref="LetterTemplateTypeModel" />.
        /// </summary>
        public LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel> LetterTemplates
        {
            get
            {
                if (_letterTemplates == null)
                    _letterTemplates = new LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel>(this.Provider.Document.LetterTemplate.FetchAllByTypeId(this.Id));
                
                return _letterTemplates;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLetterTemplateTypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLetterTemplateTypeModel(LocalProvider provider, LettmplttypeRecord record) : base(provider, record)
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
            if (_letterTemplates != null)
                _letterTemplates.Execute(obj => obj.TypeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "LTT_NAME" field.
        /// </summary>
        System.String ILetterTemplateTypeModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_DESC" field.
        /// </summary>
        System.String ILetterTemplateTypeModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> ILetterTemplateTypeModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:LetterTemplateTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILetterTemplateModel> ILetterTemplateTypeModel.LetterTemplates
        {
            get { return this.LetterTemplates; }
        }

        #endregion
    }
}
