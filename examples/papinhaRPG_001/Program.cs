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
            brabo.Vida = 1231234;
            brabo.MaxVida = 1231234;
            brabo.status();

            //UberBarbaro uberBrabo = new UberBarbaro();
            //uberBrabo.Nome = "Sinistro";
            //uberBrabo.status();

            Mago magozin = new Mago();
            magozin.Vida = 886363;
            magozin.MaxVida = 886363;
            magozin.Forca = 500;
            magozin.status();

            Console.WriteLine("");
            Console.WriteLine("##############################");
            Console.WriteLine("Iniciando turnos...");
            Console.WriteLine("##############################");
            Console.WriteLine("");

            int turno = 1;

            while (brabo.Vida > 0 && magozin.Vida > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Turno #{turno++}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("");

                brabo.atacar(magozin);
                magozin.atacar(brabo);

                brabo.status();
                magozin.status();
            }

            if (brabo.Vida == 0)
            {
                Console.WriteLine($"{brabo.Nome} perdeu!");
            }
            else
            {
                Console.WriteLine($"{magozin.Nome} perdeu!");
            }
        }
    }
}