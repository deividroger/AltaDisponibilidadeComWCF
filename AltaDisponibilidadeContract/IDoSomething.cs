using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace AltaDisponibilidadeContract
{
    [ServiceContract(Namespace="http://altadisponibilidade")]
    public interface IDoSomething
    {
        [OperationContract(IsOneWay = true)]
         void DoSomething(string mensage);
    }
}
