using AbstractFactory.Core.Laptop;
using AbstractFactory.Core.Mobile;
using AbstractFactory.Factory;

class Program
{
    static void Main(string[] args)
    {
        IDevice factoryDevices = new AsusCreateFactory();

        Laptop laptop = factoryDevices.CreateLaptop();
        Mobile mobile = factoryDevices.CreateMobile();

        laptop.DownloadApplication();
        mobile.TakePhoto();
    }
    
}