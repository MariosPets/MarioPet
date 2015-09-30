using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Animal
    {
        private int id { get; set; }
        private string nome { get; set; }
        private int idCliente { get; set; }
        private string racaPorte { get; set; }

        /// <summary>
        /// Sexo do animal:
        /// true - feminino
        /// false - masculino
        /// </summary>
        private bool sexo { get; set; }
        private string pelagemCor { get; set; }
        private DateTime nascimento { get; set; }
        private int idVeterinario { get; set; }
    }
}
