//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckInApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Family
    {
        public Family()
        {
            this.Children = new HashSet<Child>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    
        public virtual ICollection<Child> Children { get; set; }
    }
}
