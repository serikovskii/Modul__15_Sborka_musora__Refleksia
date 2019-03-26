using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typeString = typeof(String);
            string str = "London is a capital UK";
            foreach (var methodInfo in typeString.GetMethods())
            {
                ParameterInfo[] param = methodInfo.GetParameters();
                if (methodInfo.Name == "Substring" && param.Count() == 2)
                {
                    Console.WriteLine($"{methodInfo.ReturnType.Name} {methodInfo.Name} ({param[0].Name}, {param[1].Name})");

                    Console.WriteLine((methodInfo as MethodInfo).Invoke(str, new object[] { 1, 5 }));
                }
            }

            Type type = typeof(List<>);
            foreach (ConstructorInfo constructor in type.GetConstructors())
            {
                Console.WriteLine(constructor.Name);
            }
        }
    }
}
