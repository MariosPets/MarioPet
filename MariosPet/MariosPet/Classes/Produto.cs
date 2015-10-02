using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Produto
    {
        private int id { get; set; }
        private string descricao { get; set; }
        private string setor { get; set; }
        private int idFornecedor { get; set; }
        private string fabricante { get; set; }
        private DateTime vencimento { get; set; }
        private int quantidade { get; set; }
        private string unidade { get; set; }
        private double valorCusto { get; set; }
        private double valorVenda { get; set; }
        private double lucro { get; set; }
        private string tributacao { get; set; }
        private int minimoEmEstoque { get; set; }
        private int maximoEmEstoque { get; set; }
        private string codigoBarras { get; set; }
    }
}
