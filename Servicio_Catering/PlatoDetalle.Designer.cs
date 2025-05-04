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
            this.SuspendLayout();
            // 
            // lbMarc
            // 
            this.lbMarc.AutoSize = true;
            this.lbMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarc.Location = new System.Drawing.Point(18, 88);
            this.lbMarc.Name = "lbMarc";
            this.lbMarc.Size = new System.Drawing.Size(86, 13);
            this.lbMarc.TabIndex = 11;
            this.lbMarc.Text = "Tipo de plato:";
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(50, 55);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(54, 13);
            this.lbNomb.TabIndex = 9;
            this.lbNomb.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha de baja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Activo:";
            // 
            // cbTipoPlato
            // 
            this.cbTipoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlato.FormattingEnabled = true;
            this.cbTipoPlato.Location = new System.Drawing.Point(110, 85);
            this.cbTipoPlato.Name = "cbTipoPlato";
            this.cbTipoPlato.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPlato.TabIndex = 14;
            // 
            // cbPlatoActivo
            // 
            this.cbPlatoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatoActivo.FormattingEnabled = true;
            this.cbPlatoActivo.Location = new System.Drawing.Point(110, 114);
            this.cbPlatoActivo.Name = "cbPlatoActivo";
            this.cbPlatoActivo.Size = new System.Drawing.Size(121, 21);
            this.cbPlatoActivo.TabIndex = 15;
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(111, 52);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(120, 20);
            this.txtNombrePlato.TabIndex = 16;
            // 
            // lbFechaBaja
            // 
            this.lbFechaBaja.AutoSize = true;
            this.lbFechaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaBaja.Location = new System.Drawing.Point(110, 150);
            this.lbFechaBaja.Name = "lbFechaBaja";
            this.lbFechaBaja.Size = new System.Drawing.Size(75, 13);
            this.lbFechaBaja.TabIndex = 17;
            this.lbFechaBaja.Text = "01/01/2020";
            // 
            // PlatoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 393);
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
    }
}