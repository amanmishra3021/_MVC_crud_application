using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _MVC_crud_application.Models
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public long mobile { get; set; }
        public string city { get; set; }

        
        public string Deparment { get; set; }
    }
}