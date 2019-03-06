namespace CustomersAPIServices.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Catcher Wong", "James Li" };
        }

        [Authorize]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Catcher Wong - {id}";
        }

        [Authorize]
        [HttpGet("GetString/{mystring}")]
        public string GetString(string mystring)
        {
            return $"This is my string - {mystring}";
        }

        [Authorize]
        [HttpGet("MyString/{mystring1}/{mystring2}")]
        public string MyString(string mystring1,string mystring2)
        {
            return $"This is my string - {mystring1} {mystring2}";
        }
    }
}
