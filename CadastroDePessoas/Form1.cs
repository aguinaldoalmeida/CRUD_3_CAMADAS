using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDePessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FAÇO A INSTANCIAÇÃO DO CADASTRO
            Cadastro cad = new Cadastro(txtNome.Text, txtTelefone.Text);

            //INSTANCIO A MENSAGEM EM OUTRA PÁGINA
            MessageBox.Show(cad.mensagem);
        }
    }
}
