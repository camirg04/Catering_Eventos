namespace Servicio_Catering
{
    partial class DetalleInsumo
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
            this.btnGuardarInsumo = new System.Windows.Forms.Button();
            this.btnEditarInsumo = new System.Windows.Forms.Button();
            this.lbFechaBajaInsumo = new System.Windows.Forms.Label();
            this.tbNombreInsumo = new System.Windows.Forms.TextBox();
            this.lbNomb = new System.Windows.Forms.Label();
            this.cbActivoInsumo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockMinimoInsumo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUnidadMedidaInsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPerecederoInsumo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarInsumo
            // 
            this.btnGuardarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarInsumo.Location = new System.Drawing.Point(437, 278);
            this.btnGuardarInsumo.Name = "btnGuardarInsumo";
            this.btnGuardarInsumo.Size = new System.Drawing.Size(146, 29);
            this.btnGuardarInsumo.TabIndex = 37;
            this.btnGuardarInsumo.Text = "Guardar";
            this.btnGuardarInsumo.UseVisualStyleBackColor = true;
            this.btnGuardarInsumo.Click += new System.EventHandler(this.btnGuardarInsumo_Click);
            // 
            // btnEditarInsumo
            // 
            this.btnEditarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarInsumo.Location = new System.Drawing.Point(12, 278);
            this.btnEditarInsumo.Name = "btnEditarInsumo";
            this.btnEditarInsumo.Size = new System.Drawing.Size(146, 29);
            this.btnEditarInsumo.TabIndex = 36;
            this.btnEditarInsumo.Text = "Editar";
            this.btnEditarInsumo.UseVisualStyleBackColor = true;
            this.btnEditarInsumo.Click += new System.EventHandler(this.btnEditarInsumo_Click);
            // 
            // lbFechaBajaInsumo
            // 
            this.lbFechaBajaInsumo.AutoSize = true;
            this.lbFechaBajaInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaBajaInsumo.Location = new System.Drawing.Point(119, 241);
            this.lbFechaBajaInsumo.Name = "lbFechaBajaInsumo";
            this.lbFechaBajaInsumo.Size = new System.Drawing.Size(75, 13);
            this.lbFechaBajaInsumo.TabIndex = 35;
            this.lbFechaBajaInsumo.Text = "01/01/2020";
            // 
            // tbNombreInsumo
            // 
            this.tbNombreInsumo.Location = new System.Drawing.Point(122, 20);
            this.tbNombreInsumo.Name = "tbNombreInsumo";
            this.tbNombreInsumo.Size = new System.Drawing.Size(120, 20);
            this.tbNombreInsumo.TabIndex = 34;
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(62, 27);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(54, 13);
            this.lbNomb.TabIndex = 28;
            this.lbNomb.Text = "Nombre:";
            // 
            // cbActivoInsumo
            // 
            this.cbActivoInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivoInsumo.FormattingEnabled = true;
            this.cbActivoInsumo.Location = new System.Drawing.Point(122, 201);
            this.cbActivoInsumo.Name = "cbActivoInsumo";
            this.cbActivoInsumo.Size = new System.Drawing.Size(121, 21);
            this.cbActivoInsumo.TabIndex = 33;
            this.cbActivoInsumo.SelectedIndexChanged += new System.EventHandler(this.cbActivoInsumo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha de baja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Activo:";
            // 
            // tbStockMinimoInsumo
            // 
            this.tbStockMinimoInsumo.Location = new System.Drawing.Point(122, 71);
            this.tbStockMinimoInsumo.Name = "tbStockMinimoInsumo";
            this.tbStockMinimoInsumo.Size = new System.Drawing.Size(120, 20);
            this.tbStockMinimoInsumo.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Stock mínimo:";
            // 
            // tbUnidadMedidaInsumo
            // 
            this.tbUnidadMedidaInsumo.Location = new System.Drawing.Point(122, 114);
            this.tbUnidadMedidaInsumo.Name = "tbUnidadMedidaInsumo";
            this.tbUnidadMedidaInsumo.Size = new System.Drawing.Size(120, 20);
            this.tbUnidadMedidaInsumo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Unidad de medida: ";
            // 
            // cbPerecederoInsumo
            // 
            this.cbPerecederoInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerecederoInsumo.FormattingEnabled = true;
            this.cbPerecederoInsumo.Location = new System.Drawing.Point(122, 156);
            this.cbPerecederoInsumo.Name = "cbPerecederoInsumo";
            this.cbPerecederoInsumo.Size = new System.Drawing.Size(121, 21);
            this.cbPerecederoInsumo.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Perecedero:";
            // 
            // DetalleInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 334);
            this.Controls.Add(this.cbPerecederoInsumo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUnidadMedidaInsumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStockMinimoInsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarInsumo);
            this.Controls.Add(this.btnEditarInsumo);
            this.Controls.Add(this.lbFechaBajaInsumo);
            this.Controls.Add(this.tbNombreInsumo);
            this.Controls.Add(this.lbNomb);
            this.Controls.Add(this.cbActivoInsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DetalleInsumo";
            this.Text = "DetalleInsumo";
            this.Load += new System.EventHandler(this.DetalleInsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarInsumo;
        private System.Windows.Forms.Button btnEditarInsumo;
        private System.Windows.Forms.Label lbFechaBajaInsumo;
        private System.Windows.Forms.TextBox tbNombreInsumo;
        private System.Windows.Forms.Label lbNomb;
        private System.Windows.Forms.ComboBox cbActivoInsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockMinimoInsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUnidadMedidaInsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPerecederoInsumo;
        private System.Windows.Forms.Label label5;
    }
}