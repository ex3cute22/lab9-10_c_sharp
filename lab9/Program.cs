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
            //Обьект со всеми параметрами
            Car toyota = new Car("toyota", 1998, 100000);
            toyota.display();
            //Обьект с одним параметром
            Car bmw = new Car("bmw");
            bmw.display();
            //Обьект без параметров
            Car nissan = new Car();
            nissan.display();
        }
    }
}
