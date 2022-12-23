using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_11_Bank
{
    internal class BankTransaction
    {
        readonly DateTime data = DateTime.Now;
        readonly decimal summa;
        public BankTransaction(decimal summa)
        {
            this.summa = summa;
        }
        public bool PrintInfo()
        {
            Console.WriteLine($" Дата:{data} Сумма:{summa}");
            return true;
        }

        public string Printt()
        {
            return $" Дата:{data} Сумма:{summa}";
        }

    }


    public class BankFactory
    {
        static public Hashtable ht = new Hashtable(1000);


        public void CreateAccount(int Balans, Bank.tip Type)
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
        public void CreateAccount(Bank.tip Type)
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
            for (int i = 0; i < 1000; i++)
            {
                if (ht.ContainsKey(i))
                {
                    Bank bank = ht[i] as Bank;
                    Console.WriteLine($"Номер = {bank.Id}, Тип: {bank.Type}, Баланс: {bank.Balans}");
                }
            }
        }
    }


    public class Bank
    {
        public enum tip
        {
            current,
            saving
        }
        internal int Id = 0;
        internal int Balans;
        internal tip Type = tip.current;
        private static int Idk;
        private Queue<BankTransaction> queue = new Queue<BankTransaction>();

        internal Bank(int Balans, tip Type)
        {

            Id = Idk;
            Idk++;
            this.Balans = Balans;
            this.Type = Type;
        }


        internal Bank(int Balans)
        {

            Id = Idk;
            Idk++;
            this.Balans = Balans;
        }

        internal Bank(tip Type)
        {

            Id = Idk;
            Idk++;
            this.Type = Type;
        }

        public void Takeoff()
        {
            Console.WriteLine("Введите сумму, которую хотите снять");
            int off = int.Parse(Console.ReadLine());
            BankTransaction bankTransaction = new BankTransaction(-off);

            if (Balans > off)
            {
                Balans -= off;
                queue.Enqueue(bankTransaction);
            }
            else
            {
                Console.WriteLine("Неправильно попробуй еще раз");
                Takeoff();
            }
        }
        public void Takeon()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int on = int.Parse(Console.ReadLine());
            BankTransaction bankTransaction = new BankTransaction(on);
            queue.Enqueue(bankTransaction);
            Balans += on;
        }
        public void transfer(Bank Bank, int sum)
        {
            if (Balans > sum)
            {
                BankTransaction bankTransaction = new BankTransaction(-sum);
                BankTransaction bankTransaction2 = new BankTransaction(sum);

                queue.Enqueue(bankTransaction);
                Balans -= sum;
                Bank.Balans += sum;
                Bank.queue.Enqueue(bankTransaction2);
            }
            else Console.WriteLine("Не хватает денег для перевода");
        }
        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
        public void PrintMoneySell()
        {
            foreach (BankTransaction item in queue)
                item.PrintInfo();

        }
        public void PrintID()
        {
            Console.WriteLine($"Создан новый счет в банке, его номер:{Id}");

        }
    }







}
