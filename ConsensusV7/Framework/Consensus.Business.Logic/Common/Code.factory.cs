using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CodeModel" /> object.
    /// </summary>
    public partial class LocalCodeFactory
    {
        /// <summary>
        ///     Creates a new <see cref='CodeModel' /> instance.
        /// </summary>
        /// <param name="codeType">
        ///     The type of the code.
        /// </param>
        /// <returns>
        ///     A newly instantiated <see cref='CodeModel' /> instance.
        /// </returns>
        public LocalCodeModel Create(String codeType)
        {
            LocalCodeModel codeModel = new LocalCodeModel(this.Provider);
            codeModel.Type = codeType;
            codeModel.Set(false);
            return codeModel;
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CodeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CodeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CodeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCodeModel FetchByTypeAndCode(String codeType, String codeValue)
        {
            CodeRecord record = this.Provider.DataProvider.Common.Code.FetchByTypeAndCode(codeType, codeValue);
            LocalCodeModel model = record == null ? null : new LocalCodeModel(this.Provider, record);
            return model;
        }

        /// <summary>
        ///     Retrieves a single <see cref="CodeModel" /> instance from the data store.
        /// </summary>
        /// <param name="type">
        ///     The type code which distinctly identifies the type of <see cref="CodeModel" /> instance to be returned.
        /// </param>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="CodeModel" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCodeModel FetchByTypeAndCodeValue3(String codeType, String codeValue3)
        {
            CodeRecord record = this.Provider.DataProvider.Common.Code.FetchByTypeAndCodeValue3(codeType, codeValue3);
            LocalCodeModel model = record == null ? null : new LocalCodeModel(this.Provider, record);
            return model;
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CodeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CodeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CodeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<LocalCodeModel> FetchAllByType(String codeType)
        {
            IEnumerable<CodeRecord> recordCollection = this.Provider.DataProvider.Common.Code.FetchAllByType(codeType);
            IEnumerable<LocalCodeModel> modelCollection =  recordCollection.Select(record => new LocalCodeModel(this.Provider, record));
            return modelCollection;
        }

        public IEnumerable<Object> FetchAllInTree(String codeType)
        {
            IEnumerable<LocalCodeModel> modelCollection = this.FetchAllByType(codeType);
            IEnumerable<Object> result = modelCollection.Select(model => new
            {
                id = !String.IsNullOrEmpty(model.Value4) ? "###" + model.Value4 : !String.IsNullOrEmpty(model.Value2) ? "##" + model.Value2 : "#" + model.Value1,
                parent = !String.IsNullOrEmpty(model.Value4) ? "##" + model.Value2 : !String.IsNullOrEmpty(model.Value2) ? "#" + model.Value1 : "#",
                text = !String.IsNullOrEmpty(model.Value4) ? model.Value4 : !String.IsNullOrEmpty(model.Value2) ? model.Value2 : model.Value1
            });

            return result;            
        }
   
    }
}
