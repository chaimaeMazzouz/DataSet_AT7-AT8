using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace learn_dataSet
{
    class Global
    {
        public SqlConnection
           voyage_connexion = new SqlConnection(@"data source = .\SQLEXPRESS;database=CompagnieVoyage;Integrated Security=True");
    }
}
