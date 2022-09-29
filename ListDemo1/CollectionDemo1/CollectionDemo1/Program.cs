using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring an array of strings:
            string[] members = { "atik", "anika", "tarqul", "naimul" };

            // declaring a list of strings:
            List<string> family = new List<string>() { "Ipa", "Ima", "tacho", "pehel" };

            // adding the array (family) to the list (fam):
            family.AddRange(members);

            // prinint all the values (from the array and the list together):
            Console.WriteLine(String.Join(", ", family));

            // adding element to the list without specifying the index: element gets added at the end:
            family.Add("zaman");



            // adding or inserting an element at a specified index position:
            family.Insert(0, "ATIQ");

            // adding or inserting an element without an index position: gets added at the end of the list
            family.Add("John");

            // removing an element from:
            family.Remove("ATIQ");

            // removing an element from a specified index position:
            family.RemoveAt(2);

            // removing all the values from the list:
            family.Clear();

            Console.WriteLine("List after removing or Clearing all the elements: " + String.Join(", ", family));

            List<String> flowers = new List<string> { "lily", "lilac", "lotus" };

            flowers.Insert(0, "rose");

            flowers.Remove(flowers[0]);


            flowers.RemoveAt(2);

            Console.WriteLine(String.Join(" ", flowers));


            List<int> nums = new List<int>() { 10,20,30};
            nums.InsertRange(1, new List<int>{ 25,35});
            Console.WriteLine(String.Join(",", nums));




        }

    }





        }
    

