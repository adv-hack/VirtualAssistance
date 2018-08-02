using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateRoomModel : LocalTemplateModel, ITemplateRoomModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        private LocalCodeModel _roomType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Template.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Template.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Template.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        public LocalCodeModel RoomType
        {
            get
            {
                if (_roomType == null && !String.IsNullOrEmpty(this.RoomTypeCode))
                    _roomType = this.Provider.Common.Code.FetchByTypeAndCode("ROOMT", this.RoomTypeCode);
                if (_roomType == null)
                    _roomType = this.Provider.Common.Code.Create("ROOMT");
                return _roomType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        public String RoomTypeCode
        {
            get { return this.ModifiedData.RoomType; }
            set
            {
                if (this.ModifiedData.RoomType != value)
                     _roomType = null;
                this.ModifiedData.RoomType = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateRoomModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTemplateRoomModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateRoomModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTemplateRoomModel(LocalProvider provider, TemplateXrefRecord record) : base(provider, record)
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
            if (_roomType != null)
            {
                _roomType.Save();
                this.ModifiedData.RoomType = _roomType.Value1;
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
        ///     Gets the The value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel ITemplateRoomModel.RoomType
        {
            get { return this.RoomType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        System.String ITemplateRoomModel.RoomTypeCode
        {
            get { return this.RoomTypeCode; }
            set { this.RoomTypeCode = (System.String)value; }
        }

        #endregion
    }
}
