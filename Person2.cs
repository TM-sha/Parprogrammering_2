using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_2
{
    internal class Person2
    {
        private static string? _name;
        private static int _age;
        private static string? _location;

        public Person2(string name, int age, string location)
        {
            _name = name;
            _age = age;
            _location = location;
        }

        public static void ShowHobbies()
        {
            Console.WriteLine();
            Console.WriteLine($"Dette er {_name}.\n" +
                              $"{_name} er {_age} år og han bor i {_location}.");
            Console.WriteLine();
            Console.WriteLine("Trykk på et tall fra 1 til 3 for å se hva jeg liker å gjøre på min fritid.");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Jeg spiller fotball.");
                    break;
                case 2:
                    Console.WriteLine("Jeg går turer med bikkja.");
                    break;
                case 3:
                    Console.WriteLine("Jeg spiller xbox - spill.(Bare Fifa)");
                    break;
            }
        }
    }
}
