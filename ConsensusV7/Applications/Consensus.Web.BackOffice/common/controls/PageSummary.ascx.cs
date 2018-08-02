using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class PageSummary : BaseControl<Proxy>
    {
        public override string DataTypeName
        {
            get
            {
                return "Proxy";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Type pageType = Page.GetType();
            PropertyInfo dataProperty = pageType.GetProperty("Data");
            Proxy data = (Proxy)dataProperty.GetValue(Page);
            Type dataType = data.GetType();

            PropertyInfo modUserProperty = dataType.GetProperty("ModBy");
            PropertyInfo modDateProperty = dataType.GetProperty("ModDate");
            PropertyInfo idProperty = dataType.GetProperty("Id");
            string Id = (string)idProperty.GetValue(data);

            if (String.IsNullOrEmpty(Id) || (modUserProperty == null && modDateProperty == null))
            {
                rowSummary.Visible = false;
                if (this.Parent.Parent.ID == "tabSummary")
                {
                    this.Parent.Parent.Visible = false;
                }
            }
            else
            {
                if (modUserProperty != null)
                {
                    string modUser = (string)modUserProperty.GetValue(data);
                    if (!string.IsNullOrEmpty(modUser))
                        LastUser.InnerText = modUser;
                }
                if (modDateProperty != null)
                {
                    DateTime? modDate = (modDateProperty.GetValue(data) as DateTime?);
                    if (modDate.HasValue)
                        LastDate.InnerText = modDate.Value.ToString("g");
                }
            }
        }
    }
}