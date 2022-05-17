using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingS_Dialer
{
    abstract class Phone
    {

        private string _phoneNumber;
        private string _company;
        private string _phoneType;
        public Phone(string Company, string PhoneNumber, string PhoneType)
        {
            _company = Company;
            _phoneNumber = PhoneNumber;
            _phoneType = PhoneType;
        }
        //Home numbers have no such rule and should not have any additional prefix.
        public string Dial(string Company, string PhoneNumber, string PhoneType)
        {
            if (_phoneType == "1")
            {
                return Console.WriteLine(_company + " is being dialed using " + _phoneNumber);
            }
            else if (_phoneType == "2")
            {
                return Console.WriteLine(_company + " is being dialed using " + "1+" + _phoneNumber);
            }
        }

    }
}
