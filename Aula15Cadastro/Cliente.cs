using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15Cadastro
{
    internal class Cliente
    {
        //Atributos
        public string nome;
        public int idade;
        public Usuario usuario;

        //Método construtor
        public Cliente(string nome, int idade, Usuario usuario) 
        {
            this.nome = nome;
            this.idade = idade;
            this.usuario = usuario;
        }
    }
}
