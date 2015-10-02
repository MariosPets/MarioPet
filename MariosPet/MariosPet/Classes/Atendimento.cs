using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Atendimento
    {
        #region Atributos

        public int id { get; set; }
        public int idAnimal { get; set; }
        public int idFuncionario { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSaida { get; set; }

        #endregion
    }
}
