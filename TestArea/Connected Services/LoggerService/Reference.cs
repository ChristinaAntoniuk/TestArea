﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestArea.LoggerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoggerService.ILogger")]
    public interface ILogger {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Info", ReplyAction="http://tempuri.org/ILogger/InfoResponse")]
        void Info(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Info", ReplyAction="http://tempuri.org/ILogger/InfoResponse")]
        System.Threading.Tasks.Task InfoAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Warn", ReplyAction="http://tempuri.org/ILogger/WarnResponse")]
        void Warn(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Warn", ReplyAction="http://tempuri.org/ILogger/WarnResponse")]
        System.Threading.Tasks.Task WarnAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Error", ReplyAction="http://tempuri.org/ILogger/ErrorResponse")]
        void Error(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Error", ReplyAction="http://tempuri.org/ILogger/ErrorResponse")]
        System.Threading.Tasks.Task ErrorAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Debug", ReplyAction="http://tempuri.org/ILogger/DebugResponse")]
        void Debug(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Debug", ReplyAction="http://tempuri.org/ILogger/DebugResponse")]
        System.Threading.Tasks.Task DebugAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Fatal", ReplyAction="http://tempuri.org/ILogger/FatalResponse")]
        void Fatal(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogger/Fatal", ReplyAction="http://tempuri.org/ILogger/FatalResponse")]
        System.Threading.Tasks.Task FatalAsync(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoggerChannel : TestArea.LoggerService.ILogger, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoggerClient : System.ServiceModel.ClientBase<TestArea.LoggerService.ILogger>, TestArea.LoggerService.ILogger {
        
        public LoggerClient() {
        }
        
        public LoggerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoggerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Info(string message) {
            base.Channel.Info(message);
        }
        
        public System.Threading.Tasks.Task InfoAsync(string message) {
            return base.Channel.InfoAsync(message);
        }
        
        public void Warn(string message) {
            base.Channel.Warn(message);
        }
        
        public System.Threading.Tasks.Task WarnAsync(string message) {
            return base.Channel.WarnAsync(message);
        }
        
        public void Error(string message) {
            base.Channel.Error(message);
        }
        
        public System.Threading.Tasks.Task ErrorAsync(string message) {
            return base.Channel.ErrorAsync(message);
        }
        
        public void Debug(string message) {
            base.Channel.Debug(message);
        }
        
        public System.Threading.Tasks.Task DebugAsync(string message) {
            return base.Channel.DebugAsync(message);
        }
        
        public void Fatal(string message) {
            base.Channel.Fatal(message);
        }
        
        public System.Threading.Tasks.Task FatalAsync(string message) {
            return base.Channel.FatalAsync(message);
        }
    }
}
