using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Estudiantes;

namespace Presentacion_Capa
{
    public partial class txtnom1 : Form
    {
        Alumnos alumnosCS = new Alumnos();
        
        private string idProducto = null;
        private bool vEditar = false;



        public txtnom1()
        {
            InitializeComponent();
        }

        private void Datos_Alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProducto();

        }
        private void MostrarProducto()
        {
            Alumnos alumnosCS_NOreutilizable = new Alumnos();
            Datos_Alumnos.DataSource = alumnosCS_NOreutilizable.MostrarTrans();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            if(vEditar == false){

            

                try
                {
                    
                    alumnosCS.InsertarSP(txtnom.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txttelf.Text, txtcel.Text, txtdir.Text, txtemail.Text, txtfecha.Text + "-" + txtfecha2.Text + "-" + txtfecha3.Text, txtobs.Text);
                    MessageBox.Show("Los datos fueron insertados correctamente");
                    MostrarProducto();
                    limpiar();
                }
                catch(Exception)
                {
                    MessageBox.Show("Ocurrio un error al insertar los datos");
                }
            }if(vEditar==true){
                try
                {

                    alumnosCS.EditarSP(idProducto,txtnom.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txttelf.Text, txtcel.Text, txtdir.Text, txtemail.Text, txtfecha.Text + "-" + txtfecha2.Text + "-" + txtfecha3.Text, txtobs.Text);
                    MessageBox.Show("Los datos se editaron correctamente");
                    MostrarProducto();
                    vEditar = false;
                    limpiar();
                    Insertar.Text = "Ingresar Nuevo Alumno";
                }
                catch(Exception ex){
                    MessageBox.Show("No se pudieron editar los datos" + ex);
                }
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {


                if (Datos_Alumnos.SelectedRows.Count > 0)
                {
                    vEditar = true;
                    idProducto = Datos_Alumnos.CurrentRow.Cells["ID_Alumno"].Value.ToString();
                    txtnom.Text = Datos_Alumnos.CurrentRow.Cells["Primer_Nombre"].Value.ToString();
                    txtnom2.Text = Datos_Alumnos.CurrentRow.Cells["Segundo_Nombre"].Value.ToString();
                    txtape1.Text = Datos_Alumnos.CurrentRow.Cells["Primer_Apellido"].Value.ToString();
                    txtape2.Text = Datos_Alumnos.CurrentRow.Cells["Segundo_Apellido"].Value.ToString();
                    txttelf.Text = Datos_Alumnos.CurrentRow.Cells["Telefono"].Value.ToString();
                    txtcel.Text = Datos_Alumnos.CurrentRow.Cells["celular"].Value.ToString();
                    txtdir.Text = Datos_Alumnos.CurrentRow.Cells["direccion"].Value.ToString();
                    txtemail.Text = Datos_Alumnos.CurrentRow.Cells["email"].Value.ToString();

                    //Coloco un substring para divid los datos en una cadena
                    string fecha = Datos_Alumnos.CurrentRow.Cells["fecha_de_nacimiento"].Value.ToString();
                    //Reparto todos los datos de la cadena en mis diferentes cuadros de texto
                    txtfecha.Text = fecha.Substring(0, 2);
                    txtfecha2.Text = fecha.Substring(3, 2);
                    txtfecha3.Text = fecha.Substring(6, 4);

                    txtobs.Text = Datos_Alumnos.CurrentRow.Cells["observaciones"].Value.ToString();
                    Insertar.Text = "Editar los Datos";

                }
                else
                     MessageBox.Show("Seleccione una Fila en caso de que quiera editarlo");
                        


            }
            catch
            {
                 
                MessageBox.Show("Error al seleccionar datos");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Datos_Alumnos.SelectedRows.Count > 0)
            {
                idProducto = Datos_Alumnos.CurrentRow.Cells["ID_Alumno"].Value.ToString();
                alumnosCS.EliminarSP(idProducto);
                MessageBox.Show("Datos Eliminados correctamente");
                MostrarProducto();
            }
            else
                MessageBox.Show("Escoge una fila para eliminar");
        }
        private void limpiar()
        {
            txtnom.Clear();
            txtnom2.Clear();
            txtape1.Clear();
            txtape2.Clear();
            txttelf.Clear();
            txtcel.Clear();
            txtdir.Clear();
            txtemail.Clear();
            txtfecha.Clear();
            txtfecha2.Clear();
            txtfecha3.Clear();
            txtobs.Clear();
        }
    }
}
