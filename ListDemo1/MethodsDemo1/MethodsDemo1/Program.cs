using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo1
{
    class Program
    {
        static void Main(string[] args)    // 2 types of methods (function): (i) pre-defined, library, built-in (ii) custom or UDFs
        {
            int[] numbers = { 1, 2, 3, 4, 4, 5, 6, 5, 5, 7, 6, 7, 6, 7, 6, 8, 7, 8, 1, 4, 5};
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Average());
            Program pg = new Program();
            Console.WriteLine(pg.AverageOfArrayInt(numbers));
            Console.WriteLine((double) 3/2);
            Console.WriteLine("Inch to CM conversion: " + pg.GetCMFromInch(2));
            Console.WriteLine("Average of Integer Array: " + pg.AvgOfArrayInt(numbers));
            Console.WriteLine("The Max value of Integer Array: " + pg.GetMaxFromIntArray(numbers));
            Console.WriteLine(pg.OccuranceNumber(numbers, 7));
            Console.WriteLine(pg.DivisibleCount(numbers));
        }

        // We want an average (double) of an array of Int (many whole numbers)
        double AverageOfArrayInt(int[] nums)
        {
            double d = 0;
            for(int i = 0; i< nums.Length; i++)
            {
                d = d + nums[i];
            }
            return d / nums.Length;
        }

        double AvgOfArrayInt(int[] nums)
        {
            return (double) nums.Sum() / nums.Length;
        }


        // for any custom function: inputs (as parameters), logic (algorithm), output (return)
        // 1 inch = 2.54 cm
        // I am going to write a function that takes inches (double) as input and cm as output (double)

        double GetCMFromInch(double inputInch)
        {
            return inputInch * 2.54;
        }

        // write a function that takes mile as input and returns km as output.  1 mile = 1.61 km
        // You did it!



        // input: an array of Int  output: the highest element (max)

       int GetMaxFromIntArray(int[] myArray)
        {
            return myArray.Max();

        }


        // Task:  write a function that takes an Int array and returns the min value 




        int OccuranceNumber(int[] nums, int input)
        { 
            int count = 0;
            for(int i = 0; i< nums.Length; i++)
            {
                if(nums[i] == input)
                {
                    count++;
                }
            }
            return count;
        }


        // how to get the total count of odd and even numbers in an array integers:
        int DivisibleCount(int[] nums)
        {
            int count = 0;
            for(int i = 0; i <nums.Length; i++)
            {
                if (nums[i]%2 == 1)   // for odd numbers   and  if (nums[i]%2 == 0) for even numbers
                {
                    count++;
                }   
            }
            return count;
        }
    }
}
