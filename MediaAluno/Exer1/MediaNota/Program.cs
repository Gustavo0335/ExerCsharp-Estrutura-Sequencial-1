using System;

namespace MediaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int media, soma, num1, num2, num3, num4;
            string nomeAluno, nomeProf, materia;

            Console.WriteLine("Digite a Matéria:");
            materia = Console.ReadLine();
            Console.WriteLine("Nome do Professor:");
            nomeProf = Console.ReadLine();
            Console.WriteLine("Nome do Aluno");
            nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota 4");
            num4 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2 + num3 + num4;

            media = soma / 4;

            if(media >= 6)
            {
                Console.WriteLine($"O Aluno:{nomeAluno} na disciplina de {materia}, recebeu acompanhamento do professor(a){nomeProf} e esta Aprovado.");
            }
            if(media < 6)
            {
                Console.WriteLine($"O Aluno:{nomeAluno} na disciplina de {materia}, recebeu acompanhamento do professor(a){nomeProf} e esta Reprovado.");
            }
        }
    }
}
