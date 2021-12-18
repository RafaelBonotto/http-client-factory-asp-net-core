﻿using System.ComponentModel.DataAnnotations;

namespace ClientHttp.NET.Request.Setor
{
    public class SetorRequest
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Descricao { get; set; }
    }
}
