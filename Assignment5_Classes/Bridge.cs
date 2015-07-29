using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Classes
{
    public abstract class Bridge
    {
        public string Title { get; set; }
        public int Year { get; set; }
        protected double Weight { get; set; }
        public string Place { get; set; }
        public Structure Structure { get; set; }

        public Size Size { get; set; }

    }
}
