using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_LanguageBasics
{

    public struct Book
    {
        internal string Title;
        internal string Author;
        internal int Year;
        internal string Typography;
        internal string Isbn;

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Author, Title, Year);
        }
    }

    public enum Color
    {
        White,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet,
        Black,
    }
}