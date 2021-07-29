using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Day22_UserRegistrationUsingAnnotation
{
    class AnnotationForUser
    {
        public static void Display()
        {
            Console.WriteLine(" User Registration Problem Validations ");
            Console.WriteLine("===============================");
            Employee objEmployee = new Employee();


            Console.WriteLine("Enter a First Name : ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter a Last Name : ");
            String lastName = Console.ReadLine();


            Console.WriteLine("Enter a Email Address: ");
            String email = Console.ReadLine();

            Console.WriteLine("Enter a Mobile NO: ");
            String mobNo = Console.ReadLine();

            Console.WriteLine("Enter a Password: ");
            String pass = Console.ReadLine();

            objEmployee.fName = firstName;
            objEmployee.lName = lastName;
            objEmployee.email = email;
            objEmployee.mobileNo = mobNo;
            objEmployee.Password = pass;


            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                { 
                    Console.WriteLine("Error Msg : {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine(" First Name: " + objEmployee.fName + "\n Last Name : " + objEmployee.lName + "\n Email Address : " + objEmployee.email + "\n Mobile Number  : " + objEmployee.mobileNo + "\n Password  : " + objEmployee.Password);
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}

