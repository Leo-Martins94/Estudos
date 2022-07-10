using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula65
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
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Por gentileza infomar um veiculo");
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
            form_componente Form_componente = new form_componente(tb_veiculos.Text, this);
            Form_componente.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkbox form_chebox = new Form_checkbox();

            form_chebox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkedListBox form_checkedListBox = new Form_checkedListBox();

            form_checkedListBox.ShowDialog();

        }
    }
}
