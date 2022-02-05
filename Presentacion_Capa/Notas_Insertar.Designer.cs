
namespace Presentacion_Capa
{
    partial class Notas_Insertar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas_Insertar));
            this.nomID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sistema_De_ControlDataSet = new Presentacion_Capa.Sistema_De_ControlDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tarea1 = new System.Windows.Forms.ComboBox();
            this.Tarea3 = new System.Windows.Forms.ComboBox();
            this.Tarea2 = new System.Windows.Forms.ComboBox();
            this.Tarea4 = new System.Windows.Forms.ComboBox();
            this.Cursolbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.cbalumno = new System.Windows.Forms.ComboBox();
            this.lblape = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.bnt_notas = new System.Windows.Forms.Button();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mover = new System.Windows.Forms.Panel();
            this.cerrarForm = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Reporte = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_De_ControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // nomID
            // 
            this.nomID.AutoSize = true;
            this.nomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.nomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomID.ForeColor = System.Drawing.Color.White;
            this.nomID.Location = new System.Drawing.Point(118, 159);
            this.nomID.Name = "nomID";
            this.nomID.Size = new System.Drawing.Size(30, 20);
            this.nomID.TabIndex = 0;
            this.nomID.Text = "ID:";
            this.nomID.Click += new System.EventHandler(this.nomID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sistema_De_ControlDataSet
            // 
            this.sistema_De_ControlDataSet.DataSetName = "Sistema_De_ControlDataSet";
            this.sistema_De_ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.sistema_De_ControlDataSet;
            // 
            // notasTableAdapter
            // 

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarea 01:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(490, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarea 03:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(490, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tarea 02:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(490, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tarea 04:";
            // 
            // Tarea1
            // 
            this.Tarea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarea1.FormattingEnabled = true;
            this.Tarea1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Tarea1.Location = new System.Drawing.Point(580, 155);
            this.Tarea1.Name = "Tarea1";
            this.Tarea1.Size = new System.Drawing.Size(95, 21);
            this.Tarea1.TabIndex = 10;
            this.Tarea1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Tarea3
            // 
            this.Tarea3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarea3.FormattingEnabled = true;
            this.Tarea3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Tarea3.Location = new System.Drawing.Point(580, 237);
            this.Tarea3.Name = "Tarea3";
            this.Tarea3.Size = new System.Drawing.Size(95, 21);
            this.Tarea3.TabIndex = 11;
            this.Tarea3.SelectedIndexChanged += new System.EventHandler(this.Tarea3_SelectedIndexChanged);
            // 
            // Tarea2
            // 
            this.Tarea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarea2.FormattingEnabled = true;
            this.Tarea2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Tarea2.Location = new System.Drawing.Point(580, 194);
            this.Tarea2.Name = "Tarea2";
            this.Tarea2.Size = new System.Drawing.Size(95, 21);
            this.Tarea2.TabIndex = 12;
            this.Tarea2.SelectedIndexChanged += new System.EventHandler(this.Tarea2_SelectedIndexChanged);
            // 
            // Tarea4
            // 
            this.Tarea4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarea4.FormattingEnabled = true;
            this.Tarea4.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Tarea4.Location = new System.Drawing.Point(580, 282);
            this.Tarea4.Name = "Tarea4";
            this.Tarea4.Size = new System.Drawing.Size(95, 21);
            this.Tarea4.TabIndex = 13;
            this.Tarea4.SelectedIndexChanged += new System.EventHandler(this.Tarea4_SelectedIndexChanged);
            // 
            // Cursolbl
            // 
            this.Cursolbl.AutoSize = true;
            this.Cursolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.Cursolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursolbl.ForeColor = System.Drawing.Color.White;
            this.Cursolbl.Location = new System.Drawing.Point(428, 94);
            this.Cursolbl.Name = "Cursolbl";
            this.Cursolbl.Size = new System.Drawing.Size(142, 20);
            this.Cursolbl.TabIndex = 14;
            this.Cursolbl.Text = "Notas del Curso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(505, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nota del Curso:";
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.lblnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.ForeColor = System.Drawing.Color.White;
            this.lblnota.Location = new System.Drawing.Point(647, 410);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(18, 20);
            this.lblnota.TabIndex = 16;
            this.lblnota.Text = "0";
            this.lblnota.Click += new System.EventHandler(this.lblnota_Click);
            // 
            // cbalumno
            // 
            this.cbalumno.BackColor = System.Drawing.Color.White;
            this.cbalumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalumno.FormattingEnabled = true;
            this.cbalumno.Location = new System.Drawing.Point(156, 163);
            this.cbalumno.Name = "cbalumno";
            this.cbalumno.Size = new System.Drawing.Size(130, 21);
            this.cbalumno.TabIndex = 17;
            this.cbalumno.SelectedIndexChanged += new System.EventHandler(this.cbalumno_SelectedIndexChanged);
            this.cbalumno.SelectedValueChanged += new System.EventHandler(this.cbalumno_SelectedValueChanged);
            this.cbalumno.TextChanged += new System.EventHandler(this.cbalumno_TextChanged);
            // 
            // lblape
            // 
            this.lblape.AutoSize = true;
            this.lblape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.lblape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblape.ForeColor = System.Drawing.Color.White;
            this.lblape.Location = new System.Drawing.Point(211, 245);
            this.lblape.Name = "lblape";
            this.lblape.Size = new System.Drawing.Size(57, 20);
            this.lblape.TabIndex = 18;
            this.lblape.Text = "label9";
            this.lblape.Click += new System.EventHandler(this.lblape_Click);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(211, 324);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(67, 20);
            this.lblnom.TabIndex = 19;
            this.lblnom.Text = "label10";
            this.lblnom.Click += new System.EventHandler(this.lblnom_Click);
            // 
            // bnt_notas
            // 
            this.bnt_notas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_notas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_notas.Location = new System.Drawing.Point(477, 340);
            this.bnt_notas.Name = "bnt_notas";
            this.bnt_notas.Size = new System.Drawing.Size(224, 55);
            this.bnt_notas.TabIndex = 21;
            this.bnt_notas.Text = "Insertar Notas";
            this.bnt_notas.UseVisualStyleBackColor = true;
            this.bnt_notas.Click += new System.EventHandler(this.bnt_notas_Click);
            // 
            // cbCurso
            // 
            this.cbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurso.ItemHeight = 13;
            this.cbCurso.Location = new System.Drawing.Point(580, 94);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(170, 21);
            this.cbCurso.TabIndex = 22;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(39, 444);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(711, 148);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(832, 622);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // mover
            // 
            this.mover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.mover.Controls.Add(this.cerrarForm);
            this.mover.Controls.Add(this.label8);
            this.mover.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.mover.Location = new System.Drawing.Point(-4, -1);
            this.mover.Name = "mover";
            this.mover.Size = new System.Drawing.Size(832, 87);
            this.mover.TabIndex = 31;
            // 
            // cerrarForm
            // 
            this.cerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("cerrarForm.Image")));
            this.cerrarForm.Location = new System.Drawing.Point(768, 20);
            this.cerrarForm.Name = "cerrarForm";
            this.cerrarForm.Size = new System.Drawing.Size(34, 34);
            this.cerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarForm.TabIndex = 35;
            this.cerrarForm.TabStop = false;
            this.cerrarForm.Click += new System.EventHandler(this.cerrarForm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(324, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "Calificar alumno";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.mover;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Reporte
            // 
            this.Reporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Reporte.BackColor = System.Drawing.Color.Transparent;
            this.Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reporte.BorderRadius = 0;
            this.Reporte.ButtonText = "";
            this.Reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reporte.DisabledColor = System.Drawing.Color.Transparent;
            this.Reporte.Iconcolor = System.Drawing.Color.Transparent;
            this.Reporte.Iconimage = ((System.Drawing.Image)(resources.GetObject("Reporte.Iconimage")));
            this.Reporte.Iconimage_right = null;
            this.Reporte.Iconimage_right_Selected = null;
            this.Reporte.Iconimage_Selected = null;
            this.Reporte.IconMarginLeft = 0;
            this.Reporte.IconMarginRight = 0;
            this.Reporte.IconRightVisible = true;
            this.Reporte.IconRightZoom = 0D;
            this.Reporte.IconVisible = true;
            this.Reporte.IconZoom = 200D;
            this.Reporte.IsTab = false;
            this.Reporte.Location = new System.Drawing.Point(383, 615);
            this.Reporte.Name = "Reporte";
            this.Reporte.Normalcolor = System.Drawing.Color.Transparent;
            this.Reporte.OnHovercolor = System.Drawing.Color.Transparent;
            this.Reporte.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Reporte.selected = false;
            this.Reporte.Size = new System.Drawing.Size(72, 73);
            this.Reporte.TabIndex = 32;
            this.Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reporte.Textcolor = System.Drawing.Color.Transparent;
            this.Reporte.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // Notas_Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 700);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.bnt_notas);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblape);
            this.Controls.Add(this.cbalumno);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cursolbl);
            this.Controls.Add(this.Tarea4);
            this.Controls.Add(this.Tarea2);
            this.Controls.Add(this.Tarea3);
            this.Controls.Add(this.Tarea1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas_Insertar";
            this.Text = "Notas_Insertar";
            this.Load += new System.EventHandler(this.Notas_Insertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_De_ControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mover.ResumeLayout(false);
            this.mover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Sistema_De_ControlDataSet sistema_De_ControlDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Tarea1;
        private System.Windows.Forms.ComboBox Tarea3;
        private System.Windows.Forms.ComboBox Tarea2;
        private System.Windows.Forms.ComboBox Tarea4;
        private System.Windows.Forms.Label Cursolbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.ComboBox cbalumno;
        private System.Windows.Forms.Label lblape;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button bnt_notas;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mover;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox cerrarForm;
        private Bunifu.Framework.UI.BunifuFlatButton Reporte;
    }
}