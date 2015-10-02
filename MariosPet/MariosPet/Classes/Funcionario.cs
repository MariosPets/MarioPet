using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Funcionario: Pessoa
    {
        public string tipo { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
    }
}
