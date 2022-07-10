
namespace aula63
{
    partial class form_principal
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
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.lb_adicionar = new System.Windows.Forms.Label();
            this.btn_listaVeiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(294, 56);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(389, 386);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(87, 23);
            this.btn_remover.TabIndex = 1;
            this.btn_remover.Text = "Remover Tudo";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(137, 91);
            this.tb_veiculos.Multiline = true;
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.ReadOnly = true;
            this.tb_veiculos.Size = new System.Drawing.Size(232, 347);
            this.tb_veiculos.TabIndex = 2;
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(137, 56);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(151, 20);
            this.tb_veiculo.TabIndex = 3;
            // 
            // lb_adicionar
            // 
            this.lb_adicionar.AutoSize = true;
            this.lb_adicionar.Location = new System.Drawing.Point(143, 31);
            this.lb_adicionar.Name = "lb_adicionar";
            this.lb_adicionar.Size = new System.Drawing.Size(102, 13);
            this.lb_adicionar.TabIndex = 4;
            this.lb_adicionar.Text = "Adicione um veiculo";
            // 
            // btn_listaVeiculos
            // 
            this.btn_listaVeiculos.Location = new System.Drawing.Point(389, 415);
            this.btn_listaVeiculos.Name = "btn_listaVeiculos";
            this.btn_listaVeiculos.Size = new System.Drawing.Size(102, 23);
            this.btn_listaVeiculos.TabIndex = 5;
            this.btn_listaVeiculos.Text = "Mostrar Veiculos";
            this.btn_listaVeiculos.UseVisualStyleBackColor = true;
            this.btn_listaVeiculos.Click += new System.EventHandler(this.btn_listaVeiculos_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.btn_listaVeiculos);
            this.Controls.Add(this.lb_adicionar);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.MaximizeBox = false;
            this.Name = "form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "catalogo Genisis Veiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label lb_adicionar;
        private System.Windows.Forms.Button btn_listaVeiculos;
    }
}

