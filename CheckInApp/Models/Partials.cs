using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckInApp.Models
{
    public partial class Family
    {
        public string Name
        {
            get
            {
                var name = LastName;
                if (!string.IsNullOrEmpty(FirstName)) name += ", " + FirstName;
                return name;
            }
        }
    }
    public partial class Child
    {
        public int Age
        {
            get
            {
                if (this.DOB.HasValue)
                {
                    return DateTime.Today.Subtract(this.DOB.Value).Days / 365;
                }

                else
                {
                    return 0;
                }
            }
           
        }
    }
}