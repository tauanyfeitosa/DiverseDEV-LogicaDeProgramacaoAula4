using ArraysExercicios.Exercicios;

namespace ArraysExercicios
{
    public class Program
    {
        // Método principal que direciona para diferentes exercícios com base na escolha do usuário
        public static void MetodoPrincipal(int escolha)
        {
            // Verifica a escolha do usuário e chama o método correspondente
            if (escolha == 1)
            {
                // Se a escolha for 1, chama o método Main do Exercício 1
                Exercicio1.Main();
            }
            else if (escolha == 2)
            {
                // Se a escolha for 2, chama o método Executar2 do Exercício 2
                Exercicio2.Executar2();
            }
            else
            {
                // Se a escolha não for nem 1 nem 2, chama o método Executar3 do Exercício 3
                Exercicio3.Executar3();
            }
        }
    }
}
