namespace Creation_gui_app
{
    partial class HumanPlusBirdForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.NewHumanPlusBird = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(361, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 200);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.Resize += new System.EventHandler(this.pictureBox2_Resize);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(155, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 200);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(517, -1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(220, 220);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(184, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 219);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            this.pictureBox3.Resize += new System.EventHandler(this.pictureBox3_Resize);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(331, 224);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(260, 200);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(193, 453);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(274, 453);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(121, 23);
            this.BackToMainMenu.TabIndex = 7;
            this.BackToMainMenu.Text = "Back to Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // NewHumanPlusBird
            // 
            this.NewHumanPlusBird.Location = new System.Drawing.Point(401, 453);
            this.NewHumanPlusBird.Name = "NewHumanPlusBird";
            this.NewHumanPlusBird.Size = new System.Drawing.Size(103, 23);
            this.NewHumanPlusBird.TabIndex = 8;
            this.NewHumanPlusBird.Text = "New human + bird";
            this.NewHumanPlusBird.UseVisualStyleBackColor = true;
            this.NewHumanPlusBird.Click += new System.EventHandler(this.NewHumanPlusBird_Click);
            // 
            // HumanPlusBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 488);
            this.Controls.Add(this.NewHumanPlusBird);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HumanPlusBirdForm";
            this.Text = "HumanPlusBird";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Button NewHumanPlusBird;
    }
}