using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Login
{
    public partial class FormEntregas : Form
    {
        public FormEntregas()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formProdutos = new FormProdutos();
            formProdutos.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClientes = new FormClientes();
            formClientes.Show();
        }

        private void buttonPagto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPagamento = new FormPagamento();
            formPagamento.Show();
        }

        private void buttonEntregas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formEntregas = new FormEntregas();
            formEntregas.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
