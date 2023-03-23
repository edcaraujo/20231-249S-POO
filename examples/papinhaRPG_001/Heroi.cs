using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papinhaRPG_001
{
    internal class Heroi
    {
        public string Nome { get; set; }
        public int Vitalidade { get; set; }
        public int Forca { get; set; }
        public int Inteligencia { get; set; }
        public int Destreza { get; set; }
        public int Vida { get; set; }
        public int MaxVida { get; set; }
        public int Energia { get; set; }
        public int MaxEnergia { get; set; }
        public int Nivel { get; set; }
        public Heroi()
        {
            Nome = "Desconhecido";
            Nivel = 1;
        }
        public void status()
        {
            Console.WriteLine($"===== {Nome} - lvl. {Nivel} (Heroi) ======");
            Console.WriteLine($"Vida: {Vida}/{MaxVida}");
            Console.WriteLine($"Energia: {Energia}/{MaxEnergia}");
            Console.WriteLine($"Forca: {Forca}");
            Console.WriteLine($"Vitalidade: {Vitalidade}");
            Console.WriteLine($"Inteligencia: {Inteligencia}");
            Console.WriteLine($"Destreza: {Destreza}");
            Console.WriteLine("");
        }

        public void atacar(Heroi heroi)
        {
            int dano = ataque() - heroi.defesa();

            Console.WriteLine($"~> {Nome} está atacando {heroi.Nome} com '{dano}' de dano.");
            Console.WriteLine("");

            if (heroi.Vida - dano >= 0)
            {
                heroi.Vida = heroi.Vida - dano;
            }
            else
            {
                heroi.Vida = 0;
            }
        }

        private int ataque()
        {
            return (int)(Forca / 2 + Destreza / 3 + Inteligencia / 5);
        }

        private int defesa()
        {
            return (int)(Vitalidade / 4 + Destreza / 3 + Inteligencia / 5);
        }
    }
}
