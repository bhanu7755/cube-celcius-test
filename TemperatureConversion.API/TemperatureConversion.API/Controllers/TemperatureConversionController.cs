using Microsoft.AspNetCore.Mvc;
using TemperatureConversion.API.Model;
using TemperatureConversion.API.Services;

namespace TemperatureConversion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureConversionController : ControllerBase
    {
        private ITemperatureConvertor _temperatureConvertor;

        public TemperatureConversionController(ITemperatureConvertor temperatureConvertor )
        {
            _temperatureConvertor = temperatureConvertor;
        }

        [HttpGet("Convert")]
        public ActionResult<Response> Convert([FromQuery] Request request)
        {
            return _temperatureConvertor.GetTemperature(request.From.ToLower(), request.To.ToLower(), request.Value);
        }
    }
}
