using System;
namespace BankWebApp.Models
{
    public class UserRegistrationReply
    {
        
        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        UInt64 accNo;
        public UInt64 AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        float bal;
        public float Bal
        {
            get { return bal; }
            set { bal = value; }
        }
        String registrationStatus;
        public String RegistrationStatus
        {
            get { return registrationStatus; }
            set { registrationStatus = value; }
        }
        public String ReplyToString()
        {
            return Name+"-"+AccNo;
        }
    }
}
