using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Kaido08.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Importance { get; set; }
        public DateTime Credit { get; set; }
        public string Memo { get; set; }

    }
}