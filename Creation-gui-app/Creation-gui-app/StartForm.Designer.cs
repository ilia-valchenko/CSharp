namespace Creation_gui_app
{
    partial class StartForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CreateCreatureButton = new System.Windows.Forms.Button();
            this.CreateHuman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(95, 226);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(44, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(200, 18);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to Creation app";
            // 
            // CreateCreatureButton
            // 
            this.CreateCreatureButton.Location = new System.Drawing.Point(95, 54);
            this.CreateCreatureButton.Name = "CreateCreatureButton";
            this.CreateCreatureButton.Size = new System.Drawing.Size(92, 23);
            this.CreateCreatureButton.TabIndex = 2;
            this.CreateCreatureButton.Text = "Create Creature";
            this.CreateCreatureButton.UseVisualStyleBackColor = true;
            this.CreateCreatureButton.Click += new System.EventHandler(this.CreateCreatureButton_Click);
            // 
            // CreateHuman
            // 
            this.CreateHuman.Location = new System.Drawing.Point(95, 83);
            this.CreateHuman.Name = "CreateHuman";
            this.CreateHuman.Size = new System.Drawing.Size(92, 23);
            this.CreateHuman.TabIndex = 3;
            this.CreateHuman.Text = "Create human";
            this.CreateHuman.UseVisualStyleBackColor = true;
            this.CreateHuman.Click += new System.EventHandler(this.CreateHuman_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CreateHuman);
            this.Controls.Add(this.CreateCreatureButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ExitButton);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CreateCreatureButton;
        private System.Windows.Forms.Button CreateHuman;
    }
}

