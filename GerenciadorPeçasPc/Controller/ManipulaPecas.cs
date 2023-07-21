using GerenciadorPeçasPc.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPeçasPc.Controller
{
    internal class ManipulaPecas
    {
        public void  cadPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("PcadasatrarPecas",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("marcas",Pecas. Marca);
                cmd.Parameters.AddWithValue("capacidade",Pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("idPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça cadastrada com sucesso, Deseja cadastrar outra peça?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarPecas telaCadastrar = new TelaCadastrarPecas();
                    telaCadastrar.abrirCadastro();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BuscaPecasCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();

              var registros  =   cmd.ExecuteReader();

                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["idpecas"]);
                    Pecas.Peca = (string)registros["pecas"];
                    Pecas.Marca = (string)registros["marcas"];
                    Pecas.Capacidade = (string)registros["capacidade"];

                }

                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisa Código");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletarpecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
                

                var resposta = MessageBox.Show("Peça deletada com sucesso,deseja deletar outra peça?", "Deletar registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaDeletarPecas telaDeletar = new TelaDeletarPecas();
                    telaDeletar.AbrirDeletar();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void alterarpecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("capacidade", Pecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça alterada com sucesso.");
                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade = "";
            }
            catch (Exception)
            {

                throw;
            }

        }


    } 
   
}


