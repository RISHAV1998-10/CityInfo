using CityInfo.API.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private readonly CityInfoContext cityInfoContext;

        public DummyController(CityInfoContext cityInfoContext)
        {
            this.cityInfoContext = cityInfoContext ?? throw new ArgumentNullException(nameof(cityInfoContext));
        }

        [HttpGet]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
