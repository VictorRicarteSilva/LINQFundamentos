using LINQFundamentos.FonteDeDados;
internal class Select
{
    private static void Main(string[] args)
    {
        // Sintaxe de método
        IEnumerable<Alunos> alunos = FonteDeDados.GetAlunos().ToList();

        Console.WriteLine("Alunos Notas\n");
        foreach (var a in alunos) { Console.WriteLine($"{a.Nome} : {a.Nota}"); }

        // Seleciona Apenas uma propriedade de um objeto.
        IEnumerable<string> nomes = FonteDeDados.GetAlunos().Select(n => n.Nome);

        Console.WriteLine("\nAlunos\n");
        foreach (var a in nomes) { Console.WriteLine(a); }

        // Seleciona um novo formato do mesmo tipo obtendo apenas o Nome e a Nota.
        List<Alunos> lista = FonteDeDados.GetAlunos().Select(a => new Alunos()
                                                      {
                                                            Nome = a.Nome,
                                                            Idade = a.Idade
                                                      }).ToList();

        Console.WriteLine("\nAluno Idade\n");
        foreach (var a in lista) { Console.WriteLine($"{a.Nome} : {a.Idade}"); }


        Console.ReadKey();

    }
}