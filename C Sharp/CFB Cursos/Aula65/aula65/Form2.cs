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
    public partial class form_componente : Form
    {
        form_adicionar frma;
        public form_componente(String v, form_adicionar fa)
        {
            InitializeComponent();

            tb_carrosListados.Text = v;
            frma = fa;
            fa.num = 10;
            
        }

        private void tb_carrosListados_TextChanged(object sender, EventArgs e)
        {
            frma.tb_veiculos.Text = tb_carrosListados.Text;
        }
    }
}
