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

            DelegateExercises myDelegate1 = new DelegateExercises();
            myDelegate1.Method2();
        }
    }

    public class DelegateExercises
    {
        public delegate void MyDelegate();

        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
