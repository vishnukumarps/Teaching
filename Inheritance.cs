using System;
using System.Collections.Generic;
using System.Text;

namespace Teaching
{

    // multilevel
    class A
    {
      public void Hello()
        {
            Console.WriteLine("hello");
        }
       public  A()
        {

        }
       
    }
    class B:A
    {
        public B()
        {
          
        }
        public void Hai()
        {
            Console.WriteLine("Hai");
        }
      
    }
    class C:B
    {
       public void Test()
        {
            Console.WriteLine("Test");
        }
      public  C()
        {

        }

    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            C o = new C();// creating an object of  Subclass
            o.Hai();
            o.Test();
            o.Hello();




            A o1 = new B();
            B o2 = new C();
           
        }
    }
}
