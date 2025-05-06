using Builder_Classic.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Classic.Director
{
    public class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildName();
            vehicleBuilder.BuildMotor();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildMaxSpeed();
        }
    }
}
