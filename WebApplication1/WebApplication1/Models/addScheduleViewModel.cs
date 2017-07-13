using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    public class addScheduleViewModel
    {
        
        [Display(Name = "Departure")]
        [Required]
        public string departure { get; set; }
        
        [Display(Name = "Destination")]
        [Required]
        public string destination { get; set; }
        
        [Display(Name = "Weight")]
        [Required]
        public string weight { get; set; }
  
        [Display(Name = "Deliver Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public System.DateTime deliver_date { get; set; }
    }
}