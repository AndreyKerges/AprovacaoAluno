using System;

namespace NomeDoNamespace
{
    class NomeDaClasse
    {
        static void Main(string[] args)
        {
            
            double media, nota1, nota2;
            string resultado;

            Console.WriteLine("--- MÉDIA DAS NOTAS ---");
            Console.WriteLine("Digite suas notas abaixo\n");

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            bool notasValidas = nota1 >= 0 && nota1 <=10
                             && nota2 >=0 && nota2 <= 10;

            if (notasValidas)
            {
                media = (nota1 + nota2)/2;
                if (media >= 6)
                {
                    resultado = "Média igual ou  superior à média Mínima (6,0)";
                }
                else
                {
                   resultado = "Média inferior a média mínima (6,0)";
                }
                Console.WriteLine($"Você ficou com a média {media:N1}.\nResultado: {resultado}");    
            }
            else
            {
                Console.WriteLine("Digite notas entre 0 e 10");
            }
        }
    }
}

