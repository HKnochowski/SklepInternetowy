﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStoreForms.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/GameStoreWcfServiceLibrary")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/GameStore.Models")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GameDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GameIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GameNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime GamePremiereField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GameRatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GameTypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameFileBestsellerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameFileNewsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameFileRecomendedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OrRecommendedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OrToBuyField;
        
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
        public string GameDescription {
            get {
                return this.GameDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.GameDescriptionField, value) != true)) {
                    this.GameDescriptionField = value;
                    this.RaisePropertyChanged("GameDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GameId {
            get {
                return this.GameIdField;
            }
            set {
                if ((this.GameIdField.Equals(value) != true)) {
                    this.GameIdField = value;
                    this.RaisePropertyChanged("GameId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GameName {
            get {
                return this.GameNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GameNameField, value) != true)) {
                    this.GameNameField = value;
                    this.RaisePropertyChanged("GameName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime GamePremiere {
            get {
                return this.GamePremiereField;
            }
            set {
                if ((this.GamePremiereField.Equals(value) != true)) {
                    this.GamePremiereField = value;
                    this.RaisePropertyChanged("GamePremiere");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GameRating {
            get {
                return this.GameRatingField;
            }
            set {
                if ((this.GameRatingField.Equals(value) != true)) {
                    this.GameRatingField = value;
                    this.RaisePropertyChanged("GameRating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GameTypeId {
            get {
                return this.GameTypeIdField;
            }
            set {
                if ((this.GameTypeIdField.Equals(value) != true)) {
                    this.GameTypeIdField = value;
                    this.RaisePropertyChanged("GameTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameFileBestseller {
            get {
                return this.NameFileBestsellerField;
            }
            set {
                if ((object.ReferenceEquals(this.NameFileBestsellerField, value) != true)) {
                    this.NameFileBestsellerField = value;
                    this.RaisePropertyChanged("NameFileBestseller");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameFileNews {
            get {
                return this.NameFileNewsField;
            }
            set {
                if ((object.ReferenceEquals(this.NameFileNewsField, value) != true)) {
                    this.NameFileNewsField = value;
                    this.RaisePropertyChanged("NameFileNews");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameFileRecomended {
            get {
                return this.NameFileRecomendedField;
            }
            set {
                if ((object.ReferenceEquals(this.NameFileRecomendedField, value) != true)) {
                    this.NameFileRecomendedField = value;
                    this.RaisePropertyChanged("NameFileRecomended");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OrRecommended {
            get {
                return this.OrRecommendedField;
            }
            set {
                if ((this.OrRecommendedField.Equals(value) != true)) {
                    this.OrRecommendedField = value;
                    this.RaisePropertyChanged("OrRecommended");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OrToBuy {
            get {
                return this.OrToBuyField;
            }
            set {
                if ((this.OrToBuyField.Equals(value) != true)) {
                    this.OrToBuyField = value;
                    this.RaisePropertyChanged("OrToBuy");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        GameStoreForms.ServiceReference1.CompositeType GetDataUsingDataContract(GameStoreForms.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<GameStoreForms.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(GameStoreForms.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertGame", ReplyAction="http://tempuri.org/IService1/InsertGameResponse")]
        int InsertGame(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertGame", ReplyAction="http://tempuri.org/IService1/InsertGameResponse")]
        System.Threading.Tasks.Task<int> InsertGameAsync(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateGame", ReplyAction="http://tempuri.org/IService1/UpdateGameResponse")]
        int UpdateGame(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateGame", ReplyAction="http://tempuri.org/IService1/UpdateGameResponse")]
        System.Threading.Tasks.Task<int> UpdateGameAsync(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteGame", ReplyAction="http://tempuri.org/IService1/DeleteGameResponse")]
        int DeleteGame(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteGame", ReplyAction="http://tempuri.org/IService1/DeleteGameResponse")]
        System.Threading.Tasks.Task<int> DeleteGameAsync(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGame", ReplyAction="http://tempuri.org/IService1/GetGameResponse")]
        GameStoreForms.ServiceReference1.Game GetGame(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGame", ReplyAction="http://tempuri.org/IService1/GetGameResponse")]
        System.Threading.Tasks.Task<GameStoreForms.ServiceReference1.Game> GetGameAsync(GameStoreForms.ServiceReference1.Game G);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllGame", ReplyAction="http://tempuri.org/IService1/GetAllGameResponse")]
        GameStoreForms.ServiceReference1.Game[] GetAllGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllGame", ReplyAction="http://tempuri.org/IService1/GetAllGameResponse")]
        System.Threading.Tasks.Task<GameStoreForms.ServiceReference1.Game[]> GetAllGameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GameStoreForms.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GameStoreForms.ServiceReference1.IService1>, GameStoreForms.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public GameStoreForms.ServiceReference1.CompositeType GetDataUsingDataContract(GameStoreForms.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<GameStoreForms.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(GameStoreForms.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertGame(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.InsertGame(G);
        }
        
        public System.Threading.Tasks.Task<int> InsertGameAsync(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.InsertGameAsync(G);
        }
        
        public int UpdateGame(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.UpdateGame(G);
        }
        
        public System.Threading.Tasks.Task<int> UpdateGameAsync(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.UpdateGameAsync(G);
        }
        
        public int DeleteGame(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.DeleteGame(G);
        }
        
        public System.Threading.Tasks.Task<int> DeleteGameAsync(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.DeleteGameAsync(G);
        }
        
        public GameStoreForms.ServiceReference1.Game GetGame(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.GetGame(G);
        }
        
        public System.Threading.Tasks.Task<GameStoreForms.ServiceReference1.Game> GetGameAsync(GameStoreForms.ServiceReference1.Game G) {
            return base.Channel.GetGameAsync(G);
        }
        
        public GameStoreForms.ServiceReference1.Game[] GetAllGame() {
            return base.Channel.GetAllGame();
        }
        
        public System.Threading.Tasks.Task<GameStoreForms.ServiceReference1.Game[]> GetAllGameAsync() {
            return base.Channel.GetAllGameAsync();
        }
    }
}
