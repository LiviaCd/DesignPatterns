using Builder_Classic.Builder;
using Builder_Classic.Director;
using Builder_Classic.Product;

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        VehicleBuilder carBuilder = new CarBuilder();
        shop.Construct(carBuilder);
        Vehicle car = carBuilder.GetVehicle();
        car.ShowInfo();

        Console.WriteLine();

        VehicleBuilder bikeBuilder = new BikeBuilder();
        shop.Construct(bikeBuilder);
        Vehicle bike = bikeBuilder.GetVehicle();
        bike.ShowInfo();
    }
}