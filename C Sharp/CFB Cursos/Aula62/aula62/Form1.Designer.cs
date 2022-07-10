
namespace aula62
{
    partial class F_principal
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
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.lb_veiculo = new System.Windows.Forms.Label();
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_removerTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(286, 29);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(67, 31);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(213, 20);
            this.tb_veiculo.TabIndex = 1;
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(129, 15);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(78, 13);
            this.lb_veiculo.TabIndex = 2;
            this.lb_veiculo.Text = "Digite um carro";
            this.lb_veiculo.Click += new System.EventHandler(this.lb_veiculo_Click);
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.Location = new System.Drawing.Point(67, 57);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.Size = new System.Drawing.Size(294, 306);
            this.tb_listaVeiculos.TabIndex = 3;
            // 
            // btn_removerTodos
            // 
            this.btn_removerTodos.Location = new System.Drawing.Point(266, 378);
            this.btn_removerTodos.Name = "btn_removerTodos";
            this.btn_removerTodos.Size = new System.Drawing.Size(95, 23);
            this.btn_removerTodos.TabIndex = 4;
            this.btn_removerTodos.Text = "Remover todos";
            this.btn_removerTodos.UseVisualStyleBackColor = true;
            this.btn_removerTodos.Click += new System.EventHandler(this.btn_removerTodos_Click);
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.btn_removerTodos);
            this.Controls.Add(this.tb_listaVeiculos);
            this.Controls.Add(this.lb_veiculo);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - Genisis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.TextBox tb_listaVeiculos;
        private System.Windows.Forms.Button btn_removerTodos;
    }
}

