
namespace Presentacion_Capa
{
    partial class Loguin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idtxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.idlnl = new System.Windows.Forms.FlowLayoutPanel();
            this.conlnl = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgid = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.registrarsebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Ingresarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // idtxt
            // 
            this.idtxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idtxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(87, 242);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(297, 30);
            this.idtxt.TabIndex = 1;
            this.idtxt.Text = "ID";
            this.idtxt.Click += new System.EventHandler(this.idtxt_Click);
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // idlnl
            // 
            this.idlnl.BackColor = System.Drawing.Color.Black;
            this.idlnl.Location = new System.Drawing.Point(24, 278);
            this.idlnl.Name = "idlnl";
            this.idlnl.Size = new System.Drawing.Size(360, 3);
            this.idlnl.TabIndex = 3;
            this.idlnl.Paint += new System.Windows.Forms.PaintEventHandler(this.idlnl_Paint);
            // 
            // conlnl
            // 
            this.conlnl.BackColor = System.Drawing.Color.Black;
            this.conlnl.Location = new System.Drawing.Point(24, 350);
            this.conlnl.Name = "conlnl";
            this.conlnl.Size = new System.Drawing.Size(360, 3);
            this.conlnl.TabIndex = 4;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(86, 315);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.PasswordChar = '*';
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(298, 30);
            this.bunifuCustomTextbox1.TabIndex = 7;
            this.bunifuCustomTextbox1.Text = "Contraseña";
            this.bunifuCustomTextbox1.Click += new System.EventHandler(this.bunifuCustomTextbox1_Click);
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imgid
            // 
            this.imgid.BackColor = System.Drawing.SystemColors.Control;
            this.imgid.Image = global::Presentacion_Capa.Properties.Resources.Usuario;
            this.imgid.Location = new System.Drawing.Point(46, 242);
            this.imgid.Name = "imgid";
            this.imgid.Size = new System.Drawing.Size(30, 27);
            this.imgid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgid.TabIndex = 8;
            this.imgid.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(168, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // registrarsebtn
            // 
            this.registrarsebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registrarsebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registrarsebtn.BackgroundImage = global::Presentacion_Capa.Properties.Resources.Fondo_Recurso_6;
            this.registrarsebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrarsebtn.BorderRadius = 5;
            this.registrarsebtn.ButtonText = "Registrarse";
            this.registrarsebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarsebtn.DisabledColor = System.Drawing.Color.Gray;
            this.registrarsebtn.Enabled = false;
            this.registrarsebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.registrarsebtn.Iconimage = null;
            this.registrarsebtn.Iconimage_right = null;
            this.registrarsebtn.Iconimage_right_Selected = null;
            this.registrarsebtn.Iconimage_Selected = null;
            this.registrarsebtn.IconMarginLeft = 0;
            this.registrarsebtn.IconMarginRight = 0;
            this.registrarsebtn.IconRightVisible = true;
            this.registrarsebtn.IconRightZoom = 0D;
            this.registrarsebtn.IconVisible = true;
            this.registrarsebtn.IconZoom = 90D;
            this.registrarsebtn.IsTab = false;
            this.registrarsebtn.Location = new System.Drawing.Point(91, 481);
            this.registrarsebtn.Name = "registrarsebtn";
            this.registrarsebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.registrarsebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.registrarsebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.registrarsebtn.selected = false;
            this.registrarsebtn.Size = new System.Drawing.Size(241, 48);
            this.registrarsebtn.TabIndex = 10;
            this.registrarsebtn.Text = "Registrarse";
            this.registrarsebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registrarsebtn.Textcolor = System.Drawing.Color.White;
            this.registrarsebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Ingresarbtn
            // 
            this.Ingresarbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Ingresarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Ingresarbtn.BackgroundImage = global::Presentacion_Capa.Properties.Resources.FondoRecurso_51;
            this.Ingresarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ingresarbtn.BorderRadius = 5;
            this.Ingresarbtn.ButtonText = "Ingresar";
            this.Ingresarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Ingresarbtn.Enabled = false;
            this.Ingresarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Ingresarbtn.Iconimage = null;
            this.Ingresarbtn.Iconimage_right = null;
            this.Ingresarbtn.Iconimage_right_Selected = null;
            this.Ingresarbtn.Iconimage_Selected = null;
            this.Ingresarbtn.IconMarginLeft = 0;
            this.Ingresarbtn.IconMarginRight = 0;
            this.Ingresarbtn.IconRightVisible = true;
            this.Ingresarbtn.IconRightZoom = 0D;
            this.Ingresarbtn.IconVisible = true;
            this.Ingresarbtn.IconZoom = 90D;
            this.Ingresarbtn.IsTab = false;
            this.Ingresarbtn.Location = new System.Drawing.Point(91, 410);
            this.Ingresarbtn.Name = "Ingresarbtn";
            this.Ingresarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Ingresarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Ingresarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Ingresarbtn.selected = false;
            this.Ingresarbtn.Size = new System.Drawing.Size(241, 48);
            this.Ingresarbtn.TabIndex = 9;
            this.Ingresarbtn.Text = "Ingresar";
            this.Ingresarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ingresarbtn.Textcolor = System.Drawing.Color.White;
            this.Ingresarbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresarbtn.Click += new System.EventHandler(this.Ingresarbtn_Click);
            // 
            // imgcon
            // 
            this.imgcon.Image = global::Presentacion_Capa.Properties.Resources.candado;
            this.imgcon.Location = new System.Drawing.Point(46, 315);
            this.imgcon.Name = "imgcon";
            this.imgcon.Size = new System.Drawing.Size(30, 28);
            this.imgcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcon.TabIndex = 6;
            this.imgcon.TabStop = false;
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 578);
            this.Controls.Add(this.registrarsebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgid);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Ingresarbtn);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.imgcon);
            this.Controls.Add(this.conlnl);
            this.Controls.Add(this.idlnl);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.Load += new System.EventHandler(this.Loguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox idtxt;
        private System.Windows.Forms.FlowLayoutPanel conlnl;
        private System.Windows.Forms.FlowLayoutPanel idlnl;
        private System.Windows.Forms.PictureBox imgcon;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.PictureBox imgid;
        private Bunifu.Framework.UI.BunifuFlatButton registrarsebtn;
        private Bunifu.Framework.UI.BunifuFlatButton Ingresarbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}