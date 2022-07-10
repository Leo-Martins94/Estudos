
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.btn_txt = new System.Windows.Forms.Button();
            this.lb_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(135, 47);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(246, 20);
            this.txt_texto.TabIndex = 0;
            // 
            // btn_txt
            // 
            this.btn_txt.Location = new System.Drawing.Point(226, 105);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(75, 23);
            this.btn_txt.TabIndex = 1;
            this.btn_txt.Text = "button1";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // lb_txt
            // 
            this.lb_txt.AutoSize = true;
            this.lb_txt.Location = new System.Drawing.Point(249, 181);
            this.lb_txt.Name = "lb_txt";
            this.lb_txt.Size = new System.Drawing.Size(35, 13);
            this.lb_txt.TabIndex = 2;
            this.lb_txt.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_txt);
            this.Controls.Add(this.btn_txt);
            this.Controls.Add(this.txt_texto);
            this.Name = "Form1";
            this.Text = "Form_principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Button btn_txt;
        private System.Windows.Forms.Label lb_txt;
    }
}

