using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobile
{
   public class Vehicle
    {
        protected string Color { get; set; }
        protected int Speed { get; set; }
        protected int WheelCount { get; set; }

        public Vehicle(string color, int wheelCount)
        {
            Color = color;
            WheelCount = wheelCount;
        }

        public void Start()
        {
            Speed = 20;
        }
        public void Stop()
        {
            Speed = 0;
        }
        public void Accelerate(int value)
        {
            Speed += value;
        }
        public void DeAccelerate(int value)
        {
            Speed = Speed - value;
        }

        //Virtual class ?
        //
        public virtual string GetVehicleInfo()  //virual to allow sub-class to modify it if required
        {
            var info = string.Format("Color : {0}, Speed {1}, WheelCount {2} ", Color, Speed, WheelCount);
            return info;
        }

    }
}
