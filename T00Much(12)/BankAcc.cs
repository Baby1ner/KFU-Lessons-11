using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_12_
{
    public class BankAcc
    {
        public int Acc { get; set; }
        public int Id { get; set; }
        public BankAcc(int acc, int id)
        {
            Acc = acc;
            Id = id;
        }

        public static bool operator ==(BankAcc a, BankAcc b)
        {
            return a.Acc == b.Acc && a.Id == b.Id;
        }
        public static bool operator !=(BankAcc a, BankAcc b)
        {
            return !(a.Acc == b.Acc && a.Id == b.Id);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public override string ToString()
        {
            string res = $"{Acc} {Id}";
            return res;
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAcc acc)
                return Acc == acc.Acc && Id == acc.Id;
            return false;
        }
    }
}
