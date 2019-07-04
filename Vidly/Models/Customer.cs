using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSubscriedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
    }
}