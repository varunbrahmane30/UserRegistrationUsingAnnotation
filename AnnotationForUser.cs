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


            Console.WriteLine("Enter a Name : ");
            String firstName = Console.ReadLine();

            objEmployee.Name = firstName;
            
            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Member Name : {0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name);
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}

