using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Agendamento
    {
        private int id_atendimento { get; set; }
        private int id_animal { get; set; }
        private DateTime hora_agendamento { get; set; }
        private int id_funcionario { get; set; }
        private string atendido { get; set; }
    }
}
