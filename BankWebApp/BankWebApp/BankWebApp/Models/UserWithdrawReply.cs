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


    public class UserWithdrawReply : User
    {

        float withdrawAmt;
        public float WithdrawAmt
        {
            get { return withdrawAmt; }
            set
            {
                withdrawAmt = value;
            }
        }

        

    }
}
