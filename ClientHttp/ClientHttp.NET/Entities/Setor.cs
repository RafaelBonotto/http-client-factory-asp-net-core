using System;

namespace ClientHttp.NET.Entities
{
    public class Setor
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public sbyte Ativo { get; set; }
        public DateTime Data_criacao { get; set; }
        public DateTime Data_alteracao { get; set; }
    }
}
