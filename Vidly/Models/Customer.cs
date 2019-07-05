using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        public bool IsSubscriedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
    }
}