
namespace Aula66
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.btn_valorDeNum = new System.Windows.Forms.Button();
            this.btn_listaVeiculos = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(55, 51);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(235, 20);
            this.tb_veiculo.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(307, 51);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(55, 88);
            this.tb_veiculos.Multiline = true;
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.ReadOnly = true;
            this.tb_veiculos.Size = new System.Drawing.Size(327, 338);
            this.tb_veiculos.TabIndex = 3;
            // 
            // btn_valorDeNum
            // 
            this.btn_valorDeNum.Location = new System.Drawing.Point(388, 318);
            this.btn_valorDeNum.Name = "btn_valorDeNum";
            this.btn_valorDeNum.Size = new System.Drawing.Size(102, 23);
            this.btn_valorDeNum.TabIndex = 4;
            this.btn_valorDeNum.Text = "Valor de Num";
            this.btn_valorDeNum.UseVisualStyleBackColor = true;
            this.btn_valorDeNum.Click += new System.EventHandler(this.btn_valorDeNum_Click);
            // 
            // btn_listaVeiculos
            // 
            this.btn_listaVeiculos.Location = new System.Drawing.Point(389, 348);
            this.btn_listaVeiculos.Name = "btn_listaVeiculos";
            this.btn_listaVeiculos.Size = new System.Drawing.Size(101, 23);
            this.btn_listaVeiculos.TabIndex = 5;
            this.btn_listaVeiculos.Text = "Lista de veiculos";
            this.btn_listaVeiculos.UseVisualStyleBackColor = true;
            this.btn_listaVeiculos.Click += new System.EventHandler(this.btn_listaVeiculos_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(389, 378);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(101, 23);
            this.btn_remover.TabIndex = 6;
            this.btn_remover.Text = "remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_listaVeiculos);
            this.Controls.Add(this.btn_valorDeNum);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_valorDeNum;
        private System.Windows.Forms.Button btn_listaVeiculos;
        private System.Windows.Forms.Button btn_remover;
        public System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
    }
}

