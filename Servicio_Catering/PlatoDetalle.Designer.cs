namespace Servicio_Catering
{
    partial class PlatoDetalle
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
            this.lbMarc = new System.Windows.Forms.Label();
            this.lbNomb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoPlato = new System.Windows.Forms.ComboBox();
            this.cbPlatoActivo = new System.Windows.Forms.ComboBox();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.lbFechaBaja = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbIngredientes = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.btnEditarIngrediente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMarc
            // 
            this.lbMarc.AutoSize = true;
            this.lbMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarc.Location = new System.Drawing.Point(262, 33);
            this.lbMarc.Name = "lbMarc";
            this.lbMarc.Size = new System.Drawing.Size(86, 13);
            this.lbMarc.TabIndex = 11;
            this.lbMarc.Text = "Tipo de plato:";
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(48, 30);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(54, 13);
            this.lbNomb.TabIndex = 9;
            this.lbNomb.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha de baja:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Activo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbTipoPlato
            // 
            this.cbTipoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlato.Enabled = false;
            this.cbTipoPlato.FormattingEnabled = true;
            this.cbTipoPlato.Location = new System.Drawing.Point(354, 30);
            this.cbTipoPlato.Name = "cbTipoPlato";
            this.cbTipoPlato.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPlato.TabIndex = 14;
            // 
            // cbPlatoActivo
            // 
            this.cbPlatoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatoActivo.Enabled = false;
            this.cbPlatoActivo.FormattingEnabled = true;
            this.cbPlatoActivo.Location = new System.Drawing.Point(108, 68);
            this.cbPlatoActivo.Name = "cbPlatoActivo";
            this.cbPlatoActivo.Size = new System.Drawing.Size(121, 21);
            this.cbPlatoActivo.TabIndex = 15;
            this.cbPlatoActivo.SelectedIndexChanged += new System.EventHandler(this.cbPlatoActivo_SelectedIndexChanged);
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Enabled = false;
            this.txtNombrePlato.Location = new System.Drawing.Point(109, 27);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(120, 20);
            this.txtNombrePlato.TabIndex = 16;
            this.txtNombrePlato.TextChanged += new System.EventHandler(this.txtNombrePlato_TextChanged);
            // 
            // lbFechaBaja
            // 
            this.lbFechaBaja.AutoSize = true;
            this.lbFechaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaBaja.Location = new System.Drawing.Point(354, 76);
            this.lbFechaBaja.Name = "lbFechaBaja";
            this.lbFechaBaja.Size = new System.Drawing.Size(75, 13);
            this.lbFechaBaja.TabIndex = 17;
            this.lbFechaBaja.Text = "01/01/2020";
            this.lbFechaBaja.Click += new System.EventHandler(this.lbFechaBaja_Click);
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(12, 117);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(81, 13);
            this.lblIngredientes.TabIndex = 18;
            this.lblIngredientes.Text = "Ingredientes:";
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(15, 133);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(566, 266);
            this.dgvIngredientes.TabIndex = 19;
            this.dgvIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellContentClick);
            this.dgvIngredientes.SelectionChanged += new System.EventHandler(this.dgvIngredientes_SelectionChanged);

            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(586, 262);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(58, 22);
            this.btnEliminarIngrediente.TabIndex = 20;
            this.btnEliminarIngrediente.Text = "Eliminar";
            this.btnEliminarIngrediente.UseVisualStyleBackColor = true;
            this.btnEliminarIngrediente.Visible = false;
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.eliminarPlato_Click);
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPlato.Location = new System.Drawing.Point(15, 436);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(146, 29);
            this.btnEditarPlato.TabIndex = 25;
            this.btnEditarPlato.Text = "Editar Plato";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(600, 436);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 29);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(588, 190);
            this.cbIngredientes.Name = "cbIngredientes";
            this.cbIngredientes.Size = new System.Drawing.Size(158, 21);
            this.cbIngredientes.TabIndex = 30;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(587, 220);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(586, 236);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 20);
            this.txtCantidad.TabIndex = 28;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.Location = new System.Drawing.Point(585, 174);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(75, 13);
            this.lblIngrediente.TabIndex = 27;
            this.lblIngrediente.Text = "Ingrediente:";
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(642, 262);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(61, 22);
            this.btnAgregarIngrediente.TabIndex = 32;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Visible = false;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // btnEditarIngrediente
            // 
            this.btnEditarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarIngrediente.Location = new System.Drawing.Point(700, 262);
            this.btnEditarIngrediente.Name = "btnEditarIngrediente";
            this.btnEditarIngrediente.Size = new System.Drawing.Size(46, 22);
            this.btnEditarIngrediente.TabIndex = 33;
            this.btnEditarIngrediente.Text = "Editar";
            this.btnEditarIngrediente.UseVisualStyleBackColor = true;
            this.btnEditarIngrediente.Visible = false;
            this.btnEditarIngrediente.Click += new System.EventHandler(this.btnEditarIngrediente_Click);
            // 
            // PlatoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 477);
            this.Controls.Add(this.btnEditarIngrediente);
            this.Controls.Add(this.btnAgregarIngrediente);
            this.Controls.Add(this.cbIngredientes);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblIngrediente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditarPlato);
            this.Controls.Add(this.btnEliminarIngrediente);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lbFechaBaja);
            this.Controls.Add(this.txtNombrePlato);
            this.Controls.Add(this.cbPlatoActivo);
            this.Controls.Add(this.cbTipoPlato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMarc);
            this.Controls.Add(this.lbNomb);
            this.Name = "PlatoDetalle";
            this.Text = "PlatoDetalle";
            this.Load += new System.EventHandler(this.PlatoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMarc;
        private System.Windows.Forms.Label lbNomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoPlato;
        private System.Windows.Forms.ComboBox cbPlatoActivo;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.Label lbFechaBaja;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.Button btnEditarIngrediente;
    }
}