namespace Servicio_Catering
{
    partial class EditarPlato
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
            this.tabIngredientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.lbFechaBaja = new System.Windows.Forms.Label();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.lbNomb = new System.Windows.Forms.Label();
            this.cbPlatoActivo = new System.Windows.Forms.ComboBox();
            this.lbMarc = new System.Windows.Forms.Label();
            this.cbTipoPlato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editarIngredientes = new System.Windows.Forms.Button();
            this.btnEditarIngrediente = new System.Windows.Forms.Button();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.cbIngredientes = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.tabIngredientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIngredientes
            // 
            this.tabIngredientes.Controls.Add(this.tabPage1);
            this.tabIngredientes.Controls.Add(this.tabPage2);
            this.tabIngredientes.Location = new System.Drawing.Point(12, 12);
            this.tabIngredientes.Name = "tabIngredientes";
            this.tabIngredientes.SelectedIndex = 0;
            this.tabIngredientes.Size = new System.Drawing.Size(669, 362);
            this.tabIngredientes.TabIndex = 0;
            this.tabIngredientes.SelectedIndexChanged += new System.EventHandler(this.tabIngredientes_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.btnEditarPlato);
            this.tabPage1.Controls.Add(this.lbFechaBaja);
            this.tabPage1.Controls.Add(this.txtNombrePlato);
            this.tabPage1.Controls.Add(this.lbNomb);
            this.tabPage1.Controls.Add(this.cbPlatoActivo);
            this.tabPage1.Controls.Add(this.lbMarc);
            this.tabPage1.Controls.Add(this.cbTipoPlato);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plato";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(500, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 29);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPlato.Location = new System.Drawing.Point(27, 292);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(146, 29);
            this.btnEditarPlato.TabIndex = 26;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click_1);
            // 
            // lbFechaBaja
            // 
            this.lbFechaBaja.AutoSize = true;
            this.lbFechaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaBaja.Location = new System.Drawing.Point(120, 227);
            this.lbFechaBaja.Name = "lbFechaBaja";
            this.lbFechaBaja.Size = new System.Drawing.Size(75, 13);
            this.lbFechaBaja.TabIndex = 25;
            this.lbFechaBaja.Text = "01/01/2020";
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Enabled = false;
            this.txtNombrePlato.Location = new System.Drawing.Point(119, 34);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(120, 20);
            this.txtNombrePlato.TabIndex = 24;
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(23, 37);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(54, 13);
            this.lbNomb.TabIndex = 18;
            this.lbNomb.Text = "Nombre:";
            // 
            // cbPlatoActivo
            // 
            this.cbPlatoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatoActivo.Enabled = false;
            this.cbPlatoActivo.FormattingEnabled = true;
            this.cbPlatoActivo.Location = new System.Drawing.Point(118, 166);
            this.cbPlatoActivo.Name = "cbPlatoActivo";
            this.cbPlatoActivo.Size = new System.Drawing.Size(121, 21);
            this.cbPlatoActivo.TabIndex = 23;
            this.cbPlatoActivo.SelectedIndexChanged += new System.EventHandler(this.cbPlatoActivo_SelectedIndexChanged_1);
            // 
            // lbMarc
            // 
            this.lbMarc.AutoSize = true;
            this.lbMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarc.Location = new System.Drawing.Point(22, 103);
            this.lbMarc.Name = "lbMarc";
            this.lbMarc.Size = new System.Drawing.Size(86, 13);
            this.lbMarc.TabIndex = 19;
            this.lbMarc.Text = "Tipo de plato:";
            // 
            // cbTipoPlato
            // 
            this.cbTipoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlato.Enabled = false;
            this.cbTipoPlato.FormattingEnabled = true;
            this.cbTipoPlato.Location = new System.Drawing.Point(118, 100);
            this.cbTipoPlato.Name = "cbTipoPlato";
            this.cbTipoPlato.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPlato.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de baja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Activo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editarIngredientes);
            this.tabPage2.Controls.Add(this.btnEditarIngrediente);
            this.tabPage2.Controls.Add(this.btnAgregarIngrediente);
            this.tabPage2.Controls.Add(this.cbIngredientes);
            this.tabPage2.Controls.Add(this.lblCantidad);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.lblIngrediente);
            this.tabPage2.Controls.Add(this.btnEliminarIngrediente);
            this.tabPage2.Controls.Add(this.dgvIngredientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingredientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editarIngredientes
            // 
            this.editarIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editarIngredientes.Location = new System.Drawing.Point(500, 291);
            this.editarIngredientes.Name = "editarIngredientes";
            this.editarIngredientes.Size = new System.Drawing.Size(146, 29);
            this.editarIngredientes.TabIndex = 41;
            this.editarIngredientes.Text = "Editar";
            this.editarIngredientes.UseVisualStyleBackColor = true;
            this.editarIngredientes.Click += new System.EventHandler(this.editarIngredientes_Click);
            // 
            // btnEditarIngrediente
            // 
            this.btnEditarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarIngrediente.Location = new System.Drawing.Point(488, 127);
            this.btnEditarIngrediente.Name = "btnEditarIngrediente";
            this.btnEditarIngrediente.Size = new System.Drawing.Size(158, 22);
            this.btnEditarIngrediente.TabIndex = 40;
            this.btnEditarIngrediente.Text = "Editar";
            this.btnEditarIngrediente.UseVisualStyleBackColor = true;
            this.btnEditarIngrediente.Visible = false;
            this.btnEditarIngrediente.Click += new System.EventHandler(this.btnEditarIngrediente_Click_1);
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(489, 99);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(157, 22);
            this.btnAgregarIngrediente.TabIndex = 39;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Visible = false;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click_1);
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(488, 27);
            this.cbIngredientes.Name = "cbIngredientes";
            this.cbIngredientes.Size = new System.Drawing.Size(158, 21);
            this.cbIngredientes.TabIndex = 38;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(486, 57);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 37;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(489, 73);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 20);
            this.txtCantidad.TabIndex = 36;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.Location = new System.Drawing.Point(485, 11);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(75, 13);
            this.lblIngrediente.TabIndex = 35;
            this.lblIngrediente.Text = "Ingrediente:";
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(489, 155);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(157, 22);
            this.btnEliminarIngrediente.TabIndex = 34;
            this.btnEliminarIngrediente.Text = "Eliminar";
            this.btnEliminarIngrediente.UseVisualStyleBackColor = true;
            this.btnEliminarIngrediente.Visible = false;
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.btnEliminarIngrediente_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(0, 0);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(479, 336);
            this.dgvIngredientes.TabIndex = 20;
            this.dgvIngredientes.SelectionChanged += new System.EventHandler(this.dgvIngredientes_SelectionChanged_1);
            // 
            // EditarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 386);
            this.Controls.Add(this.tabIngredientes);
            this.Name = "EditarPlato";
            this.Text = "EditarPlato";
            this.Load += new System.EventHandler(this.EditarPlato_Load);
            this.tabIngredientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIngredientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbFechaBaja;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.Label lbNomb;
        private System.Windows.Forms.ComboBox cbPlatoActivo;
        private System.Windows.Forms.Label lbMarc;
        private System.Windows.Forms.ComboBox cbTipoPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnEditarIngrediente;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.Button editarIngredientes;
    }
}