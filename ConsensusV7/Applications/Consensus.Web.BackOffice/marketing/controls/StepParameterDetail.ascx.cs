using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Security;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class StepParameterDetail : BaseControl<SaqParameter, long>
    {        
        public override string DataTypeName
        {
            get { return "Step Parameter"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<long, SaqParameter> DataLoader
        {
            get { return SaqParameter.FetchById; }
        }


        //protected override void PopulateControl()
        //{
        //    base.PopulateControl();                        
        //}

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            PreBracket.DataSource = new string[] { "(", "((", "(((", "((((", "(((((" };
            PostBracket.DataSource = new string[] { ")", "))", ")))", "))))", ")))))" };
            Condition.DataSource = new string[] { "AND", "OR" };
            
            List<object> types = new List<object>();
            
            types.Add(new { Desc = "is equal to", Value = "EQUALS" });
            types.Add(new { Desc = "contains", Value = "CONTAINS" });
            types.Add(new { Desc = "starts with", Value = "STARTS WITH" });
            types.Add(new { Desc = "ends with", Value = "ENDS WITH" });
            types.Add(new { Desc = "does not equal", Value = "<>" });
            types.Add(new { Desc = "is greater than", Value = ">" });
            types.Add(new { Desc = "is less than", Value = "<" });
            types.Add(new { Desc = "is greater than or equal to", Value = ">=" });
            types.Add(new { Desc = "is less than or equal to", Value = "<=" });
            //types.Add(new { Desc = "is in", CustomisationValue = "IN" });
            //types.Add(new { Desc = "is not in", CustomisationValue = "NOT IN" });

            this.Operand.DataSource = types;
            if (this.DataSource != null)
            {
                this.Operand.FieldValue = this.DataSource.Operand;
            }
            else
            {
                Condition.FieldValue = "AND";
                Operand.FieldValue = "EQUALS";
            }
        }
    }
}