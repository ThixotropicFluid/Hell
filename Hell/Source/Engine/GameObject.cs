using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hell.Source.Engine.Components;

namespace Hell.Source.Engine
{
   
    static internal class GameObject
    {
        

    }
    internal class gameObject {
        public List<Component> Components;
        public Transform transform { get; private set; }
        public gameObject() {
            Components = new List<Component>();
            transform = new Transform(this);
            Components.Add(transform);
        }

    }
}
