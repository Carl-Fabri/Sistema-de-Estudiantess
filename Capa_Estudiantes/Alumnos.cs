using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;


namespace Capa_Estudiantes
{
    public class Alumnos
    {
        private CS_Estudiantes alumnosCC = new CS_Estudiantes();

        public DataTable MostrarTrans()
        {
            DataTable alojamiento_tablas = new DataTable();
            alojamiento_tablas = alumnosCC.Mostrar();
            return alojamiento_tablas;
        }
        public void InsertarSP(string Nom1, string Nom2, string Ape1, string Ape2, string telf, string cel, string dir, string email, string fecha, string obser)
        {
            alumnosCC.Insertar(Nom1, Nom2, Ape1, Ape2, telf , Convert.ToInt32(cel), dir, email,Convert.ToDateTime(fecha),Convert.ToInt32(obser));
        }

        public void EditarSP(string id,string Nom1, string Nom2, string Ape1, string Ape2, string telf, string cel, string dir, string email, string fecha, string obser)
        {
            alumnosCC.Editar(Convert.ToInt32(id),Nom1, Nom2, Ape1, Ape2, Convert.ToInt32(telf), Convert.ToInt32(cel), dir, email, Convert.ToDateTime(fecha), Convert.ToInt32(obser));
        }
        public void EliminarSP(string id)
        {
            alumnosCC.Eliminar(Convert.ToInt32(id));
        }

        /// /////////////////////////////////////////////////////////////
        /// Insertar Nota

        public DataTable MostrarAlumnoNotas()
        {
            DataTable EstudiantesNotas = new DataTable();
            EstudiantesNotas = alumnosCC.Ingresar();
            return EstudiantesNotas;
        }
        public DataTable MostrarAlumnoDatoss(int id)
        {
            alumnosCC.IngresarNombre(Convert.ToInt32(id));

            DataTable EstudiantesInfooo = new DataTable();
            EstudiantesInfooo = alumnosCC.IngresarNombre(id);
            return EstudiantesInfooo;
        }
        public void AgregarNotaSP(string id, string nota, string curso)
        {
            alumnosCC.InsertarNota(Convert.ToInt32(id),Convert.ToSingle(nota),curso);
        }
        public DataTable MostrarNota()
        {        
            DataTable NotasEstudiante = new DataTable();
            NotasEstudiante = alumnosCC.MostrarNotas();
            return NotasEstudiante;
        }

    }
}
