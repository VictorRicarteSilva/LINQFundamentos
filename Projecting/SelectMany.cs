using LINQFundamentos.FonteDeDados;
internal class SelectMany
{
    private static void Main(string[] args)
    {
        // O método SelectMany torna qualquer List<List<T>> em um IEnumerable<T>.
        IEnumerable<string> retornoSelectMany = FonteDeDados.GetAlunos().SelectMany(a => a.Cursos);

        Console.WriteLine("Retorno com SelectMany\n");
        foreach(string str in retornoSelectMany) { Console.WriteLine($"{str} "); }

        // Já o Select, é incapaz de interar uma lista de uma lista de tipo em uma única lista.
        IEnumerable<List<string>> retornoSelect = FonteDeDados.GetAlunos().Select(a => a.Cursos);

        Console.WriteLine("\nRetorno com Select\n");
        // Desconsiderando a crescente complexidade, para percorer cada string de uma lista de uma lista de strings, teriamos de fazer uma uma dupla iteração de loops.
        foreach (List<string> Lstr in retornoSelect)
        {
            foreach (string str in Lstr)
            {
                Console.WriteLine($"{ str} ");
            }
            Console.WriteLine();
        }

        // O método Select gera um valor de resultado para cada valor de origem, enquanto que o SelectMany gera um único valor concatenado de todos os valores de origem.

        // Podemos usar o Distinct para desconsiderar valores repetidos.
        retornoSelectMany = FonteDeDados.GetAlunos().SelectMany(a => a.Cursos).Distinct();

        Console.WriteLine("SelectMany com Distinct\n");
        foreach(string cursos in retornoSelectMany) { Console.WriteLine($"{cursos}"); } 

        Console.ReadKey();
    }
}