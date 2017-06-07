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
        public bool BuyProduct(string username, string password, Product product)
        {
            bool result = false;
            double saldo = GetKlantSaldo(username, password);
            double prijs = product.Prijs;

            if (Login(username, password))
            {
                if (saldo >= prijs)
                {
                    using (WinkelModelContainer ctx = new WinkelModelContainer())
                    {
                        AankoopRegel aankoopRegel = new AankoopRegel { Hoeveelheid = 1, Product = product};
                        Aankoop aankoop = new Aankoop { Klant = GetKlant(username, password)};
                        aankoop.AankoopRegels.Add(aankoopRegel);

                        Klant klant = GetKlant(username, password);
                        klant.Saldo -= prijs;

                        product.Aantal--;
                        
                        ctx.Aankopen.Add(aankoop);
                        ctx.SaveChanges();

                        result = true;
                    }
                }
            }

            return result;
        }

        public List<Product> GetProducts(string username, string password)
        {
            using (WinkelModelContainer ctx = new WinkelModelContainer())
            {
                if (Login(username, password))
                {
                    var products = from p in ctx.Producten
                                   select p;
                    return products.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        public List<AankoopRegel> GetAankopen(string username, string password)
        {
            using (WinkelModelContainer ctx = new WinkelModelContainer())
            {
                if (Login(username, password))
                {
                    var getAankopen = from aankoop in ctx.AankoopRegels
                                      where aankoop.Aankoop.Klant == GetKlant(username, password)
                                      select aankoop;
                    return getAankopen.ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        public Klant GetKlant(string username, string password)
        {
            Klant gevondenKlant = null;
            if (Login(username, password))
            {
                using (WinkelModelContainer ctx = new WinkelModelContainer())
                {
                    var getKlant = from klant in ctx.Klanten
                                   where klant.Username.Equals(username) && klant.Password.Equals(password)
                                   select klant;
                    gevondenKlant = getKlant.Single();
                }
            }
            return gevondenKlant;
        }

        public bool Login(string username, string password)
        {
            bool result = false;
            using (WinkelModelContainer ctx = new WinkelModelContainer())
            {
                var klant = from k in ctx.Klanten
                            where k.Username.Equals(username) && k.Password.Equals(password)
                            select k;

                if (klant.Count() != 1)
                {
                    return result;
                }
                else
                {
                    result = true;
                }

            }
            return result;
        }

        public double GetKlantSaldo(string username, string password)
        {
            double klantSaldo = 0.0;
            using (WinkelModelContainer ctx = new WinkelModelContainer())
            {
                if (Login(username, password))
                {
                    var saldo = from s in ctx.Klanten
                                where s.Username.Equals(username)
                                select s.Saldo;
                    klantSaldo = saldo.Single();
                }
            }
            return klantSaldo;
        }

        public string GetWachtwoord(string username)
        {
            string wachtwoord = null;

            using (WinkelModelContainer ctx = new WinkelModelContainer())
            {
                var getWachtwoord = from klant in ctx.Klanten
                                    where klant.Username.Equals(username)
                                    select klant.Password;

                if (getWachtwoord.Count() != 1)
                {
                    return wachtwoord;
                }
                else
                {
                    wachtwoord = getWachtwoord.Single();
                }
            }

            return wachtwoord;
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
                                        where klant.Username.Equals(username)
                                        select klant;

                    if (checkForKlant.Count() != 0)
                    {
                        return result;
                    }
                    else
                    {
                        Klant klant = new Klant { Username = username, Password = new string(username.Reverse().ToArray()), Saldo = 50.00 };
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
