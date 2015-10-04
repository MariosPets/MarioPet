using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class PessoaJuridica
    {
        #region Atributos

        public int id { get; set; }
        public string denominacaoSocial { get; set; }
        public string cnpj { get; set; }
        public int idEndereco { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public int telefone1 { get; set; }
        public int telefone2 { get; set; }

        #endregion
    }
}
