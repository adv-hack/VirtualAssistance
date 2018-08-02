using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductModel" /> object.
    /// </summary>
    public partial class LocalProductFactory
    {
        /// <summary>
        ///     Retrieves a single <see cref='LocalProductModel' /> instance.
        /// </summary>
        /// <param name="reference">
        ///     The value which identifies the <see cref='LocalProductModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LocalProductModel' /> instance that match the specified <paramref name='reference' />.
        /// </returns>
        public String FetchAllByReference(String reference)
        {
            var productList = this.Provider.DataProvider.Learning.Product.FetchAll().Where(x => x.SyProduct == 29);
            var test = productList.ConvertTo<DonationProduct>();

            ProductRecord record = this.Provider.DataProvider.Learning.Product.FetchAllByReference(reference);
            String result = record == null ? null : record.Id;
            return result;
        }

        public IEnumerable<DonationProduct> FetchDonationProduct()
        {
            var productList = this.Provider.DataProvider.Learning.Product.FetchAll().Where(x => x.SyProduct == 29);
            var donationProductList = new List<DonationProduct>();
            foreach (ProductRecord record in productList)
            {
                donationProductList.Add(new DonationProduct { Name = record.Name, Id = record.Id, Price = record.Price });
            }
            return donationProductList;
        }

        public void CreateDonationProduct(DonationProduct product)
        {
            var booking = new BookingRecord();
            booking.ProleId="1";
            this.Provider.DataProvider.Learning.Booking.Create(booking);
            //var productList = this.Provider.DataProvider.Learning.Product.FetchAll().Where(x => x.SyProduct == 29);
            //var donationProductList = new List<DonationProduct>();
            //foreach (ProductRecord record in productList)
            //{
            //    donationProductList.Add(new DonationProduct { Name = record.Name, Id = record.Id, Price = record.Price });
            //}
            //return donationProductList;
        }
        public IEnumerable<CourseProduct> FetchCourseProduct()
        {
            var productList = this.Provider.DataProvider.Learning.Product.FetchAll().Where(x => x.SyProduct == 1);
            
            var courseProductList = new List<CourseProduct>();
            var coursepriceList = new List<CourseProductPrice>();
            foreach (ProductRecord record in productList)
            {
                var priceList = this.Provider.Finance.Price.FetchAll().Where(x => x.ProductId == record.Id);
                foreach(var price in priceList)
                {
                    CourseProductPrice courseprice = new CourseProductPrice();
                    courseprice.ListName = price.PriceList.Name;
                    courseprice.UnitPrice = price.Amount;
                    coursepriceList.Add(courseprice);
                }
                courseProductList.Add(new CourseProduct { Name = record.Name, Id = record.Id, EntryDate =(record.EntryDate.HasValue) ? record.EntryDate.Value.ToShortDateString() : string.Empty,PriceList = coursepriceList });
            }
            return courseProductList;
        }


    }
}
