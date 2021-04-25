using LogService.LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class myloggerController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public myloggerController(ILoggerManager logger)
        {
            _logger = logger;
        }



        // GET: api/<myloggerController>
        [HttpPost]
        public string POST([FromBody] object obj)
        {
            _logger.LogInfo("Fetching all responses coming from the backend");
            var contentType = this.Request.ContentType;
            _logger.LogInfo($"response {obj} " + "custom message");

            return "value2";
        }






        // GET api/<myloggerController>/5
        [HttpGet("{id}")]
        public string GET(string id)
        
        {
            var contentType = this.Request.ContentType;
            var accept = this.Request.Headers;
            var acceptx = this.Request.Method;
            _logger.LogInfo("Fetching all request coming from the apigee");
            _logger.LogInfo($"requests {id} " + "custom message");
            return "value";
        }

       

    }
}
