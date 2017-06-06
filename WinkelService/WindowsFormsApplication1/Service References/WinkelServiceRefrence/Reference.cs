﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.WinkelServiceRefrence {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WinkelServiceRefrence.IWinkelService")]
    public interface IWinkelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/RegistreerKlant", ReplyAction="http://tempuri.org/IWinkelService/RegistreerKlantResponse")]
        bool RegistreerKlant(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/RegistreerKlant", ReplyAction="http://tempuri.org/IWinkelService/RegistreerKlantResponse")]
        System.Threading.Tasks.Task<bool> RegistreerKlantAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/Login", ReplyAction="http://tempuri.org/IWinkelService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/Login", ReplyAction="http://tempuri.org/IWinkelService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/GetKlantSaldo", ReplyAction="http://tempuri.org/IWinkelService/GetKlantSaldoResponse")]
        double GetKlantSaldo(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/GetKlantSaldo", ReplyAction="http://tempuri.org/IWinkelService/GetKlantSaldoResponse")]
        System.Threading.Tasks.Task<double> GetKlantSaldoAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/GetInventory", ReplyAction="http://tempuri.org/IWinkelService/GetInventoryResponse")]
        WinkelServiceLibrary.Product[] GetInventory(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/GetInventory", ReplyAction="http://tempuri.org/IWinkelService/GetInventoryResponse")]
        System.Threading.Tasks.Task<WinkelServiceLibrary.Product[]> GetInventoryAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/BuyProduct", ReplyAction="http://tempuri.org/IWinkelService/BuyProductResponse")]
        bool BuyProduct(string username, string password, WinkelServiceLibrary.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinkelService/BuyProduct", ReplyAction="http://tempuri.org/IWinkelService/BuyProductResponse")]
        System.Threading.Tasks.Task<bool> BuyProductAsync(string username, string password, WinkelServiceLibrary.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWinkelServiceChannel : WindowsFormsApplication1.WinkelServiceRefrence.IWinkelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WinkelServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.WinkelServiceRefrence.IWinkelService>, WindowsFormsApplication1.WinkelServiceRefrence.IWinkelService {
        
        public WinkelServiceClient() {
        }
        
        public WinkelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WinkelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WinkelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WinkelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegistreerKlant(string username) {
            return base.Channel.RegistreerKlant(username);
        }
        
        public System.Threading.Tasks.Task<bool> RegistreerKlantAsync(string username) {
            return base.Channel.RegistreerKlantAsync(username);
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public double GetKlantSaldo(string username, string password) {
            return base.Channel.GetKlantSaldo(username, password);
        }
        
        public System.Threading.Tasks.Task<double> GetKlantSaldoAsync(string username, string password) {
            return base.Channel.GetKlantSaldoAsync(username, password);
        }
        
        public WinkelServiceLibrary.Product[] GetInventory(string username, string password) {
            return base.Channel.GetInventory(username, password);
        }
        
        public System.Threading.Tasks.Task<WinkelServiceLibrary.Product[]> GetInventoryAsync(string username, string password) {
            return base.Channel.GetInventoryAsync(username, password);
        }
        
        public bool BuyProduct(string username, string password, WinkelServiceLibrary.Product product) {
            return base.Channel.BuyProduct(username, password, product);
        }
        
        public System.Threading.Tasks.Task<bool> BuyProductAsync(string username, string password, WinkelServiceLibrary.Product product) {
            return base.Channel.BuyProductAsync(username, password, product);
        }
    }
}