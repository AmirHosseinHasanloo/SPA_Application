using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPA_Application
{
    public class People
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(180)]
        public string Name { get; set; }
        [Required]
        [MaxLength(180)]
        public string Family { get; set; }
        public int Age { get; set; }
    }
}