using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appointment_mvc.Models
{
    public class items_master
    {
        public string username { get; set; }
        public string password { get; set; }

        public string item_name { get; set; }
        public string item_code { get; set; }
        public string item_price { get; set; }
        public string item_category { get; set; }
       
    }
}