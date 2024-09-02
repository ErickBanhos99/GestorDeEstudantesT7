﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormImprimirAlunos : Form
    {
        public FormImprimirAlunos()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormImprimirAlunos_Load(object sender, EventArgs e)
        {
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

            if (radioButtonNao.Checked == true)
            {
                dateTimePickerDataInicial.Enabled = false;
                dateTimePickerDataFinal.Enabled = false;
            }
        }

        // Metódo que preenche a tabela com os alunos do banco de dados.
        public void preencheTabela(MySqlCommand comando)
        {
            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // Determina uma altura padrão para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            // Determinar qual SERÁ a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;

            // Mostra o total de alunos
            //labelTotalDeAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDataInicial.Enabled = false;
            dateTimePickerDataFinal.Enabled = false;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDataInicial.Enabled = true;
            dateTimePickerDataFinal.Enabled = true;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Salva o arquivo em um arquivo de texto
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/lista_de_estudante.txt";


            using (var escritor = new StreamWriter(caminho))
            {
                // Verifica se ja existe
                if (!File.Exists(caminho))
                {
                    File.Create(caminho);
                }

                DateTime dataDeNascimento;

                for (int i = 0; i < dataGridViewListaDeAlunos.Rows.Count; i++)
                {
                    // Percorre as colunas
                    for (int j = 0; j < dataGridViewListaDeAlunos.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {
                            dataDeNascimento = Convert.ToDateTime(dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString());
                            // Escreve as informações de cada coluna (célula) de uma mesma linha.
                            escritor.Write("\t" +
                                dataDeNascimento.ToString("dd-MM-yyyy")
                                + "\t" + "|");
                        }
                        else if (j == dataGridViewListaDeAlunos.Columns.Count - 2)
                        {
                            escritor.Write("\t" +
                                dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            // Escreve as informações de cada coluna (célula) de uma mesma linha.
                            escritor.Write("\t" +
                                dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString()
                                + "\t" + "|");
                        }
                    }
                    escritor.WriteLine();
                    escritor.WriteLine("-----------------------------------------------------------------------------------------------" +
                        "-------------------------------------------------------------");
                }

                escritor.Close();
                MessageBox.Show("Dados salvos");
            }
        }
    }
}