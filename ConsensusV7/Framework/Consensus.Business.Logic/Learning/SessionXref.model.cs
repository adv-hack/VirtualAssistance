using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="SessionXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalSessionXrefModel
    {

        #region methods
        /// <summary>
        ///     Provides denormalisation of the sessionxref data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();

            if (this.Member == 1)
            {
                this.BlockPrice = this.Price;
                this.Price = 0;
                this.Member = 0;
            }
            else if(this.Member == 2)
            {
                this.BlockPrice = 0;
                this.Member = 1;
            }
            else
            {
                this.BlockPrice = 0;
                this.Member = 0;
            }

            if(this.EventId == null)
            {
                if(this.SessionId != null)
                {
                    //new session session xref record (new prices)
                    //populate defaults from existing xref
                    LocalSessionXrefModel mainXref = this.Session.SessionXrefMaster;
                    if(mainXref != null)
                    {                                            
                        this.EventId = mainXref.EventId;
                        this.CsgId = mainXref.CsgId;
                        this.Element = mainXref.Element;
                        this.Mandatory = mainXref.Mandatory;
                        this.MainSession = mainXref.MainSession;
                        this.ShowSales = mainXref.ShowSales;
                        this.InvPrint = mainXref.InvPrint;
                        this.VatCodeCode = mainXref.VatCodeCode;
                        this.MastSess = 0;
                    }
                }
                else if (this.EventProductId != null)
                {
                    //new event product session xref record (new prices)
                    //populate defaults from existing xref
                    LocalSessionXrefModel mainXref = this.EventProduct.SessionXrefMaster;
                    if (mainXref.Id != null)
                    {
                        this.EventId = mainXref.EventId;
                        this.CsgId = mainXref.CsgId;
                        this.Element = mainXref.Element;
                        this.Mandatory = mainXref.Mandatory;
                        this.MainSession = 0;
                        this.ShowSales = mainXref.ShowSales;
                        this.InvPrint = mainXref.InvPrint;
                        this.VatCodeCode = mainXref.VatCodeCode;
                    }
                }

            }

        }
        #endregion
    }
}
