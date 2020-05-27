using System;

namespace Teaching
{


    namespace Day_2
    {

        class Student
        {
            public int RollNo;
             public int M1;
            public int M2;
            public string Name;
            
            public  static string SchoolName;

        }
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
            }
            
            
            // l;''l'; with pram no return 

            public int Sub(int x, int y)
            {


                return x - y;
            }



        }

        class Program
        {
             static void Main(string[] args)
            {

                Program objj = new Program();
               
                Calc obj = new Calc();

                obj.Hello();
                int MyNumber;
                MyNumber = obj.getMeANumber();
                Console.WriteLine("My Random num=" + MyNumber);
                obj.AddTwoNum(12, 12);

                int sub = obj.Sub(100, 90);
                Console.WriteLine("Sub" + sub);



                HelperUtility obj2 = new HelperUtility();
                obj2.PrintHello10();


                Student s1 = new Student();
                s1.Name = "Vishnu";
                s1.M1 = 20;

                Student s2 = new Student();
                s2.Name = "Manu";
             
                
                Student.SchoolName = "NSSHSS";

                Console.ReadLine();
            }

            void manu()
            {

            }
        }
    }
}


  
