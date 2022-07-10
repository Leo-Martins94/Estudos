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
    public partial class Form_componente : Form
    {
        Form_principal form_principal;
        public Form_componente(String v , Form_principal fp)
        {
            InitializeComponent();

            form_principal = fp;
            tb_veiculosListados.Text = v;
        }

        private void Form_componente_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_principal.tb_veiculos.Text = tb_veiculosListados.Text;
        }
    }
}
