using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dockerdemoex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
    {
        return new string[] { "Shivangi", "Singh" };
    }
}