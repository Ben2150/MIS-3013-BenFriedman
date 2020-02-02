using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1ReallyPt2
{
    class Program
    {//Bennett Friedman
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int id;
            double quizzes, participation, homeworks, midterm, finalexam;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            homeworks = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            participation = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizzes = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            midterm = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            finalexam = double.Parse(Console.ReadLine());

            double finalgrade = (quizzes + participation + homeworks + midterm + finalexam) / 5;

            Console.WriteLine(firstName + lastName + "(" + id + "), your final grade is" + finalgrade.ToString("F") + "%");

            Console.WriteLine("Press any key to continue ...");

            Console.ReadKey();


        }
    }
}
