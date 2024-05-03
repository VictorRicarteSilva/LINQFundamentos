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

        // Projeção para um tipo anônimo
        var alunosTipoAnonimo = FonteDeDados.GetAlunos().Select(a => new
        {
            NomeAluno = a.Nome,
            IdadeALuno = a.Idade,
            NotaAluno = a.Nota
        }).ToList();

        Console.WriteLine("\nAlunos anônimos\n");
        foreach(var a in alunosTipoAnonimo) { Console.WriteLine($"{a.NomeAluno} : {a.IdadeALuno} : {a.NotaAluno}"); }

        // É possível realizar cálculos com o operador Select
        var funcionarios = FonteDeDados.GetFuncionario().Select(a => new
        {
            NomeFuncionario = a.Nome,
            IdadeFuncionario = a.Idade,
            SalarioAnual = a.Salario * 12
        }).ToList();

        Console.WriteLine("\nFuncionario Idade Salário anual");
        foreach (var a in funcionarios) { Console.WriteLine($"{a.NomeFuncionario} : {a.IdadeFuncionario} : {a.SalarioAnual:C}"); }

        Console.ReadKey();
    }
}