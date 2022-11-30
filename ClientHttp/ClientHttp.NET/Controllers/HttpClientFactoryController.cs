using ClientHttp.NET.Configurations;
using ClientHttp.NET.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static ClientHttp.NET.Configurations.ApiConfig;

namespace ClientHttp.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpClientFactoryController : ControllerBase
    {
        private IHttpClientFactory _httpClientFactory;

        public HttpClientFactoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // Get <Setor>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var url = $"{ApiConfig.UrlBase}{ApiConfig._Urls.Setor.Get}";

            HttpClient client = _httpClientFactory.CreateClient();

            var ret = await client.GetAsync(url);

            if (ret.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException("Código de Status Http 200 esperado!");

            var result = await ret.Content.ReadFromJsonAsync<ResponseBase<List<Setor>>>();

            return Ok(result);
        }
    }
}
