using PoliAnimal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliAnimal.Class
{
    public partial class Whale
    {
        public static List<string> getSkills()
        {
            return Methods<Whale>.getMethodsClass();
        }
    }
}
