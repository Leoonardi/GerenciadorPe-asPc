using GerenciadorPeçasPc.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPeçasPc.Model
{
    public partial class TelaAlterarPecas : Form
    {
        public TelaAlterarPecas()
        {
            InitializeComponent();
        }

        private void btnalterard_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtboxCod.Text);
            Pecas.Peca = txtboxpeca.Text;
            Pecas.Marca = txtboxmarca.Text;
            Pecas.Capacidade = txtboxcapacidade.Text;

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.alterarpecas();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtboxCod.Text);

            txtboxCod.Text = Pecas.Codigo.ToString();
            txtboxpeca.Text = Pecas.Peca;
            txtboxmarca.Text = Pecas.Marca;
            txtboxcapacidade.Text = Pecas.Capacidade;

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();
        }
    }
}
