using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_008
{
    internal class Animal
    {
        private int tamanho;
        private int idade;
        private int peso;
        private string nome;
        private string colocaracao;

        public string Coloracao
        {
            get { return colocaracao; }
            set {
                Console.WriteLine("Alterando o dado por Properties");
                colocaracao = value;
            } 
        }

        public Animal(string nome = "Desconhecido")
        {
            this.nome = nome;
        }

        public Animal(string nome, 
            int tamanho, int peso) : this(nome)
        {
            this.tamanho = tamanho;
            this.peso = peso;
        }

        public int getPeso()
        {
            return this.peso;
        }

        public void setPeso(int peso)
        {
            this.peso = peso;
        }

        public int getTamanho()
        {
            return this.tamanho;
        }

        public void setTamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            if (validaNome(nome))
                this.nome = nome;
        }

        public void fazerBarulho()
        {

        }

        public void comer()
        {

        }

        private bool validaNome(string nome)
        {
            /*
            if (nome.StartsWith("ab"))
                return true;
            else 
                return false;
            */
            return nome.StartsWith("ab") ? true : false;
        }

    }
}
