using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
Dictionary<int, int> nums = new Dictionary<int, int>() { };
        
        nums.Add(1, 2);
            nums.Add(2, 3);

            Console.WriteLine(nums.Keys.GetType());

        }
    }
}
