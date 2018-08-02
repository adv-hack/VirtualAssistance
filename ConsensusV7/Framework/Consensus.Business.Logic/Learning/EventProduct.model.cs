using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="EventProductRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalEventProductModel
    {
        private LocalSessionXrefModel _sessionXrefMaster;


        /// <summary>
        ///    Gets or sets the main session
        /// </summary>
        public LocalSessionXrefModel SessionXrefMaster
        {
            get
            {
                // Get the session xref
                if (_sessionXrefMaster == null && this.EPSessionXref.Count > 0)
                {
                    _sessionXrefMaster = this.Provider.Learning.SessionXref.Create();
                    LocalSessionXrefModel xref = this.EPSessionXref.FirstOrDefault();

                    _sessionXrefMaster.EventId = xref.EventId;
                    _sessionXrefMaster.CsgId = xref.CsgId;
                    _sessionXrefMaster.MainSession = xref.MainSession;
                    _sessionXrefMaster.Mandatory = xref.Mandatory;
                    _sessionXrefMaster.Element = xref.Element;
                    _sessionXrefMaster.ShowSales = xref.ShowSales;
                    _sessionXrefMaster.InvPrint = xref.InvPrint;
                    _sessionXrefMaster.VatCodeCode = xref.VatCodeCode;
                }
                //if we are creating a new EP record
                if (_sessionXrefMaster == null)
                {
                    _sessionXrefMaster = this.Provider.Learning.SessionXref.Create();
                }

                return _sessionXrefMaster;
            }
        }
        #region methods
        public override Boolean IsModified
        {
            get { return base.IsModified || this.SessionXrefMaster.IsModified; }
        }

        /// <summary>
        ///     Provides denormalisation of the activity data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            

            if (_sessionXrefMaster != null && _sessionXrefMaster.IsModified)
            {
                if (this.EPSessionXref.Count == 0 || (this.EPSessionXref.Count == this.EPSessionXref.Where(sess => sess.IsPersisted == false && sess.Id != null).Count()))
                    this.EPSessionXref.Add(_sessionXrefMaster);

                foreach (LocalSessionXrefModel xRefRec in this.EPSessionXref)
                {
                    //values change across all session xref entries
                    xRefRec.CsgId = this.SessionXrefMaster.CsgId;
                    xRefRec.Element = this.SessionXrefMaster.Element;
                    xRefRec.Mandatory = this.SessionXrefMaster.Mandatory;
                    xRefRec.MainSession = this.SessionXrefMaster.MainSession;
                    xRefRec.ShowSales = this.SessionXrefMaster.ShowSales;
                    xRefRec.VatCodeCode = this.SessionXrefMaster.VatCodeCode;
                    xRefRec.EventId = this.SessionXrefMaster.EventId;
                    xRefRec.InvPrint = this.SessionXrefMaster.InvPrint;
                }
            }

        }
        /// <summary>
        ///     Update the session xref records
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();

        }

        #endregion
    }
}
