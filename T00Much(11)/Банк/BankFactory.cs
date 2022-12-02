using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static T00Much_11_.Bank;
using T00Much_11_;
using System.Collections;

namespace T00Much_11_
{
    public class BankFactory
    {
        static public Hashtable ht = new Hashtable(1000) ;


        public void CreateAccount(int Balans, tip Type)
        {
            Bank product = new Bank(Balans, Type);
            product.PrintID();
            ht.Add(product.Id, product);
        }
        public void CreateAccount(int Balans)
        {
            Bank product = new Bank(Balans);
            product.PrintID();
            ht.Add(product.Id, product);
        }
        public void CreateAccount(tip Type)
        {
            Bank product = new Bank(Type);
            product.PrintID();
            ht.Add(product.Id, product);
        }

        public void ClouseAccount(int Id)
        {
            ht.Remove(Id);  
        }

        public void PrintTable()
        {
            Console.WriteLine("В таблице хранятся следующие банковские счета:");
            for (int i = 0;i< 1000;i++)
            {
                if (ht.ContainsKey(i))
                {
                    Bank bank = ht[i] as Bank;
                    Console.WriteLine($"Номер = {bank.Id}, Тип: {bank.Type}, Баланс: {bank.Balans}");
                }
            }
        }
    }
}


