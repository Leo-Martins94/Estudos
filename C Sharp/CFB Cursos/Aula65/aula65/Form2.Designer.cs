
namespace aula65
{
    partial class form_componente
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
            this.tb_carrosListados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_carrosListados
            // 
            this.tb_carrosListados.Location = new System.Drawing.Point(12, 39);
            this.tb_carrosListados.Multiline = true;
            this.tb_carrosListados.Name = "tb_carrosListados";
            this.tb_carrosListados.Size = new System.Drawing.Size(560, 399);
            this.tb_carrosListados.TabIndex = 0;
            this.tb_carrosListados.TextChanged += new System.EventHandler(this.tb_carrosListados_TextChanged);
            // 
            // form_componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.tb_carrosListados);
            this.Name = "form_componente";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_carrosListados;
    }
}