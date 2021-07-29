using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Day22_UserRegistrationUsingAnnotation
{
    class Employee
    {
        
         [Required(ErrorMessage = "Employee {0} is required")]
         [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name should have minimum of 2 charaters and maximum 100 characters")]
         [DataType(DataType.Text)]
         public string fName { get; set; }     

        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name should have minimum of 2 charaters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string lName { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "Mobile Number Required!")]
        [RegularExpression(@"(0|91)?[ ][6-9][0-9]{9}$",ErrorMessage = "Entered mobile number format is not valid.")]
        [DataType(DataType.PhoneNumber)]
        public string mobileNo { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$", ErrorMessage = "Entered Password must have minimum 8 charactors.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }

}

