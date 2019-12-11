using System;
using System.Threading;
using System.Collections.Concurrent;

namespace InputSystem
{
    class Program
    {
        // Criar instancia de uma coleção do tipo consoleKey
        private static BlockingCollection<ConsoleKey> input;
        
        static void Main(string[] args)
        {
            // Criar instancias do tipo thread que aceitam no seu construtor
            // duas funções criadas por nós
            Thread producer = new Thread(ReadKeys);
            Thread consumer = new Thread(DoStuff);

            // Instanciar a coleção para guardar o input do utilizador
            input = new BlockingCollection<ConsoleKey>();

            // Inicializar as threads
            producer.Start();
            consumer.Start();

            // Parar as threads
            producer.Join();
            consumer.Join();

            // Mensagem de obrigada ao acabar o programa
            Console.WriteLine("Obrigada!");
        }

        /// <summary>
        /// Função que lé o input do utilizador enquanto a key não for
        /// a key "Escape"
        /// </summary>
        private static void ReadKeys() 
        {
            ConsoleKey ck;
            do
            {
                ck = Console.ReadKey(true).Key;
                input.Add(ck);

            } while (ck != ConsoleKey.Escape);
        }

        /// <summary>
        /// Metodo que guarda os input do utilizador e imprime a mensagem dada
        /// a essa tecla. Enquanto a tecla de escape não for usada o programa
        /// continua.
        /// </summary>
        private static void DoStuff() 
        {
            ConsoleKey ck;
            while((ck = input.Take()) != ConsoleKey.Escape)
            {
                switch (ck) 
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Cima");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Esquerda");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Direta");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Baixo");
                        break;
                }
            }
            
        }
    }
}
