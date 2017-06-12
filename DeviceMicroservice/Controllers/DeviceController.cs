using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DeviceMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class DeviceController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Device controller";
        }
    }
}