using System;

namespace Encapsulation
{
    //class lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        //private field untuk menyimpan nilai radius
        private double radius;

        //public property untuk mengakses dan mengatur radius
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari 0");
                }
            }

            //method hitung luas lingkaran
        }
        public double Luas()
        {
            return 3.14 * radius;
        }

        //class tabung menggunakan lingkaran sebagai komponen
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            //konstruktor 
            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius; //menggunakan property lingkaran
                this.tinggi = tinggi;
            }

            public double hitungVolume()
            {
                return lingkaran.Luas() * tinggi;
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(-2, 3);
                    Console.WriteLine("Volume tabung : " + tabung.hitungVolume());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}