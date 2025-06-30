namespace Servicio_Catering.UIAdminstrador
{
    partial class UIEditarUsuario
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
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tboxClave = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.cboxPerfil = new System.Windows.Forms.ComboBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.tboxDomicilio = new System.Windows.Forms.TextBox();
            this.tboxDni = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(389, 311);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(113, 23);
            this.btnBorrarTodo.TabIndex = 37;
            this.btnBorrarTodo.Text = "Descartar cambios";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(236, 311);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 23);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tboxClave
            // 
            this.tboxClave.Location = new System.Drawing.Point(309, 264);
            this.tboxClave.Name = "tboxClave";
            this.tboxClave.Size = new System.Drawing.Size(121, 20);
            this.tboxClave.TabIndex = 35;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(309, 238);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(121, 20);
            this.tboxEmail.TabIndex = 34;
            // 
            // cboxPerfil
            // 
            this.cboxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPerfil.FormattingEnabled = true;
            this.cboxPerfil.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CHEF",
            "VENDEDOR",
            "GERENTE",
            "LOGISTICA"});
            this.cboxPerfil.Location = new System.Drawing.Point(309, 211);
            this.cboxPerfil.Name = "cboxPerfil";
            this.cboxPerfil.Size = new System.Drawing.Size(121, 21);
            this.cboxPerfil.TabIndex = 33;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(309, 183);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(121, 20);
            this.tboxTelefono.TabIndex = 32;
            // 
            // tboxDomicilio
            // 
            this.tboxDomicilio.Location = new System.Drawing.Point(309, 157);
            this.tboxDomicilio.Name = "tboxDomicilio";
            this.tboxDomicilio.Size = new System.Drawing.Size(121, 20);
            this.tboxDomicilio.TabIndex = 31;
            // 
            // tboxDni
            // 
            this.tboxDni.Location = new System.Drawing.Point(309, 131);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(121, 20);
            this.tboxDni.TabIndex = 30;
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(309, 105);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(121, 20);
            this.tboxApellido.TabIndex = 29;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(251, 188);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(177, 160);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(126, 13);
            this.lblDomicilio.TabIndex = 27;
            this.lblDomicilio.Text = "Domicilio, calle y numero:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(258, 109);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(258, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(274, 134);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 24;
            this.lblDni.Text = "DNI:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(270, 214);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 23;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(266, 267);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 22;
            this.lblClave.Text = "Clave:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(268, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(309, 80);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(121, 20);
            this.tboxNombre.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Edite los datos necesarios y haga clic en aceptar. No debe haber campos vacíos. ";
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Location = new System.Drawing.Point(309, 359);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(121, 32);
            this.btnBajaUsuario.TabIndex = 38;
            this.btnBajaUsuario.Text = "Dar baja de usuario";
            this.btnBajaUsuario.UseVisualStyleBackColor = true;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // UIEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tboxClave);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.cboxPerfil);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.tboxDomicilio);
            this.Controls.Add(this.tboxDni);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.label1);
            this.Name = "UIEditarUsuario";
            this.Text = "Editar usuario";
            this.Load += new System.EventHandler(this.UIEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tboxClave;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.ComboBox cboxPerfil;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.TextBox tboxDomicilio;
        private System.Windows.Forms.TextBox tboxDni;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBajaUsuario;
    }
}