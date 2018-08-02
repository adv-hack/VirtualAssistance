using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LettertmpltRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalLetterTemplateModel
    {
        /// <summary>
        ///     Gets the file type based of the template record.
        /// </summary>
        public String FileType
        {
            get { return this.ModifiedData.AttId !=null && this.ModifiedData.AttId.Length > 0 ? "DB":"FILE"; }
        }
    }
}
