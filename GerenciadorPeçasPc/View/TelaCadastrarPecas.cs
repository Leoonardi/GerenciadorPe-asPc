using GerenciadorPeçasPc.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPeçasPc.Model
{
    public partial class TelaCadastrarPecas : Form
    {
        public TelaCadastrarPecas()
        {
            InitializeComponent();
        }


        private void btncadastrarpecas_Click(object sender, EventArgs e)
        {
            Pecas.Peca = txtboxpecas.Text;
            Pecas.Marca = txtboxmarcas.Text;
            Pecas.Capacidade = txtboxcapacidades.Text;


            ManipulaPecas mPeca = new ManipulaPecas();
            mPeca.cadPecas();
        }

        public void abrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
