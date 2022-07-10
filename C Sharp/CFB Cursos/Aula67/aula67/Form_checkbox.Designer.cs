
namespace aula67
{
    partial class Form_checkbox
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
            this.btn_verificar = new System.Windows.Forms.Button();
            this.cb_esportivo = new System.Windows.Forms.CheckBox();
            this.cb_suv = new System.Windows.Forms.CheckBox();
            this.cb_sedan = new System.Windows.Forms.CheckBox();
            this.cb_hatch = new System.Windows.Forms.CheckBox();
            this.btn_abrirFormFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(259, 63);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 71);
            this.btn_verificar.TabIndex = 4;
            this.btn_verificar.Text = "Vetifivar Seleção";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // cb_esportivo
            // 
            this.cb_esportivo.AutoSize = true;
            this.cb_esportivo.Location = new System.Drawing.Point(58, 30);
            this.cb_esportivo.Name = "cb_esportivo";
            this.cb_esportivo.Size = new System.Drawing.Size(70, 17);
            this.cb_esportivo.TabIndex = 0;
            this.cb_esportivo.Text = "Esportivo";
            this.cb_esportivo.UseVisualStyleBackColor = true;
            // 
            // cb_suv
            // 
            this.cb_suv.AutoSize = true;
            this.cb_suv.Location = new System.Drawing.Point(58, 63);
            this.cb_suv.Name = "cb_suv";
            this.cb_suv.Size = new System.Drawing.Size(48, 17);
            this.cb_suv.TabIndex = 1;
            this.cb_suv.Text = "SUV";
            this.cb_suv.UseVisualStyleBackColor = true;
            // 
            // cb_sedan
            // 
            this.cb_sedan.AutoSize = true;
            this.cb_sedan.Location = new System.Drawing.Point(58, 96);
            this.cb_sedan.Name = "cb_sedan";
            this.cb_sedan.Size = new System.Drawing.Size(57, 17);
            this.cb_sedan.TabIndex = 2;
            this.cb_sedan.Text = "Sedan";
            this.cb_sedan.UseVisualStyleBackColor = true;
            // 
            // cb_hatch
            // 
            this.cb_hatch.AutoSize = true;
            this.cb_hatch.Location = new System.Drawing.Point(58, 129);
            this.cb_hatch.Name = "cb_hatch";
            this.cb_hatch.Size = new System.Drawing.Size(55, 17);
            this.cb_hatch.TabIndex = 3;
            this.cb_hatch.Text = "Hatch";
            this.cb_hatch.UseVisualStyleBackColor = true;
            // 
            // btn_abrirFormFilho
            // 
            this.btn_abrirFormFilho.Location = new System.Drawing.Point(247, 154);
            this.btn_abrirFormFilho.Name = "btn_abrirFormFilho";
            this.btn_abrirFormFilho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_abrirFormFilho.Size = new System.Drawing.Size(100, 23);
            this.btn_abrirFormFilho.TabIndex = 5;
            this.btn_abrirFormFilho.Text = "Abrir Form filho";
            this.btn_abrirFormFilho.UseVisualStyleBackColor = true;
            this.btn_abrirFormFilho.Click += new System.EventHandler(this.btn_abrirFormFilho_Click);
            // 
            // Form_checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 239);
            this.Controls.Add(this.btn_abrirFormFilho);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.cb_hatch);
            this.Controls.Add(this.cb_sedan);
            this.Controls.Add(this.cb_suv);
            this.Controls.Add(this.cb_esportivo);
            this.Name = "Form_checkbox";
            this.Text = "Form_checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_verificar;
        public System.Windows.Forms.CheckBox cb_esportivo;
        public System.Windows.Forms.CheckBox cb_suv;
        public System.Windows.Forms.CheckBox cb_sedan;
        public System.Windows.Forms.CheckBox cb_hatch;
        private System.Windows.Forms.Button btn_abrirFormFilho;
    }
}