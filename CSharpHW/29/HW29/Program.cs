using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW29
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = null;
            try
            {
                asm = Assembly.LoadFrom(@"..\..\..\assembly\bin\Debug\assembly.exe");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (asm != null)
            {

                Type t = asm.GetType("assembly.Worker");
                MethodInfo[] allMethods = t.GetMethods();
                Console.WriteLine("Methods: {0} \n", t.Name.ToString());
                foreach (var method in allMethods)
                {
                    Console.WriteLine(method.Name + " \t" + method.ReturnType.Name + " ");              
                }
                ConstructorInfo Constructor = t.GetConstructor(Type.EmptyTypes);
                object ClassObj = Constructor.Invoke(new object[] { });


                MethodInfo m1 = t.GetMethod("ShowMessage", new Type[] { typeof(string) });
                m1.Invoke(ClassObj, new object[] { "test123" });
                MethodInfo m2 = t.GetMethod("ShowMessage", new Type[0]);
                m2.Invoke(ClassObj, new object[0]);
            }

            Console.ReadLine();
        }
    }
}
