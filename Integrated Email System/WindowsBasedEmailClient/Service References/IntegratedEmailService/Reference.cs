﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsBasedEmailClient.IntegratedEmailService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailProviderType", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
    public enum EmailProviderType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        All = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Gmail = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Yahoo = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hotmail = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
    [System.SerializableAttribute()]
    public partial class ServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string FieldName {
            get {
                return this.FieldNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldNameField, value) != true)) {
                    this.FieldNameField = value;
                    this.RaisePropertyChanged("FieldName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Email", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
    [System.SerializableAttribute()]
    public partial class Email : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Net.Mail.Attachment[] AttachmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsBasedEmailClient.IntegratedEmailService.Contact[] BCCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsBasedEmailClient.IntegratedEmailService.Contact[] CCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsBasedEmailClient.IntegratedEmailService.Contact FromField;
        
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
        public System.Net.Mail.Attachment[] Attachments {
            get {
                return this.AttachmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentsField, value) != true)) {
                    this.AttachmentsField = value;
                    this.RaisePropertyChanged("Attachments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsBasedEmailClient.IntegratedEmailService.Contact[] BCC {
            get {
                return this.BCCField;
            }
            set {
                if ((object.ReferenceEquals(this.BCCField, value) != true)) {
                    this.BCCField = value;
                    this.RaisePropertyChanged("BCC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsBasedEmailClient.IntegratedEmailService.Contact[] CC {
            get {
                return this.CCField;
            }
            set {
                if ((object.ReferenceEquals(this.CCField, value) != true)) {
                    this.CCField = value;
                    this.RaisePropertyChanged("CC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsBasedEmailClient.IntegratedEmailService.Contact From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CodePageDataItem", Namespace="http://schemas.datacontract.org/2004/07/System.Globalization")]
    [System.SerializableAttribute()]
    public partial class CodePageDataItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string m_bodyNameField;
        
        private int m_dataIndexField;
        
        private uint m_flagsField;
        
        private string m_headerNameField;
        
        private int m_uiFamilyCodePageField;
        
        private string m_webNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string m_bodyName {
            get {
                return this.m_bodyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.m_bodyNameField, value) != true)) {
                    this.m_bodyNameField = value;
                    this.RaisePropertyChanged("m_bodyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int m_dataIndex {
            get {
                return this.m_dataIndexField;
            }
            set {
                if ((this.m_dataIndexField.Equals(value) != true)) {
                    this.m_dataIndexField = value;
                    this.RaisePropertyChanged("m_dataIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public uint m_flags {
            get {
                return this.m_flagsField;
            }
            set {
                if ((this.m_flagsField.Equals(value) != true)) {
                    this.m_flagsField = value;
                    this.RaisePropertyChanged("m_flags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string m_headerName {
            get {
                return this.m_headerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.m_headerNameField, value) != true)) {
                    this.m_headerNameField = value;
                    this.RaisePropertyChanged("m_headerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int m_uiFamilyCodePage {
            get {
                return this.m_uiFamilyCodePageField;
            }
            set {
                if ((this.m_uiFamilyCodePageField.Equals(value) != true)) {
                    this.m_uiFamilyCodePageField = value;
                    this.RaisePropertyChanged("m_uiFamilyCodePage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string m_webName {
            get {
                return this.m_webNameField;
            }
            set {
                if ((object.ReferenceEquals(this.m_webNameField, value) != true)) {
                    this.m_webNameField = value;
                    this.RaisePropertyChanged("m_webName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IntegratedEmailService.IIntegratedEmail")]
    public interface IIntegratedEmail {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIntegratedEmail/GetContacts", ReplyAction="http://tempuri.org/IIntegratedEmail/GetContactsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsBasedEmailClient.IntegratedEmailService.ServiceFault[]), Action="http://tempuri.org/IIntegratedEmail/GetContactsListOf_ServiceFaultFault", Name="ArrayOfServiceFault", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
        WindowsBasedEmailClient.IntegratedEmailService.Contact[] GetContacts(WindowsBasedEmailClient.IntegratedEmailService.EmailProviderType provider, string userId, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIntegratedEmail/GetEmails", ReplyAction="http://tempuri.org/IIntegratedEmail/GetEmailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsBasedEmailClient.IntegratedEmailService.ServiceFault[]), Action="http://tempuri.org/IIntegratedEmail/GetEmailsListOf_ServiceFaultFault", Name="ArrayOfServiceFault", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
        WindowsBasedEmailClient.IntegratedEmailService.Email[] GetEmails(WindowsBasedEmailClient.IntegratedEmailService.EmailProviderType provider, string userId, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIntegratedEmail/SendEmail", ReplyAction="http://tempuri.org/IIntegratedEmail/SendEmailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsBasedEmailClient.IntegratedEmailService.ServiceFault[]), Action="http://tempuri.org/IIntegratedEmail/SendEmailListOf_ServiceFaultFault", Name="ArrayOfServiceFault", Namespace="http://schemas.datacontract.org/2004/07/IntegratedEmailService.Entity")]
        WindowsBasedEmailClient.IntegratedEmailService.Contact[] SendEmail(WindowsBasedEmailClient.IntegratedEmailService.EmailProviderType provider, WindowsBasedEmailClient.IntegratedEmailService.Email email, string userId, string pwd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIntegratedEmailChannel : WindowsBasedEmailClient.IntegratedEmailService.IIntegratedEmail, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IntegratedEmailClient : System.ServiceModel.ClientBase<WindowsBasedEmailClient.IntegratedEmailService.IIntegratedEmail>, WindowsBasedEmailClient.IntegratedEmailService.IIntegratedEmail {
        
        public IntegratedEmailClient() {
        }
        
        public IntegratedEmailClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IntegratedEmailClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IntegratedEmailClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IntegratedEmailClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsBasedEmailClient.IntegratedEmailService.Contact[] GetContacts(WindowsBasedEmailClient.IntegratedEmailService.EmailProviderType provider, string userId, string pwd) {
            return base.Channel.GetContacts(provider, userId, pwd);
        }
        
        public WindowsBasedEmailClient.IntegratedEmailService.Email[] GetEmails(WindowsBasedEmailClient.IntegratedEmailService.EmailProviderType provider, string userId, string pwd) {
            return base.Channel.GetEmails(provider, userId, pwd);
        }
        
        public WindowsBasedEmailClient.IntegratedEmailService.Contact[] SendEmail(WindowsBasedEmailClient.IntegratedEmailService.EmailProviderType provider, WindowsBasedEmailClient.IntegratedEmailService.Email email, string userId, string pwd) {
            return base.Channel.SendEmail(provider, email, userId, pwd);
        }
    }
}