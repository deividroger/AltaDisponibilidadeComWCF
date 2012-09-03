using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AltaDisponibilidadeContract;

namespace Service
{
    [ServiceBehavior(Namespace="http://altadisponibilidade")]
    public class AltaDisponibilidadeService : IDoSomething
    {
        public void DoSomething(string mensage) {

            Console.Write(mensage);
        
        }   
    }
}
