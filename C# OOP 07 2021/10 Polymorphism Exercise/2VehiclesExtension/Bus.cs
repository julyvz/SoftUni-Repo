namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += 1.4;
        }

        public string DriveEmpty(double distance)
        {
            if (distance * (FuelConsumption - 1.4) <= FuelQuantity)
            {
                FuelQuantity -= distance * (FuelConsumption - 1.4);
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }
    }
}
