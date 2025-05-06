using Builder_Classic.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Classic.Builder
{
    public abstract class VehicleBuilder
    {

        protected Vehicle vehicle = new Vehicle();

        public abstract void BuildName();
        public abstract void BuildMotor();
        public abstract void BuildWheels();
        public abstract void BuildMaxSpeed();

        public Vehicle GetVehicle()
        {
            return vehicle;
        }


    }
}
