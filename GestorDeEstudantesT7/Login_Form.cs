using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();

            DataTable tabelaDeDados = new DataTable();

            MySqlCommand comandoSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario`= @nome_de_usuario AND `senha` = @senha", meuBancoDeDados.getConexao);

            comandoSql.Parameters.Add("@nome_de_usuario", MySqlDbType.VarChar).Value = textBoxNome.Text;
            comandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text;

            meuAdaptadorSql.SelectCommand = comandoSql;

            meuAdaptadorSql.Fill(tabelaDeDados); 

            if (tabelaDeDados.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
