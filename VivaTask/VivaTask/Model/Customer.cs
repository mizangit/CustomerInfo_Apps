using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VivaTask.Model
{
    public class Customer
    {
        public string  Name { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }
        public byte[] Photo { get; set; }
    }
}