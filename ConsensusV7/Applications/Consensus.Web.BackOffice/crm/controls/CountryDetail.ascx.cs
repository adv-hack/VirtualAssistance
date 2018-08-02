using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class CountryDetail : BaseControl<Country, string>
    {
        #region Properties

        public override string DataTypeName
        {
            get
            {
                return "Country Details";
            }
        }

        public override Func<string, Country> DataLoader
        {
            get
            {
                return Country.FetchById;
            }
        }

        #endregion

        #region Methods

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            var countryList = Country.FetchAll();

            //Order by Currency and removes null and empty entries
            var currencyList = countryList.GroupBy(x => x.Currency).Select(y => y.First()).OrderBy(z => z.Currency).ToList();
            currencyList.RemoveAll(x => x.Currency == null || x.Currency == string.Empty);
            this.Currency.DataSource = currencyList;

            //Order by Format and removes null and empty entries
            var formatList = countryList.GroupBy(x => x.Format).Select(y => y.First()).OrderBy(z => z.Format).ToList();
            formatList.RemoveAll(x => x.Format == null || x.Format == string.Empty);
            this.Format.DataSource = formatList;
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void OnPreRender(EventArgs e)
        {            
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.Format.FieldValue = "UK";
            }
            else
            {
                this.Format.FieldValue = this.DataSource.Format;
            }
        }
    }

    #endregion

}