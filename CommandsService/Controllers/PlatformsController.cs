using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Getting Platforms from CommandsService");

            //var platformItems = _repository.GetAllPlatforms();

            return Ok(/*_mapper.Map<IEnumerable<PlatformreadDto>>(platformItems)*/"kkkkk");
        }
    }
}
