using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Servico
    {
        private int id { get; set; }
        private int idAnimal { get; set; }
        private int idFuncionario { get; set; }
        private string tipo { get; set; }
        private DateTime hora_entrada { get; set; }
        private DateTime hora_saida { get; set; }
    }
}
