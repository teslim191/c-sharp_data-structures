using System;


namespace oop2
{
    class MyClass
    {
        private string home;
    }
    class House
    {
        int windows;
        bool duplex;
        public House(int numbers, bool type)
        {
            windows = numbers;
            duplex = type;

        }

        public void annualRent(int numbers)
        {
            Console.WriteLine("the house has {0} windows",numbers);
        }
        static void Main(string[] args)
        {
            House house_1 = new House(4, true);
            Console.WriteLine(house_1.windows);
            house_1.annualRent(4);

        }
    }
}
