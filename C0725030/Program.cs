﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Student Name: Leung Wai Chun      Student ID: C0725030
            //Student Name: Prabhjot Kaur       Student ID: C0730227
            //CSD3354 Section 1
            //Assignment 2
            //March 7, 2019

            DelegateExercises delegateExercises = new DelegateExercises();
            try
            {
                delegateExercises.Method3();
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Exception Occurred.");
                Console.ReadLine();
            }

        }
    }

        public delegate void MyDelegate();

        public class DelegateExercises
        {
            void Method1()
            {
                throw new System.Exception();
            }


        public void Method3()
        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();

        }
    }
}