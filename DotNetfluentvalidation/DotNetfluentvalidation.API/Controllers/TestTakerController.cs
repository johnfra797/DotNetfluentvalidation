using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetfluentvalidation.Application.Services;
using DotNetfluentvalidation.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetfluentvalidation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestTakerController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly ILogger<TestTakerController> _logger;

        public TestTakerController(ILogger<TestTakerController> logger, ITestService testService)
        {
            _logger = logger;
            _testService = testService;
        }

        [HttpPost(Name = "Create")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TestTaker> Create([FromBody] TestTaker testTaker) => _testService.SaveTestTaker(testTaker);

        [HttpPut(Name = "Update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TestTaker> Update([FromBody] TestTaker testTaker) => _testService.SaveTestTaker(testTaker);
    }
}
