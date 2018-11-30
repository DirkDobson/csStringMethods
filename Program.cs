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

            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: " + names[0]);
            System.Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Dirk", "Joe"));

            if ( String.IsNullOrWhiteSpace(" "))
                System.Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            
        }
    }
}