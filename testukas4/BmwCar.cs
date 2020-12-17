using System;

namespace testukas4
{
    public class BmwCar : IVehicle
    {
        public void Park()
        {
            Console.WriteLine("Parking on as many parking spots as possible at the same time");
        }
    
        public void Drive()
        {
            Console.WriteLine("Driving into the bus stop");
        }
    }
}