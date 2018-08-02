using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LiteratureRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLiteratureModel : LocalModel<LiteratureRecord, String>, ILiteratureModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LIT_LT_ID" field.
        /// </summary>
        private LocalLetterTemplateModel _ltId;

        /// <summary>
        ///     The collection of <see cref="PackXrefModel" /> instances that reference this <see cref="LiteratureModel" />.
        /// </summary>
        private LocalCollection<LocalPackXrefModel, IPackXrefModel> _literatureId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LiteratureRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.Literature.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LiteratureRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.Literature.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LiteratureRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.Literature.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_COST" field.
        /// </summary>
        public Double? Cost
        {
            get { return this.ModifiedData.Cost; }
            set { this.ModifiedData.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TEMPLATE" field.
        /// </summary>
        public String Template
        {
            get { return this.ModifiedData.Template; }
            set { this.ModifiedData.Template = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EXAM" field.
        /// </summary>
        public Byte? Exam
        {
            get { return this.ModifiedData.Exam; }
            set { this.ModifiedData.Exam = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_ATTENDANCE" field.
        /// </summary>
        public Byte? Attendance
        {
            get { return this.ModifiedData.Attendance; }
            set { this.ModifiedData.Attendance = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIT_LT_ID" field.
        /// </summary>
        public LocalLetterTemplateModel LtId
        {
            get
            {
                if (_ltId == null && this.LtIdId != null)
                    _ltId = this.Provider.Document.LetterTemplate.FetchById(this.LtIdId);
                if (_ltId == null)
                    _ltId = this.Provider.Document.LetterTemplate.Create();
                
                return _ltId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIT_LT_ID" field.
        /// </summary>
        public String LtIdId
        {
            get { return this.ModifiedData.LtId; }
            set
            {
                if (this.ModifiedData.LtId != value)
                     _ltId = null;
                this.ModifiedData.LtId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_SEND_OVERRIDE" field.
        /// </summary>
        public Byte? SendOverride
        {
            get { return this.ModifiedData.SendOverride; }
            set { this.ModifiedData.SendOverride = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EMAIL_ONLY" field.
        /// </summary>
        public Byte EmailOnly
        {
            get { return this.ModifiedData.EmailOnly; }
            set { this.ModifiedData.EmailOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_PRINT_ONLY" field.
        /// </summary>
        public Byte PrintOnly
        {
            get { return this.ModifiedData.PrintOnly; }
            set { this.ModifiedData.PrintOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_FILE_NAME" field.
        /// </summary>
        public String FileName
        {
            get { return this.ModifiedData.FileName; }
            set { this.ModifiedData.FileName = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackXrefModel" /> instances that reference this <see cref="LiteratureModel" />.
        /// </summary>
        public LocalCollection<LocalPackXrefModel, IPackXrefModel> LiteratureId
        {
            get
            {
                if (_literatureId == null)
                    _literatureId = new LocalCollection<LocalPackXrefModel, IPackXrefModel>(this.Provider.Document.PackXref.FetchAllByLitIdId(this.Id));
                
                return _literatureId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLiteratureModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLiteratureModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLiteratureModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLiteratureModel(LocalProvider provider, LiteratureRecord record) : base(provider, record)
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
            if (_ltId != null)
            {
                _ltId.Save();
                this.ModifiedData.LtId = _ltId.Id == null && this.ModifiedData.LtId != null ? "" : _ltId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_literatureId != null)
                _literatureId.Execute(obj => obj.LitIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "LIT_NAME" field.
        /// </summary>
        System.String ILiteratureModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_COST" field.
        /// </summary>
        System.Nullable<System.Double> ILiteratureModel.Cost
        {
            get { return this.Cost; }
            set { this.Cost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TEMPLATE" field.
        /// </summary>
        System.String ILiteratureModel.Template
        {
            get { return this.Template; }
            set { this.Template = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EXAM" field.
        /// </summary>
        System.Nullable<System.Byte> ILiteratureModel.Exam
        {
            get { return this.Exam; }
            set { this.Exam = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_ATTENDANCE" field.
        /// </summary>
        System.Nullable<System.Byte> ILiteratureModel.Attendance
        {
            get { return this.Attendance; }
            set { this.Attendance = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> ILiteratureModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> ILiteratureModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIT_LT_ID" field.
        /// </summary>
        Consensus.Document.ILetterTemplateModel ILiteratureModel.LtId
        {
            get { return this.LtId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIT_LT_ID" field.
        /// </summary>
        System.String ILiteratureModel.LtIdId
        {
            get { return this.LtIdId; }
            set { this.LtIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_SEND_OVERRIDE" field.
        /// </summary>
        System.Nullable<System.Byte> ILiteratureModel.SendOverride
        {
            get { return this.SendOverride; }
            set { this.SendOverride = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EMAIL_ONLY" field.
        /// </summary>
        System.Byte ILiteratureModel.EmailOnly
        {
            get { return this.EmailOnly; }
            set { this.EmailOnly = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_PRINT_ONLY" field.
        /// </summary>
        System.Byte ILiteratureModel.PrintOnly
        {
            get { return this.PrintOnly; }
            set { this.PrintOnly = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_FILE_NAME" field.
        /// </summary>
        System.String ILiteratureModel.FileName
        {
            get { return this.FileName; }
            set { this.FileName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:LiteratureModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> ILiteratureModel.LiteratureId
        {
            get { return this.LiteratureId; }
        }

        #endregion
    }
}
