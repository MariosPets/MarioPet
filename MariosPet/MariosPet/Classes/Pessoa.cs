﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Pessoa
    {
        private int id_pessoa { get; set; }
        private string nome { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }
        private DateTime nascimento { get; set; }
        private int id_endereco { get; set; }
    }
}
