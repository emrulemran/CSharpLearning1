using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;



namespace SeleniumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg= new Program();
            Console.WriteLine(pg.getSum(1234));

         
        }


        int getSum(int n)
        {


            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                while (n != 0)
                {
                    sum = sum + n % 10;
                    n = n / 10;
                }
            }
            sum = sum + 1;

            return sum;

        }




    }
}
