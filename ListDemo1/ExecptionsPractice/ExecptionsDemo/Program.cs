using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExecptionsDemo
{
    class Program
    {

        public static void Main(string[]args)
        {
            int num1 = 10;

            try
            {
                Console.WriteLine(num1 / 0);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Thread.Sleep(1);

            string name = "boston";

           

            try
            {
                Console.WriteLine(name[6]);
            }

            catch(Exception MyProblem)
            {
                Console.WriteLine(MyProblem.Message);
            }
            Thread.Sleep(1);

            // Task: declare an arry of intgers of 5 elemenmts and print the 8th element -
            // please handle the exception 
            int[] myNumbers = new int[5];
            myNumbers[0] = 1;
            myNumbers[1] = 2;
            myNumbers[2] = 3;
            myNumbers[3] = 4;
            myNumbers[4] = 5;

            try
            {
                Console.WriteLine(myNumbers[7]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            int userInput = Convert.ToInt16(Console.ReadLine());

            Thread.Sleep(1000);
            try
            {
                Console.WriteLine("You entered a number : " + userInput);
            }
            catch (Exception e)
            {   
                Console.WriteLine("Please input correct format: " + e.ToString());
            }
        }
    }
}