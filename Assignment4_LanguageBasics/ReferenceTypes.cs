using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_LanguageBasics
{
    public class DateYear
    {
        public int Year { get; private set; }

        public DateYear(int year)
        {
            this.Year = year;
        }

        public static int HowOld(int year)
        {
            return DateTime.Now.Year - year;
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        public static void NextLeapYear(out DateYear nextYear)
        {
            var y = DateTime.Now.Year;
            do
            {
                y++;
            } while (!IsLeapYear(y));
            nextYear=new DateYear(y);
        }

        public static void Add(ref DateYear year, int value)
        {
            year.Year += value;
        }

    }
}
