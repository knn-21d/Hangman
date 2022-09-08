namespace Hangman
{
    partial class HangMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.display = new System.Windows.Forms.Label();
            this.b23 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b24 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b25 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b26 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b16 = new System.Windows.Forms.Button();
            this.b27 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b17 = new System.Windows.Forms.Button();
            this.b28 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b18 = new System.Windows.Forms.Button();
            this.b29 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b19 = new System.Windows.Forms.Button();
            this.b30 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b31 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b32 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.current_line = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.used = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetScoreToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.resetScoreToolStripMenuItem.Text = "Reset Score";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Image = global::Hangman.Properties.Resources._0;
            this.display.Location = new System.Drawing.Point(561, 32);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(173, 179);
            this.display.TabIndex = 1;
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b23
            // 
            this.b23.Location = new System.Drawing.Point(472, 171);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(40, 40);
            this.b23.TabIndex = 2;
            this.b23.Text = "Э";
            this.b23.UseVisualStyleBackColor = true;
            this.b23.Click += new System.EventHandler(this.button_Click);
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(518, 125);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(40, 40);
            this.b12.TabIndex = 3;
            this.b12.Text = "Ъ";
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 125);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 40);
            this.b1.TabIndex = 4;
            this.b1.Text = "Й";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(58, 125);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 40);
            this.b2.TabIndex = 7;
            this.b2.Text = "Ц";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(12, 171);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(40, 40);
            this.b13.TabIndex = 6;
            this.b13.Text = "Ф";
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.button_Click);
            // 
            // b24
            // 
            this.b24.Location = new System.Drawing.Point(12, 217);
            this.b24.Name = "b24";
            this.b24.Size = new System.Drawing.Size(40, 40);
            this.b24.TabIndex = 5;
            this.b24.Text = "Я";
            this.b24.UseVisualStyleBackColor = true;
            this.b24.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(104, 125);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 40);
            this.b3.TabIndex = 10;
            this.b3.Text = "У";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b14
            // 
            this.b14.Location = new System.Drawing.Point(58, 171);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(40, 40);
            this.b14.TabIndex = 9;
            this.b14.Text = "Ы";
            this.b14.UseVisualStyleBackColor = true;
            this.b14.Click += new System.EventHandler(this.button_Click);
            // 
            // b25
            // 
            this.b25.Location = new System.Drawing.Point(58, 217);
            this.b25.Name = "b25";
            this.b25.Size = new System.Drawing.Size(40, 40);
            this.b25.TabIndex = 8;
            this.b25.Text = "Ч";
            this.b25.UseVisualStyleBackColor = true;
            this.b25.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(150, 125);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 40);
            this.b4.TabIndex = 13;
            this.b4.Text = "К";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // b15
            // 
            this.b15.Location = new System.Drawing.Point(104, 171);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(40, 40);
            this.b15.TabIndex = 12;
            this.b15.Text = "В";
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.button_Click);
            // 
            // b26
            // 
            this.b26.Location = new System.Drawing.Point(104, 217);
            this.b26.Name = "b26";
            this.b26.Size = new System.Drawing.Size(40, 40);
            this.b26.TabIndex = 11;
            this.b26.Text = "С";
            this.b26.UseVisualStyleBackColor = true;
            this.b26.Click += new System.EventHandler(this.button_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(196, 125);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 40);
            this.b5.TabIndex = 16;
            this.b5.Text = "Е";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // b16
            // 
            this.b16.Location = new System.Drawing.Point(150, 171);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(40, 40);
            this.b16.TabIndex = 15;
            this.b16.Text = "А";
            this.b16.UseVisualStyleBackColor = true;
            this.b16.Click += new System.EventHandler(this.button_Click);
            // 
            // b27
            // 
            this.b27.Location = new System.Drawing.Point(150, 217);
            this.b27.Name = "b27";
            this.b27.Size = new System.Drawing.Size(40, 40);
            this.b27.TabIndex = 14;
            this.b27.Text = "М";
            this.b27.UseVisualStyleBackColor = true;
            this.b27.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(242, 125);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 40);
            this.b6.TabIndex = 19;
            this.b6.Text = "Н";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b17
            // 
            this.b17.Location = new System.Drawing.Point(196, 171);
            this.b17.Name = "b17";
            this.b17.Size = new System.Drawing.Size(40, 40);
            this.b17.TabIndex = 18;
            this.b17.Text = "П";
            this.b17.UseVisualStyleBackColor = true;
            this.b17.Click += new System.EventHandler(this.button_Click);
            // 
            // b28
            // 
            this.b28.Location = new System.Drawing.Point(196, 217);
            this.b28.Name = "b28";
            this.b28.Size = new System.Drawing.Size(40, 40);
            this.b28.TabIndex = 17;
            this.b28.Text = "И";
            this.b28.UseVisualStyleBackColor = true;
            this.b28.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(288, 125);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 40);
            this.b7.TabIndex = 22;
            this.b7.Text = "Г";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b18
            // 
            this.b18.Location = new System.Drawing.Point(242, 171);
            this.b18.Name = "b18";
            this.b18.Size = new System.Drawing.Size(40, 40);
            this.b18.TabIndex = 21;
            this.b18.Text = "Р";
            this.b18.UseVisualStyleBackColor = true;
            this.b18.Click += new System.EventHandler(this.button_Click);
            // 
            // b29
            // 
            this.b29.Location = new System.Drawing.Point(242, 217);
            this.b29.Name = "b29";
            this.b29.Size = new System.Drawing.Size(40, 40);
            this.b29.TabIndex = 20;
            this.b29.Text = "Т";
            this.b29.UseVisualStyleBackColor = true;
            this.b29.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(334, 125);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 40);
            this.b8.TabIndex = 25;
            this.b8.Text = "Ш";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // b19
            // 
            this.b19.Location = new System.Drawing.Point(288, 171);
            this.b19.Name = "b19";
            this.b19.Size = new System.Drawing.Size(40, 40);
            this.b19.TabIndex = 24;
            this.b19.Text = "О";
            this.b19.UseVisualStyleBackColor = true;
            this.b19.Click += new System.EventHandler(this.button_Click);
            // 
            // b30
            // 
            this.b30.Location = new System.Drawing.Point(288, 217);
            this.b30.Name = "b30";
            this.b30.Size = new System.Drawing.Size(40, 40);
            this.b30.TabIndex = 23;
            this.b30.Text = "Ь";
            this.b30.UseVisualStyleBackColor = true;
            this.b30.Click += new System.EventHandler(this.button_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(380, 125);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 40);
            this.b9.TabIndex = 28;
            this.b9.Text = "Щ";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_Click);
            // 
            // b20
            // 
            this.b20.Location = new System.Drawing.Point(334, 171);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(40, 40);
            this.b20.TabIndex = 27;
            this.b20.Text = "Л";
            this.b20.UseVisualStyleBackColor = true;
            this.b20.Click += new System.EventHandler(this.button_Click);
            // 
            // b31
            // 
            this.b31.Location = new System.Drawing.Point(334, 217);
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(40, 40);
            this.b31.TabIndex = 26;
            this.b31.Text = "Б";
            this.b31.UseVisualStyleBackColor = true;
            this.b31.Click += new System.EventHandler(this.button_Click);
            // 
            // b10
            // 
            this.b10.Location = new System.Drawing.Point(426, 125);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(40, 40);
            this.b10.TabIndex = 31;
            this.b10.Text = "З";
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.button_Click);
            // 
            // b21
            // 
            this.b21.Location = new System.Drawing.Point(380, 171);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(40, 40);
            this.b21.TabIndex = 30;
            this.b21.Text = "Д";
            this.b21.UseVisualStyleBackColor = true;
            this.b21.Click += new System.EventHandler(this.button_Click);
            // 
            // b32
            // 
            this.b32.Location = new System.Drawing.Point(380, 217);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(40, 40);
            this.b32.TabIndex = 29;
            this.b32.Text = "Ю";
            this.b32.UseVisualStyleBackColor = true;
            this.b32.Click += new System.EventHandler(this.button_Click);
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(472, 125);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(40, 40);
            this.b11.TabIndex = 34;
            this.b11.Text = "Х";
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.button_Click);
            // 
            // b22
            // 
            this.b22.Location = new System.Drawing.Point(426, 171);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(40, 40);
            this.b22.TabIndex = 33;
            this.b22.Text = "Ж";
            this.b22.UseVisualStyleBackColor = true;
            this.b22.Click += new System.EventHandler(this.button_Click);
            // 
            // current_line
            // 
            this.current_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_line.Location = new System.Drawing.Point(12, 33);
            this.current_line.Name = "current_line";
            this.current_line.Size = new System.Drawing.Size(500, 89);
            this.current_line.TabIndex = 35;
            this.current_line.Text = "«New Game» to continue";
            this.current_line.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wins
            // 
            this.wins.Location = new System.Drawing.Point(552, 211);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(182, 23);
            this.wins.TabIndex = 36;
            this.wins.Text = "Wins: 0";
            // 
            // losses
            // 
            this.losses.Location = new System.Drawing.Point(552, 237);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(182, 23);
            this.losses.TabIndex = 37;
            this.losses.Text = "Losses: 0";
            // 
            // used
            // 
            this.used.Location = new System.Drawing.Point(9, 266);
            this.used.Name = "used";
            this.used.Size = new System.Drawing.Size(411, 18);
            this.used.TabIndex = 38;
            this.used.Text = "Used:";
            // 
            // HangMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 285);
            this.Controls.Add(this.used);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.current_line);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b32);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b20);
            this.Controls.Add(this.b31);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b19);
            this.Controls.Add(this.b30);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b18);
            this.Controls.Add(this.b29);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b17);
            this.Controls.Add(this.b28);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b16);
            this.Controls.Add(this.b27);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.b26);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b14);
            this.Controls.Add(this.b25);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b24);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HangMain";
            this.Text = "Hangman";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressHandler);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button b23;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b24;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b14;
        private System.Windows.Forms.Button b25;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b15;
        private System.Windows.Forms.Button b26;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b16;
        private System.Windows.Forms.Button b27;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b17;
        private System.Windows.Forms.Button b28;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b18;
        private System.Windows.Forms.Button b29;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b19;
        private System.Windows.Forms.Button b30;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b20;
        private System.Windows.Forms.Button b31;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b32;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Label current_line;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label losses;
        private System.Windows.Forms.Label used;
    }
}