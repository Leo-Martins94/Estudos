
namespace aula67
{
    partial class Form_componente
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
            this.tb_veiculosListados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_veiculosListados
            // 
            this.tb_veiculosListados.Location = new System.Drawing.Point(38, 87);
            this.tb_veiculosListados.Multiline = true;
            this.tb_veiculosListados.Name = "tb_veiculosListados";
            this.tb_veiculosListados.Size = new System.Drawing.Size(381, 338);
            this.tb_veiculosListados.TabIndex = 0;
            // 
            // Form_componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.tb_veiculosListados);
            this.Name = "Form_componente";
            this.Text = "Form_componente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_componente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_veiculosListados;
    }
}