using GerenciadorPeçasPc.Controller;
using GerenciadorPeçasPc.Model;
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
    public partial class TelaDeletarPecas : Form
    {
        public TelaDeletarPecas()
        {
            InitializeComponent();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtboxpesquisarcodigo.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();
            
            
            
            

            txtboxcodigo.Text = Pecas.Codigo.ToString();
            txtboxpeca.Text = Pecas.Peca;
            txtboxmarca.Text = Pecas.Marca;
            txtboxcapacidade.Text = Pecas.Capacidade;
        }
        public void AbrirDeletar()
        {
            this.ShowDialog();
            
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtboxcodigo.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.Deletarpecas();

            


        }
    }
}
