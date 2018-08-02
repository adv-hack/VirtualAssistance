using Consensus.Common;
using Consensus.Contact;
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

        public string CreateDonationProduct(string personName, string surname, string email, string phone, string price, string productId)
        {
            var addressId = "11";
            var sellingCompanyId = "1";
            var organisationId = "1";
            var person = new PersonRecord()
            {
                FirstName = personName,
                Surname = surname,
                HomeAddId = addressId
            };

            this.Provider.DataProvider.Contact.Person.Create(person);
            var addedPerson = this.Provider.DataProvider.Contact.Person.FetchAll().OrderByDescending(x => x.AddDate).FirstOrDefault();

            var role = new PersonRoleRecord()
            {
                PersonId = addedPerson.Id,
                Email = email,
                Phone = phone,
                SelcoSpId = sellingCompanyId,
                OrgId = organisationId,
                AddId = addressId
            };
            this.Provider.DataProvider.Contact.Role.Create(role);
            var addedRole = this.Provider.DataProvider.Contact.Role.FetchAll().OrderByDescending(x => x.AddDate).FirstOrDefault();

            var booking = new BookingRecord()
            {
                ProleId = addedRole.Id,
                InvOrgId = addedRole.OrgId,
                SelcoSpId = addedRole.SelcoSpId,
                PaymentMethd = "05-Cash",
                CurrencyType = "GBP",
                NetTotal = Convert.ToInt32(price),
                PersonId = addedRole.PersonId
            };

            this.Provider.DataProvider.Learning.Booking.Create(booking);

            var addedBooking = this.Provider.DataProvider.Learning.Booking.FetchAll().OrderByDescending(x => x.AddDate).FirstOrDefault();

            var donationProduct = this.Provider.DataProvider.Learning.Product.FetchById(productId);
            var delegateRecord = new DelegateRecord()
            {
                BookId = addedBooking.Id,
                OrgId = addedBooking.OrgId,
                PersonId = addedBooking.PersonId,
                ProleId = addedBooking.ProleId,
                ProductId = donationProduct.Id,
                Quantity = 1
            };
            this.Provider.DataProvider.Learning.Learner.Create(delegateRecord);
            var addedDelegate = this.Provider.DataProvider.Learning.Learner.FetchAll().OrderByDescending(x => x.AddDate).FirstOrDefault();


            var element = new ElementRecord()
            {
                BookId = addedBooking.Id,
                PaymentMethd = "01-Invoice",
                ProdId = donationProduct.Id,
                SelcoSpId = sellingCompanyId,
                Type = 29,
                Price = Convert.ToInt32(price),
                Description = donationProduct.Descrip,
                CostCode = donationProduct.CostCode,
                Qty = 1,
                UntPrice = Convert.ToInt32(price),
                PlId = "1",
                DelId = addedDelegate.Id
            };
            this.Provider.DataProvider.Learning.Element.Create(element);
            return "/learning/donationbooking?id=" + addedBooking.Id;
        }


        public IEnumerable<CourseProduct> FetchCourseProduct()
        {
            var productList = this.Provider.DataProvider.Learning.Product.FetchAll().Where(x => x.SyProduct == 1);

            var courseProductList = new List<CourseProduct>();
            
            foreach (ProductRecord record in productList)
            {
                var coursepriceList = new List<CourseProductPrice>();
                var priceList = this.Provider.Finance.Price.FetchAll().Where(x => x.ProductId == record.Id);
                foreach (var price in priceList)
                {
                    CourseProductPrice courseprice = new CourseProductPrice();
                    courseprice.ListName = price.PriceList.Name;
                    courseprice.UnitPrice = price.Amount;
                    coursepriceList.Add(courseprice);
                }
                courseProductList.Add(new CourseProduct { Name = record.Name, Id = record.Id, EntryDate = (record.EntryDate.HasValue) ? record.EntryDate.Value.ToShortDateString() : string.Empty, PriceList = coursepriceList,CourseLength = record.CourseLen });
            }
            return courseProductList;
        }


    }
}
