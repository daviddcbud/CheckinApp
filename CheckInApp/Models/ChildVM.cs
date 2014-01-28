using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckInApp.Models
{
    public class ChildVM
    {
        public int Id { get; set; }
        public int FamilyId { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public DateTime? DOB { get; set; }
        public int Age { get; set; }
    }
}