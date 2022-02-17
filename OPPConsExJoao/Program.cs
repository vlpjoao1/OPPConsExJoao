using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSound;

namespace OPPConsExJoao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter<=10)
            {
                Console.WriteLine("Type the Vehicle (car, train, truck):");
                string vehicleType = Console.ReadLine().ToLower();
                Vehicle vehicle = null;

                switch (vehicleType)
                {
                    case "car":
                        vehicle = new Car();
                        vehicle.Sound();
                        break;
                    case "train":
                        vehicle = new Train();
                        vehicle.Sound();
                        break;
                    case "truck":
                        vehicle = new Truck();
                        vehicle.Sound();
                        break;
                    default:
                        Console.WriteLine("Vehicle not found");
                        break;
                }
                counter++;
            }
        }
    }
}
