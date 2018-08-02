using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Document;

namespace Consensus.Web.BackOffice.document.controls
{
  public partial class OutputQueueDetail : BaseControl<OutputQueue, string>
  {
    public override String DataTypeName
    {
      get { return "Output Queue"; }
    }

    /// <summary>
    ///     Gets the delegated method for loading the API object that is presented within the page.
    /// </summary>
    public override Func<string, OutputQueue> DataLoader
    {
      get { return OutputQueue.FetchById; }
    }


    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);

        if (this.DataSource != null && this.DataSource.Id != null)
        {
            this.QueueType.IsReadOnly = Consensus.UserInterface.ConfigurableBoolean.True;
        }
    }
          
  }
}