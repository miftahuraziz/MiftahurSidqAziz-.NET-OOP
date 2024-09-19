using System;

namespace EMoney
{
    public class User
    {
        public string nama;
        public string role;
        public double saldo;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    throw new ArgumentException("Saldo tidak boleh negatif");
                }
            }

        }

        public User(string nama, string role, double saldo)
        {
            Nama = nama;
            Role = role;
            Saldo = saldo;
        }

    }

    public class Customer : User
    {
        public Customer(string nama, double saldo) : base(nama, "Customer", saldo) { }

        public void checkMoney()
        {
            Console.WriteLine($"Saldo {Nama}: {Saldo}");
        }
    }

    public class Admin : User
    {
        public Admin(string nama, double saldo) : base(nama, "Admin", saldo) { }

        // Method untuk menambah saldo ke customer
        public void addMoney(Customer customer, double jumlah)
        {
            if (jumlah > 0)
            {
                customer.Saldo += jumlah;
                Console.WriteLine($"Saldo {customer.Nama} berhasil ditambah {jumlah}, saldo sekarang: {customer.Saldo}");
            }
            else
            {
                Console.WriteLine("Jumlah saldo yang ditambahkan harus lebih dari 0.");
            }
        }

    }
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
                Console.WriteLine("Masukkan Role Anda (Admin/Customer) : ");
                role = Console.ReadLine();
                if (role == "Admin")
                {
                    Console.WriteLine("Pilih Customer (William/Surya) : ");
                    namaCustomer = Console.ReadLine();
                       
                    if (namaCustomer == "William")
                    {
                        Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan : ");
                        jumlahSaldo = double.Parse(Console.ReadLine());
                        admin.addMoney(William, jumlahSaldo);
                    }
                    else if (namaCustomer == "Surya")
                    {
                        Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan : ");
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
                    Console.WriteLine("Masukkan Nama (William/Surya) : ");
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