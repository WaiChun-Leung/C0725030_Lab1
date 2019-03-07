using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Name: Leung Wai Chun      Student ID: C0725030
            //Student Name: Prabhjot Kaur       Student ID: C0730227
            //CSD3354 Section 1
            //Assignment 2
            //March 7, 2019

            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();

        }
    }

    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }

        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}
