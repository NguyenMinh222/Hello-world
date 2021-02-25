using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornaya1
{
    class Words
    {
        private static char[] _RightWord;
        private static char[] _WritedWord;
        private static int _ScoreTry = 0;
        private static char[] _Characters;
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
            if (IsSymbol)
            {
                _ScoreTry++;
                for (int i = 0; i < _Characters.Length; i++)
                {
                    if (symbol == _Characters[i])
                    {
                       _ScoreTry--;
                    }
                }
            }
            char[] TempCharacters = new char [_Characters.Length + 1];
            for (int i = 0; i < _Characters.Length; i++)
            {
                TempCharacters[i] = _Characters[i];                
            }
            _Characters = new char [_Characters.Length + 1];
            _Characters[_Characters.Length - 1] = symbol;

        }
        public static void SeeWord() {
            Console.Clear();
            Console.WriteLine(_WritedWord);
            Console.WriteLine("Score Try = " + _ScoreTry);
        }
        public static void ResetWord ()
        {
            _Characters = new char[1];
            _Characters[0] = ' ';
            string wordd = "hello";
            _RightWord = wordd.ToCharArray();
            _WritedWord = new char[_RightWord.Length];
                        
            for (int i = 0; i < _RightWord.Length; i++)
            {
                _WritedWord[i] = '_';
            }
        }
        public static void CheckGame(ref bool EndGame) {
            int RightSymbols = _RightWord.Length;
            for (int i = 0; i < _RightWord.Length; i++)
            {
          
                if (_RightWord[i] == _WritedWord[i])
                {
                    RightSymbols--;
                    if (RightSymbols == 0)
                    {
                        SeeWord();
                        Console.WriteLine("END GAME!");
                        Console.ReadKey();
                        EndGame = false;
                       
                    }
                }
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
                Words.CheckWord(Console.ReadKey().KeyChar);
                Words.CheckGame(ref EndGame);
            }
        }
    }
}
