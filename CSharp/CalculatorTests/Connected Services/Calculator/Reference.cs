﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorTests.Calculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        decimal Add(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<decimal> AddAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
        decimal Substract(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
        System.Threading.Tasks.Task<decimal> SubstractAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        decimal Multiply(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<decimal> MultiplyAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        decimal Divide(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<decimal> DivideAsync(decimal a, decimal b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : CalculatorTests.Calculator.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<CalculatorTests.Calculator.ICalculator>, CalculatorTests.Calculator.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal Add(decimal a, decimal b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> AddAsync(decimal a, decimal b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public decimal Substract(decimal a, decimal b) {
            return base.Channel.Substract(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> SubstractAsync(decimal a, decimal b) {
            return base.Channel.SubstractAsync(a, b);
        }
        
        public decimal Multiply(decimal a, decimal b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> MultiplyAsync(decimal a, decimal b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public decimal Divide(decimal a, decimal b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> DivideAsync(decimal a, decimal b) {
            return base.Channel.DivideAsync(a, b);
        }
    }
}
