using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15Cadastro
{
    internal class Usuario
    {
        //Atributos
        public string usuario;
        public string senha;

        //Método construtor
        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
