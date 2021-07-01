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
using AlterarExcluirUsuario;
using CadastroDeUsuario;

namespace ListagemDeUsuario
{
    public partial class ListagemUsuario : Form
    {
        public ListagemUsuario()
        {
            InitializeComponent();
        }

        private void gridFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListagemUsuario_Load(object sender, EventArgs e)
        {

            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_corporation";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                conexao.Open();
                string sqlSelecionar = "SELECT * FROM tb_usuarios";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridUsuarios.DataSource = dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarExcluir formulario = new frmAlterarExcluir();
            formulario.ShowDialog();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroDeUsuario formulario = new frmCadastroDeUsuario();
            formulario.ShowDialog();
        }
    }
}
