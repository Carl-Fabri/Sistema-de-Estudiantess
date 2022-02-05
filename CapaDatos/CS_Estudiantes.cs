using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CS_Estudiantes
    {
        private CConexion cnx = new CConexion();
        
            SqlDataReader leer;

            DataTable alojamiento_tablas = new DataTable();
            SqlCommand ejecucion_comando = new SqlCommand();

        //Procesos para Mostrar Datos en el formulario Ingreso Alumno

        //Transact Mostrar
        public DataTable Mostrar()
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "Select * from Informacion";
            leer = ejecucion_comando.ExecuteReader();
            alojamiento_tablas.Load(leer);
            cnx.ConexionCerrada();

            return alojamiento_tablas;
        }

        //Procedimiento Almacenado Insertar
        public void Insertar(string Nom1, string Nom2, string Ape1, string Ape2, string telf, int cel, string dir, string email, DateTime fecha, int obser)
        {
            //Encender la Conexion
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            //Ejecutar el comando
            ejecucion_comando.CommandText = "SP_Insertar_Alumno";
            //Especificar que es un procedimiento almacenado
            ejecucion_comando.CommandType = CommandType.StoredProcedure;
            //Remplazar los objetos del procedimiento almacenado por objetos propios
            ejecucion_comando.Parameters.AddWithValue("@Primer_Nombre", Nom1);
            ejecucion_comando.Parameters.AddWithValue("@Segundo_Nombre", Nom2);
            ejecucion_comando.Parameters.AddWithValue("@Primer_Apellido", Ape1);
            ejecucion_comando.Parameters.AddWithValue("@Segundo_Apellido", Ape2);
            ejecucion_comando.Parameters.AddWithValue("@Telefono", telf);
            ejecucion_comando.Parameters.AddWithValue("@celular", cel);
            ejecucion_comando.Parameters.AddWithValue("@direccion", dir);
            ejecucion_comando.Parameters.AddWithValue("@email", email);
            ejecucion_comando.Parameters.AddWithValue("@fecha_de_nacimiento", fecha);
            ejecucion_comando.Parameters.AddWithValue("@observaciones", obser);
          
            //
            ejecucion_comando.ExecuteNonQuery();
            //Limipiamos los parametros para poder utilizarlos otra vez
            ejecucion_comando.Parameters.Clear();
            cnx.ConexionCerrada();
        }

        //Procedimiento Almacenado Edicion
        public void Editar(int id,string Nom1, string Nom2, string Ape1, string Ape2, int telf, int cel, string dir, string email, DateTime fecha, int obser)
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "SP_Editar_Alumno";
            ejecucion_comando.CommandType = CommandType.StoredProcedure;
            ejecucion_comando.Parameters.AddWithValue("@ID", id);
            ejecucion_comando.Parameters.AddWithValue("@Primer_Nombre", Nom1);
            ejecucion_comando.Parameters.AddWithValue("@Segundo_Nombre", Nom2);
            ejecucion_comando.Parameters.AddWithValue("@Primer_Apellido", Ape1);
            ejecucion_comando.Parameters.AddWithValue("@Segundo_Apellido", Ape2);
            ejecucion_comando.Parameters.AddWithValue("@Telefono", telf);
            ejecucion_comando.Parameters.AddWithValue("@celular", cel);
            ejecucion_comando.Parameters.AddWithValue("@direccion", dir);
            ejecucion_comando.Parameters.AddWithValue("@email", email);
            ejecucion_comando.Parameters.AddWithValue("@fecha_de_nacimiento", fecha);
            ejecucion_comando.Parameters.AddWithValue("@observaciones", obser);

            ejecucion_comando.ExecuteNonQuery();
            cnx.ConexionCerrada();
            ejecucion_comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "SP_Eliminar_Alumno";
            ejecucion_comando.CommandType = CommandType.StoredProcedure;
            ejecucion_comando.Parameters.AddWithValue("@ID", id);

            ejecucion_comando.ExecuteNonQuery();
            cnx.ConexionCerrada();
            ejecucion_comando.Parameters.Clear();

        }
  
        /// /////////////////////////////////////////////////////////////
        
        DataTable EstudiantesNotas = new DataTable();
        DataTable EstudiantesInfooo = new DataTable();
        DataTable NotasEstudiante = new DataTable();
        //Procesos para la ejecucion de el formulario Ingreso Notas

        public DataTable MostrarNotas()
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "Select * from Notas";
            leer = ejecucion_comando.ExecuteReader();
            NotasEstudiante.Load(leer);
            cnx.ConexionCerrada();

            return NotasEstudiante;
        }

        public DataTable Ingresar()
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "SELECT ID_ALUMNO,Primer_Nombre,Primer_Apellido FROM INFORMACION";
            leer = ejecucion_comando.ExecuteReader();
            
            EstudiantesNotas.Load(leer);

            cnx.ConexionCerrada();

            ejecucion_comando.Parameters.Clear();
            return EstudiantesNotas;
        }
        public DataTable IngresarNombre(int id)
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "SP_CargandoDatos";
            ejecucion_comando.CommandType = CommandType.StoredProcedure;           
            ejecucion_comando.Parameters.AddWithValue("@ID", id);

            leer = ejecucion_comando.ExecuteReader();
            EstudiantesInfooo.Load(leer);

            ejecucion_comando.ExecuteNonQuery();
            cnx.ConexionCerrada();
            ejecucion_comando.Parameters.Clear();
            return EstudiantesInfooo;
        }

        //Procedimiento Almacenado Insertar
        public void InsertarNota(int id, float nota, string curso)
        {
            ejecucion_comando.Connection = cnx.ConexionEncendida();
            ejecucion_comando.CommandText = "SP_ColocarNotasLOL";
            ejecucion_comando.CommandType = CommandType.StoredProcedure;
            ejecucion_comando.Parameters.AddWithValue("@ID", id);
            ejecucion_comando.Parameters.AddWithValue("@Nota_Final", nota);
            ejecucion_comando.Parameters.AddWithValue("@Curso", curso);
            ejecucion_comando.ExecuteNonQuery();
            cnx.ConexionCerrada();
            ejecucion_comando.Parameters.Clear();
        }







    }
}
