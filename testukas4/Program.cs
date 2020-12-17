using System;


namespace testukas4
{
    class Program
    {
        static void Main(string[] args)
        {
            BmwCar bmw = new BmwCar();
            AnyOtherCar car = new AnyOtherCar();

            bmw.Drive();
            bmw.Park();
            car.Drive();
            car.Park();

            Console.ReadLine();
        }
    }

    
}
