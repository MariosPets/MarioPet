using MariosPet.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Cliente: Pessoa
    {
        public void cadastrarCliente(Cliente cliente, Endereco endereco)
        {
            CrudEndereco crudEnd = new CrudEndereco();
            crudEnd.inserirEndereco(endereco);

            cliente.idEndereco = Convert.ToInt32(crudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

            CrudCliente crudCli = new CrudCliente();
            crudCli.inserirPessoa(cliente);
        }
    }
}
