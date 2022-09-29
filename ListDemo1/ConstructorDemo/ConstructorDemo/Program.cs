using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Employee
    {
        public int id;
        public string name;
        public int age;
        public double salary;

    

    public Employee(int emp_id, string empName, int empAge, double empSalary)
    {
        id = emp_id;
            name = empName;
            age = empAge;
            salary = empSalary;

    }

        public void displayInfo()
        {
            Console.WriteLine(id + " " + name + "age" + " " + salary);
        }
    }

    class EmployeeDetails
    {
        public static void Main(String[] args)
        {

            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("stu1", "zaman");
            names.Add("stu7", "atik");
            names.Add("stu5", "nayon");
            names.Add("stu6", "fiza");
            names.Add("stu3", "sanzeda");
            names.Add("stu2", "mitu");
            names.Add("stu4", "mitu");
            names.Remove("zaman");

            names.Remove("zaman");
            Console.WriteLine("Keys: " + String.Join(", ", names.Keys));
            Console.WriteLine("Values: " + String.Join(", ", names.Values));

            names.Remove("stu4");
            Console.WriteLine("Keys: " + String.Join(", ", names.Keys));
            Console.WriteLine("Values: " + String.Join(", ", names.Values));


            SortedDictionary<int, int> nums = new SortedDictionary<int, int>(){
{ 1, 100 },
{ 2, 200 },
{ 3, 300 },
{ 4, 400 },
{ 5, 500 },
{ 6, 600 },
{ 7, 700 }
};

            Console.WriteLine(nums.ContainsKey(8));     // 
            Console.WriteLine(nums.ContainsValue(700));


        }
    }

}
