using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NTLA1721050223.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}