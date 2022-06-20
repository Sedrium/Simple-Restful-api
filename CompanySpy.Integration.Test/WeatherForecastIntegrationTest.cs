using System.Net;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CompanySpy.Integration.Test.Utilities
{
    public class WeatherForecastControllerTests : FixtureTestBase
    {
        [Fact]
        public async Task GET_retrieves_weather_forecast()
        {
            var response = await _client.GetAsync("/weatherForecast", null);
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
