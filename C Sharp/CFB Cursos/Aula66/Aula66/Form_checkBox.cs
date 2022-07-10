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
    public partial class Form_checkBox : Form
    {
        List<CheckBox> veiculos = new List<CheckBox>();


        public Form_checkBox()
        {
            InitializeComponent();
            veiculos.Add(cb_esportivo);
            veiculos.Add(cb_sedan);
            veiculos.Add(cb_hatch);
            veiculos.Add(cb_suv);
        }

        private void btn_veiculosMarcados_Click(object sender, EventArgs e)
        {
            String txt = "";
           /* if (cb_esportivo.Checked)
            {
                txt += cb_esportivo.Text + ", ";
            }
            if (cb_hatch.Checked)
            {
                txt += cb_hatch.Text + ", ";
            }
            if (cb_sedan.Checked)
            {
                txt += cb_sedan.Text + ", ";
            }
            if (cb_suv.Checked)
            {
                txt += cb_suv.Text + ", ";
            }*/

            foreach (CheckBox v in veiculos)
            {
                if (v.Checked)
                    txt += v.Text + ", ";
            }

            MessageBox.Show(txt);

        }
    }
}
