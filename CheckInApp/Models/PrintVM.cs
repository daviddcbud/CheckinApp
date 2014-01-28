using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckInApp.Models
{
    public class PrintVM
    {
        public DateTime DateTime { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

    }
}