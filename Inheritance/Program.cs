using System;

namespace Inheritance
{
    //Parent class
    public class Lingkaran
    {
        double luas;

        //method menghitung luas
        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }
    }

    //child class
    public class Tabung : Lingkaran
    {
        double volume;

        public Tabung(int tinggi, double r)
        {
            //menggunakan metode luas lingkaran
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            //buat oject
            //tampilkan volume
            Tabung volumeTabung = new Tabung(10, 10);
            Console.WriteLine("Volume tabung: "+ volumeTabung.getVolume());
        }
    }
}
