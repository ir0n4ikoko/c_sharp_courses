using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Classes
{
    class Protection
    {
        public void Open()
        {
            Console.WriteLine("open bridge for usual traffic");
        }
        public void Close()
        {
            Warning();
            Console.WriteLine("close bridge for usual traffic");
        }

        private void Warning()
        {
            Console.WriteLine("warn traffic that bridge is closed");
        }
    }
}
