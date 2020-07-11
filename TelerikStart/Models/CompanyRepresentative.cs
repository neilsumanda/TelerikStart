using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikStart.Models
{
    public class CompanyRepresentative
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
    }
}