using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Servico
    {
        #region Atributos

        public int id { get; set; }
        public int idAnimal { get; set; }
        public int idFuncionario { get; set; }
        public string tipo { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_saida { get; set; }

        #endregion
    }
}
