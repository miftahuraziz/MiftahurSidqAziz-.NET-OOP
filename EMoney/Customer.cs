using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMoney
{
    internal class Customer :User
    {
        public Customer(string nama, double saldo) : base(nama, "Customer", saldo) { }

        public void checkMoney()
        {
            Console.WriteLine($"Saldo {Nama}: {Saldo}");
        }
    }
}
