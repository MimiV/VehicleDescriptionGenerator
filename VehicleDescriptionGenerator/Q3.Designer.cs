﻿namespace VehicleDescriptionGenerator
{
    partial class Q3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Q3Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Q3Home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 850);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleDescriptionGenerator.Properties.Resources.q3Back1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1396, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Q3Home
            // 
            this.Q3Home.BackgroundImage = global::VehicleDescriptionGenerator.Properties.Resources.Untitled_4;
            this.Q3Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Q3Home.Location = new System.Drawing.Point(644, 29);
            this.Q3Home.Name = "Q3Home";
            this.Q3Home.Size = new System.Drawing.Size(165, 53);
            this.Q3Home.TabIndex = 1;
            this.Q3Home.Text = "HOME";
            this.Q3Home.UseVisualStyleBackColor = true;
            this.Q3Home.Click += new System.EventHandler(this.Q3Home_Click);
            // 
            // Q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1650, 1050);
            this.Name = "Q3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Q3Home;
    }
}