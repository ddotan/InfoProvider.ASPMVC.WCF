﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfoProvider.Webs.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Agent", Namespace="http://schemas.datacontract.org/2004/07/RMS.InfoProvider.Center.Objects")]
    [System.SerializableAttribute()]
    public partial class Agent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CertificatePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.RMSBridge> RMSBridgesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InfoProvider.Webs.ServiceReference1.RMSServer RMSServerField;
        
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
        public string CertificatePath {
            get {
                return this.CertificatePathField;
            }
            set {
                if ((object.ReferenceEquals(this.CertificatePathField, value) != true)) {
                    this.CertificatePathField = value;
                    this.RaisePropertyChanged("CertificatePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.RMSBridge> RMSBridges {
            get {
                return this.RMSBridgesField;
            }
            set {
                if ((object.ReferenceEquals(this.RMSBridgesField, value) != true)) {
                    this.RMSBridgesField = value;
                    this.RaisePropertyChanged("RMSBridges");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InfoProvider.Webs.ServiceReference1.RMSServer RMSServer {
            get {
                return this.RMSServerField;
            }
            set {
                if ((object.ReferenceEquals(this.RMSServerField, value) != true)) {
                    this.RMSServerField = value;
                    this.RaisePropertyChanged("RMSServer");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RMSServer", Namespace="http://schemas.datacontract.org/2004/07/RMS.InfoProvider.ObjectModel.RMS" +
        "Objects")]
    [System.SerializableAttribute()]
    public partial class RMSServer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InfoProvider.Webs.ServiceReference1.eCentral CentralField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CentralPortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CertificateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerPortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.User> UsersField;
        
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
        public InfoProvider.Webs.ServiceReference1.eCentral Central {
            get {
                return this.CentralField;
            }
            set {
                if ((this.CentralField.Equals(value) != true)) {
                    this.CentralField = value;
                    this.RaisePropertyChanged("Central");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CentralPort {
            get {
                return this.CentralPortField;
            }
            set {
                if ((object.ReferenceEquals(this.CentralPortField, value) != true)) {
                    this.CentralPortField = value;
                    this.RaisePropertyChanged("CentralPort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Certificate {
            get {
                return this.CertificateField;
            }
            set {
                if ((object.ReferenceEquals(this.CertificateField, value) != true)) {
                    this.CertificateField = value;
                    this.RaisePropertyChanged("Certificate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceName {
            get {
                return this.InstanceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceNameField, value) != true)) {
                    this.InstanceNameField = value;
                    this.RaisePropertyChanged("InstanceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerName {
            get {
                return this.ServerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerNameField, value) != true)) {
                    this.ServerNameField = value;
                    this.RaisePropertyChanged("ServerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerPort {
            get {
                return this.ServerPortField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerPortField, value) != true)) {
                    this.ServerPortField = value;
                    this.RaisePropertyChanged("ServerPort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.User> Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RMSBridge", Namespace="http://schemas.datacontract.org/2004/07/RMS.InfoProvider.ObjectModel.RMS" +
        "Objects")]
    [System.SerializableAttribute()]
    public partial class RMSBridge : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InfoProvider.Webs.ServiceReference1.eCentral CentralField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CertificateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DealerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlatformAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlatformPortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecuritiesField;
        
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
        public InfoProvider.Webs.ServiceReference1.eCentral Central {
            get {
                return this.CentralField;
            }
            set {
                if ((this.CentralField.Equals(value) != true)) {
                    this.CentralField = value;
                    this.RaisePropertyChanged("Central");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Certificate {
            get {
                return this.CertificateField;
            }
            set {
                if ((object.ReferenceEquals(this.CertificateField, value) != true)) {
                    this.CertificateField = value;
                    this.RaisePropertyChanged("Certificate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DealerId {
            get {
                return this.DealerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DealerIdField, value) != true)) {
                    this.DealerIdField = value;
                    this.RaisePropertyChanged("DealerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Groups {
            get {
                return this.GroupsField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupsField, value) != true)) {
                    this.GroupsField = value;
                    this.RaisePropertyChanged("Groups");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceName {
            get {
                return this.InstanceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceNameField, value) != true)) {
                    this.InstanceNameField = value;
                    this.RaisePropertyChanged("InstanceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlatformAddress {
            get {
                return this.PlatformAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.PlatformAddressField, value) != true)) {
                    this.PlatformAddressField = value;
                    this.RaisePropertyChanged("PlatformAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlatformPort {
            get {
                return this.PlatformPortField;
            }
            set {
                if ((object.ReferenceEquals(this.PlatformPortField, value) != true)) {
                    this.PlatformPortField = value;
                    this.RaisePropertyChanged("PlatformPort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Securities {
            get {
                return this.SecuritiesField;
            }
            set {
                if ((object.ReferenceEquals(this.SecuritiesField, value) != true)) {
                    this.SecuritiesField = value;
                    this.RaisePropertyChanged("Securities");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eCentral", Namespace="http://schemas.datacontract.org/2004/07/RMS.InfoProvider.ObjectModel")]
    public enum eCentral : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ES1 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ES2 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ES3 = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/RMS.InfoProvider.ObjectModel.RMS" +
        "Objects")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IInfoProviderCenter")]
    public interface IInfoProviderCenter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/GetAgents", ReplyAction="http://tempuri.org/IInfoProviderCenter/GetAgentsResponse")]
        System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.Agent> GetAgents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/GetAgents", ReplyAction="http://tempuri.org/IInfoProviderCenter/GetAgentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.Agent>> GetAgentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/GetUpdateTime", ReplyAction="http://tempuri.org/IInfoProviderCenter/GetUpdateTimeResponse")]
        System.DateTime GetUpdateTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/GetUpdateTime", ReplyAction="http://tempuri.org/IInfoProviderCenter/GetUpdateTimeResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetUpdateTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/SetUpdateTimeInterval", ReplyAction="http://tempuri.org/IInfoProviderCenter/SetUpdateTimeIntervalResponse")]
        void SetUpdateTimeInterval(int i_Minutes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/SetUpdateTimeInterval", ReplyAction="http://tempuri.org/IInfoProviderCenter/SetUpdateTimeIntervalResponse")]
        System.Threading.Tasks.Task SetUpdateTimeIntervalAsync(int i_Minutes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/UpdateRepository", ReplyAction="http://tempuri.org/IInfoProviderCenter/UpdateRepositoryResponse")]
        void UpdateRepository();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/UpdateRepository", ReplyAction="http://tempuri.org/IInfoProviderCenter/UpdateRepositoryResponse")]
        System.Threading.Tasks.Task UpdateRepositoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/GetCertificatePath", ReplyAction="http://tempuri.org/IInfoProviderCenter/GetCertificatePathResponse")]
        string GetCertificatePath(string i_CertificateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfoProviderCenter/GetCertificatePath", ReplyAction="http://tempuri.org/IInfoProviderCenter/GetCertificatePathResponse")]
        System.Threading.Tasks.Task<string> GetCertificatePathAsync(string i_CertificateName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInfoProviderCenterChannel : InfoProvider.Webs.ServiceReference1.IInfoProviderCenter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InfoProviderCenterClient : System.ServiceModel.ClientBase<InfoProvider.Webs.ServiceReference1.IInfoProviderCenter>, InfoProvider.Webs.ServiceReference1.IInfoProviderCenter {
        
        public InfoProviderCenterClient() {
        }
        
        public InfoProviderCenterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfoProviderCenterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoProviderCenterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoProviderCenterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.Agent> GetAgents() {
            return base.Channel.GetAgents();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<InfoProvider.Webs.ServiceReference1.Agent>> GetAgentsAsync() {
            return base.Channel.GetAgentsAsync();
        }
        
        public System.DateTime GetUpdateTime() {
            return base.Channel.GetUpdateTime();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetUpdateTimeAsync() {
            return base.Channel.GetUpdateTimeAsync();
        }
        
        public void SetUpdateTimeInterval(int i_Minutes) {
            base.Channel.SetUpdateTimeInterval(i_Minutes);
        }
        
        public System.Threading.Tasks.Task SetUpdateTimeIntervalAsync(int i_Minutes) {
            return base.Channel.SetUpdateTimeIntervalAsync(i_Minutes);
        }
        
        public void UpdateRepository() {
            base.Channel.UpdateRepository();
        }
        
        public System.Threading.Tasks.Task UpdateRepositoryAsync() {
            return base.Channel.UpdateRepositoryAsync();
        }
        
        public string GetCertificatePath(string i_CertificateName) {
            return base.Channel.GetCertificatePath(i_CertificateName);
        }
        
        public System.Threading.Tasks.Task<string> GetCertificatePathAsync(string i_CertificateName) {
            return base.Channel.GetCertificatePathAsync(i_CertificateName);
        }
    }
}