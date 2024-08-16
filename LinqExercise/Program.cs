using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

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

            //TODO: Print the Sum of numbersDONE
            int sumNumbers = number.Sum(numbers => numbers);
            Console.WriteLine(sumNumbers);

            //TODO: Print the Average of numbers DONE
            double averageOfNumbers = number.Average(numbers => numbers);
            Console.WriteLine(averageOfNumbers);

            //TODO: Order numbers in ascending order and print to the console
            int[] ascendingNumbers = number.OrderBy(number => number).ToArray();
            foreach (var number in  ascendingNumbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in descending order and print to the console
            int[] descendingNumbers = number.OrderByDescending(number => number).ToArray();
            foreach (var number in descendingNumbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Print to the console only the numbers greater than 6
            int[] numbersOverSix = number.Where(number => number > 6).ToArray(); 
            foreach (var number in numbersOverSix)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            int[] ascendingFourNumbers = number.Take(4).OrderBy(number => number).ToArray();
            foreach (var number in ascendingFourNumbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            int[] modifiedArray = number.Select((n, index) => index == 3 ? 39 : n).OrderByDescending(n => n).ToArray();
            foreach (int number in modifiedArray)
            {
                Console.WriteLine(number);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var firstNameCSAscending = employees
                .Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S")).OrderBy(e => e.FirstName);
            foreach (var employee in firstNameCSAscending)
            {
                Console.WriteLine(employee.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var secondSortNames = employees
                .Where(e => e.Age > 26).OrderBy(e => e.Age).ThenBy(e => e.FirstName);
            foreach (var employee in secondSortNames)
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}");
            }

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sumYearsOfExperience = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Sum(e => e.YearsOfExperience);
            Console.WriteLine(sumYearsOfExperience); 

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var averageYearsOfExperience = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Average(e =>  e.YearsOfExperience);
            Console.WriteLine(averageYearsOfExperience);

            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployee = new Employee("Nika", "Thomson", 2, 2);

            var updatedEmployeeList = employees.Append(newEmployee).ToList();

            foreach (var employee in updatedEmployeeList)
            {
                Console.WriteLine(employee.FullName);
            }

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
