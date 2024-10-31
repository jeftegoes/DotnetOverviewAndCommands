using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GatewayApi.Controllers
{
    [ApiController]
    [Route("api/proxy/[controller]")]
    public class ProxyBaseController : ControllerBase
    {
        private readonly ILogger<ProxyBaseController> _logger;
        private readonly HttpClient _httpClient;
        private readonly IGatewayService _gatewayService;
        readonly string _url;

        public ProxyBaseController(
            ILogger<ProxyBaseController> logger, 
            IHttpClientFactory httpClientFactory,
            IGatewayService gatewayService)
        {
            _logger = logger;
            _gatewayService = gatewayService;
            _httpClient = httpClientFactory.CreateClient();
            _url = _gatewayService.GetUrl();
        }

        protected async Task<T> ProxyGetTo<T>(string action)
        {
            var jsonString  = (await (await _httpClient.GetAsync(_url + action)).Content.ReadAsStringAsync());

            var content = JsonConvert.DeserializeObject<T>(jsonString);

            return content;
        }

        protected async Task<string> ProxyPostTo<T>(string action, T t)
        {
            if (t == null)
                return null;

            var httpContent = (await _httpClient.PostAsJsonAsync<T>(_url + action, t)).Content;

            return await httpContent.ReadAsStringAsync();
        }

        protected async Task<string> ProxyPutTo<T>(string action, T t)
        {
            if (t == null)
                return null;
                
            var httpContent = (await _httpClient.PutAsJsonAsync<T>(_url + action, t)).Content;

            return await httpContent.ReadAsStringAsync();
        }
    }
}