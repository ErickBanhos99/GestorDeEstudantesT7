﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace GestorDeEstudantesT7
{
    internal class MeuBancoDeDados
    {
        // A conexão com o banco de dados.
        MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t7");
    }
}