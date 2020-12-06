using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdminMVCCore.Entities.Tables
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string CustomerFirstName { get; set; }
        [Required]
        public string CustomerLastName { get; set; }

        public string CustomerCity { get; set; }

        public Int64 CustomerIdentityNumber { get; set; }

        public Int64 CustomerPhone { get; set; }
    }
}
