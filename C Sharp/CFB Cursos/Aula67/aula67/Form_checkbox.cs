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
    public partial class Form_checkbox : Form
    {
        List<CheckBox> veiculos = new List<CheckBox>();
        public Form_checkbox()
        {
            InitializeComponent();
            veiculos.Add(cb_esportivo);
            veiculos.Add(cb_suv);
            veiculos.Add(cb_sedan);
            veiculos.Add(cb_hatch);
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            String txt = "";

            foreach (CheckBox v in veiculos)
            {
                if (v.Checked){
                    txt += v.Text + ", ";
                }
            }

            if (txt == "") {
                MessageBox.Show("Nenhum veiculo selecionado");
            }
            else
            {
                MessageBox.Show(txt);
            }
        }

        private void btn_abrirFormFilho_Click(object sender, EventArgs e)
        {
            Form_filho form_filho = new Form_filho();
            form_filho.ShowDialog();
        }
    }
}
