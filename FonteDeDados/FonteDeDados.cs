namespace LINQFundamentos.FonteDeDados;
{
    internal class FonteDeDados
    {
        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 256, 512
            };
            return numeros;
        }

        public static List<int> GetListaNegra() 
        {
            List<int> numeros = new List<int>()
            {
                16, 128, 512
            };
            return numeros;
        }

        //public static string[] GetPaises() { }

        public static List<Alunos> GetAlunos() 
        {
            List<Alunos> alunos = new()
            {
                new Alunos() {Nome = "Maria", Idade = 42, Nota = 7, Cursos = new List<string> { "VB.NET", "ASP.NET"} },
                new Alunos() {Nome = "Manoel", Idade = 34, Nota = 6, Cursos = new List < string > { "C#", "EF Core" }},
                new Alunos() {Nome = "Amanda", Idade = 21, Nota = 5, Cursos = new List < string > { "Java", "Node" }},
                new Alunos() {Nome = "Carlos", Idade = 18, Nota = 9, Cursos = new List < string > { "C++", "MongoDB", "Node" }},
                new Alunos() {Nome = "Alicia", Idade = 15, Nota = 4, Cursos = new List < string > { "TypeScript", "React", "Node" }},
            };
            return alunos;
        }

        public static List<Funcionario> GetFuncionario()
        {
            List<Funcionario> funcionario = new()
            {
                new Funcionario() {Nome = "Maria", Idade = 42, Salario = 3190.55m},
                new Funcionario() {Nome = "Manoel", Idade = 34, Salario = 4125.45m},
                new Funcionario() {Nome = "Amanda", Idade = 21, Salario = 5123.99m},
                new Funcionario() {Nome = "Carlos", Idade = 18, Salario = 6200.50m},
                new Funcionario() {Nome = "Alicia", Idade = 15, Salario = 4099.11m},
            };
            return funcionario;
        }
    }
}
