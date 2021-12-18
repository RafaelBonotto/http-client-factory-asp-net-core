using System.Collections.Generic;

namespace ClientHttp.NET.Response
{
    public class ResponseBase<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; } = new();
    }
}

