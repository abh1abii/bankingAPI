using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankWebApp.Models;
using System.Data.SQLite;

namespace BankWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserWithdrawController : ControllerBase
    {
        [HttpPut]
        public int UserWithdraw(UserWithdrawReply WithdrawUser)
        {

            Console.WriteLine("Withdraw   in Process..");
            
            if (WithdrawUser.WithdrawAmt <= WithdrawUser.Bal)
            {
                WithdrawUser.Bal = WithdrawUser.Bal - WithdrawUser.WithdrawAmt;

                String cs = "Data Source=/Users/abii/Projects/Bank/Bank/bankDatabase.db; Version=3;";

                SQLiteConnection con = new SQLiteConnection(cs);
                con.Open();
                string updateQuery = "UPDATE BankAcc SET Balance="+WithdrawUser.Bal+" WHERE AccNo="+WithdrawUser.AccNo+";";

                SQLiteCommand command = new SQLiteCommand(con);
                
                command.CommandText = updateQuery;

                command.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            else
                Console.WriteLine("\n\nInsufficient Balance");
            return 0;
        }
        



        
    }
}