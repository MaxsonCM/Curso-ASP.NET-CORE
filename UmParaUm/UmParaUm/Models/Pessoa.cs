﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmParaUm.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        public string Nome { get; set; }

        public int? Idade { get; set; }

        public int? EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}