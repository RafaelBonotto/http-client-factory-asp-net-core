using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientHttp.NET.Response.Setor
{
    public class SetorResponse
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public sbyte Ativo { get; set; }
        public DateTime Data_criacao { get; set; }
        public DateTime Data_alteracao { get; set; }
    }
}
