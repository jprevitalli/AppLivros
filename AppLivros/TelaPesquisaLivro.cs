using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLivros
{
    public partial class TelaPesquisaLivro : Form
    {
        public TelaPesquisaLivro()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (tbCodigoLivro.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção!");
                tbCodigoLivro.Focus();
                return;
            }

            SqlConnection Conexao = new SqlConnection(conexao.Conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoLivro", Conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoLivro.Text);
                Conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    tBoxNome.Text = tabelaDados["Nome"].ToString();
                    tBoxAutor.Text = tabelaDados["Autor"].ToString();
                    tBoxEditora.Text = tabelaDados["Editora"].ToString();
                    tBoxPaginas.Text = tabelaDados["Paginas"].ToString();
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tBoxNome.Clear();
                    tBoxAutor.Clear();
                    tBoxEditora.Clear();
                    tBoxPaginas.Clear();

                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar o código", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (Conexao.State != ConnectionState.Closed)
                {
                    Conexao.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexao = new SqlConnection(conexao.Conectar());
            SqlCommand comandos = new SqlCommand("pAlterarLivro", Conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoLivro.Text);
                comandos.Parameters.AddWithValue("@nome", tBoxNome.Text);
                comandos.Parameters.AddWithValue("@autor", tBoxAutor.Text);
                comandos.Parameters.AddWithValue("@editora", tBoxEditora.Text);

                Conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Livro Alterado com sucesso!");

            }
            catch
            {
                MessageBox.Show("Livro não alterado.");
            }
            finally
            {
                if (Conexao.State != ConnectionState.Closed)
                {
                    Conexao.Close();
                }
            }
        }

        private void btnPesqTodosLivro_Click(object sender, EventArgs e)
        {
            SqlConnection Conexao = new SqlConnection(conexao.Conectar());
            SqlCommand comandos = new SqlCommand("pBuscaTudoLivro", Conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            Conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter info = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            info.Fill(table);

            BindingSource dados = new BindingSource();

            dados.DataSource = table;

            dataGridViewLivro.DataSource = dados;
            dataGridViewLivro.Columns[0].HeaderCell.Value = "Código";
            dataGridViewLivro.Columns[1].HeaderCell.Value = "Nome";
            dataGridViewLivro.Columns[2].HeaderCell.Value = "Autor";
            dataGridViewLivro.Columns[3].HeaderCell.Value = "Editora";
            dataGridViewLivro.Columns[4].HeaderCell.Value = "Ano";
            dataGridViewLivro.Columns[5].HeaderCell.Value = "Gênero";
            dataGridViewLivro.Columns[6].HeaderCell.Value = "Páginas";
      


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection Conexao = new SqlConnection(conexao.Conectar());
            SqlCommand comandos = new SqlCommand("pDeletarLivro", Conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoLivro.Text);
                Conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Livro Excluido com sucesso!");
                tBoxNome.Clear();
                tBoxAutor.Clear();
                tBoxEditora.Clear();
                tBoxPaginas.Clear();

            }
            catch
            {
                MessageBox.Show("Livro não Excluido.");
            }
            finally
            {
                if (Conexao.State != ConnectionState.Closed)
                {
                    Conexao.Close();
                }
            }
        }
    }
}
