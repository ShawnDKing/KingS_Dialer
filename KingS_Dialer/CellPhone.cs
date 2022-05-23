using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingS_Dialer
{
    public class CellPhone : Phone

    {
        public CellPhone(string Company, string PhoneNumber, string PhoneType) :base(Company, PhoneNumber, PhoneType)
        {

        }
        public override string Dial()
        {
            {
               //what is being pushed up to the phone - going back and fixing the holes/redundancies
                    return _company + " is dialing using 1+ " + _phoneNumber;
            } 
            
        }

        
    }
}
