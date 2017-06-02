using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;

namespace WinkelServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WinkelService" in both code and config file together.
    public class WinkelService : IWinkelService
    {
        public bool BuyProduct(Klant klant, Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetInventory()
        {
            throw new NotImplementedException();
        }

        public Klant Login(string username, string password)
        {
            using ( WinkelModelContainer ctx = new WinkelModelContainer())
            {
                var klant = from k in ctx.Klanten
                            where k.Username == username && k.Password == password
                            select k;

                return klant.Single();
                //Does NOT return an object. Gives HTTP error?
            }
        }

        public bool RegistreerKlant(string username)
        {
            bool result = false;

            if (username.Contains(" "))
            {
                return result;
            }
            else
            {
                using (WinkelModelContainer ctx = new WinkelModelContainer())
                {
                    var checkForKlant = from klant in ctx.Klanten
                                        where klant.Username == username
                                        select klant;

                    if (checkForKlant.Count() != 0)
                    {
                        return result;
                    }
                    else
                    {
                        Klant klant = new Klant { Username = username, Password = new string(username.Reverse().ToArray()), Saldo = 30.00 };
                        ctx.Klanten.Add(klant);
                        ctx.SaveChanges();
                        result = true;
                    }

                }
            }
            return result;
        }
    }
}
