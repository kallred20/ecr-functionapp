using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class CreateRegisterEvent
    {
        private readonly ILogger<CreateRegisterEvent> _logger;

        public CreateRegisterEvent(ILogger<CreateRegisterEvent> logger)
        {
            _logger = logger;
        }

        [Function("CreateRegisterEvent")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
