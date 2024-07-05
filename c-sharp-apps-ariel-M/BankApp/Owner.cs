using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.BankApp
{
    public class Owner
    {
        private string FirstName;
        private string LastName;
        public Owner(string firstname,string lastname) 
        { 
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        public string GetFirstName() { return FirstName; }
        public string GetLastName() { return LastName; }
    }
}
