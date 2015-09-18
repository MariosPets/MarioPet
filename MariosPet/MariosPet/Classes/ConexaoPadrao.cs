using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class ConexaoPadrao
    {
        public static OdbcConnection createConnection()
        {
            string driver = @"SQL Server";
            string server = @".\MSERVERSQL";
            string dataBase = @"SystemManagingHouseholdTasks";

            StringBuilder stringConnection = new StringBuilder();

            stringConnection.Append("driver=");
            stringConnection.Append(driver);
            stringConnection.Append(";server=");
            stringConnection.Append(server);
            stringConnection.Append(";database=");
            stringConnection.Append(dataBase);

            return new OdbcConnection(stringConnection.ToString());
        }
    }
}
