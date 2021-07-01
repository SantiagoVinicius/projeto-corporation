using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace AlterarExcluirUsuario
{
    public partial class frmAlterarExcluir : Form
    {
        public frmAlterarExcluir()
        {
            InitializeComponent();
        }

        private void frmAlterarExcluir_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string idUsuario = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;passoword=;database=bd_corporation";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                conexao.Open();
                string sqlBuscar = $"SELECT * FROM tb_usuarios WHERE id={idUsuario}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                txtSobrenome.Text = dt.Rows[0]["sobrenome"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtTelefone.Text = dt.Rows[0]["telefone"].ToString();
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_corporation";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlAlterar = $"UPDATE tb_usuarios set nome='{txtNome.Text}' , sobrenome='{txtSobrenome.Text}' , email='{txtEmail.Text}' , telefone='{txtTelefone.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_corporation";
            string idUsuario = txtID.Text;
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_usuarios WHERE id={idUsuario}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Usuário excluído com Sucesso!");
                txtNome.Clear();
                txtID.Clear();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }
    }
}
