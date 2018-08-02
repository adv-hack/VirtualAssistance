using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotConsensus.Model
{
    public class CourseProduct
    {
        
            public String Name { get; set; }

            public string EntryDate { get; set; }

            public string Id { get; set; }


            public List<CourseProductPrice> PriceList { get; set; }

            public double? CourseLength { get; set; }

        
    }
}