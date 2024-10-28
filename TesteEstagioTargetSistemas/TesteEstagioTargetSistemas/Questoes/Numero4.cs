using System.Diagnostics.Contracts;
using System.Drawing;
using TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Xml;

namespace TesteEstagioTargetSistemas.Questoes
{
    //4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
    //• SP – R$67.836,43
    //• RJ – R$36.678,66
    //• MG – R$29.229,88
    //• ES – R$27.165,48
    //• Outros – R$19.849,53

    //Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.


    public static class Numero4
    {
        private static Dictionary<string, decimal> _estadoFaturamentoDictionary = new Dictionary<string, decimal>()
        {
            {"SP", 67_836.43m},
            {"RJ", 36_678.66m},
            {"MG", 29_229.88m},
            {"ES", 27_165.48m},
            {"Outros", 19_849.53m }
        };

        public static void CalculaPercentualDoFaturamentoDosEstadosEmRelacaoAoTotal()
        {
            var totalDaEmpresa = _estadoFaturamentoDictionary.Sum(x => x.Value);

            foreach(KeyValuePair<string, decimal> estadoFaturamento in _estadoFaturamentoDictionary)
            {
                Console.WriteLine("Questao 4: " + estadoFaturamento.Key + " " +(estadoFaturamento.Value / totalDaEmpresa) * 100 + "%" + "\n");
            }

        }
               
    }
}
