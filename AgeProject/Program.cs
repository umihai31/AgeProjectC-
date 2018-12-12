using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProject
{
    class Program
    {
        public enum Gender {Female, Male}

        public static void Retirement(String gender ,int age)
        {
            int DiffAge = 0;

            if (gender == "m")
            {
                if (age < 65)
                {
                    DiffAge = 65 - age;
                    Console.WriteLine("You have " + DiffAge + " till retirement");
                }

                else
                {
                    DiffAge = age - 65;
                    Console.WriteLine("You retired for " + DiffAge + "ages");
                }
            }

            if (gender == "f")
            {
                if (age < 62)
                {
                    DiffAge = 62 - age;
                    Console.WriteLine("You have " + DiffAge + " till retirement");
                }

                else
                {
                    DiffAge = age - 62;
                    Console.WriteLine("You retired for " + DiffAge + "ages");
                }
            }

            
        }

        public static int AgeCheck(DateTime BornDate, DateTime NowDate)
        {

            int age = 0;
            if ((NowDate.Month - BornDate.Month) < 0)
            {
                age = NowDate.Year - BornDate.Year - 1;

            }
            else
            {

                age = NowDate.Year - BornDate.Year;

            }

            return age;
        }

        static void Main(string[] args)
        {
            string BirthYearString, BirthMonthString, BirthDayString; //Variables for reading from keyboard the year,month and day
            string FirstName, LastName; // Variable used for First Name and Last Name
            bool ParseTry1, ParseTry2, ParseTry3; // For trying to parse
            DateTime BornDate;
            DateTime now = DateTime.Now;
            int NowYear = now.Year;
            int NowMonth = now.Month;
            int NowDay = now.Day;
            int age = 0;
            

            Console.WriteLine("Hello ,please give us your name");

            Console.WriteLine("First Name:");
            FirstName = Console.ReadLine();

            Console.WriteLine("Last Name : ");
            LastName = Console.ReadLine();

            Console.WriteLine("Good job {0} !! \nNow we need your Age ",FirstName);

            //Read the year from keyboard and try to convert this string to int 
            Console.WriteLine("Give us your birthday year :");
            BirthYearString = Console.ReadLine();
            ParseTry1 = Int32.TryParse(BirthYearString,out int BirthYear);
            
            while (!ParseTry1)
            {
                Console.WriteLine("This is not a valid year , give us another one :");
                BirthYearString = Console.ReadLine();
                ParseTry1 = Int32.TryParse(BirthYearString, out BirthYear);
            }

            //Read the month from keyboard and try to convert this string to int
            Console.WriteLine("Now your birth month !");
            BirthMonthString = Console.ReadLine();
            ParseTry2 = Int32.TryParse(BirthMonthString, out int BirthMonth);

            while (!ParseTry2)
            {
                Console.WriteLine("This is not a valid month , give us another one :");
                BirthYearString = Console.ReadLine();
                ParseTry2 = Int32.TryParse(BirthYearString, out BirthYear);
            }

            //Read the day from keyboard and try to convert this string to int 
            Console.WriteLine("Now your birth day !");
            BirthDayString = Console.ReadLine();
            ParseTry3 = Int32.TryParse(BirthDayString, out int BirthDay);

            while (!ParseTry3)
            {
                Console.WriteLine("This is not a valid day , give us another one :");
                BirthYearString = Console.ReadLine();
                ParseTry2 = Int32.TryParse(BirthYearString, out BirthYear);
            }

            BornDate = new DateTime(BirthYear,BirthMonth,BirthDay);
            Console.WriteLine("Thank you !!\nYou were born in {0}", BornDate.ToShortDateString());

            age = AgeCheck(BornDate, now);

            Console.WriteLine("So " + FirstName + ",you have " + age + " age now give us your gender\n M-for Male and F-for Female");
            string gender = Console.ReadLine();
            gender = gender.ToLower();

            Retirement(gender, age);


            Console.ReadLine(); //For keeping the the window opened till you press enter 
        }
    }
}
