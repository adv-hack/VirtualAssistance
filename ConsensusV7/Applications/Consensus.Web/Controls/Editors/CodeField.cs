using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a dropdown list which is pre-populated with values from a predefined, data-driven code list.
    /// </summary>
    public class CodeField : ListBase, IHaveCodeItems
    {
        #region fields

        /// <summary>
        ///     The type of the code that is displayed in the list.
        /// </summary>
        private String _codeType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the type of the code that is displayed in the list.
        /// </summary>
        public String CodeType
        {
            get { return _codeType; }
            set { _codeType = value; }
        }

        #endregion

        #region events

        /// <summary>
        ///     The delegated handler for validating the data source.
        /// </summary>
        public delegate Boolean LoadDataSourceHandler(Code code);

        /// <summary>
        ///     Occurs when the data source is loaded and is used to validate entries within the source.
        /// </summary>
        public event LoadDataSourceHandler LoadDataSource;

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            IEnumerable<Code> dataSource = Code.FetchAllByType(this.CodeType);
            if (this.LoadDataSource != null)
                dataSource = dataSource.Where(code => this.LoadDataSource.Invoke(code));

            // Populate the dropdown list
            base.InitialiseControlTree();
            //this.Field.DataTextField = "Value1";
            //this.Field.DataValueField = "Value1";
            this.DisplayMember = "Value1";
            this.DataSource = dataSource.ToList(); 
        }

        #endregion
    }
}
