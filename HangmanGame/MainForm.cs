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

        string[] letters = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"};

        public MainForm()
        {
            InitializeComponent();
            gameDataSource = new JsonHelper();
            foreach(string letter in letters)
            {
                Button button = new Button();
                button.Text = letter;
                button.Height = 35;
                button.Width = 35;
                button.Name = "btn" + letter;
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
            validateChoice(c);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            validateChoice('n');
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hangmanPictureControl1.ClearPicture();
            chancesLeft = 6;
            lblChances.Text = chancesLeft.ToString();
            round = 1;
            lblRound.Text = round.ToString();
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
                    chancesLeft = 6;
                    keyWord = "hangman";
                    displayedWord = "_______";
                }
            }
            else
            {
                chancesLeft--;
                lblChances.Text = chancesLeft.ToString();
                hangmanPictureControl1.DrawHangman(chancesLeft);
            }
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
    }
}
