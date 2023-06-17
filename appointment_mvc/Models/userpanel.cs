using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appointment_mvc.Models
{
    public class userpanel
    {
        public string username { get; set; }
        public string password { get; set; }

        public string company_name { get; set; }
        public string service_tax { get; set; }
        public string gst_rate { get; set; }
        public string discount { get; set; }
        public string whatsapp { get; set; }
        public string text_message { get; set; }
        public string gate_pass { get; set; }

    }
}