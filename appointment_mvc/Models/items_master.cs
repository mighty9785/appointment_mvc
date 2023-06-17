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
        public List<part_list> part_list { get; set; }
        public List<labr_list1> labr_list1 { get; set; }


    }

    public class part_list
    {
        public string part_code { get; set; }
        public string part_name { get; set; }
        public string part_rate { get; set; }
        public string part_cat { get; set; }

    }

    public class labr_list1
    {
        public string labr_code { get; set; }
        public string labr_name1 { get; set; }
        public string labr_rate { get; set; }
        public string labr_cat { get; set; }

    }
}