﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36315
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.DesktopUI.HotelServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/Hotel.Entity")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nppField;
        
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
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int npp {
            get {
                return this.nppField;
            }
            set {
                if ((this.nppField.Equals(value) != true)) {
                    this.nppField = value;
                    this.RaisePropertyChanged("npp");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NewRoom", Namespace="http://schemas.datacontract.org/2004/07/Hotel.Entity")]
    [System.SerializableAttribute()]
    public partial class NewRoom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DescriptionRommIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReserveField;
        
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
        public string DateFrom {
            get {
                return this.DateFromField;
            }
            set {
                if ((object.ReferenceEquals(this.DateFromField, value) != true)) {
                    this.DateFromField = value;
                    this.RaisePropertyChanged("DateFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateTo {
            get {
                return this.DateToField;
            }
            set {
                if ((object.ReferenceEquals(this.DateToField, value) != true)) {
                    this.DateToField = value;
                    this.RaisePropertyChanged("DateTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DescriptionRommId {
            get {
                return this.DescriptionRommIdField;
            }
            set {
                if ((this.DescriptionRommIdField.Equals(value) != true)) {
                    this.DescriptionRommIdField = value;
                    this.RaisePropertyChanged("DescriptionRommId");
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
        public string Fio {
            get {
                return this.FioField;
            }
            set {
                if ((object.ReferenceEquals(this.FioField, value) != true)) {
                    this.FioField = value;
                    this.RaisePropertyChanged("Fio");
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
        public string NumberPhone {
            get {
                return this.NumberPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberPhoneField, value) != true)) {
                    this.NumberPhoneField = value;
                    this.RaisePropertyChanged("NumberPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Reserve {
            get {
                return this.ReserveField;
            }
            set {
                if ((this.ReserveField.Equals(value) != true)) {
                    this.ReserveField = value;
                    this.RaisePropertyChanged("Reserve");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Hotel.Service")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelServiceReference.IHotelService")]
    public interface IHotelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/SelectAll", ReplyAction="http://tempuri.org/IHotelService/SelectAllResponse")]
        Hotel.DesktopUI.HotelServiceReference.Room[] SelectAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/SelectAll", ReplyAction="http://tempuri.org/IHotelService/SelectAllResponse")]
        System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.Room[]> SelectAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetId", ReplyAction="http://tempuri.org/IHotelService/GetIdResponse")]
        int GetId(int numRecord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetId", ReplyAction="http://tempuri.org/IHotelService/GetIdResponse")]
        System.Threading.Tasks.Task<int> GetIdAsync(int numRecord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetRowById", ReplyAction="http://tempuri.org/IHotelService/GetRowByIdResponse")]
        Hotel.DesktopUI.HotelServiceReference.Room GetRowById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetRowById", ReplyAction="http://tempuri.org/IHotelService/GetRowByIdResponse")]
        System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.Room> GetRowByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetData", ReplyAction="http://tempuri.org/IHotelService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetData", ReplyAction="http://tempuri.org/IHotelService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/AddRecord", ReplyAction="http://tempuri.org/IHotelService/AddRecordResponse")]
        Hotel.DesktopUI.HotelServiceReference.NewRoom AddRecord(Hotel.DesktopUI.HotelServiceReference.NewRoom newRoom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/AddRecord", ReplyAction="http://tempuri.org/IHotelService/AddRecordResponse")]
        System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.NewRoom> AddRecordAsync(Hotel.DesktopUI.HotelServiceReference.NewRoom newRoom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IHotelService/GetDataUsingDataContractResponse")]
        Hotel.DesktopUI.HotelServiceReference.CompositeType GetDataUsingDataContract(Hotel.DesktopUI.HotelServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IHotelService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.CompositeType> GetDataUsingDataContractAsync(Hotel.DesktopUI.HotelServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelServiceChannel : Hotel.DesktopUI.HotelServiceReference.IHotelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelServiceClient : System.ServiceModel.ClientBase<Hotel.DesktopUI.HotelServiceReference.IHotelService>, Hotel.DesktopUI.HotelServiceReference.IHotelService {
        
        public HotelServiceClient() {
        }
        
        public HotelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Hotel.DesktopUI.HotelServiceReference.Room[] SelectAll() {
            return base.Channel.SelectAll();
        }
        
        public System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.Room[]> SelectAllAsync() {
            return base.Channel.SelectAllAsync();
        }
        
        public int GetId(int numRecord) {
            return base.Channel.GetId(numRecord);
        }
        
        public System.Threading.Tasks.Task<int> GetIdAsync(int numRecord) {
            return base.Channel.GetIdAsync(numRecord);
        }
        
        public Hotel.DesktopUI.HotelServiceReference.Room GetRowById(int id) {
            return base.Channel.GetRowById(id);
        }
        
        public System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.Room> GetRowByIdAsync(int id) {
            return base.Channel.GetRowByIdAsync(id);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Hotel.DesktopUI.HotelServiceReference.NewRoom AddRecord(Hotel.DesktopUI.HotelServiceReference.NewRoom newRoom) {
            return base.Channel.AddRecord(newRoom);
        }
        
        public System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.NewRoom> AddRecordAsync(Hotel.DesktopUI.HotelServiceReference.NewRoom newRoom) {
            return base.Channel.AddRecordAsync(newRoom);
        }
        
        public Hotel.DesktopUI.HotelServiceReference.CompositeType GetDataUsingDataContract(Hotel.DesktopUI.HotelServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Hotel.DesktopUI.HotelServiceReference.CompositeType> GetDataUsingDataContractAsync(Hotel.DesktopUI.HotelServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
