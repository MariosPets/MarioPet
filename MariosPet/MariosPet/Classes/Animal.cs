using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Animal
    {
        private int id_animal { get; set; }
        private string nome_animal { get; set; }
        private int id_cliente { get; set; }
        private string raca_porte { get; set; }
        private string sexo { get; set; }
        private string pelagem_cor { get; set; }
        private DateTime nascimento { get; set; }
        private int id_veterinario { get; set; }
    }
}
