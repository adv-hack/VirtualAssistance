using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldValueModel" /> object.
    /// </summary>
    public partial class LocalScreenCustomFieldValueFactory
    {
        public LocalScreenCustomFieldValueModel FetchByFieldIdAndRecordId(Int32 fieldId, String recordId)
        {
            ScreenCustomFieldValueRecord record = this.Provider.DataProvider.UserInterface.ScreenCustomFieldValue.FetchByFieldIdAndRecordId(fieldId, recordId);
            if (record == null)
                return null;
            return new LocalScreenCustomFieldValueModel(this.Provider, record);
        }
    }
}
