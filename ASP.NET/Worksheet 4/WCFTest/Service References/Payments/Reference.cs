﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFTest.Payments {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentDetails", Namespace="http://users.aber.ac.uk/m5640/paymentprocessor")]
    [System.SerializableAttribute()]
    public partial class PaymentDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFTest.Payments.Address AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public WCFTest.Payments.Address Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreditCardNumber {
            get {
                return this.CreditCardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCardNumberField, value) != true)) {
                    this.CreditCardNumberField = value;
                    this.RaisePropertyChanged("CreditCardNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://users.aber.ac.uk/m5640/paymentprocessor")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HouseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Street1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Street2Field;
        
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
        public string HouseName {
            get {
                return this.HouseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseNameField, value) != true)) {
                    this.HouseNameField = value;
                    this.RaisePropertyChanged("HouseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street1 {
            get {
                return this.Street1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Street1Field, value) != true)) {
                    this.Street1Field = value;
                    this.RaisePropertyChanged("Street1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street2 {
            get {
                return this.Street2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Street2Field, value) != true)) {
                    this.Street2Field = value;
                    this.RaisePropertyChanged("Street2");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://users.aber.ac.uk/m5640/paymentprocessor", ConfigurationName="Payments.IPaymentService")]
    public interface IPaymentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://users.aber.ac.uk/m5640/paymentprocessor/IPaymentService/ProcessPayment", ReplyAction="http://users.aber.ac.uk/m5640/paymentprocessor/IPaymentService/ProcessPaymentResp" +
            "onse")]
        string ProcessPayment(WCFTest.Payments.PaymentDetails paymentDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://users.aber.ac.uk/m5640/paymentprocessor/IPaymentService/ProcessPayment", ReplyAction="http://users.aber.ac.uk/m5640/paymentprocessor/IPaymentService/ProcessPaymentResp" +
            "onse")]
        System.Threading.Tasks.Task<string> ProcessPaymentAsync(WCFTest.Payments.PaymentDetails paymentDetails);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaymentServiceChannel : WCFTest.Payments.IPaymentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentServiceClient : System.ServiceModel.ClientBase<WCFTest.Payments.IPaymentService>, WCFTest.Payments.IPaymentService {
        
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
        
        public string ProcessPayment(WCFTest.Payments.PaymentDetails paymentDetails) {
            return base.Channel.ProcessPayment(paymentDetails);
        }
        
        public System.Threading.Tasks.Task<string> ProcessPaymentAsync(WCFTest.Payments.PaymentDetails paymentDetails) {
            return base.Channel.ProcessPaymentAsync(paymentDetails);
        }
    }
}
