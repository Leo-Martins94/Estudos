
namespace aula67
{
    partial class Form_principal
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
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.btn_veiculosListados = new System.Windows.Forms.Button();
            this.btn_removerTudo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(65, 56);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(198, 20);
            this.tb_veiculo.TabIndex = 0;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(269, 56);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(65, 85);
            this.tb_veiculos.Multiline = true;
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.Size = new System.Drawing.Size(279, 353);
            this.tb_veiculos.TabIndex = 2;
            // 
            // btn_veiculosListados
            // 
            this.btn_veiculosListados.Location = new System.Drawing.Point(350, 353);
            this.btn_veiculosListados.Name = "btn_veiculosListados";
            this.btn_veiculosListados.Size = new System.Drawing.Size(108, 23);
            this.btn_veiculosListados.TabIndex = 4;
            this.btn_veiculosListados.Text = "Veiculos Listados";
            this.btn_veiculosListados.UseVisualStyleBackColor = true;
            this.btn_veiculosListados.Click += new System.EventHandler(this.btn_veiculosListados_Click);
            // 
            // btn_removerTudo
            // 
            this.btn_removerTudo.Location = new System.Drawing.Point(350, 394);
            this.btn_removerTudo.Name = "btn_removerTudo";
            this.btn_removerTudo.Size = new System.Drawing.Size(108, 23);
            this.btn_removerTudo.TabIndex = 5;
            this.btn_removerTudo.Text = "Remover Tudo";
            this.btn_removerTudo.UseVisualStyleBackColor = true;
            this.btn_removerTudo.Click += new System.EventHandler(this.btn_removerTudo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.btn_removerTudo);
            this.Controls.Add(this.btn_veiculosListados);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_veiculosListados;
        private System.Windows.Forms.Button btn_removerTudo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
    }
}

