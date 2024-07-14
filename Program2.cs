using System;

namespace Delegates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            
            ArithOp operation1 = new ArithOp(MathOperation.Add);
            ArithOp operation2 = new ArithOp(MathOperation.sub);
            int result1 = operation1(1200, 1000);
            int result2 = operation2(1200, 1000);
            Console.WriteLine("Addition = "+result1);
            Console.WriteLine("Subtraction = " + result2);
            
            */

            /*
            */

            mDel m1 = new mDel(mDelegate.print);
            mDel m2 = new mDel(mDelegate.disp);
            mDel m3 = m1 + m2;
            mDel m4 = m2 + m3;
            mDel m5 = m3 - m2;
            m1();
            m2();
            m3();
            m4();
            m5();
        }
    }
}
