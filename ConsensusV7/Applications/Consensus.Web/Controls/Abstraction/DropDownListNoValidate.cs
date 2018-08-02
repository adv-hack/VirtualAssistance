using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace Consensus.Web.Controls
{
    public class DropDownListNoValidate : DropDownList
    {
        protected override bool LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            if (postDataKey == this.UniqueID)
            {
                string sValue = postCollection[postDataKey];

                if (!string.IsNullOrEmpty(sValue))
                {
                    Int32 index = Enumerable.Range(0, this.Items.Count).Where(i => String.Equals(this.Items[i].Value, sValue, StringComparison.OrdinalIgnoreCase)).Select(i => i + 1).FirstOrDefault() - 1;
                    if (index < 0)
                    {
                        this.Items.Insert(0, new ListItem(sValue, sValue));
                        index = 0;
                    }
                    this.SelectedIndex = index;
                }
                return true;
            }
            return false;
        }        
    }
}
