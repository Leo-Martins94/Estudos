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
    public partial class Form_componente : Form
    {
        Form1 frma;

        public Form_componente(String v , Form1 formadicionar)
        {
            InitializeComponent();

            frma = formadicionar;
            tb_veiculosListados.Text = v;

        }

        private void Form_componente_FormClosed(object sender, FormClosedEventArgs e)
        {
            frma.tb_veiculos.Text = tb_veiculosListados.Text;
        }
    }
}
