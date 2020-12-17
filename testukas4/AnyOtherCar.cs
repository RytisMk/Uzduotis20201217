using System;

namespace testukas4
{
    public class AnyOtherCar : IVehicle
    {
        public void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }
    
        public void Drive()
        {
            Console.WriteLine("Driving to the destination");
        } 
    }
}