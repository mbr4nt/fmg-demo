using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demoapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinkedInController : ControllerBase
    {
        private readonly string accessToken = "";
        private readonly ILogger<LinkedInController> _logger;

        public LinkedInController(ILogger<LinkedInController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public LinkedInProfile Get()
        {
            //TODO: use access token to get real data
            return new LinkedInProfile {
                Name = "Fake",
                PageUrl = "https://wrongurl.com"
            };
        }

        public class LinkedInProfile {
            public string Name { get; set; }
            public string PageUrl { get; set; }
        }
    }
}
