﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IServiceBD")]
    public interface IServiceBD {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBD/AddStudent", ReplyAction="http://tempuri.org/IServiceBD/AddStudentResponse")]
        void AddStudent(string name, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBD/AddStudent", ReplyAction="http://tempuri.org/IServiceBD/AddStudentResponse")]
        System.Threading.Tasks.Task AddStudentAsync(string name, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBD/GetStudent", ReplyAction="http://tempuri.org/IServiceBD/GetStudentResponse")]
        WebService.Student[] GetStudent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBD/GetStudent", ReplyAction="http://tempuri.org/IServiceBD/GetStudentResponse")]
        System.Threading.Tasks.Task<WebService.Student[]> GetStudentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBD/RemoveStudent", ReplyAction="http://tempuri.org/IServiceBD/RemoveStudentResponse")]
        void RemoveStudent(int id, string name, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBD/RemoveStudent", ReplyAction="http://tempuri.org/IServiceBD/RemoveStudentResponse")]
        System.Threading.Tasks.Task RemoveStudentAsync(int id, string name, System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBDChannel : Client.ServiceReference.IServiceBD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBDClient : System.ServiceModel.ClientBase<Client.ServiceReference.IServiceBD>, Client.ServiceReference.IServiceBD {
        
        public ServiceBDClient() {
        }
        
        public ServiceBDClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBDClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBDClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBDClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddStudent(string name, System.DateTime date) {
            base.Channel.AddStudent(name, date);
        }
        
        public System.Threading.Tasks.Task AddStudentAsync(string name, System.DateTime date) {
            return base.Channel.AddStudentAsync(name, date);
        }
        
        public WebService.Student[] GetStudent() {
            return base.Channel.GetStudent();
        }
        
        public System.Threading.Tasks.Task<WebService.Student[]> GetStudentAsync() {
            return base.Channel.GetStudentAsync();
        }
        
        public void RemoveStudent(int id, string name, System.DateTime date) {
            base.Channel.RemoveStudent(id, name, date);
        }
        
        public System.Threading.Tasks.Task RemoveStudentAsync(int id, string name, System.DateTime date) {
            return base.Channel.RemoveStudentAsync(id, name, date);
        }
    }
}
