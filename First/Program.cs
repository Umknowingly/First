using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NULLABLE 
namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Age: ");
            string userAge = Console.ReadLine();

            int? age = null;

            if (!string.IsNullOrWhiteSpace(userAge))
            {
                age = int.Parse(userAge);
            }
            if (age == null)
            {
                Console.WriteLine("Age required, try again");
            }
            else
            {
                Console.WriteLine("Your age is " + age);
            }

            Console.ReadLine();
        }
    }
}
/* ? means it means optional eg string? name = null;
 - runtime errors are errors that don't focus on logical error but the compliler itself


if string was used:
  static void Main(string[] args)
        {
            Console.Write("Name: ");
            string userAge = Console.ReadLine();

            string Name = null;

            if (!string.IsNullOrWhiteSpace(userAge))
            {
                Name = userName;
            }
            if (Name == null)
            {
                Console.WriteLine("Age required, try again");
            }
            else
            {
                Console.WriteLine("Your Name is " + Name);
            }

                Console.ReadLine();
        }
*/