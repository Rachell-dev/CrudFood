using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudAlimentos.Models
{
    public class alimento
    {
        [Key]
        public int IdAlimento { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Description{ get; set; }
       
        [Range(1,5)]
        public int Rating { get; set; }

        
    }
}