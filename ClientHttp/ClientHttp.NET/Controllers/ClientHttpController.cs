using ClientHttp.NET.Configurations;
using ClientHttp.NET.Entities;
using ClientHttp.NET.Request.Setor;
using ClientHttp.NET.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClientHttp.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientHttpController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ClientHttpController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Get <Setor>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var url = $"{ApiConfig.UrlBase}{ApiConfig._Urls.Setor.Get}";

            var ret = await _httpClient.GetAsync(url);

            if (ret.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException("Código de Status Http 200 esperado!");

            var result = await ret.Content.ReadFromJsonAsync<ResponseBase<List<Setor>>>();

            return Ok(result);
        }

        // Post <Setor>
        [HttpPost]
        public async Task<IActionResult> PostAsync(SetorRequest request)
        {
            try
            {
                var url = $"{ApiConfig.UrlBase}{ApiConfig._Urls.Setor.Post}";

                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var ret = await _httpClient.PostAsync(url, content);

                if (ret.StatusCode != HttpStatusCode.OK)
                    throw new InvalidOperationException("Código de Status Http 200 esperado!");

                var result = await ret.Content.ReadFromJsonAsync<ResponseBase<Setor>>();

                return Ok(result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
         
    }
}
