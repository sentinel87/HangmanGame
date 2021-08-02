using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame.Controls
{
    public partial class HangmanPictureControl : UserControl
    {
        private Graphics graphics { get; set; }

        Pen whitePen = new Pen(Color.White, 4);

        public HangmanPictureControl()
        {
            InitializeComponent();
            graphics = pbControl.CreateGraphics();
        }

        public void DrawHangman(int phase)
        {
            switch(phase)
            {
                case 5:
                    graphics.DrawEllipse(whitePen, 130, 100, 50, 50); break;
                case 4:
                    graphics.DrawLine(whitePen, new Point(155, 150), new Point(155, 250)); break;
                case 3:
                    graphics.DrawLine(whitePen, new Point(155, 150), new Point(115, 190)); break;
                case 2:
                    graphics.DrawLine(whitePen, new Point(155, 150), new Point(195, 190)); break;
                case 1:
                    graphics.DrawLine(whitePen, new Point(155, 250), new Point(115, 290)); break;
                case 0:
                    graphics.DrawLine(whitePen, new Point(155, 250), new Point(195, 290)); break;
            }
        }

        public void ClearPicture()
        {
            graphics.Clear(Color.Black);
            graphics.DrawLine(whitePen, new Point(155, 40), new Point(155, 100));
            graphics.DrawLine(whitePen, new Point(40, 40), new Point(40, 360));
            graphics.DrawLine(whitePen, new Point(20, 360), new Point(100, 360));
            graphics.DrawLine(whitePen, new Point(40, 80), new Point(80, 40));
            graphics.DrawLine(whitePen, new Point(40, 40), new Point(155, 40));
        }
    }
}
