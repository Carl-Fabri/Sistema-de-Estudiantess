using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_Capa
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        int idt = 0;
        int idcon = 0;

        private void Loguin_Load(object sender, EventArgs e)
        {
          
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void idlnl_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void idtxt_Click(object sender, EventArgs e)
        {

            //Estos comando Eliminara los textos de Ejemplo
            idt++;
            if (idt < 2)
            {
                idtxt.Clear();
            }
            //////

            imgcon.Image = Properties.Resources.candado;



            imgid.Image = Properties.Resources.Usuario2;
             
            idlnl.BackColor = Color.FromArgb(81, 0, 95);
            idtxt.ForeColor = Color.FromArgb(81, 0, 95);

            conlnl.BackColor = Color.Black;
            bunifuCustomTextbox1.ForeColor = Color.Black;
        }

        private void bunifuCustomTextbox1_Click(object sender, EventArgs e)
        {

            //Estos comando Eliminara los textos de Ejemplo
            idcon++;

            if (idcon < 2)
            {
                bunifuCustomTextbox1.Clear();
            }
            ///

            imgid.Image = Properties.Resources.Usuario;
            imgcon.Image = Properties.Resources.candado2;

            bunifuCustomTextbox1.PasswordChar='*';
            conlnl.BackColor = Color.FromArgb(81, 0, 95);
            bunifuCustomTextbox1.ForeColor = Color.FromArgb(81, 0, 95);


            idlnl.BackColor = Color.Black;
            idtxt.ForeColor = Color.Black;


            
        }


        /// AquiColoca por si faltan datos para que no pueda ingresar sin haber insertado nada
        private void ActivaBotones()
        {
            int cantID = idtxt.TextLength;
            int cantCont = bunifuCustomTextbox1.TextLength;
            if (cantID > 5 && cantCont > 5)
            {
                Ingresarbtn.BackgroundImage = Properties.Resources.Fondo_Recurso_6;
                Ingresarbtn.Enabled = Enabled;

            }
            else
            {
                Ingresarbtn.BackgroundImage = Properties.Resources.FondoRecurso_51;
                Ingresarbtn.Enabled = false;

            }
        }


        private void Ingresarbtn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            ActivaBotones();
        }

        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {
            ActivaBotones();
        }
    }
}
