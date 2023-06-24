namespace SnakeProject
{
    partial class CreateWorld
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSaveGame = new System.Windows.Forms.Button();
            this.saveWorld = new System.Windows.Forms.SaveFileDialog();
            this.lblEgg = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudEggs = new System.Windows.Forms.NumericUpDown();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEggs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox1.Location = new System.Drawing.Point(45, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 415);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btSaveGame
            // 
            this.btSaveGame.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSaveGame.Location = new System.Drawing.Point(643, 483);
            this.btSaveGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveGame.Name = "btSaveGame";
            this.btSaveGame.Size = new System.Drawing.Size(102, 34);
            this.btSaveGame.TabIndex = 6;
            this.btSaveGame.Text = "Save Game";
            this.btSaveGame.UseVisualStyleBackColor = false;
            this.btSaveGame.Click += new System.EventHandler(this.btSaveGame_Click);
            // 
            // saveWorld
            // 
            this.saveWorld.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.";
            this.saveWorld.Title = "Save World";
            // 
            // lblEgg
            // 
            this.lblEgg.AutoSize = true;
            this.lblEgg.Location = new System.Drawing.Point(595, 240);
            this.lblEgg.Name = "lblEgg";
            this.lblEgg.Size = new System.Drawing.Size(72, 16);
            this.lblEgg.TabIndex = 7;
            this.lblEgg.Text = "Egg Amount";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(595, 169);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 16);
            this.lblRows.TabIndex = 8;
            this.lblRows.Text = "Rows";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(595, 116);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(50, 16);
            this.lblColumns.TabIndex = 9;
            this.lblColumns.Text = "Columns";
            // 
            // nudColumns
            // 
            this.nudColumns.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudColumns.Location = new System.Drawing.Point(709, 109);
            this.nudColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudColumns.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(78, 20);
            this.nudColumns.TabIndex = 10;
            this.nudColumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudRows
            // 
            this.nudRows.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRows.Location = new System.Drawing.Point(709, 162);
            this.nudRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudRows.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(78, 20);
            this.nudRows.TabIndex = 11;
            this.nudRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudEggs
            // 
            this.nudEggs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEggs.Location = new System.Drawing.Point(709, 238);
            this.nudEggs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEggs.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudEggs.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEggs.Name = "nudEggs";
            this.nudEggs.Size = new System.Drawing.Size(78, 20);
            this.nudEggs.TabIndex = 12;
            this.nudEggs.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(787, 437);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 13;
            // 
            // SpeedBar
            // 
            this.SpeedBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeedBar.Location = new System.Drawing.Point(607, 316);
            this.SpeedBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedBar.Maximum = 300;
            this.SpeedBar.Minimum = 100;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(168, 45);
            this.SpeedBar.TabIndex = 14;
            this.SpeedBar.Value = 100;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(676, 296);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(40, 16);
            this.lblSpeed.TabIndex = 15;
            this.lblSpeed.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(616, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(746, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "300";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGoBack.Location = new System.Drawing.Point(45, 44);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(88, 29);
            this.btGoBack.TabIndex = 19;
            this.btGoBack.Text = "Go Back";
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // CreateWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(830, 546);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.nudEggs);
            this.Controls.Add(this.nudRows);
            this.Controls.Add(this.nudColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblEgg);
            this.Controls.Add(this.btSaveGame);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateWorld";
            this.ShowIcon = false;
            this.Text = "CreateWorld";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateWorld_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEggs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSaveGame;
        private System.Windows.Forms.SaveFileDialog saveWorld;
        private System.Windows.Forms.Label lblEgg;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudEggs;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btGoBack;
    }
}