using System;
namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 4;

            var firstName = "Emran";
            string lastName = "Hossen";

            var fullName = firstName + lastName;

            var myFullName = string.Format("My full Name is {0} {1}",firstName,lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] {"This","is","Emran"};

            var formattedName = string.Join(",", names);

            Console.WriteLine(formattedName);

            var text = @"c:\project\project1";
            Console.WriteLine(text);
        }
    }
}
