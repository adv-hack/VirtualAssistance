using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Common
{
    /// <summary>
    /// Response from AFD api
    /// </summary>
    public class AfdResponse
    {
        /// <summary>
        /// If the account number is invalid, the Result field returned will be set to a value less than zero and the ErrorText will contain a corresponding error message.
        /// If the return value is AFD_SUCCESS (1) then the account number has been validated, if the return value is AFD_SUCCESS_NO_VALIDATION (2) then account numbers on this sortcode cannot be validated and so the number should still be treated as valid.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Returns if AccountNumber or Sortcode is invalid
        /// </summary>
        public string ErrorText { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        public List<AfdBankFinder> Item { get; set; }
    }

    /// <summary>
    /// AFD Bank finder details
    /// </summary>
    public class AfdBankFinder
    {
        /// <summary>
        /// Bank Name
        /// </summary>
        public string OwnerBankFullName { get; set; }

        /// <summary>
        /// Building
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Area
        /// </summary>
        public string Locality { get; set; }

        /// <summary>
        /// Town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// County
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Postcode
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// SortCode
        /// </summary>
        public string SortCode { get; set; }

    }

    public class DonationProduct
    {
        public String Name { get; set; }

        public Double? Price { get; set; }

        public string Id { get; set; }

        public string PersonName { get; set; }

        public string PersonSurname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }

    public class CourseProduct
    {
        public String Name { get; set; }

        public string EntryDate { get; set; }

        public string Id { get; set; }

         
        public List<CourseProductPrice> PriceList { get; set; }
        
    }
    public class CourseProductPrice
    {
        public String ListName { get; set; }

        public Decimal UnitPrice { get; set; }
    }

}
