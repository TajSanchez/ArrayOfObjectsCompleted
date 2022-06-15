using System;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] garage = new Car[4];

            Car car1 = new Car("Ferarri");
            Car car2 = new Car("BMW");
            Car car3 = new Car("McClarren");
            Car car4 = new Car("Aston Martin");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;
            garage[3] = car4;

            Console.WriteLine(garage[0].model);
            

        }

        class Car
        {
            public String model;
            
            public Car(string model)
            {
                this.model = model;
            }
        }
    }
}
