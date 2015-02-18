﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfMetadata.PaymentServiceWcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexJsonObject", Namespace="http://schemas.datacontract.org/2004/07/WcfContracts")]
    [System.SerializableAttribute()]
    public partial class ComplexJsonObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WrapperObject", Namespace="http://schemas.datacontract.org/2004/07/WcfContracts")]
    [System.SerializableAttribute()]
    public partial class WrapperObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentServiceWcf.IPaymentService")]
    public interface IPaymentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ApplyPayment", ReplyAction="http://tempuri.org/IPaymentService/ApplyPaymentResponse")]
        int ApplyPayment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ApplyPayment", ReplyAction="http://tempuri.org/IPaymentService/ApplyPaymentResponse")]
        System.Threading.Tasks.Task<int> ApplyPaymentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ApplyVoid", ReplyAction="http://tempuri.org/IPaymentService/ApplyVoidResponse")]
        int ApplyVoid();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ApplyVoid", ReplyAction="http://tempuri.org/IPaymentService/ApplyVoidResponse")]
        System.Threading.Tasks.Task<int> ApplyVoidAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ApplyRefund", ReplyAction="http://tempuri.org/IPaymentService/ApplyRefundResponse")]
        int ApplyRefund();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ApplyRefund", ReplyAction="http://tempuri.org/IPaymentService/ApplyRefundResponse")]
        System.Threading.Tasks.Task<int> ApplyRefundAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/GetInformation", ReplyAction="http://tempuri.org/IPaymentService/GetInformationResponse")]
        WcfMetadata.PaymentServiceWcf.ComplexJsonObject GetInformation(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/GetInformation", ReplyAction="http://tempuri.org/IPaymentService/GetInformationResponse")]
        System.Threading.Tasks.Task<WcfMetadata.PaymentServiceWcf.ComplexJsonObject> GetInformationAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/PutInformation", ReplyAction="http://tempuri.org/IPaymentService/PutInformationResponse")]
        WcfMetadata.PaymentServiceWcf.WrapperObject PutInformation(WcfMetadata.PaymentServiceWcf.ComplexJsonObject value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/PutInformation", ReplyAction="http://tempuri.org/IPaymentService/PutInformationResponse")]
        System.Threading.Tasks.Task<WcfMetadata.PaymentServiceWcf.WrapperObject> PutInformationAsync(WcfMetadata.PaymentServiceWcf.ComplexJsonObject value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaymentServiceChannel : WcfMetadata.PaymentServiceWcf.IPaymentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentServiceClient : System.ServiceModel.ClientBase<WcfMetadata.PaymentServiceWcf.IPaymentService>, WcfMetadata.PaymentServiceWcf.IPaymentService {
        
        public PaymentServiceClient() {
        }
        
        public PaymentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ApplyPayment() {
            return base.Channel.ApplyPayment();
        }
        
        public System.Threading.Tasks.Task<int> ApplyPaymentAsync() {
            return base.Channel.ApplyPaymentAsync();
        }
        
        public int ApplyVoid() {
            return base.Channel.ApplyVoid();
        }
        
        public System.Threading.Tasks.Task<int> ApplyVoidAsync() {
            return base.Channel.ApplyVoidAsync();
        }
        
        public int ApplyRefund() {
            return base.Channel.ApplyRefund();
        }
        
        public System.Threading.Tasks.Task<int> ApplyRefundAsync() {
            return base.Channel.ApplyRefundAsync();
        }
        
        public WcfMetadata.PaymentServiceWcf.ComplexJsonObject GetInformation(string value) {
            return base.Channel.GetInformation(value);
        }
        
        public System.Threading.Tasks.Task<WcfMetadata.PaymentServiceWcf.ComplexJsonObject> GetInformationAsync(string value) {
            return base.Channel.GetInformationAsync(value);
        }
        
        public WcfMetadata.PaymentServiceWcf.WrapperObject PutInformation(WcfMetadata.PaymentServiceWcf.ComplexJsonObject value) {
            return base.Channel.PutInformation(value);
        }
        
        public System.Threading.Tasks.Task<WcfMetadata.PaymentServiceWcf.WrapperObject> PutInformationAsync(WcfMetadata.PaymentServiceWcf.ComplexJsonObject value) {
            return base.Channel.PutInformationAsync(value);
        }
    }
}
