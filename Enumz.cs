using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class Enumz
    {
        enum Brand
        {
            Toyota,
            Nissan,
            BMW,
            Ford,
            Mustang,
            Chryslar,
            AlphaRomeo = 10,
            Jaguar,
            Bentley
        }


        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };


        static void Main(string[] args)
        {




            Brand myBrand = Brand.Toyota;
            Console.WriteLine("My brand is: " + myBrand);

            int indexOfBrand = (int)Brand.Mustang;
            Console.WriteLine("The index position of Mustant is: " + indexOfBrand);


            Brand brnd = Brand.Chryslar;

            switch (brnd)
            {
                case Brand.Toyota:
                    Console.WriteLine("Its Toyota!");
                    break;

                case Brand.Nissan:
                    Console.WriteLine("Its Nissan!");
                    break;

                case Brand.BMW:
                    Console.WriteLine("Its BMW!");
                    break;
                case Brand.Ford:
                    Console.WriteLine("Its Ford!");
                    break;
                case Brand.Mustang:
                    Console.WriteLine("Its Toyota!");
                    break;
                case Brand.Chryslar:
                    Console.WriteLine("Its Chryslar!");
                    break;
                case Brand.AlphaRomeo:
                    Console.WriteLine("Its AlphaRomeo!");
                    break;

                case Brand.Jaguar:
                    Console.WriteLine("Its Jaguar!");
                    break;

                case Brand.Bentley:
                    Console.WriteLine("Its Bentley!");
                    break;


            }



            // GetNames:
            foreach (string name in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(name);
            }

            // GetValues:
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }

        }
    }
}
