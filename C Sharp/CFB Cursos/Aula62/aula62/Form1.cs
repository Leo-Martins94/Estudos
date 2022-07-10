using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula62
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        private void lb_veiculo_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veiculo");
                tb_veiculo.Focus();
                return;
            }
            else
            {
                tb_listaVeiculos.Text += tb_veiculo.Text + ", ";

                tb_veiculo.Clear();
                tb_veiculo.Focus();
            }
        }

        private void btn_removerTodos_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }
    }
}
