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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLancamentos_MouseHover(object sender, EventArgs e)
        {
            lblLancamentos.ForeColor = Color.DarkSeaGreen;
        }

        private void lblLancamentos_MouseLeave(object sender, EventArgs e)
        {
            lblLancamentos.ForeColor = Color.Transparent;
        }

        private void lblPlanejamento_MouseHover(object sender, EventArgs e)
        {
            lblPlanejamento.ForeColor = Color.DarkSeaGreen;
        }

        private void lblPlanejamento_MouseLeave(object sender, EventArgs e)
        {
            lblPlanejamento.ForeColor = Color.Transparent;
        }

        private void lblRelatorios_MouseHover(object sender, EventArgs e)
        {
            lblRelatorios.ForeColor = Color.DarkSeaGreen;
        }

        private void lblRelatorios_MouseLeave(object sender, EventArgs e)
        {
            lblRelatorios.ForeColor = Color.Transparent;
        }

        private void lblLancamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLancamentos formLancamentos = new frmLancamentos();
            formLancamentos.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
