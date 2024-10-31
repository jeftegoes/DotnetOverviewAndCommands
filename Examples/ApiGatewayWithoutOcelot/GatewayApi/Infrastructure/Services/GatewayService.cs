using Core.Interfaces;

namespace Infrastructure.Services
{
    public class GatewayService : IGatewayService
    {
        private readonly string _url;

        public GatewayService(string url)
        {
            _url = url;
        }

        public string GetUrl()
        {
            return _url;
        }
    }
}