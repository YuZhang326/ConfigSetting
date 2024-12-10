using ConfigSetting.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigSetting.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private IConfiguration _configuration;
    private readonly IOptions<CustomerConfig> _customerConfig;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        IConfiguration configuration,
        IOptions<CustomerConfig> customerConfig)
    {
        _logger = logger;
        _configuration = configuration;
        _customerConfig = customerConfig;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        // Step by step find the custom Settings in the appsettings.json file
        // The first method
        var emailKey1 = _configuration.GetSection("CustomerConfig")
            .GetSection("EmailKey").Value;

        // The second method
        var emailKey2 = _configuration.GetValue<string>("CustomerConfig:EmailKey");

        // The third way
        var emailKey3 = _customerConfig.Value.EmailKey;

        return Ok($"email key: {emailKey3}");
    }
}
