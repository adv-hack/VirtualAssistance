using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="GiftaidRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalGiftaidModel
    {

        /// <summary>
        ///     Gets or sets the value of the "GIF_ACTIVE" field.
        /// </summary>
        public Boolean Active
        {
            get { return this.ModifiedData.Active == 1; }
            set { this.ModifiedData.Active = (Byte)(value ? 1 : 0); }
        }

        /// <summary>
        ///     Sets the denormalised data
        /// </summary>
        protected internal override void Denormalise()
        {
            if (this.Id == 0 && this.TypeCode != null)
            {
                this.FirstName = this.PnId.FirstName;
                this.Surname = this.PnId.Surname;
                //if (this.PnId.PrincipalRole != null)
                //{
                //    this.Address = this.PnId.PrincipalRole.Address.MailString;
                //}
                this.Active = true;

                if (this.StartDate == null)
                    this.StartDate = DateTime.Today;
            }
            else
            {
                if (this.TypeCode != null && this.EndDate < DateTime.Today)
                {
                    this.Active = false;
                }
            }
        }
        /// <summary>
        ///     Updates the dates for the gift aid records
        /// </summary>
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (this.Active)
            {
                LocalGiftaidModel[] otherGiftAids = this.PnId.GiftAid.Where(giftAid => giftAid.Id != this.Id && (giftAid.EndDate == null || giftAid.Active)).ToArray();
                otherGiftAids.Execute(giftAid => giftAid.EndDate = giftAid.EndDate ?? DateTime.Today).Execute(giftAid => giftAid.Active = false).Execute(giftAid => giftAid.Save());

            }

        }
    }
}
