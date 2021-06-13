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
    public class UserDepositController : ControllerBase
    {
        [HttpPut]
        public int UserDeposit(UserDepositReply DepUser)
        {

            Console.WriteLine("Deposit   in Process..");
            DepUser.Bal += DepUser.DepAmt;
            string updateQuery = "UPDATE BankAcc SET Balance="+DepUser.Bal+" WHERE AccNo="+DepUser.AccNo+";";
            
            String cs = "Data Source=/Users/abii/Projects/Bank/Bank/bankDatabase.db; Version=3;";

            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();
            SQLiteCommand command = new SQLiteCommand(con);
            
            command.CommandText = updateQuery;

            command.ExecuteNonQuery();
            con.Close();
            return 1;



        }
    }
}