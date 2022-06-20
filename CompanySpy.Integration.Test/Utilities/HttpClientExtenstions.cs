using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CompanySpy.Integration.Test.Utilities
{
    public static class HttpClientExtenstions
    {
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, string url, object request)
        {
            return client.GetAsync(url);
        }
    }
}
