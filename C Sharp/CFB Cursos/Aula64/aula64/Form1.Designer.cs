
namespace aula64
{
    partial class form_adicionar
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
            this.btn_listaVeiculos = new System.Windows.Forms.Button();
            this.lb_adicionarVeiculo = new System.Windows.Forms.Label();
            this.btn_removerTudo = new System.Windows.Forms.Button();
            this.tb_adicionarVeiculo = new System.Windows.Forms.TextBox();
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(294, 56);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_listaVeiculos
            // 
            this.btn_listaVeiculos.Location = new System.Drawing.Point(375, 328);
            this.btn_listaVeiculos.Name = "btn_listaVeiculos";
            this.btn_listaVeiculos.Size = new System.Drawing.Size(146, 23);
            this.btn_listaVeiculos.TabIndex = 1;
            this.btn_listaVeiculos.Text = "Mostrar a lista de veiculos";
            this.btn_listaVeiculos.UseVisualStyleBackColor = true;
            this.btn_listaVeiculos.Click += new System.EventHandler(this.btn_listaVeiculos_Click);
            // 
            // lb_adicionarVeiculo
            // 
            this.lb_adicionarVeiculo.AutoSize = true;
            this.lb_adicionarVeiculo.Location = new System.Drawing.Point(96, 33);
            this.lb_adicionarVeiculo.Name = "lb_adicionarVeiculo";
            this.lb_adicionarVeiculo.Size = new System.Drawing.Size(97, 13);
            this.lb_adicionarVeiculo.TabIndex = 2;
            this.lb_adicionarVeiculo.Text = "Adicionar o veiculo";
            // 
            // btn_removerTudo
            // 
            this.btn_removerTudo.Location = new System.Drawing.Point(396, 299);
            this.btn_removerTudo.Name = "btn_removerTudo";
            this.btn_removerTudo.Size = new System.Drawing.Size(98, 23);
            this.btn_removerTudo.TabIndex = 3;
            this.btn_removerTudo.Text = "Remover tudo";
            this.btn_removerTudo.UseVisualStyleBackColor = true;
            this.btn_removerTudo.Click += new System.EventHandler(this.btn_removerTudo_Click);
            // 
            // tb_adicionarVeiculo
            // 
            this.tb_adicionarVeiculo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adicionarVeiculo.Location = new System.Drawing.Point(99, 59);
            this.tb_adicionarVeiculo.Name = "tb_adicionarVeiculo";
            this.tb_adicionarVeiculo.Size = new System.Drawing.Size(179, 20);
            this.tb_adicionarVeiculo.TabIndex = 4;
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.Enabled = false;
            this.tb_listaVeiculos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_listaVeiculos.Location = new System.Drawing.Point(99, 85);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.Size = new System.Drawing.Size(270, 266);
            this.tb_listaVeiculos.TabIndex = 5;
            // 
            // btn_valNum
            // 
            this.btn_valNum.Location = new System.Drawing.Point(407, 256);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(87, 23);
            this.btn_valNum.TabIndex = 6;
            this.btn_valNum.Text = "valor de num";
            this.btn_valNum.UseVisualStyleBackColor = true;
            this.btn_valNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.tb_listaVeiculos);
            this.Controls.Add(this.tb_adicionarVeiculo);
            this.Controls.Add(this.btn_removerTudo);
            this.Controls.Add(this.lb_adicionarVeiculo);
            this.Controls.Add(this.btn_listaVeiculos);
            this.Controls.Add(this.btn_adicionar);
            this.MaximizeBox = false;
            this.Name = "form_adicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_listaVeiculos;
        private System.Windows.Forms.Label lb_adicionarVeiculo;
        private System.Windows.Forms.Button btn_removerTudo;
        private System.Windows.Forms.TextBox tb_adicionarVeiculo;
        private System.Windows.Forms.Button btn_valNum;
        public System.Windows.Forms.TextBox tb_listaVeiculos;
    }
}

