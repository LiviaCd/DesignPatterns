using Prototype.Additional;
using Prototype.Core;

class Program()
{
    static void Main(string[] args)
    {
        Dragon dragon1 = ReadearCreature.ReadDragon();
        Mario mario1 = ReadearCreature.ReadMario();
        Dragon dragon2 = (Dragon)dragon1.Clone();
        Mario mario2 = (Mario)mario1.Clone();

        dragon2.Name = "Alduin";
        dragon2.Level.BaseAttack = 35;

        mario2.Name = "Super Mario";
        mario2.Level.BaseHealth = 8;

        dragon1.DisplayDataDragon();
        dragon2.DisplayDataDragon();

        mario1.DisplayDataMario();
        mario2.DisplayDataMario();
    }
}