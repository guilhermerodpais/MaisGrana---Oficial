using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGrana
{
    public partial class frmLancamentos : Form
    {
        public frmLancamentos()
        {
            InitializeComponent();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio formInicio = new frmInicio();
            formInicio.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio formInicio = new frmInicio();
            formInicio.ShowDialog();
        }

        string str = "";
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                txtValor.Text = "";
            }
            if (str.Length == 1)
            {
                txtValor.Text = "0.0" + str;
            }
            else if (str.Length == 2)
            {
                txtValor.Text = "0." + str;
            }
            else if (str.Length > 2)
            {
                txtValor.Text = str.Substring(0, str.Length - 2) + "." +
                                str.Substring(str.Length - 2);
            }
        }

        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
