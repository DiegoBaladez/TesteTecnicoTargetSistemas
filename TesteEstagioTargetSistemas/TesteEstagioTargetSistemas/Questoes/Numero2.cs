namespace TesteEstagioTargetSistemas.Testes
{
    public static class Numero2
    {
        //2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
        //   escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado
        //   pertence ou não a sequência.
        private static string _pertenceFibo = "O número informado pertence a sequência de fibonacci";
        private static string _naoPertenceFibo = "O número informado não pertence a sequência de fibonacci";
        
        public static string VerificaSeEhFibo(int num)
        {
            var fibonacci = CalculaSequenciaDeFibonacci(num);

            if (fibonacci.Contains(num)) return _pertenceFibo;

            return _naoPertenceFibo;
        }
        
        public static List<int> CalculaSequenciaDeFibonacci(int indice)
        {
            int penultimo = 0;
            int ultimo = 1;
            List<int> fibonacci = new List<int> { penultimo, ultimo };

            if (indice == 0 || indice == 1) return fibonacci;
            
            for (int i = 2; i <= indice; i++)
            {
                int atual = penultimo + ultimo;
                fibonacci.Add(atual);
                penultimo = ultimo;
                ultimo = atual;
            }

            return fibonacci;
        }
    }
}
