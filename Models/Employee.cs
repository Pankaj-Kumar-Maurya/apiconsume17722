using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiconsume17722.Models
{
    public class Employee
    {
        public int rid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> salary { get; set; }
    }
}