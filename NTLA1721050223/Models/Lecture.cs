using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTLA1721050223.Models
{
    public class Lecture
    {
        [Required]
        [StringLength(20)]
        public string PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
        [StringLength(50)]
        public string Faculty { get; set; }
        public string Department { get; set; }
    }
}