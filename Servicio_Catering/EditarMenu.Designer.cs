namespace Servicio_Catering
{
    partial class EditarMenu
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
            this.tbPrecioxpersona = new System.Windows.Forms.TextBox();
            this.btnGuardarMenu = new System.Windows.Forms.Button();
            this.btnEditarMenu = new System.Windows.Forms.Button();
            this.lbFechaBaja = new System.Windows.Forms.Label();
            this.tbNombreMenu = new System.Windows.Forms.TextBox();
            this.lbNomb = new System.Windows.Forms.Label();
            this.cbMenuActivo = new System.Windows.Forms.ComboBox();
            this.lbMarc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditarPlatos = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.cbPlatos = new System.Windows.Forms.ComboBox();
            this.lblPlato = new System.Windows.Forms.Label();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.tabIngredientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
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
            this.tabIngredientes.TabIndex = 1;
            this.tabIngredientes.SelectedIndexChanged += new System.EventHandler(this.tabIngredientes_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPrecioxpersona);
            this.tabPage1.Controls.Add(this.btnGuardarMenu);
            this.tabPage1.Controls.Add(this.btnEditarMenu);
            this.tabPage1.Controls.Add(this.lbFechaBaja);
            this.tabPage1.Controls.Add(this.tbNombreMenu);
            this.tabPage1.Controls.Add(this.lbNomb);
            this.tabPage1.Controls.Add(this.cbMenuActivo);
            this.tabPage1.Controls.Add(this.lbMarc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menú";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbPrecioxpersona
            // 
            this.tbPrecioxpersona.Enabled = false;
            this.tbPrecioxpersona.Location = new System.Drawing.Point(146, 107);
            this.tbPrecioxpersona.Name = "tbPrecioxpersona";
            this.tbPrecioxpersona.Size = new System.Drawing.Size(120, 20);
            this.tbPrecioxpersona.TabIndex = 28;
            // 
            // btnGuardarMenu
            // 
            this.btnGuardarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarMenu.Location = new System.Drawing.Point(500, 292);
            this.btnGuardarMenu.Name = "btnGuardarMenu";
            this.btnGuardarMenu.Size = new System.Drawing.Size(146, 29);
            this.btnGuardarMenu.TabIndex = 27;
            this.btnGuardarMenu.Text = "Guardar";
            this.btnGuardarMenu.UseVisualStyleBackColor = true;
            this.btnGuardarMenu.Visible = false;
            this.btnGuardarMenu.Click += new System.EventHandler(this.btnGuardarMenu_Click);
            // 
            // btnEditarMenu
            // 
            this.btnEditarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarMenu.Location = new System.Drawing.Point(27, 292);
            this.btnEditarMenu.Name = "btnEditarMenu";
            this.btnEditarMenu.Size = new System.Drawing.Size(146, 29);
            this.btnEditarMenu.TabIndex = 26;
            this.btnEditarMenu.Text = "Editar";
            this.btnEditarMenu.UseVisualStyleBackColor = true;
            this.btnEditarMenu.Click += new System.EventHandler(this.btnEditarMenu_Click);
            // 
            // lbFechaBaja
            // 
            this.lbFechaBaja.AutoSize = true;
            this.lbFechaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaBaja.Location = new System.Drawing.Point(143, 227);
            this.lbFechaBaja.Name = "lbFechaBaja";
            this.lbFechaBaja.Size = new System.Drawing.Size(75, 13);
            this.lbFechaBaja.TabIndex = 25;
            this.lbFechaBaja.Text = "01/01/2020";
            // 
            // tbNombreMenu
            // 
            this.tbNombreMenu.Enabled = false;
            this.tbNombreMenu.Location = new System.Drawing.Point(146, 41);
            this.tbNombreMenu.Name = "tbNombreMenu";
            this.tbNombreMenu.Size = new System.Drawing.Size(120, 20);
            this.tbNombreMenu.TabIndex = 24;
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(24, 41);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(54, 13);
            this.lbNomb.TabIndex = 18;
            this.lbNomb.Text = "Nombre:";
            // 
            // cbMenuActivo
            // 
            this.cbMenuActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuActivo.Enabled = false;
            this.cbMenuActivo.FormattingEnabled = true;
            this.cbMenuActivo.Location = new System.Drawing.Point(145, 169);
            this.cbMenuActivo.Name = "cbMenuActivo";
            this.cbMenuActivo.Size = new System.Drawing.Size(121, 21);
            this.cbMenuActivo.TabIndex = 23;
            this.cbMenuActivo.SelectedIndexChanged += new System.EventHandler(this.cbMenuActivo_SelectedIndexChanged);
            // 
            // lbMarc
            // 
            this.lbMarc.AutoSize = true;
            this.lbMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarc.Location = new System.Drawing.Point(22, 110);
            this.lbMarc.Name = "lbMarc";
            this.lbMarc.Size = new System.Drawing.Size(118, 13);
            this.lbMarc.TabIndex = 19;
            this.lbMarc.Text = "Precio por persona:";
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
            this.label2.Location = new System.Drawing.Point(23, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Activo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditarPlatos);
            this.tabPage2.Controls.Add(this.btnAgregarPlato);
            this.tabPage2.Controls.Add(this.cbPlatos);
            this.tabPage2.Controls.Add(this.lblPlato);
            this.tabPage2.Controls.Add(this.btnEliminarPlato);
            this.tabPage2.Controls.Add(this.dgvPlatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Platos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditarPlatos
            // 
            this.btnEditarPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPlatos.Location = new System.Drawing.Point(500, 291);
            this.btnEditarPlatos.Name = "btnEditarPlatos";
            this.btnEditarPlatos.Size = new System.Drawing.Size(146, 29);
            this.btnEditarPlatos.TabIndex = 41;
            this.btnEditarPlatos.Text = "Editar";
            this.btnEditarPlatos.UseVisualStyleBackColor = true;
            this.btnEditarPlatos.Click += new System.EventHandler(this.btnEditarPlatos_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPlato.Location = new System.Drawing.Point(488, 66);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(157, 22);
            this.btnAgregarPlato.TabIndex = 39;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Visible = false;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // cbPlatos
            // 
            this.cbPlatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatos.FormattingEnabled = true;
            this.cbPlatos.Location = new System.Drawing.Point(488, 27);
            this.cbPlatos.Name = "cbPlatos";
            this.cbPlatos.Size = new System.Drawing.Size(158, 21);
            this.cbPlatos.TabIndex = 38;
            // 
            // lblPlato
            // 
            this.lblPlato.AutoSize = true;
            this.lblPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlato.Location = new System.Drawing.Point(485, 11);
            this.lblPlato.Name = "lblPlato";
            this.lblPlato.Size = new System.Drawing.Size(36, 13);
            this.lblPlato.TabIndex = 35;
            this.lblPlato.Text = "Plato";
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPlato.Location = new System.Drawing.Point(488, 94);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(157, 22);
            this.btnEliminarPlato.TabIndex = 34;
            this.btnEliminarPlato.Text = "Eliminar";
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            this.btnEliminarPlato.Visible = false;
            this.btnEliminarPlato.Click += new System.EventHandler(this.btnEliminarPlato_Click);
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
            this.dgvPlatos.Size = new System.Drawing.Size(479, 336);
            this.dgvPlatos.TabIndex = 20;
            this.dgvPlatos.SelectionChanged += new System.EventHandler(this.dgvPlatos_SelectionChanged);
            // 
            // EditarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 382);
            this.Controls.Add(this.tabIngredientes);
            this.Name = "EditarMenu";
            this.Text = "EditarMenu";
            this.Load += new System.EventHandler(this.EditarMenu_Load);
            this.tabIngredientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIngredientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGuardarMenu;
        private System.Windows.Forms.Button btnEditarMenu;
        private System.Windows.Forms.Label lbFechaBaja;
        private System.Windows.Forms.TextBox tbNombreMenu;
        private System.Windows.Forms.Label lbNomb;
        private System.Windows.Forms.ComboBox cbMenuActivo;
        private System.Windows.Forms.Label lbMarc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEditarPlatos;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ComboBox cbPlatos;
        private System.Windows.Forms.Label lblPlato;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.TextBox tbPrecioxpersona;
    }
}