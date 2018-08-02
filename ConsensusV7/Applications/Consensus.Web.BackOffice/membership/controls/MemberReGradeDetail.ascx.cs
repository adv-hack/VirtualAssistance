using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Membership;
using Consensus.Learning;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MemberReGradeDetail : BaseControl<MemberLocation, String>
    {
        #region fields

        private String _memberPeriodId;
        private String _prodId;
        #endregion

        #region properties
        /// <summary>
        public String MemberPeriodId
        {
            get { return _memberPeriodId; }
            set { _memberPeriodId = value; }
        }
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }
        public override String DataTypeName
        {
            get { return "Member ReGrade"; }
        }

        #endregion

        #region page cycle
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            
            this.MemberPeriodId = this.Request.QueryString["mepid"];
            this.ProdId = this.Request.QueryString["prodid"];
            List<Product> listProduct = new List<Product>();
            MemberLocation objMemberLocation = MemberLocation.FetchAllByMemberPeriodId(this.MemberPeriodId).Where(x => x.Current == 1).FirstOrDefault();
            
            this.ExistingGrade.FieldValue = "-";
            if (objMemberLocation != null && objMemberLocation.Product != null)
            {
                this.ExistingGrade.FieldValue = objMemberLocation.Product.Name;                
            }

            this.Current.FieldValue = "1";
            this.Systype.FieldValue = "2"; // For Grade type SyType = 2
            this.Price.FieldValue = "0.00";
            foreach (var item in MemberBom.FetchAllByProdParentIdId(this.ProdId).ToList())
            {
                if(item.GradeProd.Prices.Count > 0)
                {
                    item.GradeProd.Price = Convert.ToDouble(Finance.Price.FetchAllByProductId(item.GradeProd.Id).Min(x => x.Amount));
                }
                listProduct.Add(item.GradeProd);
            }
            this.NewGrade.DataSource = listProduct;
            this.AllGradePrice.DataSource = listProduct;
            this.AllVatCode.DataSource = listProduct;  
        }
        #endregion

    }
}