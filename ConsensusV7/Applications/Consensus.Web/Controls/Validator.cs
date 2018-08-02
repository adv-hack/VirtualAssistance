using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    public class Validator : CustomValidator
    {
        public Boolean Critical
        {
            get;
            set;
        }

        public Validator()
        {
            this.Critical = true;
            this.ValidateEmptyText = true;
            this.Display = ValidatorDisplay.None;
        }
    }
}
