using System;
using System.Runtime.InteropServices.Marshalling;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 _userbootcamp11 = new UserBootcamp11();
            _userbootcamp11.NamaUser = "Aziz";
            Console.WriteLine("Nama : " + _userbootcamp11);
        }
    }
    public class UserBootcamp11
    {
        string nama;
        string role;
        int emoney;

        public string NamaUser
        {
            get { return nama; }
            set { nama = value; }
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int eMoney
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }



}