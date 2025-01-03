using System.Data;
using System.Runtime.ConstrainedExecution;

namespace WorkingWithDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;


            Console.WriteLine("Hour : " + now.Hour);
            Console.WriteLine("Minute : " + now.Minute);
            Console.WriteLine("Second : " + now.Second);


            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


            // Times Span
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes : " + timespan.Minutes);
            Console.WriteLine("Minutes : " + timespan.TotalMinutes);

            // Add and Sub
            Console.WriteLine("Add Example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example : " + timespan.Add(TimeSpan.FromMinutes(2)));

            // Tos string
            Console.WriteLine("ToStirng" + timespan.ToString());

            // parse
            Console.WriteLine("parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
