﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ProxyHttpBooking {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/Data.Domains")]
    [System.SerializableAttribute()]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustumerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReturnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartField;
        
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
        public int CarId {
            get {
                return this.CarIdField;
            }
            set {
                if ((this.CarIdField.Equals(value) != true)) {
                    this.CarIdField = value;
                    this.RaisePropertyChanged("CarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustumerId {
            get {
                return this.CustumerIdField;
            }
            set {
                if ((this.CustumerIdField.Equals(value) != true)) {
                    this.CustumerIdField = value;
                    this.RaisePropertyChanged("CustumerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime End {
            get {
                return this.EndField;
            }
            set {
                if ((this.EndField.Equals(value) != true)) {
                    this.EndField = value;
                    this.RaisePropertyChanged("End");
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
        public bool Returned {
            get {
                return this.ReturnedField;
            }
            set {
                if ((this.ReturnedField.Equals(value) != true)) {
                    this.ReturnedField = value;
                    this.RaisePropertyChanged("Returned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Start {
            get {
                return this.StartField;
            }
            set {
                if ((this.StartField.Equals(value) != true)) {
                    this.StartField = value;
                    this.RaisePropertyChanged("Start");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/Data.Domains")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YearModelField;
        
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
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
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
        public string RegNr {
            get {
                return this.RegNrField;
            }
            set {
                if ((object.ReferenceEquals(this.RegNrField, value) != true)) {
                    this.RegNrField = value;
                    this.RaisePropertyChanged("RegNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string YearModel {
            get {
                return this.YearModelField;
            }
            set {
                if ((object.ReferenceEquals(this.YearModelField, value) != true)) {
                    this.YearModelField = value;
                    this.RaisePropertyChanged("YearModel");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyHttpBooking.IServiceBooking")]
    public interface IServiceBooking {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/Create", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/CreateResponse")]
        void Create(Client.ProxyHttpBooking.Booking entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/Create", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(Client.ProxyHttpBooking.Booking entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/ReadAll", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/ReadAllResponse")]
        Client.ProxyHttpBooking.Booking[] ReadAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/ReadAll", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/ReadAllResponse")]
        System.Threading.Tasks.Task<Client.ProxyHttpBooking.Booking[]> ReadAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/ReadById", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/ReadByIdResponse")]
        Client.ProxyHttpBooking.Booking ReadById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/ReadById", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/ReadByIdResponse")]
        System.Threading.Tasks.Task<Client.ProxyHttpBooking.Booking> ReadByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/Update", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/UpdateResponse")]
        void Update(Client.ProxyHttpBooking.Booking entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/Update", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Client.ProxyHttpBooking.Booking entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/Delete", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/DeleteResponse")]
        void Delete(Client.ProxyHttpBooking.Booking entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceGenericOf_Booking/Delete", ReplyAction="http://tempuri.org/IServiceGenericOf_Booking/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(Client.ProxyHttpBooking.Booking entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooking/GetAllBookingTimeSpan", ReplyAction="http://tempuri.org/IServiceBooking/GetAllBookingTimeSpanResponse")]
        Client.ProxyHttpBooking.Booking[] GetAllBookingTimeSpan(System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooking/GetAllBookingTimeSpan", ReplyAction="http://tempuri.org/IServiceBooking/GetAllBookingTimeSpanResponse")]
        System.Threading.Tasks.Task<Client.ProxyHttpBooking.Booking[]> GetAllBookingTimeSpanAsync(System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooking/ReturnCar", ReplyAction="http://tempuri.org/IServiceBooking/ReturnCarResponse")]
        void ReturnCar(Client.ProxyHttpBooking.Booking booking);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooking/ReturnCar", ReplyAction="http://tempuri.org/IServiceBooking/ReturnCarResponse")]
        System.Threading.Tasks.Task ReturnCarAsync(Client.ProxyHttpBooking.Booking booking);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooking/GetAvailableCars", ReplyAction="http://tempuri.org/IServiceBooking/GetAvailableCarsResponse")]
        Client.ProxyHttpBooking.Car[] GetAvailableCars(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooking/GetAvailableCars", ReplyAction="http://tempuri.org/IServiceBooking/GetAvailableCarsResponse")]
        System.Threading.Tasks.Task<Client.ProxyHttpBooking.Car[]> GetAvailableCarsAsync(System.DateTime start, System.DateTime end);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBookingChannel : Client.ProxyHttpBooking.IServiceBooking, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBookingClient : System.ServiceModel.ClientBase<Client.ProxyHttpBooking.IServiceBooking>, Client.ProxyHttpBooking.IServiceBooking {
        
        public ServiceBookingClient() {
        }
        
        public ServiceBookingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBookingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBookingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBookingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(Client.ProxyHttpBooking.Booking entity) {
            base.Channel.Create(entity);
        }
        
        public System.Threading.Tasks.Task CreateAsync(Client.ProxyHttpBooking.Booking entity) {
            return base.Channel.CreateAsync(entity);
        }
        
        public Client.ProxyHttpBooking.Booking[] ReadAll() {
            return base.Channel.ReadAll();
        }
        
        public System.Threading.Tasks.Task<Client.ProxyHttpBooking.Booking[]> ReadAllAsync() {
            return base.Channel.ReadAllAsync();
        }
        
        public Client.ProxyHttpBooking.Booking ReadById(int id) {
            return base.Channel.ReadById(id);
        }
        
        public System.Threading.Tasks.Task<Client.ProxyHttpBooking.Booking> ReadByIdAsync(int id) {
            return base.Channel.ReadByIdAsync(id);
        }
        
        public void Update(Client.ProxyHttpBooking.Booking entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Client.ProxyHttpBooking.Booking entity) {
            return base.Channel.UpdateAsync(entity);
        }
        
        public void Delete(Client.ProxyHttpBooking.Booking entity) {
            base.Channel.Delete(entity);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(Client.ProxyHttpBooking.Booking entity) {
            return base.Channel.DeleteAsync(entity);
        }
        
        public Client.ProxyHttpBooking.Booking[] GetAllBookingTimeSpan(System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetAllBookingTimeSpan(startDate, endDate);
        }
        
        public System.Threading.Tasks.Task<Client.ProxyHttpBooking.Booking[]> GetAllBookingTimeSpanAsync(System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetAllBookingTimeSpanAsync(startDate, endDate);
        }
        
        public void ReturnCar(Client.ProxyHttpBooking.Booking booking) {
            base.Channel.ReturnCar(booking);
        }
        
        public System.Threading.Tasks.Task ReturnCarAsync(Client.ProxyHttpBooking.Booking booking) {
            return base.Channel.ReturnCarAsync(booking);
        }
        
        public Client.ProxyHttpBooking.Car[] GetAvailableCars(System.DateTime start, System.DateTime end) {
            return base.Channel.GetAvailableCars(start, end);
        }
        
        public System.Threading.Tasks.Task<Client.ProxyHttpBooking.Car[]> GetAvailableCarsAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.GetAvailableCarsAsync(start, end);
        }
    }
}