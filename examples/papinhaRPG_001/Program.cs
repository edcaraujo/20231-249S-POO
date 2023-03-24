namespace papinhaRPG_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("##############################");
            Console.WriteLine("Criando jogo...");
            Console.WriteLine("##############################");
            Console.WriteLine("");


            Barbaro brabo = new Barbaro();
            brabo.Nome = "Brabo";
            //brabo.Vida = 1231234;
            //brabo.MaxVida = 1231234;
            brabo.status();

            //UberBarbaro uberBrabo = new UberBarbaro();
            //uberBrabo.Nome = "Sinistro";
            //uberBrabo.status();

            Mago magozin = new Mago();
            magozin.Nome = "Dumbledore";
            //magozin.Vida = 886363;
            //magozin.MaxVida = 886363;
            //magozin.Forca = 500;
            magozin.status();

            Arqueiro archer = new Arqueiro();
            archer.Nome = "Legolas";
            //magozin.Vida = 886363;
            //magozin.MaxVida = 886363;
            //magozin.Forca = 500;
            archer.status();


            List<Heroi> herois = new List<Heroi>();
            herois.Add(brabo);
            herois.Add(magozin);
            herois.Add(archer);

            Console.WriteLine("");
            Console.WriteLine("##############################");
            Console.WriteLine("Iniciando turnos...");
            Console.WriteLine("##############################");
            Console.WriteLine("");

            int turno = 1;
            
            while (!hasWinner(herois))
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Turno #{turno++}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("");

                foreach (Heroi heroi in herois)
                {
                    foreach (Heroi inimigo in herois)
                    {
                        if (heroi != inimigo)
                        {
                            heroi.atacar(inimigo);
                        }
                    }
                }


                brabo.atacar(magozin);
                magozin.atacar(brabo);

                foreach (Heroi heroi in herois)
                {
                    heroi.status();
                }
            }

            showWinner(herois);
        }


        public static bool hasWinner(List<Heroi> herois)
        {
            int alive = 0;

            foreach (Heroi heroi in herois)
            {
                if (heroi.Vida > 0)
                    alive++;
            }

            return (alive == 1);
        }

        public static void showWinner(List<Heroi> herois)
        {
            if (hasWinner(herois))
            {
                foreach (Heroi heroi in herois)
                {
                    if (heroi.Vida > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("##############################");
                        Console.WriteLine("Vencedor...");
                        Console.WriteLine("##############################");
                        Console.WriteLine("");

                        Console.WriteLine("");
                        Console.WriteLine($"\"Respeita a minha história\" ({heroi.Nome})");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        heroi.status();
                    }
                }
            }
        }
    }
}