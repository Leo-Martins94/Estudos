using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula66
{
    public partial class Form1 : Form
    {
        public int num;
        public Form1()
        {
            InitializeComponent();

            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Por gentileza digite um veiculo");
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
            tb_veiculo.Clear();
            tb_veiculos.Clear();
            tb_veiculo.Focus();
        }

        private void btn_listaVeiculos_Click(object sender, EventArgs e)
        {
            Form_componente form_componente = new Form_componente(tb_veiculos.Text, this);
            form_componente.ShowDialog();
        }

        private void btn_valorDeNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkBox form_checkBox = new Form_checkBox();
            form_checkBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkedListBox form_checkedListBox = new Form_checkedListBox();
            form_checkedListBox.ShowDialog();
        }
    }
}
