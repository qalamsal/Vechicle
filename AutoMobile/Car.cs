using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobile
{
    public class Car:Vehicle
    {
        public Car(string color, int mufflerCount) : base(color, 4)
        {
            MufflerCount = mufflerCount;
        }
        private int MufflerCount { get; set; }
        public override string GetVehicleInfo()
        {
            var info = string.Format("Color : {0}, Speed {1}, WheelCount {2} , MufflerCount {3}", Color, Speed, WheelCount, MufflerCount);
            return info;
        }
    }
}
