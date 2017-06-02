using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WinkelServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWinkelService" in both code and config file together.
    [ServiceContract]
    public interface IWinkelService
    {
        [OperationContract]
        bool RegistreerKlant(string username);
        [OperationContract]
        bool Login(string username, string password);
        [OperationContract]
        double GetKlantSaldo(string username, string password);
        [OperationContract]
        List<Product> GetInventory(string username, string password);
        [OperationContract]
        bool BuyProduct(string username, string password, Product product);
    }
}
