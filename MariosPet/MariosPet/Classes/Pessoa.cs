using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Pessoa
    {
        #region Atributos

        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime nascimento { get; set; }
        public int idEndereco { get; set; }

        #endregion
    }
}
