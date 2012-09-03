using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltaDisponibilidade.Console.AltaDisponibilidadeClient;

namespace AltaDisponibilidade.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var entrada = System.Console.ReadLine();

            using (DoSomethingClient dosomething = new DoSomethingClient())
            {
                dosomething.DoSomething(entrada);
            }
            System.Console.ReadKey();
        }
    }
}
