using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocacaoBiblioteca.Controller;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var loginDoUsuario = Console.ReadLine();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            var senhaDoUsuario = Console.ReadLine();
        }
    }
}
