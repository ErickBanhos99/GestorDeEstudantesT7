﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form());

            Login_Form formLogin = new Login_Form();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
