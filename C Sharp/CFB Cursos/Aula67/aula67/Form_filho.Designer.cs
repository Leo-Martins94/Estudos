
namespace aula67
{
    partial class Form_filho
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
            this.cb_hatch = new System.Windows.Forms.CheckBox();
            this.cb_sedan = new System.Windows.Forms.CheckBox();
            this.cb_suv = new System.Windows.Forms.CheckBox();
            this.cb_esportivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_hatch
            // 
            this.cb_hatch.AutoSize = true;
            this.cb_hatch.Location = new System.Drawing.Point(45, 165);
            this.cb_hatch.Name = "cb_hatch";
            this.cb_hatch.Size = new System.Drawing.Size(55, 17);
            this.cb_hatch.TabIndex = 7;
            this.cb_hatch.Text = "Hatch";
            this.cb_hatch.UseVisualStyleBackColor = true;
            this.cb_hatch.CheckedChanged += new System.EventHandler(this.cb_hatch_CheckedChanged);
            // 
            // cb_sedan
            // 
            this.cb_sedan.AutoSize = true;
            this.cb_sedan.Location = new System.Drawing.Point(45, 132);
            this.cb_sedan.Name = "cb_sedan";
            this.cb_sedan.Size = new System.Drawing.Size(57, 17);
            this.cb_sedan.TabIndex = 6;
            this.cb_sedan.Text = "Sedan";
            this.cb_sedan.UseVisualStyleBackColor = true;
            this.cb_sedan.CheckedChanged += new System.EventHandler(this.cb_sedan_CheckedChanged);
            // 
            // cb_suv
            // 
            this.cb_suv.AutoSize = true;
            this.cb_suv.Location = new System.Drawing.Point(45, 99);
            this.cb_suv.Name = "cb_suv";
            this.cb_suv.Size = new System.Drawing.Size(48, 17);
            this.cb_suv.TabIndex = 5;
            this.cb_suv.Text = "SUV";
            this.cb_suv.UseVisualStyleBackColor = true;
            this.cb_suv.CheckedChanged += new System.EventHandler(this.cb_suv_CheckedChanged);
            // 
            // cb_esportivo
            // 
            this.cb_esportivo.AutoSize = true;
            this.cb_esportivo.Location = new System.Drawing.Point(45, 66);
            this.cb_esportivo.Name = "cb_esportivo";
            this.cb_esportivo.Size = new System.Drawing.Size(70, 17);
            this.cb_esportivo.TabIndex = 4;
            this.cb_esportivo.Text = "Esportivo";
            this.cb_esportivo.UseVisualStyleBackColor = true;
            this.cb_esportivo.CheckedChanged += new System.EventHandler(this.cb_esportivo_CheckedChanged);
            // 
            // Form_filho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.cb_hatch);
            this.Controls.Add(this.cb_sedan);
            this.Controls.Add(this.cb_suv);
            this.Controls.Add(this.cb_esportivo);
            this.Name = "Form_filho";
            this.Text = "Form_filho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_hatch;
        private System.Windows.Forms.CheckBox cb_sedan;
        private System.Windows.Forms.CheckBox cb_suv;
        private System.Windows.Forms.CheckBox cb_esportivo;
    }
}