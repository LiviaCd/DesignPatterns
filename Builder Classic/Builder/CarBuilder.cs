using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Classic.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public override void BuildName()
        {
            vehicle.Name = "Car";
        }
        public override void BuildMotor()
        {
            vehicle.Motor = "V8 Engine";
        }
        public override void BuildWheels()
        {
            vehicle.Wheels = "4 Wheels";
        }
        public override void BuildMaxSpeed()
        {
            vehicle.MaxSpeed = 220.5;
        }
    }
}
