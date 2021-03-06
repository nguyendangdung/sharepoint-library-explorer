﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main.Copy2010ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", ConfigurationName="Copy2010ServiceReference.CopySoap")]
    public interface CopySoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/CopyIntoItemsLocal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        uint CopyIntoItemsLocal(out Main.Copy2010ServiceReference.CopyResult[] Results, string SourceUrl, string[] DestinationUrls);
        
        // CODEGEN: Parameter 'Stream' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/CopyIntoItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Main.Copy2010ServiceReference.CopyIntoItemsResponse CopyIntoItems(Main.Copy2010ServiceReference.CopyIntoItemsRequest request);
        
        // CODEGEN: Parameter 'Stream' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Main.Copy2010ServiceReference.GetItemResponse GetItem(Main.Copy2010ServiceReference.GetItemRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class CopyResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private CopyErrorCode errorCodeField;
        
        private string errorMessageField;
        
        private string destinationUrlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CopyErrorCode ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("ErrorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
                this.RaisePropertyChanged("ErrorMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationUrl {
            get {
                return this.destinationUrlField;
            }
            set {
                this.destinationUrlField = value;
                this.RaisePropertyChanged("DestinationUrl");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public enum CopyErrorCode {
        
        /// <remarks/>
        Success,
        
        /// <remarks/>
        DestinationInvalid,
        
        /// <remarks/>
        DestinationMWS,
        
        /// <remarks/>
        SourceInvalid,
        
        /// <remarks/>
        DestinationCheckedOut,
        
        /// <remarks/>
        InvalidUrl,
        
        /// <remarks/>
        Unknown,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class FieldInformation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private FieldType typeField;
        
        private string displayNameField;
        
        private string internalNameField;
        
        private System.Guid idField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FieldType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
                this.RaisePropertyChanged("DisplayName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InternalName {
            get {
                return this.internalNameField;
            }
            set {
                this.internalNameField = value;
                this.RaisePropertyChanged("InternalName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Guid Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public enum FieldType {
        
        /// <remarks/>
        Invalid,
        
        /// <remarks/>
        Integer,
        
        /// <remarks/>
        Text,
        
        /// <remarks/>
        Note,
        
        /// <remarks/>
        DateTime,
        
        /// <remarks/>
        Counter,
        
        /// <remarks/>
        Choice,
        
        /// <remarks/>
        Lookup,
        
        /// <remarks/>
        Boolean,
        
        /// <remarks/>
        Number,
        
        /// <remarks/>
        Currency,
        
        /// <remarks/>
        URL,
        
        /// <remarks/>
        Computed,
        
        /// <remarks/>
        Threading,
        
        /// <remarks/>
        Guid,
        
        /// <remarks/>
        MultiChoice,
        
        /// <remarks/>
        GridChoice,
        
        /// <remarks/>
        Calculated,
        
        /// <remarks/>
        File,
        
        /// <remarks/>
        Attachments,
        
        /// <remarks/>
        User,
        
        /// <remarks/>
        Recurrence,
        
        /// <remarks/>
        CrossProjectLink,
        
        /// <remarks/>
        ModStat,
        
        /// <remarks/>
        AllDayEvent,
        
        /// <remarks/>
        Error,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CopyIntoItems", WrapperNamespace="http://schemas.microsoft.com/sharepoint/soap/", IsWrapped=true)]
    public partial class CopyIntoItemsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=0)]
        public string SourceUrl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=1)]
        public string[] DestinationUrls;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=2)]
        public Main.Copy2010ServiceReference.FieldInformation[] Fields;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Stream;
        
        public CopyIntoItemsRequest() {
        }
        
        public CopyIntoItemsRequest(string SourceUrl, string[] DestinationUrls, Main.Copy2010ServiceReference.FieldInformation[] Fields, byte[] Stream) {
            this.SourceUrl = SourceUrl;
            this.DestinationUrls = DestinationUrls;
            this.Fields = Fields;
            this.Stream = Stream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CopyIntoItemsResponse", WrapperNamespace="http://schemas.microsoft.com/sharepoint/soap/", IsWrapped=true)]
    public partial class CopyIntoItemsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=0)]
        public uint CopyIntoItemsResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=1)]
        public Main.Copy2010ServiceReference.CopyResult[] Results;
        
        public CopyIntoItemsResponse() {
        }
        
        public CopyIntoItemsResponse(uint CopyIntoItemsResult, Main.Copy2010ServiceReference.CopyResult[] Results) {
            this.CopyIntoItemsResult = CopyIntoItemsResult;
            this.Results = Results;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItem", WrapperNamespace="http://schemas.microsoft.com/sharepoint/soap/", IsWrapped=true)]
    public partial class GetItemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=0)]
        public string Url;
        
        public GetItemRequest() {
        }
        
        public GetItemRequest(string Url) {
            this.Url = Url;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemResponse", WrapperNamespace="http://schemas.microsoft.com/sharepoint/soap/", IsWrapped=true)]
    public partial class GetItemResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=0)]
        public uint GetItemResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=1)]
        public Main.Copy2010ServiceReference.FieldInformation[] Fields;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Stream;
        
        public GetItemResponse() {
        }
        
        public GetItemResponse(uint GetItemResult, Main.Copy2010ServiceReference.FieldInformation[] Fields, byte[] Stream) {
            this.GetItemResult = GetItemResult;
            this.Fields = Fields;
            this.Stream = Stream;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CopySoapChannel : Main.Copy2010ServiceReference.CopySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CopySoapClient : System.ServiceModel.ClientBase<Main.Copy2010ServiceReference.CopySoap>, Main.Copy2010ServiceReference.CopySoap {
        
        public CopySoapClient() {
        }
        
        public CopySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CopySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CopySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CopySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public uint CopyIntoItemsLocal(out Main.Copy2010ServiceReference.CopyResult[] Results, string SourceUrl, string[] DestinationUrls) {
            return base.Channel.CopyIntoItemsLocal(out Results, SourceUrl, DestinationUrls);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Main.Copy2010ServiceReference.CopyIntoItemsResponse Main.Copy2010ServiceReference.CopySoap.CopyIntoItems(Main.Copy2010ServiceReference.CopyIntoItemsRequest request) {
            return base.Channel.CopyIntoItems(request);
        }
        
        public uint CopyIntoItems(string SourceUrl, string[] DestinationUrls, Main.Copy2010ServiceReference.FieldInformation[] Fields, byte[] Stream, out Main.Copy2010ServiceReference.CopyResult[] Results) {
            Main.Copy2010ServiceReference.CopyIntoItemsRequest inValue = new Main.Copy2010ServiceReference.CopyIntoItemsRequest();
            inValue.SourceUrl = SourceUrl;
            inValue.DestinationUrls = DestinationUrls;
            inValue.Fields = Fields;
            inValue.Stream = Stream;
            Main.Copy2010ServiceReference.CopyIntoItemsResponse retVal = ((Main.Copy2010ServiceReference.CopySoap)(this)).CopyIntoItems(inValue);
            Results = retVal.Results;
            return retVal.CopyIntoItemsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Main.Copy2010ServiceReference.GetItemResponse Main.Copy2010ServiceReference.CopySoap.GetItem(Main.Copy2010ServiceReference.GetItemRequest request) {
            return base.Channel.GetItem(request);
        }
        
        public uint GetItem(string Url, out Main.Copy2010ServiceReference.FieldInformation[] Fields, out byte[] Stream) {
            Main.Copy2010ServiceReference.GetItemRequest inValue = new Main.Copy2010ServiceReference.GetItemRequest();
            inValue.Url = Url;
            Main.Copy2010ServiceReference.GetItemResponse retVal = ((Main.Copy2010ServiceReference.CopySoap)(this)).GetItem(inValue);
            Fields = retVal.Fields;
            Stream = retVal.Stream;
            return retVal.GetItemResult;
        }
    }
}
