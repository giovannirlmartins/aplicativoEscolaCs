using System;
using System.Reflection.Metadata.Ecma335;

namespace escola; //school;

public class Program
{
    static void Main()
    {
        // tipo nomeDaVariavel;
        float nota1, nota2, nota3, media;
        string opcao;        

        List <Professor> professores = new List<Professor>();

        Professor professorAtual = new Professor();

        professorAtual = professorAtual.CadastrarProfessor(professorAtual);
        professores.Add(professorAtual);

        bool estaLogado = professorAtual.Login(professores);

        if(estaLogado == true){
            do{
            
            Console.WriteLine("Bem-Vindo Professor(a) " + professorAtual.nome);
            
            Console.WriteLine("Digite a nota 1 do aluno: ");
            nota1 = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Digite a nota 2 do aluno: ");
            nota2 = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Digite a nota 3 do aluno: ");
            nota3 = float.Parse(Console.ReadLine() ?? "");

            media = (nota1+nota2+nota3)/3;

            Console.WriteLine("A média do aluno é: " + media.ToString("F2"));
            //Console.WriteLine($"A média do aluno é: {media}");
            //Se a media for maior ou igual a 7 = APROVADO, se a media for menor que 7 
            // e maior ou igual a 3 = RECUPERAÇÃO, menor que 3 = REPROVADO

            if (media >= 7)
            {
                Console.WriteLine("Você está APROVADO!");
            }

            else if (media < 7 && media>=3)
            {
                Console.WriteLine("Você está em RECUPERAÇÃO.");
            }
            else
            {
                Console.WriteLine("Você está REPROVADO!");
            }

            Console.WriteLine("Deseja calcular a média de outro aluno?");
            Console.WriteLine("Digite 's' para sim e 'n' para não");
            opcao = Console.ReadLine() ?? "";
            }while(opcao=="s" || opcao=="S");
        }
        
        Console.WriteLine("Não pode acessar a área do aluno. Faça seu login novamente!");
    }
}