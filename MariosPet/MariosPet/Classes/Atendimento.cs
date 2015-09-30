using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Atendimento
    {
        private int id { get; set; }
        private int idAnimal { get; set; }
        private int idFuncionario { get; set; }
        private DateTime horaEntrada { get; set; }
        private DateTime horaSaida { get; set; }
    }
}
