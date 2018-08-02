using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TrainerRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalTrainerModel
    {
        /// <summary>
        ///     Provides denormalisation of the Trainer data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            if (this.ModifiedData.Id == null)
            {
                this.ModifiedData.AinAddDate = DateTime.Now;
                this.ModifiedData.AinModDate = DateTime.Now;
                this.ModifiedData.AinRcvDate = DateTime.Now;
                this.ModifiedData.AinLock = "0";
            }
            else
            {
                this.ModifiedData.AinModDate = DateTime.Now;
            }
        }
    }
}
