namespace ClientHttp.NET.Configurations
{
    public static class ApiConfig
    {
        public static string UrlBase  { get; set;}

        public static Urls _Urls = new();

        public class Urls
        {
            public Setor Setor { get; set; } = new();
        }

        public class Setor
        {
            public string Get { get; set; }
            public string GetById { get; set; }
            public string Post { get; set; }
        }
    }
}
