using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula64
{
    public partial class form_adicionar : Form
    {
        public int num;

        public form_adicionar()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_adicionarVeiculo.Text == "")
            {
                MessageBox.Show("Por favor digite um veiculo");
            }
            else
            {
                tb_listaVeiculos.Text += tb_adicionarVeiculo.Text + ", ";
                tb_adicionarVeiculo.Clear();
                tb_adicionarVeiculo.Focus();
            }
        }

        private void btn_removerTudo_Click(object sender, EventArgs e)
        {
            tb_adicionarVeiculo.Clear();
            tb_listaVeiculos.Clear();
            tb_adicionarVeiculo.Focus();
        }

        private void btn_listaVeiculos_Click(object sender, EventArgs e)
        {
            form_componente Form_componente = new form_componente(tb_listaVeiculos.Text, this);
            Form_componente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
    }
}
