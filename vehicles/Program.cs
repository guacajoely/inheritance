namespace Garage
{


    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

        }
    }


    ///////////////////////////////////////////////////////////////////////
    //INTERFACE

    public interface IGas
    {

        int CurrentTankPercentage { get; }
        void RefuelTank();

    }

    public interface IElectric
    {
        int CurrentChargePercentage { get; }
        void ChargeBattery();

    }

    public class Zero : IElectric // EV
    {
        public int CurrentChargePercentage { get; set; } = 70;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }

    public class Tesla : IElectric // EV
    {
        public int CurrentChargePercentage { get; set; } = 70;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }

    public class Cessna : IGas // GAS 
    {
        public int CurrentTankPercentage { get; set; } = 30;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }

    public class Ram : IGas // GAS 
    {
        public int CurrentTankPercentage { get; set; } = 30;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }
    

///////////////////////////////////////////////////////////////////////////
// INHERITANCE 
    // public class GasVehicle
    // {
    //     public string MainColor { get; set; }
    //     public int MaximumOccupancy { get; set; }
    //     public double FuelCapacity { get; set; }
    //     public void RefuelTank()
    //     {
    //         // method definition omitted
    //     }
    //     public virtual void Drive()
    //     {
    //         //console.writeline drive message
    //     }
    //     public virtual void Turn(string direction)
    //     {
    //         //console.writeline turn message
    //     }
    //     public virtual void Stop()
    //     {
    //         //console.writeline stop message
    //     }
    // }

    // public class ElectricVehicle
    // {
    //     public string MainColor { get; set; }
    //     public int MaximumOccupancy { get; set; }
    //     public double BatteryKWh { get; set; }
    //     public void ChargeBattery()
    //     {
    //         // method definition omitted
    //     }
    //     public virtual void Drive()
    //     {
    //         //console.writeline drive message
    //     }
    //     public virtual void Turn(string direction)
    //     {
    //         //console.writeline turn message
    //     }
    //     public virtual void Stop()
    //     {
    //         //console.writeline stop message
    //     }
    // }

    // public class Zero : IElectric // Electric motorcycle
    // {
    //     public override void Drive()
    //     {
    //         Console.WriteLine($"The {MainColor} Zero drives past. Zoooom!");
    //     }
    //     public override void Turn(string direction)
    //     {
    //         Console.WriteLine($"The Zero turned {direction}.");
    //     }
    //     public override void Stop()
    //     {
    //         Console.WriteLine($"The Zero stopped.");
    //     }
 
    // }

    // public class Cessna : IGas// Gas powered light aircraft
    // {
    //     public override void Drive()
    //     {
    //         Console.WriteLine($"The {MainColor} Cessna flies past. Vroom!");
    //     }
    //     public override void Turn(string direction)
    //     {
    //         Console.WriteLine($"The Cessna turned {direction}.");
    //     }
    //     public override void Stop()
    //     {
    //         Console.WriteLine($"The Cessna landed.");
    //     }
    // }

    // public class Tesla : IElectric// Electric car
    // {
    //     public override void Drive()
    //     {
    //         Console.WriteLine($"The {MainColor} Tesla drives past. Zoooom!");
    //     }
    //     public override void Turn(string direction)
    //     {
    //         Console.WriteLine($"The Tesla turned {direction}.");
    //     }
    //     public override void Stop()
    //     {
    //         Console.WriteLine($"The Tesla came to a stop.");
    //     }
    // }

    // public class Ram : IGas// Gas powered truck
    // {
    //     public override void Drive()
    //     {
    //         Console.WriteLine($"The {MainColor} Ram drives past. Vroom!");
    //     }
    //     public override void Turn(string direction)
    //     {
    //         Console.WriteLine($"The Ram turned {direction}.");
    //     }
    //     public override void Stop()
    //     {
    //         Console.WriteLine($"The Ram stopped running.");
    //     }
    // }


}
