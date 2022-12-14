using System;

namespace Hangman_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "dodecahedron";

            //display all gallows
            for (int n = 0; n < 11; n++)
            {
                DrawGallow(n);
                Console.WriteLine(DisplaySecretWord(secretWord));
                Console.ReadLine();
            }
        }

        static string DisplaySecretWord(string word)
        {
            string output = "";
            foreach(char l in word)
            {
                output += " _ ";
            }
            return output;
        }


        public static void DrawGallow(int wrongGuesses)
        {
            //clear screen for new gallow.
            Console.Clear();

            switch (wrongGuesses)
            {
                case 0: Stage0(); break;
                case 1: Stage1(); break;
                case 2: Stage2(); break;
                case 3: Stage3(); break;
                case 4: Stage4(); break;
                case 5: Stage5(); break;
                case 6: Stage6(); break;
                case 7: Stage7(); break;
                case 8: Stage8(); break;
                case 9: Stage9(); break;
                case 10: StageFinal(); break;
            }
        }

        private static void Stage0()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage1()
        {

            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage2()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage3()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage4()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage5()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @      |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage6()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @       @  ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage7()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \'   @ ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage8()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }
        private static void Stage9()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\__~__/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void StageFinal()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    / x x \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\__~__/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }
    }
}
