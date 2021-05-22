using System;

namespace Labaratornaya1
{
    class Words
    {
        private static char[] _RightWord;
        private static char[] _WritedWord;
        private static int _ScoreTry = 0;
        private static char[] _Characters;
        private static string[] _Words1; 
        public static void CheckWord(char symbol)
        {
            bool IsSymbol = true;
            for (int i = 0; i < _RightWord.Length; i++)
            {
                if (symbol == _RightWord[i])
                {
                    _WritedWord[i] = symbol;
                    IsSymbol = false;
                }
            }
            if (IsSymbol && symbol >= 'a' && symbol <= 'z')
            {
                _ScoreTry++;
                for (int i = 0; i < _Characters.Length; i++)
                {
                    if (symbol == _Characters[i])
                    {
                        _ScoreTry--;
                        return;
                    }
                }
                char[] TempCharacters = new char[_Characters.Length + 1];
                for (int j = 0; j < _Characters.Length; j++)
                {
                    TempCharacters[j] = _Characters[j];
                }
                _Characters = new char[_Characters.Length + 1];
                for (int j = 0; j < _Characters.Length; j++)
                {
                    _Characters[j] = TempCharacters[j];
                }
                _Characters[_Characters.Length - 1] = symbol;
            }
        }
        public static void SeeWord()
        {
            Console.Clear();
            Console.WriteLine(_WritedWord);
            Console.WriteLine("Количество неправильных попыток (8) = " + _ScoreTry);
        }
        public static void ResetWord()
        {
            _Characters = new char[1];
            _Characters[0] = ' ';
            Random rnd = new Random();
            int value = rnd.Next();
            _Words1 = new string[256];
            _Words1[0] = "bubble";
            _Words1[1] = "belarus";
            _Words1[2] = "web";
            _Words1[3] = "constant";
            _Words1[4] = "nguyen";
            _Words1[5] = "babbyshark";
            _Words1[6] = "trouble";
            _Words1[7] = "vietnam";
            _Words1[8] = "programmer";
            _Words1[9] = "bsuir";
            _Words1[10] = "development";
            _Words1[11] = "iphone";
            _RightWord = _Words1[value%7].ToCharArray();
            _WritedWord = new char[_RightWord.Length];
            for (int i = 0; i < _RightWord.Length; i++)
            {
                _WritedWord[i] = '_';
            }
        }
        public static void CheckGame(ref bool EndGame)
        {
            if (_ScoreTry == 8)
            {
                SeeWord();
                Chelovek();
                Console.WriteLine("Вы проиграли!");
                Console.ReadKey();
                EndGame = false;
                return;
            }
            int RightSymbols = _RightWord.Length;
            for (int i = 0; i < _RightWord.Length; i++)
            {
                if (_RightWord[i] == _WritedWord[i])
                {
                    RightSymbols--;
                    if (RightSymbols == 0)
                    {
                        SeeWord();
                        Chelovek();
                        Console.WriteLine("Вы угадали слово!");
                        Console.ReadKey();
                        EndGame = false;
                    }
                }
            }
        }
        public static void Chelovek()
        {
            switch (_ScoreTry)
            {
                case 1:
                    for (int i = 0; i < 6; i++)
                    { 
                        Console.WriteLine("|");
                    }
                   break;
                case 2:
                    Console.WriteLine("_______");
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                case 3:
                    Console.WriteLine("_______");
                    Console.WriteLine("|      |");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                case 4:
                    Console.WriteLine("_______");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      0");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                case 5:
                    Console.WriteLine("_______");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      0");
                    Console.WriteLine("|     /");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                case 6:
                    Console.WriteLine("_______");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      0");
                    Console.WriteLine("|     / \\ ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                case 7:
                    Console.WriteLine("_______");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      0");
                    Console.WriteLine("|     /|\\ ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                case 8:
                    Console.WriteLine("_______");
                    
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      0");
                    Console.WriteLine("|     /|\\ ");
                    Console.WriteLine("|     / \\ ");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("|");
                    }
                    break;
                default: break;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Words.ResetWord();
            bool EndGame = true;
            while (EndGame)
            {
                Words.SeeWord();
                Words.Chelovek();
                Words.CheckWord(Console.ReadKey().KeyChar);
                Words.CheckGame(ref EndGame);
            }
        }
    }
}