using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WDMMicroservice.Controllers
{
    [Route("api/WDM/[controller]")]
    public class WDMController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "WDM controller";
        }
    }
}