namespace LINQFundamentos.FonteDeDados;
{
    public class Alunos
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public int Nota { get; set; }
        public List<string> Cursos { get; set; } = new List<string>();
    }
}