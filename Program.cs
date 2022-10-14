using System;

namespace pianino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами F1 и F2, чтобы выйти нажми X: ");
            ConsoleKeyInfo vixod = Console.ReadKey();

            while (vixod.Key != ConsoleKey.X)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("это первая октава, чтобы выйти нажми Z");
                    Console.WriteLine("черные клавиши: E T U");
                    Console.WriteLine("белые клавиши: A S D F G H J K L");
                    ConsoleKeyInfo nota = Console.ReadKey();
                    Octava1(nota);
                }

                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("это седьмая октава, чтобы выйти нажми Z");
                    Console.WriteLine("черные клавиши: E T U");
                    Console.WriteLine("белые клавиши: A S D F G H J K L");
                    ConsoleKeyInfo nota2 = Console.ReadKey();
                    octava7(nota2);
                }
            }Console.WriteLine("   <- Вы вышли");
        }

        static void Octava1(ConsoleKeyInfo nota)
        {
           int[] firstOctave = new int[] { 33, 35, 37, 39, 41, 44, 46, 49, 52, 55, 58, 62 };
            while (true)
            {
                if (nota.Key == ConsoleKey.A) zvyk(firstOctave[0]);
                else if (nota.Key == ConsoleKey.S) zvyk(firstOctave[1]);
                else if (nota.Key == ConsoleKey.D) zvyk(firstOctave[2]);
                else if (nota.Key == ConsoleKey.E) zvyk(firstOctave[3]);
                else if (nota.Key == ConsoleKey.G) zvyk(firstOctave[4]);
                else if (nota.Key == ConsoleKey.H) zvyk(firstOctave[5]);
                else if (nota.Key == ConsoleKey.T) zvyk(firstOctave[6]);
                else if (nota.Key == ConsoleKey.K) zvyk(firstOctave[7]);
                else if (nota.Key == ConsoleKey.U) zvyk(firstOctave[8]);
                else if (nota.Key == ConsoleKey.F) zvyk(firstOctave[9]);
                else if (nota.Key == ConsoleKey.J) zvyk(firstOctave[10]);
                else if (nota.Key == ConsoleKey.L) zvyk(firstOctave[11]);
                else if (nota.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    Console.WriteLine("вы вышли из октавы, введите новую");
                }
                else Console.WriteLine("  -> неверная клавиша");
                 nota = Console.ReadKey();   
            }
            Console.WriteLine("  <- Вы вышли из пианино");    
        } 

        static void octava7(ConsoleKeyInfo nota2)
        {
            int[] sevenOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            while(true)
            {
                if (nota2.Key == ConsoleKey.A) zvyk(sevenOctave[0]);
                else if (nota2.Key == ConsoleKey.S) zvyk(sevenOctave[1]);
                else if (nota2.Key == ConsoleKey.D) zvyk(sevenOctave[2]);
                else if (nota2.Key == ConsoleKey.E) zvyk(sevenOctave[3]);
                else if (nota2.Key == ConsoleKey.G) zvyk(sevenOctave[4]);
                else if (nota2.Key == ConsoleKey.H) zvyk(sevenOctave[5]);
                else if (nota2.Key == ConsoleKey.T) zvyk(sevenOctave[6]);
                else if (nota2.Key == ConsoleKey.K) zvyk(sevenOctave[7]);
                else if (nota2.Key == ConsoleKey.U) zvyk(sevenOctave[8]);
                else if (nota2.Key == ConsoleKey.F) zvyk(sevenOctave[9]);
                else if (nota2.Key == ConsoleKey.J) zvyk(sevenOctave[10]);
                else if (nota2.Key == ConsoleKey.L) zvyk(sevenOctave[11]);
                else if (nota2.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    Console.WriteLine("вы вышли из октавы, введите новую");
                }
                else Console.WriteLine("  -> неверная клавиша");
                nota2 = Console.ReadKey();
            }
            Console.WriteLine("  <- Вы вышли из пианино");
        }

        static void zvyk(int perem)
        {
            Console.Beep(perem, 400);
            Console.Clear();
        }
    }
}