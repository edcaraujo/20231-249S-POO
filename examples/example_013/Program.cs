namespace example_013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Jojojojo";
            pessoa.CPF = "987987987";
            pessoa.RG = "123123123";

            DBPessoa dbPessoa = new DBPessoa();
            dbPessoa.insert(pessoa);

        }
    }
}