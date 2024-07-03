using PoliAnimal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PoliAnimal.Utils
{
    internal sealed class Methods<T>
    {
        private static List<string> methods { get; set; } = new List<string>();

        public static List<string> getMethodsClass()
        {
            Type type = typeof(T);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (MethodInfo method in methods)
            {
                if (method != null && method.DeclaringType == type)
                {
                    Methods<T>.methods.Add(method.Name);
                }
            }
            return Methods<T>.methods;

        }

    }
}
