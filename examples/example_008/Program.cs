 namespace example_008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa("Edu");
            Pessoa p2 = new Pessoa("Maria", 35);
            Pessoa p3 = new Pessoa();

            //p1.altura = -19;
            p1.setAltura(123);
            p1.setAltura(-25);
            p1.Sobrenome = "Araujo";

            p2.setAltura(100);
            p2.setTelefone("999999999");
            // Pessoa p3 = new Pessoa("Desconhecido");

            p1.imprimirInfos();
            p2.imprimirInfos();
            p3.imprimirInfos();








            /*
            Conta minhaConta1 = new Conta();
            minhaConta1.codigo = 123;
            minhaConta1.saldo = 1500.0f;
            minhaConta1.tipo = "corrente";
            minhaConta1.dono = "Du";  
             */

            //        Conta minhaConta1 = new Conta(123, 1500.0f, "corrente", "Du");
            //        Conta minhaConta2 = new Conta(12365);






            /*
            Conta minhaConta1 = new Conta(123, 1500.0f, 
                                            "corrente", "Du");

            Conta minhaConta2 = new Conta(523432, 1000.0f,
                                           "corrente", "Joao");
            */

            /*
            Animal animalExemplo1 = new Animal();
            animalExemplo1.setTamanho(200);
            animalExemplo1.setNome("abed");

            animalExemplo1.Coloracao = "Azul";

            Console.WriteLine(animalExemplo1.getNome());
            */

        }
    }
}