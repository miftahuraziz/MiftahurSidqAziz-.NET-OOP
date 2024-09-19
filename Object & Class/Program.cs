using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    class User
    {
        //Atribute
        string nama = "Aziz";
        string role = "DA";
        int eMoney = 100000000;

        //Method
        public void UserDetail()
        {
            Console.WriteLine("Ini detail usernya");
        }

        //Object
        static void Main(string[] args)
        {
            //Class adalah blueprint dari object
            User userBootcamp = new User();
            userBootcamp.UserDetail();        
        }
    }
}
