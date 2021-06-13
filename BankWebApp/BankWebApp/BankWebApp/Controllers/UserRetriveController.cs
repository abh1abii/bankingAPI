using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;

using Microsoft.AspNetCore.Mvc;
using BankWebApp.Models;

namespace BankWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserRetriveController : ControllerBase
    {   
          public List<User> GetAllUsers()
        {
            

            return UserRegistration.getInstance().getAllUsers();

        }
        [HttpGet]
        [Route("Search")]
        public User GetSearch([FromQuery] UInt64 AccNo)
        {
            return UserRegistration.getInstance().GetAccNo(AccNo);
        }

    }
}