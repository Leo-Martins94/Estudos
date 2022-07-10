
namespace aula64
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
            this.lb_carrolistados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_carrosListados
            // 
            this.tb_carrosListados.Location = new System.Drawing.Point(23, 38);
            this.tb_carrosListados.Multiline = true;
            this.tb_carrosListados.Name = "tb_carrosListados";
            this.tb_carrosListados.Size = new System.Drawing.Size(534, 400);
            this.tb_carrosListados.TabIndex = 0;
            // 
            // lb_carrolistados
            // 
            this.lb_carrolistados.AutoSize = true;
            this.lb_carrolistados.Location = new System.Drawing.Point(255, 9);
            this.lb_carrolistados.Name = "lb_carrolistados";
            this.lb_carrolistados.Size = new System.Drawing.Size(79, 13);
            this.lb_carrolistados.TabIndex = 1;
            this.lb_carrolistados.Text = "Carros Listados";
            // 
            // form_componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.lb_carrolistados);
            this.Controls.Add(this.tb_carrosListados);
            this.Name = "form_componente";
            this.Text = "form_componente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_componente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_carrosListados;
        private System.Windows.Forms.Label lb_carrolistados;
    }
}