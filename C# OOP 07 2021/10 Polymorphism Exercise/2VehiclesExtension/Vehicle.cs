namespace Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity > tankCapacity ?  0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }

        public string Drive(double distance)
        {
            if (distance * FuelConsumption <= FuelQuantity)
            {
                FuelQuantity -= distance * FuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual bool Refuel(double liters)
        {
            if (liters <= 0)
            {
                System.Console.WriteLine("Fuel must be a positive number");
                return false;
            }
            
            if (FuelQuantity + liters > TankCapacity)
            {
                System.Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return false;
            }
            
            FuelQuantity += liters;
            return true;
        }
    }
}
