using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckInApp.Models
{
    public class FamilyVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public List<ChildVM> Children { get; set; }
        public FamilyVM()
        {
            Children = new List<ChildVM>();
        }
    }
}