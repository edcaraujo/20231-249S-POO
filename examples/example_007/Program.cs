namespace example_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = 10;






    

            while (n-- > 0)
            {
                Console.WriteLine("n: "+n);
            }

            int money = 1500; 

            do
            {
                Console.WriteLine("Vamos comprar!");
                money -= 10;
                Console.WriteLine($"Ainda tenho {money}");
                
            }while (money > 1000);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

             

           
 

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} é par");
                }
            }
           
            //while (true)
            //{

                Console.WriteLine("Digite um número:");
                int N = int.Parse(Console.ReadLine());
                bool primo = true;

                for (int i = 2; i < N/2; i++)
                {
                    if (N % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                    Console.WriteLine($"{N} é primo");
                else
                    Console.WriteLine($"{N} NÃO é primo");
            //}
            int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach(int a in lista )
            {
                Console.WriteLine(a);
            }

            int[] lista2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] nomes = new string[100];

            int[,] matriz = { { 1, 2 }, { 2, 3 } };

            nomes.Append("Teste");
            







        }
    }
}