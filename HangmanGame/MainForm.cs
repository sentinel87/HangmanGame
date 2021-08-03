using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangmanGame.Helpers;

namespace HangmanGame
{
    public partial class MainForm : Form
    {
        private IGameDataSource gameDataSource { get; set; }
        int chancesLeft = 6;
        int round = 1;

        string keyWord = "hangman";
        string displayedWord = "_______";

        List<string>gameWords { get; set; }
        List<string>selectedWords { get; set; }


        string[] letters = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"};

        public MainForm()
        {
            InitializeComponent();
            gameDataSource = new JsonHelper();
            gameWords = gameDataSource.GetGameData();
            foreach(string letter in letters)
            {
                Button button = new Button();
                button.Text = letter;
                button.Height = 35;
                button.Width = 35;
                button.Name = "btn" + letter;
                button.Enabled = false;
                button.Click += new EventHandler(btnLetter_Click);
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
                return;

            char c = btn.Name.ToLower().Last();
            btn.Enabled = false;
            validateChoice(c);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            validateChoice('n');
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gameWords.Count<12)
            {
                MessageBox.Show("Game source does not have enough words (12).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                selectedWords = getRoundWords();
            }
            clearGame();
            nextRound();
            round = 1;
        }

        private void validateChoice(char c)
        {
            List<int> charIdxs = checkChar(c);

            if(charIdxs.Count>0)
            {
                StringBuilder sb = new StringBuilder(displayedWord);
                foreach (int idx in charIdxs)
                {
                    sb[idx] = c;
                }

                displayedWord = sb.ToString();

                lblWord.Text = separateChars(displayedWord);

                if (displayedWord==keyWord)
                {
                    round++;
                    clearGame();
                    nextRound();
                    MessageBox.Show("Good job!", "Round passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nextRound();
                }
            }
            else
            {
                chancesLeft--;
                lblChances.Text = chancesLeft.ToString();
                hangmanPictureControl1.DrawHangman(chancesLeft);
                if(chancesLeft==0)
                {
                    MessageBox.Show("Game over!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearGame();
                }
            }
        }

        private void nextRound()
        {
            keyWord = selectedWords[round - 1];
            displayedWord = "";
            displayedWord = displayedWord.PadLeft(keyWord.Length, '_');
            lblWord.Text = separateChars(displayedWord);
        }

        private void clearGame()
        {
            hangmanPictureControl1.ClearPicture();
            chancesLeft = 6;
            lblChances.Text = chancesLeft.ToString();
            lblRound.Text = round.ToString();
            foreach (Control control in flowLayoutPanel1.Controls)
                control.Enabled = true;
        }

        private List<string> getRoundWords()
        {
            List<string> words = new List<string>();
            List<int> indexes = new List<int>();
            Random rnd = new Random();
            int counter = 0;
            while(counter<5)
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

        private List<int> checkChar(char c)
        {
            List<int> charIdxs = new List<int>();
            for (int i = keyWord.IndexOf(c); i > -1; i = keyWord.IndexOf(c, i + 1))
            {
                charIdxs.Add(i);
            }

            return charIdxs;
        }

        private string separateChars(string word)
        {
            string result = "";
            StringBuilder sb = new StringBuilder(word);
            for (int i=0;i<word.Length;i++)
            {
                result += sb[i];
                if (i != word.Length - 1)
                    result += " ";
            }

            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
