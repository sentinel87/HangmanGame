using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public class Logic
    {
        public int ChancesLeft = 6;
        public int Round = 1;

        public DateTime StartingTime { get; set; }

        public string KeyWord = "hangman";
        public string DisplayedWord = "_______";

        List<string> gameWords { get; set; }
        List<string> selectedWords { get; set; }

        public Logic()
        {
            gameWords = new List<string>();
            selectedWords = new List<string>();
            StartingTime = DateTime.Now;
        }

        public void SetDataSource(List<string>words)
        {
            gameWords = words;
        }

        public bool ResetLogic()
        {
            if (gameWords.Count < 12)
            {
                return false;
            }
            else
            {
                selectedWords = getRoundWords();
            }
            StartingTime = DateTime.Now;
            Round = 1;
            ChancesLeft = 6;
            NextRound();
            return true;
        }

        public string validateChoice(char c, out bool passed, out bool nextRound)
        {
            string result = DisplayedWord;
            nextRound = false;
            List<int> charIdxs = checkChar(c);

            if (charIdxs.Count > 0)
            {
                StringBuilder sb = new StringBuilder(DisplayedWord);
                foreach (int idx in charIdxs)
                {
                    sb[idx] = c;
                }

                DisplayedWord = sb.ToString();

                passed = true;

                if (DisplayedWord == KeyWord)
                {
                    Round++;
                    nextRound = true;
                    result = DisplayedWord;
                }
            }
            else
            {
                ChancesLeft--;
                passed = false;
            }

            return result;
        }

        public void NextRound()
        {
            KeyWord = selectedWords[Round - 1];
            DisplayedWord = "";
            DisplayedWord = DisplayedWord.PadLeft(KeyWord.Length, '_');
            ChancesLeft = 6;
        }

        private List<int> checkChar(char c)
        {
            List<int> charIdxs = new List<int>();
            for (int i = KeyWord.IndexOf(c); i > -1; i = KeyWord.IndexOf(c, i + 1))
            {
                charIdxs.Add(i);
            }

            return charIdxs;
        }

        private List<string> getRoundWords()
        {
            List<string> words = new List<string>();
            List<int> indexes = new List<int>();
            Random rnd = new Random();
            int counter = 0;
            while (counter < 5)
            {
                int idx = rnd.Next(0, gameWords.Count - 1);
                if (indexes.Any(i => i == idx))
                    continue;
                else
                {
                    words.Add(gameWords[idx]);
                    indexes.Add(idx);
                    counter++;
                }
            }

            return words;
        }
    }
}
