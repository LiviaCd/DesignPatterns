using Composite.Component;
using Composite.Leaf;

class Program
{
    static void Main(string[] args)
    {
        GameObject gameObject1 = new GameObject("Cube");
        GameObject gameObject2 = new GameObject("Empty");
        GameObject gameObject3 = new GameObject("Sphere");

        GameObjectGroup gameObjectGroup1 = new GameObjectGroup("Canvas");

        gameObjectGroup1.AddGameObjectComponent(gameObject1);
        gameObjectGroup1.AddGameObjectComponent(gameObject2);
        gameObjectGroup1.AddGameObjectComponent(gameObject3);

        GameObjectGroup gameObjectGroup2 = new GameObjectGroup("Plane");
        gameObjectGroup2.AddGameObjectComponent(gameObjectGroup1);

        gameObjectGroup2.Display();
    }
}