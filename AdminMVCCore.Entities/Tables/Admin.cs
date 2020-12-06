using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdminMVCCore.Entities.Tables
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string AdminPass { get; set; }
    }
}
