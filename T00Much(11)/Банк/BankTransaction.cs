using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_11_
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
}
