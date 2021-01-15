﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IntroduceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Introduce {
            get {
                return this.IntroduceField;
            }
            set {
                if ((object.ReferenceEquals(this.IntroduceField, value) != true)) {
                    this.IntroduceField = value;
                    this.RaisePropertyChanged("Introduce");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentId {
            get {
                return this.StudentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentIdField, value) != true)) {
                    this.StudentIdField = value;
                    this.RaisePropertyChanged("StudentId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddStudent", ReplyAction="http://tempuri.org/IService/AddStudentResponse")]
        bool AddStudent(SMClient.ServiceReference1.Student newStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddStudent", ReplyAction="http://tempuri.org/IService/AddStudentResponse")]
        System.Threading.Tasks.Task<bool> AddStudentAsync(SMClient.ServiceReference1.Student newStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteStudent", ReplyAction="http://tempuri.org/IService/DeleteStudentResponse")]
        bool DeleteStudent(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteStudent", ReplyAction="http://tempuri.org/IService/DeleteStudentResponse")]
        System.Threading.Tasks.Task<bool> DeleteStudentAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListStudents", ReplyAction="http://tempuri.org/IService/GetListStudentsResponse")]
        SMClient.ServiceReference1.Student[] GetListStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListStudents", ReplyAction="http://tempuri.org/IService/GetListStudentsResponse")]
        System.Threading.Tasks.Task<SMClient.ServiceReference1.Student[]> GetListStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        bool UpdateStudent(int id, [System.ServiceModel.MessageParameterAttribute(Name="updateStudent")] SMClient.ServiceReference1.Student updateStudent1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        System.Threading.Tasks.Task<bool> UpdateStudentAsync(int id, SMClient.ServiceReference1.Student updateStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentById", ReplyAction="http://tempuri.org/IService/GetStudentByIdResponse")]
        SMClient.ServiceReference1.Student GetStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentById", ReplyAction="http://tempuri.org/IService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> GetStudentByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : SMClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<SMClient.ServiceReference1.IService>, SMClient.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddStudent(SMClient.ServiceReference1.Student newStudent) {
            return base.Channel.AddStudent(newStudent);
        }
        
        public System.Threading.Tasks.Task<bool> AddStudentAsync(SMClient.ServiceReference1.Student newStudent) {
            return base.Channel.AddStudentAsync(newStudent);
        }
        
        public bool DeleteStudent(int Id) {
            return base.Channel.DeleteStudent(Id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteStudentAsync(int Id) {
            return base.Channel.DeleteStudentAsync(Id);
        }
        
        public SMClient.ServiceReference1.Student[] GetListStudents() {
            return base.Channel.GetListStudents();
        }
        
        public System.Threading.Tasks.Task<SMClient.ServiceReference1.Student[]> GetListStudentsAsync() {
            return base.Channel.GetListStudentsAsync();
        }
        
        public bool UpdateStudent(int id, SMClient.ServiceReference1.Student updateStudent1) {
            return base.Channel.UpdateStudent(id, updateStudent1);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStudentAsync(int id, SMClient.ServiceReference1.Student updateStudent) {
            return base.Channel.UpdateStudentAsync(id, updateStudent);
        }
        
        public SMClient.ServiceReference1.Student GetStudentById(int id) {
            return base.Channel.GetStudentById(id);
        }
        
        public System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> GetStudentByIdAsync(int id) {
            return base.Channel.GetStudentByIdAsync(id);
        }
    }
}
