using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Dirk Dobson  ";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(lastName);
        }
    }
}