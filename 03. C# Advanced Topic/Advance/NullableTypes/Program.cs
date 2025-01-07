namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable<DateTime> date = null;

            DateTime? date = new DateTime(2014, 1, 1);
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            Console.WriteLine(date3.GetValueOrDefault());
            Console.WriteLine(date2);

            /*Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);*/


            DateTime? date4 = null;
            DateTime date5;

            if (date != null)
            {
                date5 = date.GetValueOrDefault();
            }
            else
                date5 = DateTime.Today;

            Console.WriteLine(date5);

            DateTime? date6 = null;
            DateTime date7 = date6 ?? DateTime.Today;
            Console.WriteLine(date7);



        }
    }
}
