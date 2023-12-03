using System;

namespace Parprogrammering_2
{
    internal class Program
    {
        static void Main()
        {
            Person1 Tommy = new Person1("Tommy Misje", 36, "Bergen");
            Person2 Aleksander = new Person2("John Doe", 24, "Fredrikstad");

            Person1.ShowHobbies();
            Person2.ShowHobbies();
        }
    }
}