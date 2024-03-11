/*
* Author: Joaquin Gomez
* Course: COMP-003A
* Purpose: Lecture activity for variables, type system, Math, and Console properties
* Reference: The C# Player's Guide (4e) by RB Whitaker
*/
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we going starat a condittional statement
            Console.WriteLine("Numeric to grade using an if-else statement.");
            // Here we enter a score
            Console.WriteLine("Enter a numberic grade (0-100): ");
            string summitGrade = Console.ReadLine();
            double numbericGrade = Convert.ToDouble(summitGrade);
            //if condition, numericGrade is greater than or equal to 90
            if (numbericGrade >= 90)
            {
                // console output Letter Grade: A
                Console.WriteLine("A");
            }
            //else -if condition, numericGrade is greater than or equal to 80
            else if (numbericGrade >= 80)
            {
                /// console output Letter Grade: B
                Console.WriteLine("B");
            }
            //else -if condition, numericGrade is greater than or equal to 70
            else if (numbericGrade >= 70)
            {
                // console output Letter Grade: C }
                Console.WriteLine("C");
            }
            //else -if condition, numericGrade is greater than or equal to 60
            else if (numbericGrade >= 60)
            {
                // console output Letter Grade: D 
                Console.WriteLine("D");
            }
            //else
            else if (numbericGrade <=60){
                // console output Letter Grade: F };
                Console.WriteLine("F \n You Failed Good Luck");
            }
            // else
            else {
                // console output Invalid input!
                Console.WriteLine("Invalid input!");
            }
                // Here we the grade
            Console.WriteLine($"Letter Grade: {numbericGrade}");

            Console.WriteLine("************************************************");
            Console.WriteLine("Integer to string day  using an switch statement");
            Console.WriteLine("Enter an integer day of the week (1-7): ");
            string numberofday = Console.ReadLine();
            int numbericDay = Convert.ToInt32(numberofday);
            //switch expression, numericDay 1.1 switch case 1
            switch (numbericDay)
            {
                case 1:
                // console output String Day: Monday
                    Console.WriteLine("Monday ");
                // ensure to add a break;
                    break;
                case 2:
                    // console output String Day: Tuesday
                    Console.WriteLine("Tuesday ");
                    // ensure to add a break
                    break;
                case 3:
                    // console output String Day: Wednesday
                    Console.WriteLine("Wednesday ");
                    // ensure to add a break;
                    break;
                case 4:
                    // console output String Day: Thursday
                    Console.WriteLine("Thursday");
                    // ensure to add a break;
                    break;
                case 5:
                    // console output String Day: Friday
                    Console.WriteLine("Friday ");
                    // ensure to add a break;
                    break;
                case 6:
                    // console output String Day: Saturday
                    Console.WriteLine("Saturday ");
                    // ensure to add a break;
                    break;
                case 7:
                    // console output String Day: Sunday
                    Console.WriteLine("Sunday ");
                    // ensure to add a break;
                    break;
                default:
                    // console output Invalid day!
                    Console.WriteLine("Invalid day! ");
                    // ensure to add a break;
                    break;
            }
            // Outputs the day
            Console.ReadKey();

        }
    }
}
