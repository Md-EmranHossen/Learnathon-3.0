using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feilds
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            {
                this.Name = name;
            }

        }
        public void Promote()
        {
           // Orders = new List<Order>();
           // Read only keyword allow us to change a field either declearation time or in a constructor

        }
        
    }
}
