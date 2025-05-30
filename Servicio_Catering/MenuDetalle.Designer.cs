namespace Servicio_Catering
{
    partial class MenuDetalle
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
            this.lblFechaBajaMenu = new System.Windows.Forms.Label();
            this.txtNombreMenu = new System.Windows.Forms.TextBox();
            this.cbMenuActivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMarc = new System.Windows.Forms.Label();
            this.lbNomb = new System.Windows.Forms.Label();
            this.txtPrecioMenu = new System.Windows.Forms.TextBox();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.cbPlatoMenu = new System.Windows.Forms.ComboBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.dgvPlatosMenu = new System.Windows.Forms.DataGridView();
            this.lblIngredientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatosMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaBajaMenu
            // 
            this.lblFechaBajaMenu.AutoSize = true;
            this.lblFechaBajaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaBajaMenu.Location = new System.Drawing.Point(408, 73);
            this.lblFechaBajaMenu.Name = "lblFechaBajaMenu";
            this.lblFechaBajaMenu.Size = new System.Drawing.Size(75, 13);
            this.lblFechaBajaMenu.TabIndex = 25;
            this.lblFechaBajaMenu.Text = "01/01/2020";
            // 
            // txtNombreMenu
            // 
            this.txtNombreMenu.Enabled = false;
            this.txtNombreMenu.Location = new System.Drawing.Point(134, 24);
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.Size = new System.Drawing.Size(120, 20);
            this.txtNombreMenu.TabIndex = 24;
            // 
            // cbMenuActivo
            // 
            this.cbMenuActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuActivo.Enabled = false;
            this.cbMenuActivo.FormattingEnabled = true;
            this.cbMenuActivo.Location = new System.Drawing.Point(133, 65);
            this.cbMenuActivo.Name = "cbMenuActivo";
            this.cbMenuActivo.Size = new System.Drawing.Size(121, 21);
            this.cbMenuActivo.TabIndex = 23;
            this.cbMenuActivo.SelectedIndexChanged += new System.EventHandler(this.cbMenuActivo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Activo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de baja:";
            // 
            // lbMarc
            // 
            this.lbMarc.AutoSize = true;
            this.lbMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarc.Location = new System.Drawing.Point(287, 30);
            this.lbMarc.Name = "lbMarc";
            this.lbMarc.Size = new System.Drawing.Size(118, 13);
            this.lbMarc.TabIndex = 19;
            this.lbMarc.Text = "Precio por persona:";
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(73, 27);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(54, 13);
            this.lbNomb.TabIndex = 18;
            this.lbNomb.Text = "Nombre:";
            // 
            // txtPrecioMenu
            // 
            this.txtPrecioMenu.Enabled = false;
            this.txtPrecioMenu.Location = new System.Drawing.Point(411, 24);
            this.txtPrecioMenu.Name = "txtPrecioMenu";
            this.txtPrecioMenu.Size = new System.Drawing.Size(120, 20);
            this.txtPrecioMenu.TabIndex = 26;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPlato.Location = new System.Drawing.Point(642, 227);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(61, 22);
            this.btnAgregarPlato.TabIndex = 43;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Visible = false;
            // 
            // cbPlatoMenu
            // 
            this.cbPlatoMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlatoMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatoMenu.FormattingEnabled = true;
            this.cbPlatoMenu.Location = new System.Drawing.Point(548, 191);
            this.cbPlatoMenu.Name = "cbPlatoMenu";
            this.cbPlatoMenu.Size = new System.Drawing.Size(158, 21);
            this.cbPlatoMenu.TabIndex = 42;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.Location = new System.Drawing.Point(545, 175);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(40, 13);
            this.lblIngrediente.TabIndex = 39;
            this.lblIngrediente.Text = "Plato:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(557, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 29);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(47, 374);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 29);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar Menú";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPlato.Location = new System.Drawing.Point(557, 227);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(58, 22);
            this.btnEliminarPlato.TabIndex = 36;
            this.btnEliminarPlato.Text = "Eliminar";
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            this.btnEliminarPlato.Visible = false;
            // 
            // dgvPlatosMenu
            // 
            this.dgvPlatosMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatosMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatosMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatosMenu.Location = new System.Drawing.Point(42, 134);
            this.dgvPlatosMenu.Name = "dgvPlatosMenu";
            this.dgvPlatosMenu.Size = new System.Drawing.Size(497, 224);
            this.dgvPlatosMenu.TabIndex = 35;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(39, 118);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(46, 13);
            this.lblIngredientes.TabIndex = 34;
            this.lblIngredientes.Text = "Platos:";
            // 
            // MenuDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 423);
            this.Controls.Add(this.btnAgregarPlato);
            this.Controls.Add(this.cbPlatoMenu);
            this.Controls.Add(this.lblIngrediente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminarPlato);
            this.Controls.Add(this.dgvPlatosMenu);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.txtPrecioMenu);
            this.Controls.Add(this.lblFechaBajaMenu);
            this.Controls.Add(this.txtNombreMenu);
            this.Controls.Add(this.cbMenuActivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMarc);
            this.Controls.Add(this.lbNomb);
            this.Name = "MenuDetalle";
            this.Text = "MenuDetalle";
            this.Load += new System.EventHandler(this.MenuDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatosMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaBajaMenu;
        private System.Windows.Forms.TextBox txtNombreMenu;
        private System.Windows.Forms.ComboBox cbMenuActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMarc;
        private System.Windows.Forms.Label lbNomb;
        private System.Windows.Forms.TextBox txtPrecioMenu;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ComboBox cbPlatoMenu;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.DataGridView dgvPlatosMenu;
        private System.Windows.Forms.Label lblIngredientes;
    }
}