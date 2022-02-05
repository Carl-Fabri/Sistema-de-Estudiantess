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

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Presentacion_Capa
{
    public partial class Form1 : Form
    {
        Alumnos alumnosCS = new Alumnos();
        
        private string idProducto = null;
        private bool vEditar = false;

        public Form1()
        {
            InitializeComponent();
        }
        public struct EnvioDatos
        {
            public int valordeform;
        }

        private void Datos_Alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProducto();
            CerrarBotones();

            Datos_Alumnos.Columns[0].ReadOnly = true;
            Datos_Alumnos.Columns[1].ReadOnly = true;
            Datos_Alumnos.Columns[2].ReadOnly = true;
            Datos_Alumnos.Columns[3].ReadOnly = true;
            Datos_Alumnos.Columns[4].ReadOnly = true;
            Datos_Alumnos.Columns[5].ReadOnly = true;
            Datos_Alumnos.Columns[6].ReadOnly = true;
            Datos_Alumnos.Columns[7].ReadOnly = true;
            Datos_Alumnos.Columns[8].ReadOnly = true;
            Datos_Alumnos.Columns[9].ReadOnly = true;
            Datos_Alumnos.Columns[10].ReadOnly = true;

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
                    ////// Funcion para insertar
                    ///
                    //Parametros para el recuadro de apellido no se quede vacio
                    if ((txtape1.Text == String.Empty) && (txtape2.Text == String.Empty))
                    {
                        MessageBox.Show("Colocar correctamente los apellidos en las 2 casillas");
                    }
                    else
                        //Parametros para el recuadro de nombre no se quede vacio
                        if (txtnom.Text == "")
                        {
                        MessageBox.Show("Ingresar un Nombre Valido");
                        }
                        else
                               //Parametros para el recuadro de celular
                               if (txtcel.Text.Length == 9)
                                {
                                    //Parametros para el recuadro de direccion
                                    if (txtdir.Text == String.Empty)
                                    {
                                        MessageBox.Show("Ingresar una direccion valida");
                                    }
                                    else
                                        //Parametros para el recuadro del email
                                        if (txtemail.Text == String.Empty)
                                    {
                                        MessageBox.Show("Colocar un email valido");
                                    }
                                    else
                                                //Parametros para los recuadros de fecha
                                        if ((Convert.ToInt32(txtfecha2.Text) <= 12) && (Convert.ToInt32(txtfecha.Text) < 31) && (Convert.ToInt32(txtfecha3.Text) < 2222) && (Convert.ToInt32(txtfecha3.Text) > 1799))
                                        {
                                            //Parametros para los recuadros de observacion
                                            if (Convert.ToInt32(txtobs.Text) <= 3)
                                            {
                                                alumnosCS.InsertarSP(txtnom.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txttelf.Text, txtcel.Text, txtdir.Text, txtemail.Text, txtfecha.Text + "-" + txtfecha2.Text + "-" + txtfecha3.Text, txtobs.Text);
                                                MessageBox.Show("Los datos fueron insertados correctamente");
                                                MostrarProducto();
                                                limpiar();
                                            }
                                            else
                                                MessageBox.Show("Las observaciones deben de ser menores a 3");
                                        }
                                        else
                                            MessageBox.Show("Porfavor Coloque una fecha correcta");
                                    }
                            else
                                MessageBox.Show("Porfavor Ingrese otro numero de celular es importante para la institucion colocar un numero de celular");
                }
                catch(Exception)
                {
                    MessageBox.Show("Ocurrio un error al insertar los datos verificar los datos ingresados");
                }
            }if(vEditar==true){
                ////// Funcion para editar
                try
                {
                    //Parametros para el recuadro de apellido no se quede vacio
                    if ((txtape1.Text == String.Empty) && (txtape2.Text == String.Empty))
                    {
                        MessageBox.Show("Colocar correctamente los apellidos en las 2 casillas");
                    }
                    else
                        //Parametros para el recuadro de nombre no se quede vacio
                        if (txtnom.Text == "")
                    {
                        MessageBox.Show("Ingresar un Nombre Valido");
                    }
                    else
                            //Parametros para el recuadro de celular
                       if (txtcel.Text.Length == 9)
                       {
                            //Parametros para el recuadro de direccion
                            if (txtdir.Text == String.Empty)
                            {
                                MessageBox.Show("Ingresar una direccion valida");
                            }
                            else
                                //Parametros para el recuadro del email
                                if (txtemail.Text == String.Empty)
                                {
                                    MessageBox.Show("Colocar un email valido");                                  
                                }
                                else
                                      //Parametros para los recuadros de fecha
                                    if ((Convert.ToInt32(txtfecha2.Text) <= 12) && (Convert.ToInt32(txtfecha.Text) < 31) && (Convert.ToInt32(txtfecha3.Text) < 2222) && (Convert.ToInt32(txtfecha3.Text) > 1799))
                                    {
                                        //Parametros para los recuadros de observacion
                                        if (Convert.ToInt32(txtobs.Text) <= 3)
                                        {
                                            alumnosCS.EditarSP(idProducto, txtnom.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txttelf.Text, txtcel.Text, txtdir.Text, txtemail.Text, txtfecha.Text + "-" + txtfecha2.Text + "-" + txtfecha3.Text, txtobs.Text);
                                            MessageBox.Show("Los datos se editaron correctamente");
                                            MostrarProducto();
                                            vEditar = false;
                                            limpiar();
                                            Insertar.Text = "Ingresar Nuevo Alumno";
                                            CerrarBotones();
                                        }
                                        else
                                            MessageBox.Show("Las observaciones deben de ser menores a 3");
                                    }
                                    else
                                        MessageBox.Show("Porfavor Coloque una fecha correcta");
                        }
                        else
                            MessageBox.Show("Porfavor Ingrese otro numero de celular es importante para la institucion colocar un numero de celular");
                }          
                catch(Exception ex){
                    MessageBox.Show("No se pudieron editar los datos" + ex);
                }
            }
        }
        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            txtnom.MaxLength = 30;
        }
        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            txtfecha.MaxLength = 2;
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Datos_Alumnos.SelectedRows.Count > 0)
                {
                    Eliminar.Enabled=false;
                    Propiedades.Enabled = false;

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
                Datos_Alumnos.ClearSelection();

                CerrarBotones();

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
            Datos_Alumnos.ClearSelection();
        }

         /* Mandar datos de un DatagridView a otro Formulario */
        private int Datos_Alumnoss;

        public int Datos_Alumnoss1 { get => Datos_Alumnoss; set => Datos_Alumnoss = value; }

        private void datoosss()
        {
            Datos_Alumnoss = Convert.ToInt32(Datos_Alumnos.CurrentRow.Cells["ID_Alumno"].Value.ToString());
        }

        private void Propiedades_Click(object sender, EventArgs e)
        {
            datoosss();
            Notas_Insertar frminsert = new Notas_Insertar();

            AddOwnedForm(frminsert);
            frminsert.Show();
            this.Hide();

        }

        private void Datos_Alumnos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Datos_Alumnos.SelectedRows.Count > 0)
            {
                AbrirBotones();

            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(vEditar == false){
                CerrarBotones();
                Datos_Alumnos.ClearSelection();

            }
            if (vEditar == true)
            {
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton3.Enabled = false;
            }



        }

        private void Datos_Alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vEditar == false)
            {
                CerrarBotones();
                

            }
            if (vEditar == true)
            {
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton3.Enabled = false;
            }


        }
        private void CerrarBotones()
        {
            Eliminar.Enabled = false;
            Editar.Enabled = false;
            Propiedades.Enabled = false;

            ////Botones de Bunifu
            ///
            bunifuFlatButton1.Enabled = false;
            bunifuFlatButton2.Enabled = false;
            bunifuFlatButton3.Enabled = false;
        }
        private void AbrirBotones()
        {
            Eliminar.Enabled = true;
            Editar.Enabled = true;
            Propiedades.Enabled = true;

            ////Botones de Bunifu
            ///
            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txttelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) /* Si el texto ingresado no pertenece a una letra se cumplira este parametro */
            {

                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void txtcel_TextChanged(object sender, EventArgs e)
        {
            txtcel.MaxLength = 9;
        }

        private void txtcel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) /* Si el texto ingresado no pertenece a una letra se cumplira este parametro */
            {

                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

            
        }

        private void txttelf_TextChanged(object sender, EventArgs e)
        {
            txttelf.MaxLength = 9;
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) /* Si el texto ingresado no pertenece a una letra se cumplira este parametro */
            {

                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void txtfecha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) /* Si el texto ingresado no pertenece a una letra se cumplira este parametro */
            {

                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void txtfecha3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) /* Si el texto ingresado no pertenece a una letra se cumplira este parametro */
            {

                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void txtobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) /* Si el texto ingresado no pertenece a una letra se cumplira este parametro */
            {

                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {
            txtobs.MaxLength = 1;
        }

        private void txtfecha2_TextChanged(object sender, EventArgs e)
        {
            txtfecha2.MaxLength = 2;
        }

        private void txtfecha3_TextChanged(object sender, EventArgs e)
        {
            txtfecha3.MaxLength = 4;
        }

        private void txtnom2_TextChanged(object sender, EventArgs e)
        {
            txtnom2.MaxLength = 30;
        }

        private void txtape1_TextChanged(object sender, EventArgs e)
        {
            txtape1.MaxLength = 30;
        }

        private void txtape2_TextChanged(object sender, EventArgs e)
        {
            txtape2.MaxLength = 30;
        }

        private void txtdir_TextChanged(object sender, EventArgs e)
        {
            txtdir.MaxLength = 50;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            txtemail.MaxLength = 40;
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
        }

        private void txtnom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
        }

        private void txtape1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) /* Si el texto ingresado no es un espacio se cumplira este parametro */
            {
                e.Handled = true;
            }
        }

        private void cerrarForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Datos_Alumnos.SelectedRows.Count > 0)
                {
                    bunifuFlatButton2.Enabled = false;
                    bunifuFlatButton3.Enabled = false;

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
                    bunifuFlatButton4.Text = "Editar los Datos";

                }
                else
                    MessageBox.Show("Seleccione una Fila en caso de que quiera editarlo");

            }
            catch
            {

                MessageBox.Show("Error al seleccionar datos");
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (vEditar == false)
            {
                try
                {
                    ////// Funcion para insertar
                    ///
                    //Parametros para el recuadro de apellido no se quede vacio
                    if ((txtape1.Text == String.Empty) && (txtape2.Text == String.Empty))
                    {
                        MessageBox.Show("Colocar correctamente los apellidos en las 2 casillas");
                    }
                    else
                        //Parametros para el recuadro de nombre no se quede vacio
                        if (txtnom.Text == "")
                    {
                        MessageBox.Show("Ingresar un Nombre Valido");
                    }
                    else
                               //Parametros para el recuadro de celular
                               if (txtcel.Text.Length == 9)
                    {
                        //Parametros para el recuadro de direccion
                        if (txtdir.Text == String.Empty)
                        {
                            MessageBox.Show("Ingresar una direccion valida");
                        }
                        else
                            //Parametros para el recuadro del email
                            if (txtemail.Text == String.Empty)
                        {
                            MessageBox.Show("Colocar un email valido");
                        }
                        else
                            //Parametros para los recuadros de fecha
                            if ((Convert.ToInt32(txtfecha2.Text) <= 12) && (Convert.ToInt32(txtfecha.Text) < 31) && (Convert.ToInt32(txtfecha3.Text) < 2222) && (Convert.ToInt32(txtfecha3.Text) > 1799))
                        {
                            //Parametros para los recuadros de observacion
                            if (Convert.ToInt32(txtobs.Text) <= 3)
                            {
                                alumnosCS.InsertarSP(txtnom.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txttelf.Text, txtcel.Text, txtdir.Text, txtemail.Text, txtfecha.Text + "-" + txtfecha2.Text + "-" + txtfecha3.Text, txtobs.Text);
                                MessageBox.Show("Los datos fueron insertados correctamente");
                                MostrarProducto();
                                limpiar();
                            }
                            else
                                MessageBox.Show("Las observaciones deben de ser menores a 3");
                        }
                        else
                            MessageBox.Show("Porfavor Coloque una fecha correcta");
                    }
                    else
                        MessageBox.Show("Porfavor Ingrese otro numero de celular es importante para la institucion colocar un numero de celular");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al insertar los datos verificar los datos ingresados");
                }
            }
            if (vEditar == true)
            {
                ////// Funcion para editar
                try
                {
                    //Parametros para el recuadro de apellido no se quede vacio
                    if ((txtape1.Text == String.Empty) && (txtape2.Text == String.Empty))
                    {
                        MessageBox.Show("Colocar correctamente los apellidos en las 2 casillas");
                    }
                    else
                        //Parametros para el recuadro de nombre no se quede vacio
                        if (txtnom.Text == "")
                    {
                        MessageBox.Show("Ingresar un Nombre Valido");
                    }
                    else
                       //Parametros para el recuadro de celular
                       if (txtcel.Text.Length == 9)
                    {
                        //Parametros para el recuadro de direccion
                        if (txtdir.Text == String.Empty)
                        {
                            MessageBox.Show("Ingresar una direccion valida");
                        }
                        else
                            //Parametros para el recuadro del email
                            if (txtemail.Text == String.Empty)
                        {
                            MessageBox.Show("Colocar un email valido");
                        }
                        else
                                //Parametros para los recuadros de fecha
                                if ((Convert.ToInt32(txtfecha2.Text) <= 12) && (Convert.ToInt32(txtfecha.Text) < 31) && (Convert.ToInt32(txtfecha3.Text) < 2222) && (Convert.ToInt32(txtfecha3.Text) > 1799))
                        {
                            //Parametros para los recuadros de observacion
                            if (Convert.ToInt32(txtobs.Text) <= 3)
                            {
                                alumnosCS.EditarSP(idProducto, txtnom.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txttelf.Text, txtcel.Text, txtdir.Text, txtemail.Text, txtfecha.Text + "-" + txtfecha2.Text + "-" + txtfecha3.Text, txtobs.Text);
                                MessageBox.Show("Los datos se editaron correctamente");
                                MostrarProducto();
                                vEditar = false;
                                limpiar();
                                bunifuFlatButton4.Text = "Ingresar Nuevo Alumno";
                                CerrarBotones();
                            }
                            else
                                MessageBox.Show("Las observaciones deben de ser menores a 3");
                        }
                        else
                            MessageBox.Show("Porfavor Coloque una fecha correcta");
                    }
                    else
                        MessageBox.Show("Porfavor Ingrese otro numero de celular es importante para la institucion colocar un numero de celular");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos" + ex);
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (Datos_Alumnos.SelectedRows.Count > 0)
            {
                idProducto = Datos_Alumnos.CurrentRow.Cells["ID_Alumno"].Value.ToString();
                alumnosCS.EliminarSP(idProducto);
                MessageBox.Show("Datos Eliminados correctamente");
                MostrarProducto();
                Datos_Alumnos.ClearSelection();

                CerrarBotones();

            }
            else
                MessageBox.Show("Escoge una fila para eliminar");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            datoosss();
            Notas_Insertar frminsert = new Notas_Insertar();

            AddOwnedForm(frminsert);
            frminsert.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            AlumnosReporte reporte_alumno = new AlumnosReporte();
            ReportDocument reportes = new ReportDocument(); 
            reportes.Load(@"\Users\elfab\OneDrive\Documentos\Aprendimientos\Cuarto Semestre\Lenguaje de Programacion\Trabajo Final\Acabado\Sistemade Registro de Estudiantes\Presentacion_Capa\ReporteNotas.rpt");
            reporte_alumno.crystalReportViewer1.ReportSource = reportes;
            reporte_alumno.Show();
            reportes.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\elfab\OneDrive\Documentos\Aprendimientos\Cuarto Semestre\Lenguaje de Programacion\Trabajo Final\Acabado\Sistemade Registro de Estudiantes\ReportesReportes_Alumnos.pdf");

        }

        private void topFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
