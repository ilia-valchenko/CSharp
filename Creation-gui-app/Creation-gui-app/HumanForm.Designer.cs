namespace Creation_gui_app
{
    partial class HumanForm
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.NewHumanButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HumanPlusBirdButton = new System.Windows.Forms.Button();
            this.HumanPlusDogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(150, 200);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picEllipse_Paint);
            this.picture.Resize += new System.EventHandler(this.picEllipse_Resize);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Location = new System.Drawing.Point(11, 226);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(75, 23);
            this.BackToMenuButton.TabIndex = 0;
            this.BackToMenuButton.Text = "Back";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // NewHumanButton
            // 
            this.NewHumanButton.Location = new System.Drawing.Point(93, 226);
            this.NewHumanButton.Name = "NewHumanButton";
            this.NewHumanButton.Size = new System.Drawing.Size(75, 23);
            this.NewHumanButton.TabIndex = 1;
            this.NewHumanButton.Text = "New human";
            this.NewHumanButton.UseVisualStyleBackColor = true;
            this.NewHumanButton.Click += new System.EventHandler(this.NewHumanButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(156, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(190, 200);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // HumanPlusBirdButton
            // 
            this.HumanPlusBirdButton.Location = new System.Drawing.Point(175, 226);
            this.HumanPlusBirdButton.Name = "HumanPlusBirdButton";
            this.HumanPlusBirdButton.Size = new System.Drawing.Size(84, 23);
            this.HumanPlusBirdButton.TabIndex = 3;
            this.HumanPlusBirdButton.Text = "Human + bird";
            this.HumanPlusBirdButton.UseVisualStyleBackColor = true;
            this.HumanPlusBirdButton.Click += new System.EventHandler(this.HumanPlusBirdButton_Click);
            // 
            // HumanPlusDogButton
            // 
            this.HumanPlusDogButton.Location = new System.Drawing.Point(265, 226);
            this.HumanPlusDogButton.Name = "HumanPlusDogButton";
            this.HumanPlusDogButton.Size = new System.Drawing.Size(81, 23);
            this.HumanPlusDogButton.TabIndex = 4;
            this.HumanPlusDogButton.Text = "Human + dog";
            this.HumanPlusDogButton.UseVisualStyleBackColor = true;
            this.HumanPlusDogButton.Click += new System.EventHandler(this.HumanPlusDogButton_Click);
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.HumanPlusDogButton);
            this.Controls.Add(this.HumanPlusBirdButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.NewHumanButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.picture);
            this.Name = "HumanForm";
            this.Text = "HumanForm";
            this.Load += new System.EventHandler(this.HumanForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HumanForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Button NewHumanButton;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button HumanPlusBirdButton;
        private System.Windows.Forms.Button HumanPlusDogButton;
    }
}