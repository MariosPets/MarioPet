using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Servico
    {
        private int id_servico { get; set; }
        private int id_animal { get; set; }
        private int id_funcionario { get; set; }
        private string tipo_servico { get; set; }
        private DateTime hora_entrada_servico { get; set; }
        private DateTime hora_saida_servico { get; set; }
    }
}
