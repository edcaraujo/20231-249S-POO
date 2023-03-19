using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_001
{
    internal class Conta
    {
        public int codigo;
        public float saldo = 1000.0f;
        public string tipo;
        public string dono;

        public Conta()
        {

        }
        public void sacar(float valor)
        {
            saldo -= valor;
        }

        public void depositar(float valor)
        {
            saldo += valor;
        }

        public void transferir(float valor,Conta destino)
        {
            sacar(valor);
            destino.depositar(valor);
        }

        public void imprimirSaldo()
        {
            Console.WriteLine("Olá, "+dono+". Atualmente o seu saldo é de R$ "+saldo+".");
        }
    }
}
