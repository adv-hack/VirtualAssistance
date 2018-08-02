using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalSessionModel
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
                if (_sessionXrefMaster == null && this.SessionXrefActivity.Count > 0)
                {
                    _sessionXrefMaster = this.Provider.Learning.SessionXref.Create();
                    LocalSessionXrefModel xref = this.SessionXrefActivity.Where(x => x.MastSess == 1 || x.MastSess == null).FirstOrDefault();

                    _sessionXrefMaster.EventId = xref.EventId;
                    _sessionXrefMaster.CsgId = xref.CsgId;
                    _sessionXrefMaster.MainSession = xref.MainSession;
                    _sessionXrefMaster.Mandatory = xref.Mandatory;
                    _sessionXrefMaster.Element = xref.Element;
                    _sessionXrefMaster.ShowSales = xref.ShowSales;
                    _sessionXrefMaster.InvPrint = xref.InvPrint;
                    _sessionXrefMaster.VatCodeCode = xref.VatCodeCode;
                    _sessionXrefMaster.Real = xref.Real;
                }
                //if we are creatinga new session
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
                if (this.SessionXrefActivity.Count == 0 || (this.SessionXrefActivity.Count == this.SessionXrefActivity.Where(sess => sess.IsPersisted == false && sess.Id != null).Count()))
                    this.SessionXrefActivity.Add(_sessionXrefMaster);

                foreach (LocalSessionXrefModel xRefRec in this.SessionXrefActivity)
                {
                    //values change across all session xref entries
                    xRefRec.CsgId = this.SessionXrefMaster.CsgId;
                    xRefRec.Element = this.SessionXrefMaster.Element;
                    xRefRec.Mandatory = this.SessionXrefMaster.Mandatory;
                    xRefRec.MainSession = this.SessionXrefMaster.MainSession;
                    xRefRec.ShowSales = this.SessionXrefMaster.ShowSales;
                    xRefRec.EventId = this.SessionXrefMaster.EventId;
                    xRefRec.InvPrint = this.SessionXrefMaster.InvPrint;
                    xRefRec.VatCodeCode = this.SessionXrefMaster.VatCodeCode;
                    xRefRec.Real = this.SessionXrefMaster.Real;
                }
            }
        }
        /// <summary>
        ///     Update the session xref records
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (this.SessionXrefMaster != null)
            {
                if (this.SessionXrefMaster.MainSession == 1)
                {
                    LocalSessionXrefModel[] currMainSessionXrefs = this.SessionXrefMaster.Event.SessionXrefEvent.Where(sessionXref => sessionXref.SessionId != this.Id && sessionXref.MainSession == 1).ToArray();
                    if (currMainSessionXrefs.Count() > 0)
                    {
                        currMainSessionXrefs.Execute(sessionXref => sessionXref.MainSession = 0).Execute(sessionXref => sessionXref.Save());
                        this.Provider.Learning.Event.CalculateCourseNumbers(this.SessionXrefMaster.EventId);
                    }
                }
                // Save the SessionXref data as well as calcualte the Course number
                if (this._sessionXrefActivity != null)
                {
                    this._sessionXrefActivity.Execute(obj => obj.SessionId = this.Id).Execute(obj => obj.Save());
                    this.Provider.Learning.Event.CalculateCourseNumbers(this.SessionXrefMaster.EventId);
                    this._sessionXrefActivity = null;
                }  
            }
        }



        #endregion
    }
}
