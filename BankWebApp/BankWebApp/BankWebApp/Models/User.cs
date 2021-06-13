using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankWebApp.Models
{
    public class User
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
        
    }
}
