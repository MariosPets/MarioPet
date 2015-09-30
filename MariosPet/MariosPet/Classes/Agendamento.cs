using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Agendamento
    {
        private int id { get; set; }
        private int idAnimal { get; set; }
        private int idFuncionario { get; set; }
        private DateTime hora { get; set; }        
        private bool atendido { get; set; }
    }
}
