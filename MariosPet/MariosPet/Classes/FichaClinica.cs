using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class FichaClinica
    {
        private int id { get; set; }
        private int idAnimal { get; set; }
        private int idVeterinario { get; set; }
        private DateTime data { get; set; }
        private string historicoClinico { get; set; }
        private string sintomas { get; set; }
        private string sistemasAcometidos { get; set; }
        private string examesComplementares { get; set; }
        private string prescricao { get; set; }
    }
}
