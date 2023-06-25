using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //writeline will add a new line
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("This is me learning C# again");
            /*Console.WriteLine(3 + 3);
            Console.WriteLine(3 - 3);
            Console.WriteLine(3 / 3);
            Console.WriteLine(10 % 3);
            Console.WriteLine(3 * 3);*/

            /*write will not add a new line
            Console.Write("Hello");
            Console.Write("World");*/

            //variable
            string name = "john";
            const int age = 30;
            double price = 30.5D;
            float weight = 50.5f;

            //declare multiple variable
            //int a = 10, b = 20, c = 30;

            //scientific number
            float frequency = 3e2f;
            //Console.WriteLine("the frequency is about {0}", frequency);

            long salary = 922337203685477580L;
            //Console.WriteLine(salary);

            //Console.WriteLine(price.GetType());
            //Console.WriteLine("my name is {0} and i am {1} years old and i bought fuel for {2}", name, age, price);

            //char variable
            char myGrade = 'B';

            //implicit casting ---> smaller to larger
            int grade = 9;
            double gradePerAvg = grade;

            //Console.WriteLine("my gpa is {0}",gradePerAvg.GetType());

            //explicit casting
            int monthlySalaray = 500;
            double salaryPerMonth = (double)monthlySalaray;
            //Console.WriteLine(monthlySalaray.GetType());

            int myAge = 50;
            double totalWeight = 50.5;
            bool staff = true;

            //Console.WriteLine(Convert.ToInt64(totalWeight));
            //Console.WriteLine(Convert.ToDouble(myAge));

            //taking user's input
            //Console.WriteLine("enter your surname");
            //string surname = Console.ReadLine();
            //Console.WriteLine($"my surname is {surname}");

            //Console.WriteLine("how old are you?");
            string ageNow = Console.ReadLine();
            long MyAge = Convert.ToInt64(ageNow);
            //Console.WriteLine("i am {0} years old",MyAge);

            //Console.WriteLine("what year were you born? ");
            string yearBorn = Console.ReadLine();
            int yearBornInt = Convert.ToInt32(yearBorn);

            Console.WriteLine("enter present year: ");
            string presentYear = Console.ReadLine();
            int presentYearInt = Convert.ToInt32(presentYear);

            int presentAge = presentYearInt - yearBornInt;
            //Console.WriteLine("i am {0} years old",presentAge);

            //math
            Math.Max(5, 10);
            Math.Min(10, 30);
            Math.Sqrt(49);
            Math.Abs(-7.9);
            Math.Round(6.88);


            
            

        }
    }
}

//variables
// int e.g 10, -10
//double e.g 10.5, -10.5
//char e.g 'a', 'b'
//string "a","b"
//bool true or false

//const keyword to keep a variable unchanged.