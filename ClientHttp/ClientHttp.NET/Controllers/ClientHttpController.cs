using ClientHttp.NET.Response.Setor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
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

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var url = "https://localhost:44358/api/Setor";

            var ret = await _httpClient.GetAsync(url);

            if (ret.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException("Código de Status Http 200 esperado!");

            var result = await ret.Content.ReadFromJsonAsync<ListaSetorResponse>();

            return Ok(result);
        }
    }
}
