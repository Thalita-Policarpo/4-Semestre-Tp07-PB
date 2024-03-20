namespace _4ºSemestre_Tp07_PB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de alunos
            Aluno aluno1 = new Aluno { Nome = "João", Matricula = "123" };
            Aluno aluno2 = new Aluno { Nome = "Maria", Matricula = "456" };

            // Criação de disciplina
            Disciplina disciplina = new Disciplina { Nome = "Matemática", Codigo = "MAT101" };

            // Criação de professor
            Professor professor = new Professor { Nome = "Carlos", Matricula = "789" };

            // Criação de turma
            Turma turma = new Turma { Codigo = "TURMA1", Disciplina = disciplina, Professor = professor };

            // Adicionando alunos à turma
            Console.WriteLine(turma.AddAluno(aluno1));
            Console.WriteLine(turma.AddAluno(aluno2));

            // Tentando abrir a turma
            Console.WriteLine($"A turma pode ser aberta? {turma.AbrirTurma()}");

            // Gerando a pauta
            Console.WriteLine(turma.GerarPauta());
        }
    }

}
