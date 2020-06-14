using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorDapper.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First name too long")]
        [MinLength (2, ErrorMessage ="First name too short")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last name too long")]
        [MinLength(2, ErrorMessage = "Last name too short")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
