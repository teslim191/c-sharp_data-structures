using System;

namespace oop
{

    class Car
    {
        string color;
        int maxSpeed;

        public void drivingSchool()
        {
            Console.WriteLine("what a nice school to learn");
        }

        static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.color = "Red";
            MyCar.maxSpeed = 200;

            Console.WriteLine(MyCar.color);
            Console.WriteLine(MyCar.maxSpeed);
            MyCar.drivingSchool();

        }
    }



}
