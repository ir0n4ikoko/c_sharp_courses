using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Classes
{
    class MovableBridge
    {
        public MovingType Type;
        protected Mechanism Drive;
        private Brake Brake;
        public Protection Protection;

        public virtual void MoveBridge()
        {
            Console.WriteLine("Bridge moved to allow passage");
        }

        public virtual void ReturnBridge()
        {
            Console.WriteLine("Bridge is moved back");
        }

        private void StopTrafficWhileMoving()
        {
            Console.WriteLine("Put barrier to block traffic");
        }

    }
}
