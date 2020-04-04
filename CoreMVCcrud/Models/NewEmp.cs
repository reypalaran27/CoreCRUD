using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreMVCcrud.Models
{
    public class NewEmp
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Enter Customer Name")]
        [Display(Name = "Customer Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter Customer Age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int age { get; set; }

        [Required(ErrorMessage = "Enter Customer Gender")]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        
    }
}
