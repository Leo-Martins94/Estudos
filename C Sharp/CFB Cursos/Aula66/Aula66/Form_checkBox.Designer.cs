
namespace Aula66
{
    partial class Form_checkBox
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
            this.cb_esportivo = new System.Windows.Forms.CheckBox();
            this.cb_sedan = new System.Windows.Forms.CheckBox();
            this.cb_hatch = new System.Windows.Forms.CheckBox();
            this.cb_suv = new System.Windows.Forms.CheckBox();
            this.btn_veiculosMarcados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_esportivo
            // 
            this.cb_esportivo.AutoSize = true;
            this.cb_esportivo.Location = new System.Drawing.Point(38, 21);
            this.cb_esportivo.Name = "cb_esportivo";
            this.cb_esportivo.Size = new System.Drawing.Size(70, 17);
            this.cb_esportivo.TabIndex = 0;
            this.cb_esportivo.Text = "Esportivo";
            this.cb_esportivo.UseVisualStyleBackColor = true;
            // 
            // cb_sedan
            // 
            this.cb_sedan.AutoSize = true;
            this.cb_sedan.Location = new System.Drawing.Point(38, 44);
            this.cb_sedan.Name = "cb_sedan";
            this.cb_sedan.Size = new System.Drawing.Size(57, 17);
            this.cb_sedan.TabIndex = 1;
            this.cb_sedan.Text = "Sedan";
            this.cb_sedan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cb_sedan.UseVisualStyleBackColor = true;
            // 
            // cb_hatch
            // 
            this.cb_hatch.AutoSize = true;
            this.cb_hatch.Location = new System.Drawing.Point(38, 67);
            this.cb_hatch.Name = "cb_hatch";
            this.cb_hatch.Size = new System.Drawing.Size(55, 17);
            this.cb_hatch.TabIndex = 2;
            this.cb_hatch.Text = "Hatch";
            this.cb_hatch.UseVisualStyleBackColor = true;
            // 
            // cb_suv
            // 
            this.cb_suv.AutoSize = true;
            this.cb_suv.Location = new System.Drawing.Point(38, 90);
            this.cb_suv.Name = "cb_suv";
            this.cb_suv.Size = new System.Drawing.Size(48, 17);
            this.cb_suv.TabIndex = 3;
            this.cb_suv.Text = "SUV";
            this.cb_suv.UseVisualStyleBackColor = true;
            // 
            // btn_veiculosMarcados
            // 
            this.btn_veiculosMarcados.Location = new System.Drawing.Point(196, 110);
            this.btn_veiculosMarcados.Name = "btn_veiculosMarcados";
            this.btn_veiculosMarcados.Size = new System.Drawing.Size(157, 23);
            this.btn_veiculosMarcados.TabIndex = 4;
            this.btn_veiculosMarcados.Text = "Veiculos Marcados";
            this.btn_veiculosMarcados.UseVisualStyleBackColor = true;
            this.btn_veiculosMarcados.Click += new System.EventHandler(this.btn_veiculosMarcados_Click);
            // 
            // Form_checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.btn_veiculosMarcados);
            this.Controls.Add(this.cb_suv);
            this.Controls.Add(this.cb_hatch);
            this.Controls.Add(this.cb_sedan);
            this.Controls.Add(this.cb_esportivo);
            this.Name = "Form_checkBox";
            this.Text = "Form_checkBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_esportivo;
        private System.Windows.Forms.CheckBox cb_sedan;
        private System.Windows.Forms.CheckBox cb_hatch;
        private System.Windows.Forms.CheckBox cb_suv;
        private System.Windows.Forms.Button btn_veiculosMarcados;
    }
}