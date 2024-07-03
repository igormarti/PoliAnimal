using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliAnimal.Class
{
    public abstract class Animal
    {
        protected string Name { get; set; }

        public virtual void eat() { }

        public virtual void observe() { }
    }
}
