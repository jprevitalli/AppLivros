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
    public partial class telaCadLivro : Form
    {
        public telaCadLivro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexao = new SqlConnection(conexao.Conectar());
            SqlCommand comando = new SqlCommand("pCadastrarLivro", Conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", tBoxNome.Text);
                comando.Parameters.AddWithValue("@autor", tBoxAutor.Text);
                comando.Parameters.AddWithValue("@editora", tBoxEditora.Text);
                comando.Parameters.AddWithValue("@ano", dTPickerLivro.Text);
                comando.Parameters.AddWithValue("@genero", listBoxLivro.Text);
                comando.Parameters.AddWithValue("@paginas", tBoxPaginas.Text);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                Conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Livro Cadastrado com Sucesso! Deseja Cadastrar outro Livro ou Sair?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    tBoxNome.Clear();
                    tBoxAutor.Clear();
                    tBoxEditora.Clear();
                    tBoxPaginas.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Livro não Cadastrado!", "Atenção");
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
    }
}
