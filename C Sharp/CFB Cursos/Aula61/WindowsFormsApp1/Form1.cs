using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            /* string txt;
             txt = txt_texto.Text;
             lb_txt.Text = txt;*/

            lb_txt.Text = txt_texto.Text;
        }
    }
}
