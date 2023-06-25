using System;

namespace helloworld_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string
            string course = "c# is an interesting programming language";
            //length of a string
            //Console.WriteLine("the length of the string is {0}",course.Length);

            //uppercase
            //Console.WriteLine(course.ToUpper());

            //lower
            //Console.WriteLine(course.ToLower());

            //concatenation
            string f_name = "john";
            string l_name = "doe";
            //Console.WriteLine(f_name+" "+l_name);

            string full_name = string.Concat(f_name, l_name);
            //Console.WriteLine("my fullname is {0}",full_name);

            //string interpolation
            //Console.WriteLine($"my full name is {f_name} {l_name}");

            //accessing strings
            //Console.WriteLine(f_name[0]);

            //get the index position
            //Console.WriteLine(f_name.IndexOf("n"));

            //substring
            //Console.WriteLine(f_name.Substring(0,3));

            //special characters
            string sentence = "the man known as \"john wick\" is here";
            //Console.WriteLine(sentence);

            //boolean
            int votingAgeLimit = 18;

            int ageOfPerson = 25;

            //Console.WriteLine(ageOfPerson >= votingAgeLimit);

            if (ageOfPerson >= votingAgeLimit)
            {
                //Console.WriteLine("eligible to vote");
            }
            else
            {
                //Console.WriteLine("you are not eligible to vote");
            }

            //ternery operator

            int BP_Reading = 140;
            string result = BP_Reading > 140 ? "bp is high" : "bp is stable";
            //Console.WriteLine(result);

            //gp
            //Console.WriteLine("enter your CGPA");
            //double CGPA = Convert.ToDouble(Console.ReadLine());
            /*string grade = CGPA >= 4.50 && CGPA <= 5.00 ? "first class" :
                CGPA >= 3.50 && CGPA <= 4.49 ? "second-class upper" :
                CGPA >= 2.50 && CGPA <= 3.49 ? "second-class lower" :
                CGPA >= 1.50 && CGPA <= 2.49 ? "third class" :
                CGPA >= 1.00 && CGPA <= 1.49 ? "pass" :
                "out of scale";*/

            //Console.WriteLine(grade);

            /*Console.WriteLine("enter a password");
            string password = Console.ReadLine();
            int passwordLength = password.Length;

            switch (passwordLength)
            {
                case 6:
                    Console.WriteLine("password is too short");
                    break;
                case 10:
                    Console.WriteLine("password is weak");
                    break;
                case 12:
                    Console.WriteLine("password is strong");
                    break;
                default:
                    Console.WriteLine("password length is not allowed");
                    break;
            }
            */

            //while loop

            /*int x = 0;
            while (x < 5)
            {
                Console.WriteLine("the value of x is {0}",x);
                x++;
            }*/

            /*

            int secret_number = 10;
            int guess_start = 0;
            int guess_limit = 3;

            while (guess_start < guess_limit)
            {
                Console.Write("guess a number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secret_number)
                {
                    Console.WriteLine("you win!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("you lose, try again");
                }
                guess_start++;
            }

            if (guess_start >= guess_limit)
            {
                Console.WriteLine("Game over");

            }
            */
            /*do while
            int y = 0;
            do
            {
                Console.WriteLine(y);
                y++;

            } while (y < 10);

            */
            //for loop

            /*for (int i = 0; i < 10; i+=2)
            {
                //Console.WriteLine(i);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(i);
                }

            }*/

            //foreach loop 

            /* string[] cars = { "mazda", "benz", "bmw", "volvo", "audi", "toyota", "honda", "kia" };

             foreach (var item in cars)
             {
                 if (item == "audi")
                 {
                     continue;

                 }

                 Console.WriteLine(item);

             }*/

            //array
            //different ways of creating arrays
            string[] names = { "john", "doe", "janet", "jackson" };
            int[] results = new int[4];
            long[] grades = new long[5] { 10, 20, 50, 60, 50};
            double[] price = new double[] { 4.5, 6.7, 3.6, 8.0 };

            //declare an array and initialise it later will require you to use the new.
            bool[] status;

            status = new bool[] { true, false };
            foreach (bool item in status)
            {
                //Console.WriteLine(item);
            }

            //loop through array using for loop
            for (int i = 0; i < names.Length; i++)
            {
                //Console.WriteLine("the name is {0}",names[i]);

            }

            //sort an array

            Array.Sort(names);

            foreach (var item in names)
            {
                //Console.WriteLine(item);
            }

            //multi-dimensional 
            int[,] values = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(values.GetValue(0,2));
            //Console.WriteLine(values[0,2]);

            //use a for loop for a multidimensional array
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(0); j++)
                {
                    Console.WriteLine(values[i,j]);
                }

            }

        }
    }
}
