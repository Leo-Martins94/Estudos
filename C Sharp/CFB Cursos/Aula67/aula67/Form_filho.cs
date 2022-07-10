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
    public partial class Form_filho : Form
    {
        public Form_checkbox form_checkbox;
        public Form_filho()
        {
            InitializeComponent();

            try
            {
                form_checkbox = Application.OpenForms["Form_checkbox"] as Form_checkbox;

                cb_esportivo.Checked = form_checkbox.cb_esportivo.Checked;
                cb_sedan.Checked = form_checkbox.cb_sedan.Checked;
                cb_suv.Checked = form_checkbox.cb_suv.Checked;
                cb_hatch.Checked = form_checkbox.cb_hatch.Checked;
            }
            catch
            {
                MessageBox.Show("Formulario não encontrado revise o codigo");
            }

        }

        private void cb_esportivo_CheckedChanged(object sender, EventArgs e)
        {
            form_checkbox.cb_esportivo.Checked = cb_esportivo.Checked;
        }

        private void cb_suv_CheckedChanged(object sender, EventArgs e)
        {
            form_checkbox.cb_suv.Checked = cb_suv.Checked;
        }

        private void cb_sedan_CheckedChanged(object sender, EventArgs e)
        {
            form_checkbox.cb_sedan.Checked = cb_sedan.Checked;
        }

        private void cb_hatch_CheckedChanged(object sender, EventArgs e)
        {
            form_checkbox.cb_hatch.Checked = cb_hatch.Checked;
        }
    }
}
