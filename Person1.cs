using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_2
{
    internal class Person1
    {
        private static string? _name;
        private static int _age;
        private static string? _location;

        public Person1(string name, int age, string location)
        {
            _name = name;
            _age = age;
            _location = location;
        }

        public static void ShowHobbies()
        {

            Console.WriteLine($"Dette er {_name}.\n" +
                              $"{_name} er {_age} år og han bor i {_location}.");
            Console.WriteLine();
            Console.WriteLine("Trykk på et tall fra 1 til 3 for å se hva jeg liker å gjøre på min fritid.");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Jeg spiller gitar.");
                    break;
                case 2:
                    Console.WriteLine("Jeg går en tur i skogen på kveldstider.");
                    break;
                case 3:
                    Console.WriteLine("Jeg spiller pc - spill.");
                    break;
            }
        }
    }
}
