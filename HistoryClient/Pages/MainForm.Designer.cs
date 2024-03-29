﻿namespace HistoryClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.newRecordButton = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.moodAnalyzerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // newRecordButton
            // 
            this.newRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.newRecordButton.Location = new System.Drawing.Point(100, 180);
            this.newRecordButton.Name = "newRecordButton";
            this.newRecordButton.Size = new System.Drawing.Size(175, 50);
            this.newRecordButton.TabIndex = 0;
            this.newRecordButton.Text = "New Record";
            this.newRecordButton.UseVisualStyleBackColor = true;
            this.newRecordButton.Click += new System.EventHandler(this.NewRecordButton_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonHistory.Location = new System.Drawing.Point(325, 180);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(175, 50);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.button2_Click);
            // 
            // Icon
            // 
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.Location = new System.Drawing.Point(225, 10);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(150, 120);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 2;
            this.Icon.TabStop = false;
            this.Icon.Click += new System.EventHandler(this.Icon_Click);
            // 
            // moodAnalyzerLabel
            // 
            this.moodAnalyzerLabel.AutoSize = true;
            this.moodAnalyzerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.moodAnalyzerLabel.Location = new System.Drawing.Point(167, 140);
            this.moodAnalyzerLabel.Name = "moodAnalyzerLabel";
            this.moodAnalyzerLabel.Size = new System.Drawing.Size(268, 32);
            this.moodAnalyzerLabel.TabIndex = 3;
            this.moodAnalyzerLabel.Text = "Mood Analyzer 2.0";
            this.moodAnalyzerLabel.Click += new System.EventHandler(this.MoodAnalyzerLabel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dark Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moodAnalyzerLabel);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.newRecordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Mood Analyzer";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRecordButton;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label moodAnalyzerLabel;
        private System.Windows.Forms.Button button1;
    }
}