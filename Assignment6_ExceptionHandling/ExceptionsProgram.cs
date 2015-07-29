using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ExceptionHandling
{
    class ExceptionsProgram
    {
        /*
         * • CREATE METHODS WHICH CHECKS INPUT ARUGEMENTS AND THROWS EXCEPTIONS
         * • CREATE CUSTOM EXCEPTIONS AND THROW THEM
         * • WRITE TRY-CATCH-FINALLY BLOCK WITH MULTIPLE CATCH STATEMENTS
         * • RETHROW EXCEPTION
         * • ADD CONDITIONAL COMPILATION SIMBOLS
         * • USE DEBUG CLASS TO WRITE DEBUG INFORMATION TO OUTPUT WINDOW
         * • DECLARE IMPLICIT TYPED VARIABLE USING KEYWORD VAR
         * • CREATE SEALED CLASSES, METHODS AND PROPERTIES
         */
        static void Main(string[] args)
        {
            try
            {
                SaveUser(null, DateTime.Now);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message );
            }
            try
            {
                SaveUser("1234567890123456", DateTime.Now);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message );
            }
            try
            {
                SaveUser("Ion", DateTime.Now.AddYears(-200));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
                //throw;
            }
            finally
            {
                int i = 0;
                i = 1010;
                Console.ReadLine();
            }
            //ff
            //ff

        }

        public static void SaveUser(string name, DateTime birhtday)
        {
            if (name == null || name.Equals("") || name.Length == 0) throw new ArgumentNullException(name, "User name cannot be empty");
            if (name.Length>15) throw new ArgumentException("User name max length is 15 symbols");
            if (birhtday == null) throw new  ArgumentNullException();
            if (birhtday.Year<1900 || birhtday>=DateTime.Now) throw new ArgumentOutOfRangeException(birhtday.ToString("yyyy-mm-dd"), "User birthday is out of range");
        }


    }
}
