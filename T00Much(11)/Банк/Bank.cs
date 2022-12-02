using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_11_
{
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
