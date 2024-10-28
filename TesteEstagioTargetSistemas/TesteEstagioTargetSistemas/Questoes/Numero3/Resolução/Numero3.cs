using System.Net.Http.Headers;
using TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Classes;
using TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Xml;

namespace TesteEstagioTargetSistemas.Questoes.Numero3.Resolução
{
    public static class Numero3
    {
        //3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
        //• O menor valor de faturamento ocorrido em um dia do mês;
        //• O maior valor de faturamento ocorrido em um dia do mês;
        //• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

        //IMPORTANTE:
        //a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
        //b) Podem existir dias sem faturamento, como nos finais de semana e feriados.Estes dias devem ser ignorados no cálculo da média;

        public static List<decimal> GetListaDefaturamentoPorDia()
        {
            var basePath = "Adicione o path da pasta que está o programa";
            var path = $"{basePath}\\TesteEstagioTargetSistemas\\TesteEstagioTargetSistemas\\MaterialComplementar\\Faturamento.xml";

            List<decimal> valores = new List<decimal>();
            var faturamento = XmlService.Deserializacao<Faturamento>(path);

            foreach (var dia in faturamento.Mes.Dias)
            {
                if (dia.Total != 0) valores.Add(dia.Total);
            }

            return valores;
        }

        public static string GetMenorValorDoMesEmUmDia()
        {
            return $" O menor valor eh: {GetListaDefaturamentoPorDia().Min()}";

        }

        public static string GetMaiorValorDoMesEmUmDia()
        {
            return $"O maior valor eh: {GetListaDefaturamentoPorDia().Max()}";
        }

        public static int GetNumeroDiasDoMesQueOFaturamentoDiarioFoiMaiorQueAMedia()
        {
            var valores = GetListaDefaturamentoPorDia();

            var total = valores.Sum();

            var media = total / valores.Count;

            var diasAcimaDaMedia = CalculaValoresAcimaDaMedia(media, valores);

            return diasAcimaDaMedia;
        }

        private static int CalculaValoresAcimaDaMedia(decimal media ,List<decimal> valores)
        {
            var diasAcimaDamedia = new List<decimal>();

            foreach (var valor in valores)
            {
                if (valor > media) diasAcimaDamedia.Add(valor);
            }

            return diasAcimaDamedia.Count;
        }
    }
}
