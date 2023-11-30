namespace ArraysExercicios.Exercicios
{
    internal class Exercicio2
    {
        internal static void Executar2()
        {
            // Solicita ao usuário o tamanho do array de inteiros
            Console.WriteLine("Digite o tamanho do array:");
            int tamanho = ObterNumeroInteiro();

            // Solicita ao usuário os elementos do array de inteiros
            Console.WriteLine("Digite os elementos do array de inteiros (separados por espaço):");
            int[] arrayInt = ConstruirArray<int>(tamanho);
            MostrarArray(arrayInt, "Array de inteiros:");

            // Pausa de 5 segundos
            Thread.Sleep(5000);

            // Solicita ao usuário os elementos do array de strings
            Console.WriteLine("\nDigite os elementos do array de strings (separados por espaço):");
            string[] arrayString = ConstruirArray<string>(tamanho);
            MostrarArray(arrayString, "Array de strings:");

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Ordena e mostra o array de inteiros
            Console.WriteLine("\nArray de inteiros após ordenação:");
            OrdenarArray(arrayInt);
            MostrarArray(arrayInt);

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Ordena e mostra o array de strings
            Console.WriteLine("\nArray de strings após ordenação:");
            OrdenarArray(arrayString);
            MostrarArray(arrayString);

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Calcula e mostra a média dos elementos do array de inteiros
            Console.WriteLine("\nMédia dos elementos do array de inteiros: " + CalcularMedia(arrayInt));

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Encontra e mostra o maior elemento do array de inteiros
            Console.WriteLine("\nMaior elemento do array de inteiros: " + EncontrarMaiorElemento(arrayInt));

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Verifica se o array de inteiros está ordenado
            Console.WriteLine("\nO array de inteiros está ordenado? " + EstaOrdenado(arrayInt));

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Solicita ao usuário o elemento a ser pesquisado no array de inteiros
            Console.WriteLine("\nDigite o elemento a ser pesquisado no array de inteiros:");
            int elementoPesquisado = ObterNumeroInteiro();
            PesquisarElemento(arrayInt, elementoPesquisado);

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Remove elementos duplicados e mostra o array de inteiros
            Console.WriteLine("\nRemovendo elementos duplicados do array de inteiros:");
            RemoverElementosDuplicados(arrayInt);
            MostrarArray(arrayInt, "Array de inteiros sem duplicatas:");

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Inverte e mostra o array de inteiros
            Console.WriteLine("\nArray de inteiros invertido:");
            InverterArray(arrayInt);
            MostrarArray(arrayInt);

            // Pausa de 1 segundo
            Thread.Sleep(1000);

            // Solicita ao usuário o tamanho do segundo array para concatenação
            Console.WriteLine("\nDigite o tamanho do segundo array para concatenação:");
            int tamanhoSegundoArray = ObterNumeroInteiro();
            int[] segundoArray = ConstruirArray<int>(tamanhoSegundoArray);

            // Concatena e mostra os arrays
            int[] arrayConcatenado = ConcatenarArrays(arrayInt, segundoArray);
            MostrarArray(arrayConcatenado, "Arrays concatenados:");

            // Pausa de 1 segundo
            Thread.Sleep(1000);
        }

        // Método para encontrar o maior elemento em cada array, feito com polimorfismo paramêtrico para suportar
        // qualquer tipo primitivo 

        private static T EncontrarMaiorElemento<T>(T[] array) where T : IComparable<T>
        {
            T maiorElemento = array[0];

            foreach (var elemento in array)
            {
                if (elemento.CompareTo(maiorElemento) > 0)
                {
                    maiorElemento = elemento;
                }
            }

            return maiorElemento;
        }

        //Método para inverter array
        private static void InverterArray<T>(T[] array)
        {
            int inicio = 0;
            int fim = array.Length - 1;

            while (inicio < fim)
            {
                T temp = array[inicio];
                array[inicio] = array[fim];
                array[fim] = temp;

                inicio++;
                fim--;
            }
        }

        //Método para verificar se o array está ordenado ou não
        private static bool EstaOrdenado<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        //Método para mostrar arrays
        private static void MostrarArray<T>(T[] array, string mensagem = "Array:")
        {
            Console.WriteLine(mensagem);
            foreach (var elemento in array)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        //Método para ordenar o array
        private static void OrdenarArray<T>(T[] array)
        {
            Array.Sort(array);
        }

        //Método para calcular média
        private static double CalcularMedia<T>(T[] array)
        {
            double soma = 0;

            foreach (dynamic elemento in array)
            {
                soma += elemento;
            }

            return soma / array.Length;
        }

        //Método para obtero array de números
        private static int ObterNumeroInteiro()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número inteiro válido!");
            }

            return numero;
        }

        //Método para a construção de array
        private static T[] ConstruirArray<T>(int tamanho)
        {
            T[] array = new T[tamanho];

            while (true)
            {
                Console.WriteLine($"Digite os {tamanho} elementos do array (separados por espaço):");
                string entrada = Console.ReadLine();

                string[] partes = entrada.Split(' ');

                if (typeof(T) == typeof(int))
                {
                    // Para array de inteiros, validar tamanho e se são inteiros
                    if (partes.Length != tamanho || !ValidarEntradasNumericas(partes))
                    {
                        Console.WriteLine($"A entrada não tem o tamanho indicado pelo usuário ou contém caracteres não numéricos. Repita o processo e coloque a entrada novamente.");
                        continue;
                    }
                }
                else if (typeof(T) == typeof(string))
                {
                    // Para array de strings, validar apenas o tamanho
                    if (partes.Length != tamanho)
                    {
                        Console.WriteLine($"A entrada não tem o tamanho indicado pelo usuário. Repita o processo e coloque a entrada novamente.");
                        continue;
                    }
                }

                for (int i = 0; i < tamanho; i++)
                {
                    array[i] = (T)Convert.ChangeType(partes[i].Trim(), typeof(T));
                }

                break;
            }

            return array;
        }

        //Validar entrada numérica
        private static bool ValidarEntradasNumericas(string[] entradas)
        {
            foreach (var entrada in entradas)
            {
                if (!IsNumeric(entrada))
                {
                    return false;
                }
            }
            return true;
        }

        //Método para verificar se é um numero
        private static bool IsNumeric(string entrada)
        {
            return double.TryParse(entrada, out _);
        }

        //Método para pesquisar elementos em um array
        private static void PesquisarElemento<T>(T[] array, T elemento)
        {
            int indice = Array.IndexOf(array, elemento);

            if (indice != -1)
            {
                Console.WriteLine($"Elemento {elemento} encontrado no índice {indice}.");
            }
            else
            {
                Console.WriteLine($"Elemento {elemento} não encontrado no array.");
            }
        }

        //remover elemento de um array
        private static void RemoverElementosDuplicados<T>(T[] array)
        {
            List<T> listaSemDuplicatas = array.Distinct().ToList();
            listaSemDuplicatas.CopyTo(array);
        }

        //Método para concatenar dois arrays
        private static T[] ConcatenarArrays<T>(T[] array1, T[] array2)
        {
            T[] arrayConcatenado = new T[array1.Length + array2.Length];
            array1.CopyTo(arrayConcatenado, 0);
            array2.CopyTo(arrayConcatenado, array1.Length);
            return arrayConcatenado;
        }
    }
}
