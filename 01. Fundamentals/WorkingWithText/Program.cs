namespace WorkingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String
            var FullName = "Emran Hossen ";
            Console.WriteLine("Trim : '{0}'",FullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", FullName.Trim().ToUpper());

            var index = FullName.IndexOf(' ');
            var firstName = FullName.Substring(0, index);
            var lastName = FullName.Substring(index+ 1);
            Console.WriteLine("FirstName:" + firstName);
            Console.WriteLine("LastName:" + lastName);


            //Another way
            var names = FullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            Console.WriteLine(FullName.Replace("Emran", "Moshfegh"));
            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            //Updated Way
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // String to number
            var str = "25";
            Convert.ToByte(str); // Age is not greater then 250

            // Number to string
            float price = 29.95f;
            Console.WriteLine( price.ToString("C0"));
        }
    }
}
