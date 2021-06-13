using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BankWebApp.Models;
namespace BankWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserDeleteController : ControllerBase
    {
        [HttpDelete]
        public int DeleteUserRecord(User user)
        {
            UInt64 AccNo = user.AccNo;
            Console.WriteLine("Deleting in process..");
            return UserRegistration.getInstance().Remove(AccNo);
        }
    }
}