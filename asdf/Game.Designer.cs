namespace SnakeProject
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btGB = new System.Windows.Forms.Button();
            this.pbxWorld = new System.Windows.Forms.PictureBox();
            this.btStartGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblscore = new System.Windows.Forms.Label();
            this.btOpenWorld = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // btGB
            // 
            this.btGB.Location = new System.Drawing.Point(30, 27);
            this.btGB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGB.Name = "btGB";
            this.btGB.Size = new System.Drawing.Size(87, 28);
            this.btGB.TabIndex = 0;
            this.btGB.Text = "Go Back";
            this.btGB.UseVisualStyleBackColor = true;
            this.btGB.Click += new System.EventHandler(this.btGB_Click);
            // 
            // pbxWorld
            // 
            this.pbxWorld.BackColor = System.Drawing.Color.PaleGreen;
            this.pbxWorld.Location = new System.Drawing.Point(30, 91);
            this.pbxWorld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxWorld.Name = "pbxWorld";
            this.pbxWorld.Size = new System.Drawing.Size(700, 615);
            this.pbxWorld.TabIndex = 1;
            this.pbxWorld.TabStop = false;
            this.pbxWorld.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxWorld_Paint);
            // 
            // btStartGame
            // 
            this.btStartGame.Location = new System.Drawing.Point(643, 27);
            this.btStartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(87, 28);
            this.btStartGame.TabIndex = 2;
            this.btStartGame.Text = "Start Game";
            this.btStartGame.UseVisualStyleBackColor = true;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Comic Sans MS", 15.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(306, 29);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(26, 30);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "0";
            // 
            // btOpenWorld
            // 
            this.btOpenWorld.Location = new System.Drawing.Point(495, 27);
            this.btOpenWorld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOpenWorld.Name = "btOpenWorld";
            this.btOpenWorld.Size = new System.Drawing.Size(87, 28);
            this.btOpenWorld.TabIndex = 4;
            this.btOpenWorld.Text = "Load World";
            this.btOpenWorld.UseVisualStyleBackColor = true;
            this.btOpenWorld.Click += new System.EventHandler(this.btOpenWorld_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFile";
            this.OpenFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.";
            this.OpenFile.Title = "Load Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score :";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenWorld);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btStartGame);
            this.Controls.Add(this.pbxWorld);
            this.Controls.Add(this.btGB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Game_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGB;
        private System.Windows.Forms.PictureBox pbxWorld;
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btOpenWorld;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label label1;
    }
}