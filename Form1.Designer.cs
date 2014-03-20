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
            this.rockRad = new System.Windows.Forms.RadioButton();
            this.paperRad = new System.Windows.Forms.RadioButton();
            this.scissorsRad = new System.Windows.Forms.RadioButton();
            this.lizardRad = new System.Windows.Forms.RadioButton();
            this.spockRad = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Controls.Add(this.rockRad);
            this.groupBox1.Controls.Add(this.paperRad);
            this.groupBox1.Controls.Add(this.scissorsRad);
            this.groupBox1.Controls.Add(this.lizardRad);
            this.groupBox1.Controls.Add(this.spockRad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select One:";
            // 
            // rockRad
            // 
            this.rockRad.AutoSize = true;
            this.rockRad.Location = new System.Drawing.Point(6, 19);
            this.rockRad.Name = "rockRad";
            this.rockRad.Size = new System.Drawing.Size(51, 17);
            this.rockRad.TabIndex = 1;
            this.rockRad.Text = "Rock";
            this.rockRad.UseVisualStyleBackColor = true;
            // 
            // paperRad
            // 
            this.paperRad.AutoSize = true;
            this.paperRad.Location = new System.Drawing.Point(6, 42);
            this.paperRad.Name = "paperRad";
            this.paperRad.Size = new System.Drawing.Size(53, 17);
            this.paperRad.TabIndex = 2;
            this.paperRad.Text = "Paper";
            this.paperRad.UseVisualStyleBackColor = true;
            // 
            // scissorsRad
            // 
            this.scissorsRad.AutoSize = true;
            this.scissorsRad.Location = new System.Drawing.Point(6, 65);
            this.scissorsRad.Name = "scissorsRad";
            this.scissorsRad.Size = new System.Drawing.Size(64, 17);
            this.scissorsRad.TabIndex = 3;
            this.scissorsRad.Text = "Scissors";
            this.scissorsRad.UseVisualStyleBackColor = true;
            // 
            // lizardRad
            // 
            this.lizardRad.AutoSize = true;
            this.lizardRad.Location = new System.Drawing.Point(6, 88);
            this.lizardRad.Name = "lizardRad";
            this.lizardRad.Size = new System.Drawing.Size(53, 17);
            this.lizardRad.TabIndex = 4;
            this.lizardRad.Text = "Lizard";
            this.lizardRad.UseVisualStyleBackColor = true;
            // 
            // spockRad
            // 
            this.spockRad.AutoSize = true;
            this.spockRad.Location = new System.Drawing.Point(6, 111);
            this.spockRad.Name = "spockRad";
            this.spockRad.Size = new System.Drawing.Size(56, 17);
            this.spockRad.TabIndex = 5;
            this.spockRad.Text = "Spock";
            this.spockRad.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.RadioButton rockRad;
        private System.Windows.Forms.RadioButton paperRad;
        private System.Windows.Forms.RadioButton scissorsRad;
        private System.Windows.Forms.RadioButton lizardRad;
        private System.Windows.Forms.RadioButton spockRad;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}

