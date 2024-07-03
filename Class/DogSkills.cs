using PoliAnimal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PoliAnimal.Class
{
    public partial class Dog
    {
        public static List<string> getSkills()
        {
            return Methods<Dog>.getMethodsClass();
        }
    }
}
