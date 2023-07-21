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
    public partial class TelaPesquisaPecas : Form
    {
        public TelaPesquisaPecas()
        {
            InitializeComponent();
        }

        private void btnbuscarcodigo_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtboxcodigo.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            txtboxcodigo.Text = Pecas.Codigo.ToString();
            txtboxpeca.Text = Pecas.Peca;
            txtboxmarca.Text = Pecas.Marca;
            txtboxcapacidade.Text = Pecas.Capacidade;
        }
    }
}
