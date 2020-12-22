using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("toyota", 1998, 100000);
            toyota.display();
            Car bmw = new Car("bmw");
            bmw.display();
            Car nissan = new Car();
            nissan.display();
        }
    }
}
