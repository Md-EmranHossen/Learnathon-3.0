namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int num = b;

            int x = 256;
            //byte by = x;
            //byte by = (byte) x;
            byte by = (byte)x;

            Console.WriteLine(by);
            Console.WriteLine(num);


            var number = "12335";
            int i = Convert.ToInt32(number);
            int j = int.Parse(number);
            Console.WriteLine(j);



            try
            {
                var ID = "21225103064";
                byte Bt = Convert.ToByte(ID);
            }
            catch(Exception)
            {
                Console.WriteLine("Out of Range");
            }



            try
            {
                var str = true;
                bool Status = Convert.ToBoolean(str);
                Console.WriteLine(Status);
            }
            catch (Exception)
            {
                Console.WriteLine("Can not Convert");
            }


        }

    }
}
