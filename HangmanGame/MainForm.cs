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
        Logic logic { get; set; }
        private IGameDataSource gameDataSource { get; set; }

        string[] letters = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"};

        public MainForm()
        {
            InitializeComponent();
            gameDataSource = new JsonHelper();
            logic = new Logic();
            logic.SetDataSource(gameDataSource.GetGameData());
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
            bool passed = false;
            bool next = false;
            lblWord.Text = logic.validateChoice(c, out passed, out next);

            if (passed == false)
                hangmanPictureControl1.DrawHangman(logic.ChancesLeft);
            if(next == true)
            {
                lblWord.Text = separateChars(logic.DisplayedWord);
                MessageBox.Show("Good job!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logic.NextRound();
                clearGame();
            }
            lblWord.Text = separateChars(logic.DisplayedWord);
            lblChances.Text = logic.ChancesLeft.ToString();
            lblRound.Text = logic.Round.ToString();
            if (logic.ChancesLeft == 0)
            {
                MessageBox.Show("Game over!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearGame();
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool result = logic.ResetLogic();
            if(!result)
            {
                MessageBox.Show("Game source does not have enough words (12).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clearGame();
            lblWord.Text = separateChars(logic.DisplayedWord);
            logic.Round = 1;
        }

        private void clearGame()
        {
            hangmanPictureControl1.ClearPicture();
            lblChances.Text = logic.ChancesLeft.ToString();
            lblRound.Text = logic.Round.ToString();
            lblWord.Text = separateChars(logic.DisplayedWord);
            foreach (Control control in flowLayoutPanel1.Controls)
                control.Enabled = true;
        }

        private string separateChars(string word)
        {
            string result = "";
            StringBuilder sb = new StringBuilder(word);
            for (int i = 0; i < word.Length; i++)
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
