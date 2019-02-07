using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string PhoneNumder;
            string Address;
            string DateOfBirth;
            string Email;
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Phone Numder: ");
            PhoneNumder = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Date Of Birth: ");
            DateOfBirth = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("\n\t My Personal Information ");
            Console.WriteLine("\n\t Name: " + Name);
            Console.WriteLine("\t Phone Numder: " + PhoneNumder);
            Console.WriteLine("\t Address: " + Address);
            Console.WriteLine("\t Date Of Birth: " + DateOfBirth);
            Console.WriteLine("\t Email: " + Email);
            Console.ReadKey();
        }
    }
}
