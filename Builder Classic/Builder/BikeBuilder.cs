using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Classic.Builder
{
    public class BikeBuilder : VehicleBuilder
    {
        public override void BuildName()
        {
            vehicle.Name = "Motorbike";
        }
        public override void BuildMotor()
        {
            vehicle.Motor = "600cc Engine";
        }
        public override void BuildWheels()
        {
            vehicle.Wheels = "2 Wheels";
        }
        public override void BuildMaxSpeed()
        {
            vehicle.MaxSpeed = 180.0;
        }
    }
}
