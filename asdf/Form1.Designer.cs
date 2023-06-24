namespace SnakeProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btPlayGame = new System.Windows.Forms.Button();
            this.btCrW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlayGame
            // 
            this.btPlayGame.BackColor = System.Drawing.Color.LawnGreen;
            this.btPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPlayGame.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayGame.Location = new System.Drawing.Point(73, 179);
            this.btPlayGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPlayGame.Name = "btPlayGame";
            this.btPlayGame.Size = new System.Drawing.Size(123, 62);
            this.btPlayGame.TabIndex = 0;
            this.btPlayGame.Text = "Play Game";
            this.btPlayGame.UseVisualStyleBackColor = false;
            this.btPlayGame.Click += new System.EventHandler(this.btPlayGame_Click);
            // 
            // btCrW
            // 
            this.btCrW.BackColor = System.Drawing.Color.LawnGreen;
            this.btCrW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCrW.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrW.Location = new System.Drawing.Point(46, 295);
            this.btCrW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCrW.Name = "btCrW";
            this.btCrW.Size = new System.Drawing.Size(182, 69);
            this.btCrW.TabIndex = 1;
            this.btCrW.Text = "Create World";
            this.btCrW.UseVisualStyleBackColor = false;
            this.btCrW.Click += new System.EventHandler(this.btCrW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Snake Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::asdf.Properties.Resources.f434fb9be8a841b560bcfc142445a60d_icon;
            this.pictureBox1.Location = new System.Drawing.Point(262, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 241);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(524, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCrW);
            this.Controls.Add(this.btPlayGame);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlayGame;
        private System.Windows.Forms.Button btCrW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

