using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_ExceptionHandling
{
    class SealedExamples
    {
        //44
        private class A
        {
            protected virtual void F1() { Console.WriteLine("A.F1"); }
            protected virtual void F2() { Console.WriteLine("A.F2"); }
            protected virtual string P1 { get; set; }
            protected virtual string P2 { get; set; }
        }

        sealed class B:A
        {
             
        }

        private class C : A
        {
            protected sealed override void F1() { Console.WriteLine("C.F1"); }

            protected override void F2() { Console.WriteLine("C.F2"); }

            protected sealed override string P1 { get; set; }
            protected override string P2 { get; set; }
        }
        //cannot inherit from sealed class
        //private class D : B
        //{
        //}
        private class E : C
        {
            //cannot override because it's sealed
            //protected sealed override void F1()
            //{
            //    base.F1();
            //}

            protected override void F2()
            {
                base.F2();
            }

            //cannot override because it's sealed
            //protected sealed override string P1 { get; set; }
            protected override string P2 { get; set; }
        }
    }
}
