using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotConsensus.Model
{
    public class DonationProduct
    {
        #region Properties
        
        public String Name { get; set; }

        public Double? Price { get; set; }

        public string Id { get; set; }

        public string PersonName { get; set; }

        public string PersonSurname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        #endregion
    }
}