using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using static System.Console;

        var intType = typeof(int);
        var assembly = intType.Assembly;
        WriteLine($"Assembly {assembly.FullName}");


        var assemblytypes = assembly.GetTypes();

        for (int i = 0; i < 3; i++)              //Чим більше ставимо число тим більше типів (класів) витягує.
        {
            Console.WriteLine();
            Console.WriteLine("TYPE:");
            Console.WriteLine(assemblytypes[i]);
            Console.WriteLine();
            Console.WriteLine("METHODS OF THIS TYPE:");
            var typeMethods = assemblytypes[i].GetMethods();
            foreach (var method in typeMethods)
            {
                Console.WriteLine();
                Console.WriteLine(method.Name + " Method");
                Console.WriteLine(method.ReturnType.Name + " return type");
                var methodparams = method.GetParameters();
                foreach (var parameter in methodparams)
                {
                    Console.WriteLine(parameter.Name + " parameter");
                }
                Console.WriteLine("-------------------------------------------------------------------------");
            }

        }

