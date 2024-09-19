using System;

namespace EMoney
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer William = new Customer("William", 1000);
            Customer Surya = new Customer("Surya", 1000);

            Admin admin = new Admin("Admin", 100000);

            string role = "";
            string namaCustomer = "";
            double jumlahSaldo = 0;

            try
            {
                Console.Write("Masukkan Role Anda (Admin/Customer) : ");
                role = Console.ReadLine();
                if (role == "Admin")
                {
                    Console.Write("Pilih Customer (William/Surya) : ");
                    namaCustomer = Console.ReadLine();

                    if (namaCustomer == "William")
                    {
                        Console.Write("Masukkan jumlah saldo yang ingin ditambahkan : ");
                        jumlahSaldo = double.Parse(Console.ReadLine());
                        admin.addMoney(William, jumlahSaldo);
                    }
                    else if (namaCustomer == "Surya")
                    {
                        Console.Write("Masukkan jumlah saldo yang ingin ditambahkan : ");
                        jumlahSaldo = double.Parse(Console.ReadLine());
                        admin.addMoney(Surya, jumlahSaldo);
                    }
                    else
                    {
                        Console.WriteLine("Customer tidak terdaftar");
                    }
                }
                else if (role == "Customer")
                {
                    Console.Write("Masukkan Nama (William/Surya) : ");
                    namaCustomer = Console.ReadLine();

                    if (namaCustomer == "William")
                    {
                        William.checkMoney();
                    }
                    else if (namaCustomer == "Surya")
                    {
                        Surya.checkMoney();
                    }
                    else
                    {
                        Console.WriteLine("Customer tidak ditemukan.");
                    }
                }
                else
                {
                    Console.WriteLine("Role tidak valid.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}