using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            Console.WriteLine(classA.c);
        }
    }
    class A
    {
        private int a = 2;
        private int b = 2;
        public int c
        {
            get
            {return a *= (a + b);}
            set{ a = value;}
        }
    }
}