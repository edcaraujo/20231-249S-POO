namespace example_006
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha:");
            string pwd = Console.ReadLine();

            if (pwd == "123")
            {
                Console.WriteLine("Sério? Vamos mudar a senha!");
            }
            else if (pwd == "patinho22")
            {
                Console.WriteLine("Boa");
            }
            else
            {
                Console.WriteLine("Ainda bem que está errado!");
            }

            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("É par");
            else
                Console.WriteLine("É impar");

            Console.WriteLine((n % 2 == 0 ? "É par" : "É impar"));

            int dia = 0;

            switch (dia)
            {
                case 0:
                    Console.WriteLine("Domingo");
                    break;
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terça");
                    break;

                default:
                    Console.WriteLine("Esse dia não existe");
                    break;
            }




        }
    }
}