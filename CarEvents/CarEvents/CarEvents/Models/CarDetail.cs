using System;
using System.Collections.Generic;
using System.Text;


 

namespace CarEvents.Models
    {
        public class CarDetail
        {

            public string id { get; set; }
            public string modelName { get; set; }
            public string make { get; set; }

            public string carTypeId { get; set; }
            public string carType { get; set; }
            public string description { get; set; }
            public string launchDate { get; set; }
            public string price { get; set; }
            //public string image { get; set; }


        }
        public class CarList
        {
            public List<CarDetail> Cardetail { get; set; }
        }
    }






