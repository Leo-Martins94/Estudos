using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula67
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Por gentileza digitar um veiculo");
            }
            else
            {
                tb_veiculos.Text += tb_veiculo.Text + ", ";
                tb_veiculo.Clear();
                tb_veiculo.Focus();
            }
        }

        private void btn_removerTudo_Click(object sender, EventArgs e)
        {
            tb_veiculo.Clear();
            tb_veiculos.Clear();
            tb_veiculo.Focus();
        }

        private void btn_veiculosListados_Click(object sender, EventArgs e)
        {
            Form_componente form_componente = new Form_componente(tb_veiculos.Text, this);
            form_componente.ShowDialog();
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkbox form_checkbox = new Form_checkbox();
            form_checkbox.ShowDialog();
        }
    }
}
