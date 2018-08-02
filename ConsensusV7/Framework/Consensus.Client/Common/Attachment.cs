using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consensus.Searches;

namespace Consensus.Common
{
    public partial class Attachment
    {
        public static ISearchesRunnable GetListQuery(string Url, string RecordId)
        {
            return Query.Create()
                .Select("ATT_ID")
                .Select("ATT_MIME")
                .Select("ATT_FILE_NAME")
                .Select("ATT_ADD_BY")
                .Select("ATT_ADD_DATE")
                .Select("ATT_CATEGORY")
                .Select("LZC_CATEGORY_TITLE")
                .Select("ATT_VISIBILITY")
                .Select("ATT_WEB")
                .Select("ATT_ORDER_NUM")
                .Select("uri")
                .From(QuerySources.Attachments)
                .Where("ATT_TABLE_URL", QueryConditionTypes.Equal, Url)
                .And("ATT_RECORD_ID", QueryConditionTypes.Equal, RecordId)
                .OrderBy("ATT_ORDER_NUM", true)
                .ThenBy("ATT_FILE_NAME", true);
        }

        public static Dictionary<string, object>[] GetListQueryResults(string Url, string RecordId)
        {
            ISearchesRunnable q = GetListQuery(Url, RecordId);
            return q.Run();
        }
    }
}
