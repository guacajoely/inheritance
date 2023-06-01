namespace Garage
{


    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero(){
                MainColor = "black",
                MaximumOccupancy = 1,
                BatteryKWh = 14
            };

            Cessna mx410 = new Cessna(){
                MainColor = "white",
                MaximumOccupancy = 2,
                FuelCapacity = 40
            };

            Tesla modelS = new Tesla(){
                MainColor = "Silver",
                MaximumOccupancy = 4,
                BatteryKWh = 90
            };

            Ram r1500 = new Ram(){
                MainColor = "blue",
                MaximumOccupancy = 2,
                FuelCapacity = 20
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            modelS.Drive();
            modelS.Turn("around");
            modelS.Stop();

            r1500.Drive();
            r1500.Turn("upside down");
            r1500.Stop();

        }
    }


    public class GasVehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public virtual void Drive()
        {
            //console.writeline drive message
        }
        public virtual void Turn(string direction)
        {
            //console.writeline turn message
        }
        public virtual void Stop()
        {
            //console.writeline stop message
        }
    }

    public class ElectricVehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public virtual void Drive()
        {
            //console.writeline drive message
        }
        public virtual void Turn(string direction)
        {
            //console.writeline turn message
        }
        public virtual void Stop()
        {
            //console.writeline stop message
        }
    }

    public class Zero : ElectricVehicle // Electric motorcycle
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Zoooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turned {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Zero stopped.");
        }
 
    }

    public class Cessna : GasVehicle// Gas powered light aircraft
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Vroom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna turned {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Cessna landed.");
        }
    }

    public class Tesla : ElectricVehicle// Electric car
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. Zoooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla turned {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Tesla came to a stop.");
        }
    }

    public class Ram : GasVehicle// Gas powered truck
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. Vroom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram turned {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Ram stopped running.");
        }
    }
}
