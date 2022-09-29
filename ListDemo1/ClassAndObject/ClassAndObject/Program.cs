using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{

    class Test
    {

        public static void Main(String[] args)
        {





            Queue<string> cars = new Queue<string>();
            cars.Enqueue("ford");
            cars.Enqueue("tesla");
            cars.Enqueue("nissan");
            cars.Enqueue("buick");
            cars.Enqueue("mazda");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }



            Console.WriteLine("Number of elements of this queue: " + cars.Count());


            Console.WriteLine("Peek element: " + cars.Peek());
            Console.WriteLine("Dequeue: " + cars.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + cars.Peek());

            ;

           foreach (var car in cars)
            {
                Console.WriteLine("After clearning the queue: " + cars);
            }


        }

    }

}





