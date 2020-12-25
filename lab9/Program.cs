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
            //Одномерный массив обьектов
            Car[] array = new Car[2]
            {
                new Car("Toyota", 1998, 150000),
                new Car("Bmw", 2012, 3000000) 
            };

            for (int i = 0; i < array.Length; i++)
            {
                array[i].display();
            }

            //Двумерный массив обьектов
            Car[][] array2 = new Car[2][];
            for (int i = 0; i < 2; i++)
            {
                array2[i] = new Car[2];
            }

            for (int j = 0; j < 2; j++)
            {
                array2[0][j] = new Car("Toyota[0][" + j.ToString() + "]", 1998 + (j * 2), 150000 + (j * 30000));
            }

            for (int j = 0; j < 2; j++)
            {
                array2[1][j] = new Car("Bmw[1][" + j.ToString() + "]", 2010 + (j * 2), 300000 + (j * 30000));
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array2[i][j].display();
                }
            }


    /*  //Обьект со всеми параметрами
        Car toyota = new Car("toyota", 1998, 100000);
        toyota.display();
        //Обьект с одним параметром
        Car bmw = new Car("bmw");
        bmw.display();
        //Обьект без параметров
        Car nissan = new Car();
        nissan.read();
        nissan.display();*/
    }
}
}
