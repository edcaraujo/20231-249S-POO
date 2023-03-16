namespace example_004
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Olá, digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Seu nome é: '" + nome +"'. Tudo bem?");
            Console.WriteLine($"Seu nome é: '{nome}'. Tudo bem?");


            Console.Write("Olá, qual a sua idade: ");
            string txtIdade = Console.ReadLine();

            int idade = Convert.ToInt32(txtIdade);
            int idade2 = int.Parse(txtIdade);

            Console.WriteLine($"Minha idade {idade} e de novo {idade2}");

            Console.Write("Olá, digite sua altura e peso: ");
            
            string[] info = Console.ReadLine().Split();
            int info1 = int.Parse(info[0]);
            int info2 = int.Parse(info[1]);
            Console.WriteLine($"Info: {info1} {info2}");


        }
    }
}