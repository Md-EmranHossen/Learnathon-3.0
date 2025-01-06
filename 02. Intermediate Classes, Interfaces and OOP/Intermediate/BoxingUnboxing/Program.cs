using System.Collections;

namespace BoxingUnboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
           var list = new ArrayList();
            list.Add(1);
            list.Add("Emran");
            list.Add(4.5f);
            list.Add(DateTime.Now);
            var number = (int)list[1];

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Emran");
        }
    }
}
