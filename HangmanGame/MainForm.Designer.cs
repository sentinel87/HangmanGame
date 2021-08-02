
namespace HangmanGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.hangmanPictureControl1 = new HangmanGame.Controls.HangmanPictureControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChances = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 267);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // hangmanPictureControl1
            // 
            this.hangmanPictureControl1.Location = new System.Drawing.Point(433, 40);
            this.hangmanPictureControl1.Name = "hangmanPictureControl1";
            this.hangmanPictureControl1.Size = new System.Drawing.Size(300, 400);
            this.hangmanPictureControl1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQ.Location = new System.Drawing.Point(13, 313);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(35, 35);
            this.btnQ.TabIndex = 3;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnW.Location = new System.Drawing.Point(54, 313);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(35, 35);
            this.btnW.TabIndex = 4;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnE.Location = new System.Drawing.Point(95, 313);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(35, 35);
            this.btnE.TabIndex = 5;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnR.Location = new System.Drawing.Point(136, 313);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(35, 35);
            this.btnR.TabIndex = 6;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnT.Location = new System.Drawing.Point(177, 313);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(35, 35);
            this.btnT.TabIndex = 7;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnY.Location = new System.Drawing.Point(218, 313);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(35, 35);
            this.btnY.TabIndex = 8;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnU.Location = new System.Drawing.Point(259, 313);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(35, 35);
            this.btnU.TabIndex = 9;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnI.Location = new System.Drawing.Point(300, 313);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(35, 35);
            this.btnI.TabIndex = 10;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnO.Location = new System.Drawing.Point(341, 313);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(35, 35);
            this.btnO.TabIndex = 11;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnP.Location = new System.Drawing.Point(382, 313);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(35, 35);
            this.btnP.TabIndex = 12;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chances";
            // 
            // lblChances
            // 
            this.lblChances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblChances.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChances.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblChances.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChances.Location = new System.Drawing.Point(94, 68);
            this.lblChances.Name = "lblChances";
            this.lblChances.Size = new System.Drawing.Size(76, 20);
            this.lblChances.TabIndex = 14;
            this.lblChances.Text = "6";
            this.lblChances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnA.Location = new System.Drawing.Point(31, 354);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(35, 35);
            this.btnA.TabIndex = 15;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnS.Location = new System.Drawing.Point(72, 354);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(35, 35);
            this.btnS.TabIndex = 16;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD.Location = new System.Drawing.Point(113, 354);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(35, 35);
            this.btnD.TabIndex = 17;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF.Location = new System.Drawing.Point(154, 354);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(35, 35);
            this.btnF.TabIndex = 18;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnG.Location = new System.Drawing.Point(195, 354);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(35, 35);
            this.btnG.TabIndex = 19;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnH.Location = new System.Drawing.Point(236, 354);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(35, 35);
            this.btnH.TabIndex = 20;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJ.Location = new System.Drawing.Point(277, 354);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(35, 35);
            this.btnJ.TabIndex = 21;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnK.Location = new System.Drawing.Point(318, 354);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(35, 35);
            this.btnK.TabIndex = 22;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnL.Location = new System.Drawing.Point(359, 354);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(35, 35);
            this.btnL.TabIndex = 23;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN.Location = new System.Drawing.Point(260, 395);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(35, 35);
            this.btnN.TabIndex = 24;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZ.Location = new System.Drawing.Point(55, 395);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(35, 35);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnX.Location = new System.Drawing.Point(96, 395);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(35, 35);
            this.btnX.TabIndex = 26;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(137, 395);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(35, 35);
            this.btnC.TabIndex = 27;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnV.Location = new System.Drawing.Point(178, 395);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(35, 35);
            this.btnV.TabIndex = 28;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnB.Location = new System.Drawing.Point(219, 395);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(35, 35);
            this.btnB.TabIndex = 29;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnM.Location = new System.Drawing.Point(300, 395);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(35, 35);
            this.btnM.TabIndex = 30;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWord.Location = new System.Drawing.Point(13, 151);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(136, 37);
            this.lblWord.TabIndex = 31;
            this.lblWord.Text = "_ _ _ _ _ _ _";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Round";
            // 
            // lblRound
            // 
            this.lblRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRound.Location = new System.Drawing.Point(94, 106);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(76, 20);
            this.lblRound.TabIndex = 33;
            this.lblRound.Text = "1";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 462);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblChances);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.hangmanPictureControl1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hangman game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private Controls.HangmanPictureControl hangmanPictureControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChances;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRound;
    }
}

