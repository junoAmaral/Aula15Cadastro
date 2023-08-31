using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15Cadastro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void atualizaInterface()
        {
            listView1.Items.Clear(); 
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                listView1.Items.Add(Program.clientes[i].nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuarioCadast = txtUsuario2.Text;
            string senha = txtSenha2.Text;
            string nome = txtNome.Text;
            int idade = 2023 - int.Parse(txtNascmt.Text);

            Usuario usuario = new Usuario(usuarioCadast, senha);
            Cliente cliente = new Cliente(nome, idade, usuario);
            Program.clientes.Add(cliente);
            atualizaInterface();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            atualizaInterface();
        }
    }
}
