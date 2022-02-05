using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CapaDatos
{
    public class CConexion
    {
        private SqlConnection cnx = new SqlConnection("Server=FABRII-PC;Database= Sistema_De_Control; Integrated Security=true");

        public SqlConnection ConexionEncendida()
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            return cnx;
        }

        public SqlConnection ConexionCerrada()
        {
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
            return cnx;
        }
    }
}
