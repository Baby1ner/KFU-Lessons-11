using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T00Much_11_;
using T00Much_11_Bank;
using T00Much_11_Home;
namespace T00Much_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1,2 ");
            BankFactory bankFactory = new BankFactory();
            bankFactory.CreateAccount(123, Bank.tip.saving);
            bankFactory.CreateAccount(123, Bank.tip.current);
            bankFactory.CreateAccount(3003, Bank.tip.current);
            bankFactory.PrintTable();
            bankFactory.ClouseAccount(1);
            bankFactory.PrintTable();
            Console.WriteLine();
            Console.WriteLine("Домашнее задание 1,2");
            Doma dom1 = Creator.Create();
            Doma dom2 = Creator.Create();
            Creator.Delete(dom1.Id);
            Console.WriteLine(dom2.Id);
        }
    } 
}
