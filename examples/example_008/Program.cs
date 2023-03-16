namespace example_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Conta minhaConta1 = new Conta();
            minhaConta1.codigo = 123;
            minhaConta1.saldo = 1500.0f;
            minhaConta1.tipo = "corrente";
            minhaConta1.dono = "Du";  
             */
            /*
            Conta minhaConta1 = new Conta(123, 1500.0f, 
                                            "corrente", "Du");

            Conta minhaConta2 = new Conta(523432, 1000.0f,
                                           "corrente", "Joao");
            */
            Animal animalExemplo1 = new Animal();
            animalExemplo1.setTamanho(200);
            animalExemplo1.setNome("abed");

            animalExemplo1.Coloracao = "Azul";

            Console.WriteLine(animalExemplo1.getNome());


         }
    }
}