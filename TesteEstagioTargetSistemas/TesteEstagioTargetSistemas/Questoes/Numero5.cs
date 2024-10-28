using System.Text;

namespace TesteEstagioTargetSistemas.Questoes
{
    public static class Numero5
    {
        public static string InvertePalavra(string palavra)
        {
            var stringBuilder = new StringBuilder();

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(palavra[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
