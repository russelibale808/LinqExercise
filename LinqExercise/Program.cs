using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        public static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers DONE
            var sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();

            ////TODO: Print the Average of numbers DONE
            var ave = numbers.Average();
            Console.WriteLine(ave);
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console DONE
            var ascending = numbers.OrderBy(numbers => numbers);
            Console.WriteLine("Sorted in Ascending order ");
            foreach (int value in ascending)
            {
                Console.Write(value);
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console DONE
            var decsending = numbers.OrderByDescending(numbers => numbers);
            Console.WriteLine("Sorted in Decending order ");
            foreach (int value in decsending)
            {
                Console.Write(value);
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6 DONE
            var greaterThan = numbers.Where(numbers => (numbers > 6));
            Console.WriteLine("Numbers greater than 6");
            foreach (int i in greaterThan)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!** DONE
            var evens = numbers.Where(numbers => numbers % 2 == 0);
            Console.WriteLine("Evens");
            foreach (int value in evens.Take(4))
            {
                Console.Write($"{value}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 37;
            var decsend = numbers.OrderByDescending(numbers => numbers);
            Console.WriteLine("Sorted in Decending order ");
            foreach (int value in decsend)
            {
                Console.Write($"{value},");
            }
            Console.WriteLine();
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName. DONE
            IEnumerable<Employee> list = employees.Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S")).OrderBy(e => e.FirstName);
            foreach (var i in list)
            {
                Console.WriteLine($"{i.FullName}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result. DONE
            IEnumerable<Employee> ageOf26 = employees.Where(e => e.Age > 26).OrderBy(e => e.Age).ThenBy(e => e.FirstName);
            foreach (var e in ageOf26)
            {
                Console.WriteLine($"{e.Age},{e.FullName}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            IEnumerable<Employee> YOE = employees.Where(e => e.YearsOfExperience <= 10 && e.Age > 35);
    
            Console.WriteLine($"Sum YOE : {YOE.Sum(e => e.YearsOfExperience)}");
            Console.WriteLine($"Avg YOE : {YOE.Average(e => e.YearsOfExperience)}");
            Console.WriteLine();
            

            //TODO: Add an employee to the end of the list without using employees.Add()
            
            employees = employees.Append(new Employee("Russel", "Ibale", 37, 0)).ToList();
            employees.ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;


            
        }
        #endregion
    }
}
