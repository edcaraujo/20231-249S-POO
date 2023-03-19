using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_008
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private string telefone;
        private string sobrenome;

        public string Sobrenome { 
            get { return sobrenome; } 
            set {
                Console.WriteLine("Set por Properties");
                this.sobrenome = value; 
            } 
        }

        public Pessoa(string nome = "Unknow")
        {
            this.nome = nome;
        }

        public Pessoa(string nome, int idade) : this(nome)
        {
            this.idade = idade;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string value)
        {
            this.nome = value;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double altura)
        {
            if (altura > 0)
                this.altura = altura;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void imprimirNome()
        {
            Console.WriteLine($"[ {nome} ]");
        }

        public void imprimirInfos()
        {
            imprimirNome();
            Console.WriteLine($"Idade: {idade}.");
            Console.WriteLine($"Altura: {altura}.");
            Console.WriteLine($"Telefone: {telefone}.");
        }
    }
}
