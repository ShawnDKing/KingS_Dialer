using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingS_Dialer
{
    public abstract class Phone
    {

        protected string _phoneNumber;
        protected string _company;
        protected string _phoneType;

        public Phone(string Company, string PhoneNumber, string PhoneType)
        {
            _company = Company;
            _phoneNumber = PhoneNumber;
            _phoneType = PhoneType;
        }
        //Home numbers have no such rule and should not have any additional prefix.
        
        public virtual string Dial()
        {
            if (_phoneType == "2")
            {
                return _company + " is dialing using 1 + " + _phoneNumber;
            }
            else if (_phoneType == "1")
            {
                return _company + "is dialing using " + _phoneNumber;
            } return Dial();
            // I need to go back through and figure where everything is passing to and coming from
        }

        
    }
}
