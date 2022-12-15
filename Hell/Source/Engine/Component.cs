using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Source.Engine
{
    public abstract class Component
    {
        public enum ReturnStates
        {
            NotImplemented = 0,
            Failed = 1, // indednted behaviour failed (probably undefined)
            Succeed = 2, // (good)
            ExceptionCaught = 3 // error (bad)
        }
        public virtual ReturnStates Update()
        {
            return 0;
        }
        public virtual ReturnStates Start()
        {
            return 0;
        }
        public virtual ReturnStates FixedUpdate()
        {
            return 0;
        }
        public virtual ReturnStates OnCollisionEnter()
        {
            return 0;
        }
    }
}
