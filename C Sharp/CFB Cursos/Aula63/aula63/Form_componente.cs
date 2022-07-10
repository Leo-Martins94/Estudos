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
    public partial class Form_componente : Form
    {
        public Form_componente(String v)
        {
            InitializeComponent();

            tb_listaVeiculos.Text = v;
        }

        private void Form_componente_Load(object sender, EventArgs e)
        {

        }
    }
}
