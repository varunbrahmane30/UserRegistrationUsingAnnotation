﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Day22_UserRegistrationUsingAnnotation
{
    class Employee
    {
        
            [Required(ErrorMessage = "Employee {0} is required")]
            [StringLength(100, MinimumLength = 2, ErrorMessage = "Name should have minimum of 2 charaters and maximum 100 characters")]
            [DataType(DataType.Text)]
            public string Name { get; set; } 

        }

}
