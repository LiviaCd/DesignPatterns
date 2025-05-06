using Composite.Composite;
using Composite.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Component
{
    public class GameObjectGroup : Composite.GameObject
    {
        public List<Composite.GameObject> _gameObjects = new List<Composite.GameObject>();
        public GameObjectGroup(string name) : base(name) { }

        public override void Display(int level = 0)
        {
            string space = new string(' ', level);
            Console.WriteLine(space + Name);

            foreach (var gameObject in _gameObjects)
            {
                gameObject.Display(level+1);
            }
        }

        public void AddGameObjectComponent(Composite.GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
        }

        public void RemoveGameObjectComponent(Composite.GameObject gameObject)
        {
            _gameObjects.Remove(gameObject);
        }


    }
}
