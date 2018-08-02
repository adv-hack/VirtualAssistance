using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="HistorylinkRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalHistoryLinkModel
    {
        public override bool IsModified
        {
            get
            {
                return true;
            }
        }
        public void SaveAndCleanUp()
        {
            Boolean isCreate = !this.IsPersisted;
            this.Save();

                this.Provider.DataProvider.UserInterface.HistoryLink.CleanUp(this.UserId);        
        }
    }
}
