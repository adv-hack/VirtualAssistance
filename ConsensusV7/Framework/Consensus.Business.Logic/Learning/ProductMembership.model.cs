using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalProductMembershipModel
    {
        /// <summary>
        ///     Gets or sets whether the membership product has a fixed renewal date.
        /// </summary>
        public Boolean IsRenewalFixed
        {
            get { return this.ModifiedData.FixedRenewal.ConvertTo<Boolean>(); }
            set { this.ModifiedData.FixedRenewal = (value ? 1 : 0).ConvertTo<Byte>(); }
        }

        /// <summary>
        ///     Gets or sets the day on which the fixed renewal occurs.
        /// </summary>
        public Int32 RenewalDay
        {
            get { return this.ModifiedData.RenewalDay.ConvertTo<Int32>(); }
            set { this.ModifiedData.RenewalDay = value.ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets or sets the month on which the fixed renewal occurs.
        /// </summary>
        public Int32 RenewalMonth
        {
            get { return this.ModifiedData.RenewalMonth.ConvertTo<Int32>(); }
            set { this.ModifiedData.RenewalMonth = value.ConvertTo<String>(); }
        }

        /// <summary>
        ///     Gets or sets the minimum number of days allowed for a renewing membership.
        /// </summary>
        public Int32 RenewalExclusion
        {
            get { return this.ModifiedData.ExclDay.ConvertTo<Int32>(); }
            set { this.ModifiedData.ExclDay = value.ConvertTo<String>(); }
        }

        /// <summary>
        ///     Calculates the proposed end date for a membership that is based upon this product, based on the specified start date.
        /// </summary>
        /// <param name="startDate">
        ///     The proposed start date for the membership.
        /// </param>
        /// <returns>
        ///     The proposed end date for the membership.
        /// </returns>
        public DateTime CalculateMembershipEndDate(DateTime startDate)
        {
            Int32 iteration = 0;
            
            // Calculate the end date of the membership, accounting for the exclusion period.
            DateTime? endDate = null;
            while (endDate == null || (this.RenewalExclusion != 0 && (endDate.Value - startDate).TotalDays < this.RenewalExclusion) || endDate < startDate)
                endDate = this.CalculateMembershipEndDate(startDate, iteration += 1);
            
            return endDate.Value;
        }

        /// <summary>
        ///     Calculates the proposed end date for a membership that is based upon this product, based on the specified start date.
        /// </summary>
        /// <param name="startDate">
        ///     The proposed start date for the membership.
        /// </param>
        /// <param name="iteration">
        ///     The iterations by which the membership end date is calculated.
        /// </param>
        /// <returns>
        ///     The proposed end date for the membership.
        /// </returns>
        private DateTime CalculateMembershipEndDate(DateTime startDate, Int32 iteration)
        {
            DateTime endDate;

            if (!this.IsRenewalFixed && this.CourseLen.HasValue && this.CourseLen.Value != 0)
                endDate = startDate.AddMonths(this.CourseLen.ConvertTo<Int32>() * iteration).AddDays(-1);
            else if (this.RenewalMonth <= 0 || this.RenewalMonth >= 13)
                endDate = startDate.AddYears(iteration).AddDays(-1);
            else if (this.RenewalDay <= 0 || this.RenewalDay >= DateTime.DaysInMonth(startDate.Year + iteration, this.RenewalMonth))
                endDate = startDate.AddYears(iteration).AddDays(-1);
            else
                endDate = new DateTime(startDate.Year + (iteration - 1), this.RenewalMonth, this.RenewalDay);

            return endDate;
        }

        /// <summary>
        ///     Calculates the price for a new membership that is based upon this product.
        /// </summary>
        /// <param name="personId">
        ///     The person that the membership is for.
        /// </param>
        /// <param name="startDate">
        ///     The date on which the membership will start.
        /// </param>
        /// <param name="endDate">
        ///     The date on which the membership will end.
        /// </param>
        /// <param name="priceList">
        ///     The price list from which the price is selected.
        /// </param>
        /// <returns></returns>
        public Object CalculateMembershipPrice(String personId, Int32 quantity, DateTime startDate, DateTime endDate, String priceList)
        {
            // Ensure start date is later than end date
            if (startDate > endDate)
                throw new Exception("Start date must be before end date.");

            if (quantity <= 0)
                quantity = 1;

            // Get the applicable price
            LocalPriceModel priceModel = this.Prices.FirstOrDefault(price => price.PriceListId == priceList && (price.QtyMin == null || quantity >= price.QtyMin.Value) && (price.QtyMax == null || price.QtyMax == 0 || quantity <= price.QtyMax.Value));
            if (priceModel == null)
                throw new Exception("A valid price could not be found for this membership product.");

            // Determine the pro-rata factor for the membership
            Int32 lengthY = (endDate.AddDays(1).Year - startDate.Year);
            Int32 lengthM = (endDate.AddDays(1).Month - startDate.Month);
            Int32 lengthD = Math.Abs(endDate.AddDays(1).Day - startDate.Day);

            // Apply the pro-rata factor and return the price
            Decimal factor = ((lengthY * 12) + lengthM + (lengthD >= 15 ? 1 : 0)) / this.CourseLen.ConvertTo<Decimal>();
            Decimal amount = priceModel.Amount * factor;
            Decimal vatRate = priceModel.VatCode.Value3.ConvertTo<Decimal>();
            Decimal vatAmount = amount * vatRate / 100M;
            return new { Amount = amount, VatRate = vatRate, VatAmount = vatAmount, Total = amount + vatAmount, VatCode = priceModel.VatCode.Value1 };
        }
    }
}
