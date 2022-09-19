

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("        Ordenação pelo Método Bolha");
            Console.WriteLine();

            int[] vetor = { 5, 3, 2, 4, 7, 1, 0, 6 };

            Program program = new Program();
            int[] resultado = program.OrdenacaoBolha(vetor);

            Console.WriteLine("  Resultado da ordenação: ", vetor);
            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine();
            Console.ReadLine();
        }


        public int[] OrdenacaoBolha(int[] vetor)
        {
            int tamanho = vetor.Length;
            int auxiliar;

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        auxiliar = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = auxiliar;
                    }
                }
            }

            return vetor;
        }
    }
}