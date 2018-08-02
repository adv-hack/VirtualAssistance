using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PrintQueueRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalOutputQueueModel
    {
      /// <summary>
      ///     Updates the print queue
      /// </summary>
      protected override void ResolveDependent()
      {
        base.ResolveDependent();
        if (this.SystemDefault == 1 && this.QueueType == "Printer")
        {
          LocalOutputQueueModel[] otherOutputQueues = this.Provider.Document.OutputQueue.FetchAll().Where(queue => queue.Id != this.Id && String.Equals(queue.QueueType, "Printer", StringComparison.OrdinalIgnoreCase)).ToArray();

          otherOutputQueues.Execute(queue => queue.SystemDefault = 0).Execute(queue => queue.Save());
        }

      }
    }
}
