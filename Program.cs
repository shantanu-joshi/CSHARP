using System;

namespace C_Sharp
{
    class Program
    {


        static float AAverage(int a,int b,int c)
        {
            float ans  = a+b+c;
            return ans / 3;

        }
        static void Main(string[] args)
        {
            int number = 32;
            Console.WriteLine("Hello World!");  // leave new line
            Console.Write("Hello Shantanu"); //leave no new line
            Console.WriteLine(" Meri jaan  "+number);

            int a =  34;
            Convert.ToBoolean(a);

            bool isint = true;
            double b = 34.4;
            int d = (int)b;
            float c = 34.4f;

            Console.WriteLine(b+" "+c+" "+d);
            Console.WriteLine(isint);
            Console.WriteLine(a);


            //string number2 = Console.ReadLine();   //Taking input
            Console.WriteLine(number);  

            int maxnumber = Math.Max(345,3456);
            Double aaa = Math.Sqrt(36);   //Takes double
            Console.WriteLine(aaa);
            Console.WriteLine(maxnumber);


            // string name = Console.ReadLine();
            // string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name} and you have {candies} candies");

            string hellowrld = "Hello this is shantanu";
            Console.WriteLine(hellowrld[0]);
            Console.WriteLine(hellowrld.IndexOf("shantanu"));
            Console.WriteLine(hellowrld.Substring(0,5));


            //Escape sequence
            string newword = "\"this is me\"shatnau";
            Console.WriteLine(newword);


            // //Decision 
            // Console.WriteLine("Enter ur age");
            // string str = Console.ReadLine();
            // int age =Convert.ToInt32(str);
            // if(age>18)
            // {
            //     Console.WriteLine("You Passes");
            // }
            // else
            // {
            //     Console.WriteLine("You failed");
            // }


            int age = 78;

            switch (age)
            {
                case 18:
                  Console.WriteLine("Please wait for an year");
                  break;
                case 20:
                  Console.WriteLine("Hello");
                  break;
                case 78:
                  Console.WriteLine("Hello shantanu joshi");
                  break;
            }


            Console.WriteLine(AAverage(10,2011,30));



        }
    }
}
