using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace first_mvc.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage ="Please verify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}