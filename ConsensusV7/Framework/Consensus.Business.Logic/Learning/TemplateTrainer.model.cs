using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalTemplateTrainerModel
    {
        /// <summary>
        ///     The type of trainer
        /// </summary>
        private LocalCodeModel _typeModel;

        /// <summary>
        ///     Gets the The value of the "TXREF_TRAINER" field.
        /// </summary>
        public LocalCodeModel TypeModel
        {
            get
            {
                if (_typeModel == null && this.Trainer != null)
                    _typeModel = this.Provider.Common.Code.FetchByTypeAndCodeValue3("AREFT", this.Trainer.ConvertTo<String>());
                if (_typeModel == null)
                    _typeModel = this.Provider.Common.Code.Create("AREFT");
                return _typeModel;
            }
        }

        public String TypeModelCode
        {
            get { return this.TypeModel.Value1; }
            set
            {
                _typeModel = this.Provider.Common.Code.FetchByTypeAndCode("AREFT", value);
                this.Trainer = (_typeModel != null) ? _typeModel.Value3.ConvertTo<Byte>() : this.Trainer;
            }
        }


        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.ModifiedData.Type = 1;
        }
    }
}
