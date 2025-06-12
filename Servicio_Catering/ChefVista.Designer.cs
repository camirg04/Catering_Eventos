namespace Servicio_Catering
{
    partial class Administracion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbTipoPlato = new System.Windows.Forms.ComboBox();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.eliminarPlato = new System.Windows.Forms.Button();
            this.agregarPlato = new System.Windows.Forms.Button();
            this.verPlato = new System.Windows.Forms.Button();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fechaHastaEvento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fechaDesdeEvento = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimeHastaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeDesdeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvVencimientos = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnEditarAlerta = new System.Windows.Forms.Button();
            this.btnBuscarAlerta = new System.Windows.Forms.Button();
            this.cbEstadoAlerta = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvAlertas = new System.Windows.Forms.DataGridView();
            this.dateTimeHastaAlerta = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimeDesdeAlerta = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.cbEstadoEvento = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimientos)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.cbTipoPlato);
            this.tabPage1.Controls.Add(this.cbActivo);
            this.tabPage1.Controls.Add(this.lblActivo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbFiltrar);
            this.tabPage1.Controls.Add(this.eliminarPlato);
            this.tabPage1.Controls.Add(this.agregarPlato);
            this.tabPage1.Controls.Add(this.verPlato);
            this.tabPage1.Controls.Add(this.dgvPlatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(700, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Platos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(590, 299);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 24);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(561, 177);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // cbTipoPlato
            // 
            this.cbTipoPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlato.FormattingEnabled = true;
            this.cbTipoPlato.Location = new System.Drawing.Point(561, 221);
            this.cbTipoPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoPlato.Name = "cbTipoPlato";
            this.cbTipoPlato.Size = new System.Drawing.Size(138, 21);
            this.cbTipoPlato.TabIndex = 11;
            // 
            // cbActivo
            // 
            this.cbActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Location = new System.Drawing.Point(561, 264);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(138, 21);
            this.cbActivo.TabIndex = 10;
            // 
            // lblActivo
            // 
            this.lblActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(561, 249);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(44, 15);
            this.lblActivo.TabIndex = 9;
            this.lblActivo.Text = "Activo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar platos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltrar.Location = new System.Drawing.Point(561, 206);
            this.lbFiltrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(35, 15);
            this.lbFiltrar.TabIndex = 6;
            this.lbFiltrar.Text = "Tipo";
            // 
            // eliminarPlato
            // 
            this.eliminarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarPlato.Location = new System.Drawing.Point(561, 70);
            this.eliminarPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminarPlato.Name = "eliminarPlato";
            this.eliminarPlato.Size = new System.Drawing.Size(136, 24);
            this.eliminarPlato.TabIndex = 2;
            this.eliminarPlato.Text = "Eliminar";
            this.eliminarPlato.UseVisualStyleBackColor = true;
            // 
            // agregarPlato
            // 
            this.agregarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarPlato.Location = new System.Drawing.Point(561, 41);
            this.agregarPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agregarPlato.Name = "agregarPlato";
            this.agregarPlato.Size = new System.Drawing.Size(136, 24);
            this.agregarPlato.TabIndex = 3;
            this.agregarPlato.Text = "Agregar";
            this.agregarPlato.UseVisualStyleBackColor = true;
            this.agregarPlato.Click += new System.EventHandler(this.agregarPlato_Click);
            // 
            // verPlato
            // 
            this.verPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verPlato.Location = new System.Drawing.Point(561, 13);
            this.verPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.verPlato.Name = "verPlato";
            this.verPlato.Size = new System.Drawing.Size(136, 24);
            this.verPlato.TabIndex = 4;
            this.verPlato.Text = "Ver detalle";
            this.verPlato.UseVisualStyleBackColor = true;
            this.verPlato.Click += new System.EventHandler(this.verPlato_Click);
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Location = new System.Drawing.Point(0, 0);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.Size = new System.Drawing.Size(556, 427);
            this.dgvPlatos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(807, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menús";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(684, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(655, 179);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(655, 223);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(655, 266);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Plato";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Buscar menús";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(653, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(655, 72);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(655, 43);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 24);
            this.button3.TabIndex = 16;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(655, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 24);
            this.button4.TabIndex = 17;
            this.button4.Text = "Ver detalle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(651, 430);
            this.dataGridView2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fechaHastaEvento);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.fechaDesdeEvento);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.cbEstadoEvento);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.dgvEventos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(807, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eventos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fechaHastaEvento
            // 
            this.fechaHastaEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaHastaEvento.Location = new System.Drawing.Point(670, 271);
            this.fechaHastaEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaHastaEvento.Name = "fechaHastaEvento";
            this.fechaHastaEvento.Size = new System.Drawing.Size(125, 20);
            this.fechaHastaEvento.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(672, 258);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Hasta";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(672, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Desde";
            // 
            // fechaDesdeEvento
            // 
            this.fechaDesdeEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaDesdeEvento.Location = new System.Drawing.Point(670, 235);
            this.fechaDesdeEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaDesdeEvento.Name = "fechaDesdeEvento";
            this.fechaDesdeEvento.Size = new System.Drawing.Size(125, 20);
            this.fechaDesdeEvento.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(691, 301);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 24);
            this.button5.TabIndex = 25;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(699, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Buscar eventos";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(668, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Estado";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(670, 46);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 24);
            this.button7.TabIndex = 16;
            this.button7.Text = "Agregar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(670, 17);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 24);
            this.button8.TabIndex = 17;
            this.button8.Text = "Ver detalle";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dgvEventos
            // 
            this.dgvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(2, 0);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(662, 430);
            this.dgvEventos.TabIndex = 14;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.dateTimeHastaVencimiento);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dateTimeDesdeVencimiento);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.dgvVencimientos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(807, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vencimientos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(688, 249);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 26);
            this.button6.TabIndex = 40;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(668, 206);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Hasta";
            // 
            // dateTimeHastaVencimiento
            // 
            this.dateTimeHastaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeHastaVencimiento.Location = new System.Drawing.Point(665, 225);
            this.dateTimeHastaVencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeHastaVencimiento.Name = "dateTimeHastaVencimiento";
            this.dateTimeHastaVencimiento.Size = new System.Drawing.Size(140, 20);
            this.dateTimeHastaVencimiento.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Desde";
            // 
            // dateTimeDesdeVencimiento
            // 
            this.dateTimeDesdeVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDesdeVencimiento.Location = new System.Drawing.Point(665, 175);
            this.dateTimeDesdeVencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeDesdeVencimiento.Name = "dateTimeDesdeVencimiento";
            this.dateTimeDesdeVencimiento.Size = new System.Drawing.Size(140, 20);
            this.dateTimeDesdeVencimiento.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(666, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Fecha";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(668, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Filtrar vencimientos";
            // 
            // dgvVencimientos
            // 
            this.dgvVencimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencimientos.Location = new System.Drawing.Point(0, 0);
            this.dgvVencimientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVencimientos.Name = "dgvVencimientos";
            this.dgvVencimientos.Size = new System.Drawing.Size(661, 430);
            this.dgvVencimientos.TabIndex = 15;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnEditarAlerta);
            this.tabPage5.Controls.Add(this.btnBuscarAlerta);
            this.tabPage5.Controls.Add(this.cbEstadoAlerta);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.dgvAlertas);
            this.tabPage5.Controls.Add(this.dateTimeHastaAlerta);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.dateTimeDesdeAlerta);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(807, 425);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Alertas Stock";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnEditarAlerta
            // 
            this.btnEditarAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarAlerta.Location = new System.Drawing.Point(672, 19);
            this.btnEditarAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarAlerta.Name = "btnEditarAlerta";
            this.btnEditarAlerta.Size = new System.Drawing.Size(135, 24);
            this.btnEditarAlerta.TabIndex = 52;
            this.btnEditarAlerta.Text = "Editar";
            this.btnEditarAlerta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAlerta
            // 
            this.btnBuscarAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarAlerta.Location = new System.Drawing.Point(706, 312);
            this.btnBuscarAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarAlerta.Name = "btnBuscarAlerta";
            this.btnBuscarAlerta.Size = new System.Drawing.Size(68, 24);
            this.btnBuscarAlerta.TabIndex = 51;
            this.btnBuscarAlerta.Text = "Buscar";
            this.btnBuscarAlerta.UseVisualStyleBackColor = true;
            // 
            // cbEstadoAlerta
            // 
            this.cbEstadoAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoAlerta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoAlerta.FormattingEnabled = true;
            this.cbEstadoAlerta.Location = new System.Drawing.Point(672, 146);
            this.cbEstadoAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstadoAlerta.Name = "cbEstadoAlerta";
            this.cbEstadoAlerta.Size = new System.Drawing.Size(125, 21);
            this.cbEstadoAlerta.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(669, 132);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 15);
            this.label23.TabIndex = 49;
            this.label23.Text = "Estado";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(669, 262);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Hasta";
            // 
            // dgvAlertas
            // 
            this.dgvAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertas.Location = new System.Drawing.Point(-3, 0);
            this.dgvAlertas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlertas.Name = "dgvAlertas";
            this.dgvAlertas.Size = new System.Drawing.Size(668, 430);
            this.dgvAlertas.TabIndex = 40;
            // 
            // dateTimeHastaAlerta
            // 
            this.dateTimeHastaAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeHastaAlerta.Location = new System.Drawing.Point(672, 275);
            this.dateTimeHastaAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeHastaAlerta.Name = "dateTimeHastaAlerta";
            this.dateTimeHastaAlerta.Size = new System.Drawing.Size(125, 20);
            this.dateTimeHastaAlerta.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(673, 210);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Desde";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(704, 66);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 15);
            this.label21.TabIndex = 42;
            this.label21.Text = "Filtrar alertas";
            // 
            // dateTimeDesdeAlerta
            // 
            this.dateTimeDesdeAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDesdeAlerta.Location = new System.Drawing.Point(672, 223);
            this.dateTimeDesdeAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeDesdeAlerta.Name = "dateTimeDesdeAlerta";
            this.dateTimeDesdeAlerta.Size = new System.Drawing.Size(125, 20);
            this.dateTimeDesdeAlerta.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(673, 183);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "Fecha";
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarSesion.Location = new System.Drawing.Point(748, 2);
            this.CerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(97, 29);
            this.CerrarSesion.TabIndex = 0;
            this.CerrarSesion.Text = "Cerrar sesión";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(13, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(98, 15);
            this.lblBienvenida.TabIndex = 14;
            this.lblBienvenida.Text = "¡Bienvenido/a!";
            // 
            // cbEstadoEvento
            // 
            this.cbEstadoEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEvento.FormattingEnabled = true;
            this.cbEstadoEvento.Location = new System.Drawing.Point(670, 168);
            this.cbEstadoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoEvento.Name = "cbEstadoEvento";
            this.cbEstadoEvento.Size = new System.Drawing.Size(125, 21);
            this.cbEstadoEvento.TabIndex = 23;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.tabControl1);
            this.Name = "Administracion";
            this.Text = "Administración Catering";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimientos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DateTimePicker fechaDesdeEvento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker fechaHastaEvento;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.DataGridView dgvVencimientos;
        private System.Windows.Forms.DateTimePicker dateTimeHastaVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeDesdeVencimiento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbTipoPlato;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.Button eliminarPlato;
        private System.Windows.Forms.Button agregarPlato;
        private System.Windows.Forms.Button verPlato;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnEditarAlerta;
        private System.Windows.Forms.Button btnBuscarAlerta;
        private System.Windows.Forms.ComboBox cbEstadoAlerta;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvAlertas;
        private System.Windows.Forms.DateTimePicker dateTimeHastaAlerta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dateTimeDesdeAlerta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbEstadoEvento;
    }
}