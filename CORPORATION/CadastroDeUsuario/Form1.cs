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
using System.IO;


namespace CadastroDeUsuario
{
    public partial class frmCadastroDeUsuario : Form
    {
        public frmCadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text);
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

        }
        private void SalvarUsuario(string nome, string sobrenome, string email, string telefone)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\usuarios.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine(nome + " - " + sobrenome + " - " + email + " - " + telefone);
            arquivo.Close();

            string bancoDeDados = "server=localhost;user id=root;passoword=;database=bd_corporation";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"insert into tb_usuarios(nome , sobrenome , email , telefone  ) values('{nome}' , '{sobrenome}' , '{email}' , '{telefone}')";
                cmd.ExecuteNonQuery();

                conexao.Close();
                MessageBox.Show("Cadastrado Com Sucesso!!!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados: " + erro.Message);
            }
        }
    }
}
