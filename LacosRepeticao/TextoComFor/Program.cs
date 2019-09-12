using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = @"Pensando mais a longo prazo, a execução dos pontos do programa estimula a padronização dos modos de operação convencionais. 
O empenho em analisar a constante divulgação das informações acarreta um processo de reformulação e modernização dos relacionamentos verticais entre as hierarquias. 
No entanto, não podemos esquecer que o fenômeno da Internet faz parte de um processo de gerenciamento dos níveis de motivação departamental. 
A certificação de metodologias que nos auxiliam a lidar com o entendimento das metas propostas apresenta tendências no sentido de aprovar a manutenção do sistema de participação geral.
Do mesmo modo, o novo modelo estrutural aqui preconizado garante a contribuição de um grupo importante na determinação do fluxo de informações.
A prática cotidiana prova que o desenvolvimento contínuo de distintas formas de atuação assume importantes posições no estabelecimento das direções preferenciais no sentido do progresso. Neste sentido, o início da atividade geral de formação de atitudes pode nos levar a considerar a reestruturação do sistema de formação de quadros que corresponde às necessidades. As experiências acumuladas demonstram que a revolução dos costumes obstaculiza a apreciação da importância do orçamento setorial.";
            var countFind = 0;
            Console.WriteLine("Encontre a palavra");
            var palavra = Console.ReadLine();
            for (int i = 0; i < (nome.Length - 3); i++)
            //for (int i = 1; i < 5; i++)
            {
                var palavraParaComparar = nome[i].ToString() +
                                          nome[i + 1].ToString() +
                                          nome[i + 2].ToString() +
                                          nome[i + 3].ToString();




                if (palavra == palavraParaComparar)
                    countFind++;
                //var stringBuilder = $"{nome[i - 1]}-{nome[i]}-{nome[i + 1]}";
                //Console.WriteLine(stringBuilder);

                //  if (stringBuilder.Contains("b-i"))
                //    countFind++;

                // Console.WriteLine($"{nome[i - 1]}+{nome[i + 1]}");

                // if ((nome[i - 1] + nome[i].ToString()) == "ab")
                //   countFind++;

            }
            Console.WriteLine($"Total de {palavra}  {countFind}");
            Console.ReadKey();
        }
    }
}

