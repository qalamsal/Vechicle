using AutoMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessVehicle();
            ProcessCar();
            Console.ReadLine();
        }
        private static void ProcessVehicle()
        {
            var vehicleList = new List<Vehicle>();
            while (true)
            {
                Console.WriteLine("Enter vehicle color");
                var col = Console.ReadLine();
                Console.WriteLine("Enter vehicle wheelCount");
                var wheels = Convert.ToInt32(Console.ReadLine());
                var vehi = new Vehicle(col, wheels);
                Random random = new Random();
                var value = random.Next(10, 100);
                vehi.Accelerate(value);
                vehicleList.Add(vehi);
                Console.WriteLine("Do you want to enter new Vehicle info. If yes , enter Y");
                var reTry = Console.ReadLine();
                if (reTry != "Y")
                {
                    break;
                }
            }

            foreach (var item in vehicleList)
            {
                Console.WriteLine(item.GetVehicleInfo());
            }
        }
        private static void ProcessCar()
        {
            var cars = new List<Car>();
            while (true)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Enter car color");
                var col = Console.ReadLine();
                Console.WriteLine("Enter car mufflerCount");
                var mufflers = Convert.ToInt32(Console.ReadLine());
                var car = new Car(col, mufflers);
                Random random = new Random();
                var value = random.Next(10, 100);
                car.Accelerate(value);
                cars.Add(car);
                Console.WriteLine("Do you want to enter new Car info. If yes , enter Y");
                var reTry = Console.ReadLine();
                if (reTry != "Y")
                {
                    break;
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.GetVehicleInfo());
            }
        }
    }
}
