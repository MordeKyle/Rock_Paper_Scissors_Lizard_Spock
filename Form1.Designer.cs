namespace Rock_Paper_Scissors_Lizard_Spock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rockButton = new System.Windows.Forms.RadioButton();
            this.paperButton = new System.Windows.Forms.RadioButton();
            this.scissorsButton = new System.Windows.Forms.RadioButton();
            this.lizardButton = new System.Windows.Forms.RadioButton();
            this.spockButton = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rockButton);
            this.groupBox1.Controls.Add(this.paperButton);
            this.groupBox1.Controls.Add(this.scissorsButton);
            this.groupBox1.Controls.Add(this.lizardButton);
            this.groupBox1.Controls.Add(this.spockButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select One:";
            // 
            // rockButton
            // 
            this.rockButton.AutoSize = true;
            this.rockButton.Location = new System.Drawing.Point(6, 19);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(51, 17);
            this.rockButton.TabIndex = 1;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            this.paperButton.AutoSize = true;
            this.paperButton.Location = new System.Drawing.Point(6, 42);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(53, 17);
            this.paperButton.TabIndex = 2;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorsButton
            // 
            this.scissorsButton.AutoSize = true;
            this.scissorsButton.Location = new System.Drawing.Point(6, 65);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(64, 17);
            this.scissorsButton.TabIndex = 3;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            // 
            // lizardButton
            // 
            this.lizardButton.AutoSize = true;
            this.lizardButton.Location = new System.Drawing.Point(6, 88);
            this.lizardButton.Name = "lizardButton";
            this.lizardButton.Size = new System.Drawing.Size(53, 17);
            this.lizardButton.TabIndex = 4;
            this.lizardButton.Text = "Lizard";
            this.lizardButton.UseVisualStyleBackColor = true;
            // 
            // spockButton
            // 
            this.spockButton.AutoSize = true;
            this.spockButton.Location = new System.Drawing.Point(6, 111);
            this.spockButton.Name = "spockButton";
            this.spockButton.Size = new System.Drawing.Size(56, 17);
            this.spockButton.TabIndex = 5;
            this.spockButton.Text = "Spock";
            this.spockButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(180, 177);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer\'s Choice:";
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerChoiceLabel.Location = new System.Drawing.Point(301, 53);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(121, 23);
            this.computerChoiceLabel.TabIndex = 3;
            this.computerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results:";
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(301, 97);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(121, 23);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors Lizard Spock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rockButton;
        private System.Windows.Forms.RadioButton paperButton;
        private System.Windows.Forms.RadioButton scissorsButton;
        private System.Windows.Forms.RadioButton lizardButton;
        private System.Windows.Forms.RadioButton spockButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}

