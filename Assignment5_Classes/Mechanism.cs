using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Classes
{
    class Mechanism
    {
        private void Move()
        {
            Console.WriteLine("Bridge starts to move");
        }

        private void Move(Direction direction)
        {
            Console.WriteLine("Bridge starts to move "+direction);
        }

        public void OpenBridge()
        {
            Move();
            Console.WriteLine("Bridge opened");
        }

        public void CloseBridge()
        {
            Move();
            Console.WriteLine("Bridge closed");
        }
    }

    internal enum Direction
    {
        Left,
        Right,
        Bottom,
        Up,
    }
}
