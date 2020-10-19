using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(5,5);
            B classB = new B(5,5,5);
            Console.WriteLine(classB.c2);
        }
    }
    class A
    {
        public int a = 1;
        public int b = 1;
        public int c
        {
            get
            {return a *= (a + b);}
            set{ a = value;}
        }
         public A (int a, int b){
             this.a = a;
             this.b = b;
          Console.WriteLine( a + b + " ответ");  } 
         public A (){}
    }
    class B : A
    {
        public int d = 0;
        
        public int c2 {
            get { while(d<15)
                d = d  +a + b;
                 return d;
                            }
              set{ c2 = value; }
              
              
                    }
                    public B (int a, int b, int d) : base (a, b){
                    this.d = d; }
                    public B (int d){
                    this.d = d;
                    Console.WriteLine( d +  " ответ");  }
                    }
             
        
    }





      
        


        
    
