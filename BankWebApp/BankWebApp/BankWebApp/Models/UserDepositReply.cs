using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;


namespace BankWebApp.Models
{
    

    public class UserDepositReply:User
    {
        
        float depAmt;
        public float DepAmt
        {
            get { return depAmt; }
            set
            {
                depAmt = value;
            }
        }

        
        
    }
}
