using LINQFundamentos.FonteDeDados;
internal class Where
{
    private static void Main(string[] args)
    {
        // Usando var para simplificar as instanciações de objetos List<int>
        var numeros = FonteDeDados.GetNumeros();

        // A clausura Where sempre espera por uma função que retorna um bool, mas usamos uma expresão lambda para delegar essa função.
        var resultado1 = numeros.Where(n => n < 10);

        // A expressão lambda pode ter baixa ou alta complexidade na sua definição
        var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

        // 16 128 512
        var listaNegra = FonteDeDados.GetListaNegra();

        // Dentro das expressões lambda podemos utilizar de métodos implementados pelas classes cujo os objetos representados dentro da expressão os implemente como por exemplo o Contains da classe List
        var resultado3 = numeros.Where(n => !listaNegra.Contains(n));

        // Lazy execution exemplo - resultado só é mostrado quando todos os Where forem executados
        var resultado4 = numeros.Where(n => n>1)
                                .Where(n => n > 4)
                                .Where(n => n > 20);

        Console.WriteLine("Resultado 1: " + String.Join(" ", resultado1));
        Console.WriteLine("Resultado 2: " + String.Join(" ", resultado2));
        Console.WriteLine("Resultado 3: " + String.Join(" ", resultado3));
        Console.WriteLine("Resultado 4: " + String.Join(" ", resultado4));

        //Trabalhando com objetos complexos
        Console.WriteLine("\nTrabalhando com objetos complexos \n");

        // lista de objetos do tipo Aluno
        var alunos = FonteDeDados.GetAlunos();

        // Dentro das expressões podemos utilizar das propriedades e campos dos objetos representados pela expressão
        var resultado5 = alunos.Where(a => a.Nome.StartsWith('A') && a.Idade < 18);

        foreach (var aluno in resultado5) { Console.WriteLine(aluno.Nome + " : " + aluno.Idade); }

        // Para comparação segue uma solução para a mesma filtragem usando linguagem de consulta(SQL) ao invés de uma expressão lambda 
        var filtro = from a in alunos
                     where a.Nome.StartsWith('A') && a.Idade < 18
                     select a;

        Console.WriteLine("\nUsando SQL\n");

        foreach (var aluno  in filtro) { Console.WriteLine(aluno.Nome + " : " + aluno.Idade); }

        Console.ReadKey();

    }
}