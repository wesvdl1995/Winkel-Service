﻿using System;
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
            throw new NotImplementedException();
        }

        public List<Product> GetInventory(string username, string password)
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