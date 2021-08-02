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
        public MainForm()
        {
            InitializeComponent();
            gameDataSource = new JsonHelper();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //gameDataSource.GetGameData();
            chancesLeft--;
            lblChances.Text = chancesLeft.ToString();
            hangmanPictureControl1.DrawHangman(chancesLeft);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hangmanPictureControl1.ClearPicture();
            chancesLeft = 6;
            lblChances.Text = chancesLeft.ToString();
            round = 1;
            lblRound.Text = round.ToString();
        }
    }
}
