using System;
using System.Collections.Generic;
using System.Text;

namespace Teaching
{
    class Father
    {
        public void Hello()
        {
            Console.WriteLine("Hello From father class");
        }
        public string HomeName = "xyz home";
        public string Address = "xyz Address";
    }
    class Son : Father
    {
       public  void HelloFromSon()
        {
            Console.WriteLine("Hello From son class");

        }

        void Car()
        {

        }

    }

    class Daughter: Father
    {
       public void HelloFromDaughter()
        {
            Console.WriteLine("Hello From Daughter class");

        }
        void scooter()
        {

        }
    }
    class Hierrarical
    {
        static void Main(string[] args)
        {
            Son o = new Son();
            o.HelloFromSon();
            o.Hello();

            Daughter ob1 = new Daughter();
            ob1.Hello();
            ob1.HelloFromDaughter();
        }
    }
}
