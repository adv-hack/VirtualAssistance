using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="GiftaidRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalGiftaidModel : LocalModel<GiftaidRecord, Int32>, IGiftaidModel
    {
        #region fields

        /// <summary>
        ///     The value of the "GIF_PN_ID" field.
        /// </summary>
        private LocalPersonModel _pnId;

        /// <summary>
        ///     The value of the "GIF_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<GiftaidRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Giftaid.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<GiftaidRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Giftaid.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<GiftaidRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Giftaid.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "GIF_PN_ID" field.
        /// </summary>
        public LocalPersonModel PnId
        {
            get
            {
                if (_pnId == null)
                    _pnId = this.Provider.Contact.Person.FetchById(this.PnIdId);
                if (_pnId == null)
                    _pnId = this.Provider.Contact.Person.Create();
                
                return _pnId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_PN_ID" field.
        /// </summary>
        public String PnIdId
        {
            get { return this.ModifiedData.PnId; }
            set
            {
                if (this.ModifiedData.PnId != value)
                     _pnId = null;
                this.ModifiedData.PnId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "GIF_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("DECLA", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("DECLA");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_TYPE" field.
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
        ///     Gets or sets the value of the "GIF_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_COMMUNICATION" field.
        /// </summary>
        public Byte Communication
        {
            get { return this.ModifiedData.Communication; }
            set { this.ModifiedData.Communication = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_FIRST_NAME" field.
        /// </summary>
        public String FirstName
        {
            get { return this.ModifiedData.FirstName; }
            set { this.ModifiedData.FirstName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_SURNAME" field.
        /// </summary>
        public String Surname
        {
            get { return this.ModifiedData.Surname; }
            set { this.ModifiedData.Surname = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalGiftaidModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalGiftaidModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalGiftaidModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalGiftaidModel(LocalProvider provider, GiftaidRecord record) : base(provider, record)
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
            if (_pnId != null)
            {
                _pnId.Save();
                this.ModifiedData.PnId = _pnId.Id == null && this.ModifiedData.PnId != null ? "" : _pnId.Id;
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
        ///     Gets or sets the value of the "GIF_ACTIVE" field.
        /// </summary>
        System.Boolean IGiftaidModel.Active
        {
            get { return this.Active; }
            set { this.Active = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets the The value of the "GIF_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IGiftaidModel.PnId
        {
            get { return this.PnId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_PN_ID" field.
        /// </summary>
        System.String IGiftaidModel.PnIdId
        {
            get { return this.PnIdId; }
            set { this.PnIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "GIF_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IGiftaidModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_TYPE" field.
        /// </summary>
        System.String IGiftaidModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IGiftaidModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IGiftaidModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_COMMUNICATION" field.
        /// </summary>
        System.Byte IGiftaidModel.Communication
        {
            get { return this.Communication; }
            set { this.Communication = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_FIRST_NAME" field.
        /// </summary>
        System.String IGiftaidModel.FirstName
        {
            get { return this.FirstName; }
            set { this.FirstName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_SURNAME" field.
        /// </summary>
        System.String IGiftaidModel.Surname
        {
            get { return this.Surname; }
            set { this.Surname = (System.String)value; }
        }

        #endregion
    }
}
