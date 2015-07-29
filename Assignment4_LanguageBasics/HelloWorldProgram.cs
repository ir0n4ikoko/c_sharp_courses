using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_LanguageBasics
{
    class HelloWorldProgram
    {
        static void Main(string[] args)
        {
            //---Create a helLo world program in C#

            Console.WriteLine("Hello world!");

            //---Create instances of value types and reference types

            Color c = Color.Green;
            Book skeet = new Book {Title = "C# in Depth", Author = "Skeet J.", Year = 2013};
            Console.WriteLine("Book to read: " + skeet);
            skeet.Isbn = "9781617291340";
            skeet.Typography = "Mannan";

            DateYear myBirthYear=new DateYear(1989);

            //---Use static methods
            var age = DateYear.HowOld(myBirthYear.Year); 
            Console.WriteLine("I am "+age+" years old.");
            Console.WriteLine("My birth year is " + (DateYear.IsLeapYear(myBirthYear.Year)?"":"not")+ " leap year.");
            DateYear nextLeapYear;

            //---Write a method for each type of parameter modifier 

            DateYear.NextLeapYear(out nextLeapYear);
            Console.WriteLine("The next leap year is " + nextLeapYear.Year);
            DateYear.Add(ref nextLeapYear, 4);
            Console.WriteLine("The next next leap year is " + nextLeapYear.Year);

            //---Use boxing and unboxing to prove the understanding of it

            object box = Color.Indigo;
            var unbox = (int) box;

            Console.WriteLine("Boxed color:"+box+"; Unboxed:"+unbox);

            box = 7;
            object unboxc = (Color)box;
            Console.WriteLine("Boxed color:" + box + "; Unboxed:" + unboxc);

            Console.ReadKey();

        }
    }
}
