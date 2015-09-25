using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Atendimento
    {
        private int id_atendimento { get; set; }
        private int id_animal { get; set; }
        private int id_funcionario { get; set; }
        private DateTime hora_entrada_atendimento { get; set; }
        private DateTime hora_saida_atendimento { get; set; }
    }
}
