using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            Type type = typeof(Console);
            //MethodInfo[] methodInfo = type.GetMethods();

            foreach (MethodInfo methodInfo in type.GetMethods())
            {
                Console.WriteLine(methodInfo);
            }
            Console.WriteLine("task 2");
            Reserve reserve = new Reserve()
            {
                NamePerson = "Asem",
                CountPerson = 5,
                dateTime = new DateTime(2019, 03, 14, 20, 30, 00),
                NumberPerson = "+7013603988",
                Check = 180000
            };
            int count = reserve.CountPerson;
            Type typeReserve = typeof(Reserve);
            
            foreach(PropertyInfo property in typeReserve.GetProperties())
            {
                Console.WriteLine($"{property.Name} = {property.GetValue(reserve, null)}");
            }

        }
    }
}
