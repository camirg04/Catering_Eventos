namespace Servicio_Catering.UIAdminstrador
{
    partial class UIAdministrador
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVisualizaUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.tboxInApellido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.tboxInDNI = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTodoEmpleados = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaUsuarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Administración";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(976, 36);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(109, 17);
            this.lblBienvenida.TabIndex = 15;
            this.lblBienvenida.Text = "Nombre usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1141, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sistema Catering Empresa SRL";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 593);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvVisualizaUsuarios);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1264, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVisualizaUsuarios
            // 
            this.dgvVisualizaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisualizaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisualizaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizaUsuarios.Location = new System.Drawing.Point(6, 9);
            this.dgvVisualizaUsuarios.MultiSelect = false;
            this.dgvVisualizaUsuarios.Name = "dgvVisualizaUsuarios";
            this.dgvVisualizaUsuarios.ReadOnly = true;
            this.dgvVisualizaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizaUsuarios.Size = new System.Drawing.Size(956, 552);
            this.dgvVisualizaUsuarios.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnEditarUsuario);
            this.groupBox3.Controls.Add(this.tboxInApellido);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnAgregarUsuario);
            this.groupBox3.Controls.Add(this.tboxInDNI);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnTodoEmpleados);
            this.groupBox3.Location = new System.Drawing.Point(968, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 592);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Enabled = false;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(83, 140);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(117, 23);
            this.btnEditarUsuario.TabIndex = 19;
            this.btnEditarUsuario.Text = "Editar usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // tboxInApellido
            // 
            this.tboxInApellido.Location = new System.Drawing.Point(64, 310);
            this.tboxInApellido.Name = "tboxInApellido";
            this.tboxInApellido.Size = new System.Drawing.Size(154, 23);
            this.tboxInApellido.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Ingrese el apellido:";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(83, 96);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(117, 23);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // tboxInDNI
            // 
            this.tboxInDNI.Location = new System.Drawing.Point(64, 259);
            this.tboxInDNI.Name = "tboxInDNI";
            this.tboxInDNI.Size = new System.Drawing.Size(154, 23);
            this.tboxInDNI.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(97, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ingrese el DNI:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(100, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(97, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Usuarios";
            // 
            // btnTodoEmpleados
            // 
            this.btnTodoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoEmpleados.Location = new System.Drawing.Point(83, 53);
            this.btnTodoEmpleados.Name = "btnTodoEmpleados";
            this.btnTodoEmpleados.Size = new System.Drawing.Size(117, 23);
            this.btnTodoEmpleados.TabIndex = 0;
            this.btnTodoEmpleados.Text = "Usuarios activos";
            this.btnTodoEmpleados.UseVisualStyleBackColor = true;
            this.btnTodoEmpleados.Click += new System.EventHandler(this.btnTodoEmpleados_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1264, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Buscar";
            // 
            // UIAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UIAdministrador";
            this.Text = "UIAdministrador";
            this.Load += new System.EventHandler(this.UIAdministrador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaUsuarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvVisualizaUsuarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tboxInApellido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox tboxInDNI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTodoEmpleados;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Label label2;
    }
}