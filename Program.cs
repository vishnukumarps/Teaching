using System;

namespace Teaching
{
    class Program
    {
        using System;

namespace Day_2
    {
        class Calc
        {
            public void Hello()// with out return type with out param
            {
                Console.WriteLine("Hello");
            }

            public int getMeANumber() // wih return type with out pram
            {
                Random ran = new Random();

                return ran.Next(100);

            }


            public void AddTwoNum(int x, int y)
            {
                Console.WriteLine("Sum =" + (x + y));
            }// with pram no return 




        }

        class Program
        {
            static void Main(string[] args)
            {

                Calc obj = new Calc();

                obj.Hello();
                int MyNumber;
                MyNumber = obj.getMeANumber();
                Console.WriteLine("My Random num=" + MyNumber);
                obj.AddTwoNum(12, 12);
                Console.ReadLine();
            }
        }
    }

}
}
