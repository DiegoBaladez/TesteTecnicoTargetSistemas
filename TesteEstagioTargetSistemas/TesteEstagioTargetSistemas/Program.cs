using TesteEstagioTargetSistemas.Questoes;
using TesteEstagioTargetSistemas.Questoes.Numero3.Resolução;
using TesteEstagioTargetSistemas.Testes;

namespace TesteEstagioTargetSistemas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questao 1: " + Numero1.ValorVariavelSoma() + "\n");
            Console.WriteLine("Questao 2: " + Numero2.VerificaSeEhFibo(20) + "\n");
            Console.WriteLine("Questao 3: " + Numero3.GetMenorValorDoMesEmUmDia()+ "\n");
            Console.WriteLine("Questao 3: " + Numero3.GetMaiorValorDoMesEmUmDia() + "\n" );
            Console.WriteLine("Questao 3: " + Numero3.GetNumeroDiasDoMesQueOFaturamentoDiarioFoiMaiorQueAMedia() + "\n");
            Numero4.CalculaPercentualDoFaturamentoDosEstadosEmRelacaoAoTotal();
            Console.WriteLine("Questao 5: " + Numero5.InvertePalavra("amor") + "\n" );


        }
    }
}