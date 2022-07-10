using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula63
{
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Por favor digite veiculo");
            }
            else
            {
                tb_veiculos.Text += tb_veiculo.Text + ", ";
                tb_veiculo.Clear();
                tb_veiculo.Focus();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            tb_veiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
            tb_veiculo.Focus();
        }

        private void btn_listaVeiculos_Click(object sender, EventArgs e)
        {
            Form_componente form_Componente = new Form_componente(tb_veiculos.Text);
            form_Componente.ShowDialog();
        }
    }
}
