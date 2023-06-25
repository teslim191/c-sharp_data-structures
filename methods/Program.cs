using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            GetName();
            FullName("teslim", "jimoh");
            Profile("teslim jimoh");

            int result = age(10, 10);
            Console.WriteLine(result);
            MyMethod(child_3: "john", child_1:"mike", child_2:"pence");

            int method_one = MethodOverLoad(10, 10);
            double method_two = MethodOverLoad(20.5, 20.4);
            Console.WriteLine("int: "+method_one);
            Console.WriteLine("double: "+method_two);

        }
        //method that contains an array
        static void GetName()
        {
            string[] names = { "john", "lukaz", "joe" };

            foreach (string name in names)
            {
                Console.WriteLine(name);

            }

        }

        //parameters and arguments

        static void FullName(string f_name, string l_name)
        {
            Console.WriteLine("my full name is {0} {1}", f_name,l_name);
        }

        //default parameter
        static void Profile(string fullname, int age = 27)
        {
            Console.WriteLine("my fullname is {0} and i am {1} years old",fullname,age);
        }

        //return value

        static int age(int x, int y)
        {
            return x + y;
        }

        //named argument

        static void MyMethod(string child_1, string child_2, string child_3)
        {
            Console.WriteLine("the third child is: {0}",child_3);
        }

        //method overloading: multiple method with the same name but different parameters

        static int MethodOverLoad(int y, int z)
        {
            return y + z;
        }

        static double MethodOverLoad(double y, double z)
        {
            return y + z;
        }
    }
}
