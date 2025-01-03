namespace ControlFlow
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            // if else and else fi statement
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon");
            }
            else
            {
                Console.WriteLine("It's Evening");
            }


            // Conditional Operator
            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
                price = 29.95f;

            bool isSilverCustomer = true;

            //Ternary operator
            float Amount = (isGoldCustomer) ? 19.95f : 29.95f;

            var season = Season.Autom;

            switch (season)
            {
                case Season.Autom:
                    Console.WriteLine("It'a autom and a beautiful season");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summar and this is very hot");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's a spring this is very nice");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            //Increasing order
            for(int i = 1; i <= 10; i++)
            {
                if((i % 2 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            //Decreasing Order
            for (int i = 10; i >= 1; i--)
            {
                if ((i % 2 == 0))
                {
                    Console.WriteLine(i);
                }
            }


            //Difference between normal loop and Foreach Loops

            string name = "Emran Hossen";
            for(int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
            foreach(var c in name)
            {
                Console.Write(c);
            }

            int k = 0;
            //While Loop
            while(k < 10)
            {
                if(k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
                if (k == 5)
                {
                    break;
                }
            }
            k = 0;

            // do while loop
            do
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            } while (k < 10);



        }
    }
}
