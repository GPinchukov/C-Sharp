using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            B classB = new B(5,5);
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
        public int d = 1;
        public int i = 0;
        public int[] arr;
        
        public int c2 {
            get { while(d<15)
                d = d  +a + b;
                 return d;
                            }
              set{ c2 = value; }
              
                    }
          public B (int var1, int var2){
              a = var1;
              d = var2;
              arr = new int[a];
             
             for (i = 0; i < a; i++){
                 arr[i] = d*i;
             }
          foreach(int i in arr) Console.WriteLine(i);
                    }
             
        
    }

}



      
        


        
    
