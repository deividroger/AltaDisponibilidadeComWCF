﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AltaDisponibilidade.Console.AltaDisponibilidadeClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://altadisponibilidade", ConfigurationName="AltaDisponibilidadeClient.IDoSomething")]
    public interface IDoSomething {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://altadisponibilidade/IDoSomething/DoSomething")]
        void DoSomething(string mensage);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://altadisponibilidade/IDoSomething/DoSomething")]
        System.Threading.Tasks.Task DoSomethingAsync(string mensage);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoSomethingChannel : AltaDisponibilidade.Console.AltaDisponibilidadeClient.IDoSomething, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoSomethingClient : System.ServiceModel.ClientBase<AltaDisponibilidade.Console.AltaDisponibilidadeClient.IDoSomething>, AltaDisponibilidade.Console.AltaDisponibilidadeClient.IDoSomething {
        
        public DoSomethingClient() {
        }
        
        public DoSomethingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DoSomethingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoSomethingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoSomethingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoSomething(string mensage) {
            base.Channel.DoSomething(mensage);
        }
        
        public System.Threading.Tasks.Task DoSomethingAsync(string mensage) {
            return base.Channel.DoSomethingAsync(mensage);
        }
    }
}