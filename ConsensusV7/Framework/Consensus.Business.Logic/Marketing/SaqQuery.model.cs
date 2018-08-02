using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalSaqQueryModel
    {
        // From v7 the UI renders checkboxes (Yes/No) for the data protection options, however for most of these options the database
        // holds 0 = Not Set, 1 = Set or 2 = Ignore. Checkbox off (No) needs to map to Ignore (2), hence these mapping properties
        // There are a couple of exceptions, where the V6 UI has a checkbox only (e.g. PnExcludeArchivedBool/PnFlag3); these are 
        // included for convenience.
        public bool PnDoNotEmailBool { get { return (this.PnDonotmail2 == 1); } set { this.PnDonotmail2 = (byte)(value ? 1 : 2); } }
        public bool PnDoNotMailBool { get { return (this.PnDonotmail == 1); } set { this.PnDonotmail = (byte)(value ? 1 : 2); } }
        public bool PnDoNotFaxBool { get { return (this.PnFlag1 == 1); } set { this.PnFlag1 = (byte)(value ? 1 : 2); } }
        public bool PnDoNotSwapBool { get { return (this.PnFlag2 == 1); } set { this.PnFlag2 = (byte)(value ? 1 : 2); } }
        public bool PnExcludeArchivedBool { get { return (this.PnFlag3 == 1); } set { this.PnFlag3 = Convert.ToByte(value); } }
        public bool ProleDoNotEmailBool { get { return (this.ProleDoNotEmail == 1); } set { this.ProleDoNotEmail = (byte)(value ? 1 : 2); } }
        public bool ProleDoNotMailBool { get { return (this.ProleDoNotMail == 1); } set { this.ProleDoNotMail = (byte)(value ? 1 : 2); } }
        public bool ProleDoNotFaxBool { get { return (this.ProleDoNotFax == 1); } set { this.ProleDoNotFax = (byte)(value ? 1 : 2); } }
        public bool ProleDoNotSwapBool { get { return (this.ProleDoNotSwap == 1); } set { this.ProleDoNotSwap = (byte)(value ? 1 : 2); } }
        public bool ProleDoNotCallBool { get { return (this.ProleUsernum1 == 1); } set { this.ProleUsernum1 = (byte)(value ? 1 : 2); } }
        public bool ProleExcludeDisabledBool { get { return (this.ProleDisFlag == 1); } set { this.ProleDisFlag = Convert.ToByte(value); } }
        public bool OrgDoNotEmailBool { get { return (this.OrgUsernum1 == 1); } set { this.OrgUsernum1 = (byte)(value ? 1 : 2); } }
        public bool OrgDoNotMailBool { get { return (this.OrgDonotmail == 1); } set { this.OrgDonotmail = (byte)(value ? 1 : 2); } }
        public bool OrgDoNotFaxBool { get { return (this.OrgDonotfax == 1); } set { this.OrgDonotfax = (byte)(value ? 1 : 2); } }
        public bool OrgDoNotRentBool { get { return (this.OrgFlag1 == 1); } set { this.OrgFlag1 = (byte)(value ? 1 : 2); } }

        public byte Dedupe
        {
            get { return this.PnDedupe; }
            set { this.PnDedupe = value; this.OrgDedupe = value; }
        }
    }
}
