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
        Boolean RegistreerKlant(string username);
        [OperationContract]
        Klant Login(string username, string password);
        [OperationContract]
        List<Product> GetInventory();
        [OperationContract]
        bool BuyProduct(Klant klant, Product product);
    }
}
