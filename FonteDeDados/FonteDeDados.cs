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
                new Alunos() {Nome = "Maria", Idade = 42},
                new Alunos() {Nome = "Manoel", Idade = 34},
                new Alunos() {Nome = "Amanda", Idade = 21},
                new Alunos() {Nome = "Carlos", Idade = 18},
                new Alunos() {Nome = "Alicia", Idade = 15},
            };
            return alunos;
        }
    }
}
