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
    public partial class Notas_Insertar : Form
    {
        
        public Notas_Insertar()
        {
            InitializeComponent();
            cbalumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            Tarea1.DropDownStyle = ComboBoxStyle.DropDownList;
            Tarea2.DropDownStyle = ComboBoxStyle.DropDownList;
            Tarea3.DropDownStyle = ComboBoxStyle.DropDownList;
            Tarea4.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        

        private void lblid_Click(object sender, EventArgs e)
        {

        }
        private void Notas_Insertar_Load(object sender, EventArgs e)
        {
            MostrarNotas();
            Datos();   
            Cargar();

            /* Traer Datos del otro formulario */

            Form1 almacenado = Owner as Form1;
            cbalumno.SelectedValue = almacenado.Datos_Alumnoss1;

            /*------------------------------------------------*/


            /* Bloquear las celdas del Data Grid View */
            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].ReadOnly = true;
            dataGridView2.Columns[3].ReadOnly = true;
            dataGridView2.Columns[4].ReadOnly = true;
        }
        private void MostrarNotas()
        {
            Alumnos notasCC = new Alumnos();
            dataGridView2.DataSource = notasCC.MostrarNota();

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarNota();
            
        }

        private void cbalumno_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbalumno_TextChanged(object sender, EventArgs e)
        {
            Alumnos alumnosCZ = new Alumnos();
            DataTable lblapess = alumnosCZ.MostrarAlumnoDatoss(Convert.ToInt32(cbalumno.SelectedValue.ToString()));
            lblape.Text = lblapess.Rows[1]["Primer_Nombre"].ToString() + ' ' + lblapess.Rows[1]["Segundo_Nombre"].ToString();
            lblnom.Text = lblapess.Rows[1]["Primer_Apellido"].ToString() + ' ' + lblapess.Rows[1]["Segundo_Apellido"].ToString();
        }

        private void lblape_Click(object sender, EventArgs e)
        {
            
        }
        private void Cargar()
        {
            
        }

        private void cbalumno_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        public void Datos()

        {
            //Conexion de Datos
            Alumnos alumnosCS = new Alumnos();

            cbalumno.ValueMember = "ID_Alumno";
            cbalumno.DataSource = alumnosCS.MostrarAlumnoNotas();
            cbalumno.DisplayMember = "ID_Alumno";
            




            //Datos de Curso
            cbCurso.Items.Add("Comunicacion");
            cbCurso.Items.Add("Matematica");
            cbCurso.Items.Add("Ciencia");
            cbCurso.Items.Add("Historia");

            cbCurso.SelectedItem = "Comunicacion";
  

            //Datos de la nota
            Tarea1.SelectedIndex = 0;
            Tarea2.SelectedIndex = 0;
            Tarea3.SelectedIndex = 0;
            Tarea4.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tarea1.SelectedIndex = 0;
            Tarea2.SelectedIndex = 0;
            Tarea3.SelectedIndex = 0;
            Tarea4.SelectedIndex = 0;
        }

        private void bnt_notas_Click(object sender, EventArgs e)
        {
            Alumnos alumnosCCC = new Alumnos();

            alumnosCCC.AgregarNotaSP(cbalumno.SelectedValue.ToString(), lblnota.Text.ToString(),cbCurso.SelectedItem.ToString());
            MessageBox.Show("Notas Insertadas Correctamente");
            MostrarNotas();

        }
        private void GenerarNota()
        {
            float Nota1;
            float Nota2;
            float Nota3;
            float Nota4;

            //Nota 1
            if (Tarea1.SelectedIndex == 1)
            {
                Nota1 = 5;
            }
            else
                Nota1 = 0;

            //Nota 2
            if (Tarea2.SelectedIndex == 1)
            {
                Nota2 = 5;
            }
            else
                Nota2 = 0;

            //Nota 3
            if (Tarea3.SelectedIndex == 1)
            {
                Nota3 = 5;
            }
            else
                Nota3 = 0;

            //Nota 4
            if (Tarea4.SelectedIndex == 1)
            {
                Nota4 = 5;
            }
            else
                Nota4 = 0;


            float Promedio = Nota1 + Nota2 + Nota3 + Nota4;
            string Resumen1 = Convert.ToString(Promedio);
            

            lblnota.Text = Resumen1;


        }

        private void lblnota_Click(object sender, EventArgs e)
        {

        }

        private void Tarea2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarNota();
        }

        private void Tarea3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarNota();
        }

        private void Tarea4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarNota();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDatos_Click(object sender, EventArgs e)
        {
            Form1 anterior = new Form1();
            anterior.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 anterior = new Form1();
            anterior.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 anterior = new Form1();
            anterior.Show();
            this.Hide();
        }

        private void lblnom_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Form1 anterior = new Form1();
            anterior.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nomID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Reporte_Click(object sender, EventArgs e)
        {
            NotasReporte reporte_notas = new NotasReporte();
            ReportDocument reportessnota = new ReportDocument();
            reportessnota.Load(@"C:\Users\elfab\OneDrive\Documentos\Aprendimientos\Cuarto Semestre\Lenguaje de Programacion\Trabajo Final\Acabado\Sistemade Registro de Estudiantes\Presentacion_Capa\Calificaciones.rpt");
            reporte_notas.crystalReportViewer1.ReportSource = reportessnota;
            reporte_notas.Show();
            reportessnota.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\elfab\OneDrive\Documentos\Aprendimientos\Cuarto Semestre\Lenguaje de Programacion\Trabajo Final\Acabado\Sistemade Registro de Estudiantes\Reportes\Reportes_Notas.pdf");

        }
    }
    }

