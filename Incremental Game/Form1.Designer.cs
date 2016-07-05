namespace Incremental_Game
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
            this.homeButton = new System.Windows.Forms.Button();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.screenOneButton = new System.Windows.Forms.Button();
            this.screenOneLabel2 = new System.Windows.Forms.Label();
            this.screenOneLabel3 = new System.Windows.Forms.Label();
            this.screenOneLabel4 = new System.Windows.Forms.Label();
            this.ScreenTwoButton = new System.Windows.Forms.Button();
            this.ScreenTwoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 50);
            this.homeButton.TabIndex = 0;
            this.homeButton.Tag = "";
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // upgradeButton
            // 
            this.upgradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradeButton.Location = new System.Drawing.Point(118, 12);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(100, 50);
            this.upgradeButton.TabIndex = 1;
            this.upgradeButton.Text = "Upgrades";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // screenOneButton
            // 
            this.screenOneButton.Location = new System.Drawing.Point(12, 129);
            this.screenOneButton.Name = "screenOneButton";
            this.screenOneButton.Size = new System.Drawing.Size(312, 343);
            this.screenOneButton.TabIndex = 3;
            this.screenOneButton.Tag = "";
            this.screenOneButton.UseVisualStyleBackColor = true;
            this.screenOneButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // screenOneLabel2
            // 
            this.screenOneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOneLabel2.Location = new System.Drawing.Point(12, 65);
            this.screenOneLabel2.Name = "screenOneLabel2";
            this.screenOneLabel2.Size = new System.Drawing.Size(72, 25);
            this.screenOneLabel2.TabIndex = 5;
            this.screenOneLabel2.Tag = "";
            this.screenOneLabel2.Text = "Points";
            // 
            // screenOneLabel3
            // 
            this.screenOneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOneLabel3.Location = new System.Drawing.Point(199, 65);
            this.screenOneLabel3.Name = "screenOneLabel3";
            this.screenOneLabel3.Size = new System.Drawing.Size(70, 25);
            this.screenOneLabel3.TabIndex = 6;
            this.screenOneLabel3.Tag = "";
            this.screenOneLabel3.Text = "Level:";
            // 
            // screenOneLabel4
            // 
            this.screenOneLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOneLabel4.Location = new System.Drawing.Point(275, 65);
            this.screenOneLabel4.Name = "screenOneLabel4";
            this.screenOneLabel4.Size = new System.Drawing.Size(40, 25);
            this.screenOneLabel4.TabIndex = 7;
            this.screenOneLabel4.Tag = "";
            this.screenOneLabel4.Text = "Lvl";
            // 
            // ScreenTwoButton
            // 
            this.ScreenTwoButton.Enabled = false;
            this.ScreenTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton.Location = new System.Drawing.Point(12, 129);
            this.ScreenTwoButton.Name = "ScreenTwoButton";
            this.ScreenTwoButton.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton.TabIndex = 8;
            this.ScreenTwoButton.Text = "Upgrade Click Power";
            this.ScreenTwoButton.UseVisualStyleBackColor = true;
            this.ScreenTwoButton.Visible = false;
            this.ScreenTwoButton.Click += new System.EventHandler(this.ScreenTwoButton_Click);
            // 
            // ScreenTwoLabel
            // 
            this.ScreenTwoLabel.Enabled = false;
            this.ScreenTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabel.Location = new System.Drawing.Point(118, 129);
            this.ScreenTwoLabel.Name = "ScreenTwoLabel";
            this.ScreenTwoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabel.Size = new System.Drawing.Size(206, 46);
            this.ScreenTwoLabel.TabIndex = 9;
            this.ScreenTwoLabel.Tag = "";
            this.ScreenTwoLabel.Text = "Level up to: 10 \r\nWill cost you: 500";
            this.ScreenTwoLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 483);
            this.Controls.Add(this.ScreenTwoLabel);
            this.Controls.Add(this.ScreenTwoButton);
            this.Controls.Add(this.screenOneLabel4);
            this.Controls.Add(this.screenOneLabel3);
            this.Controls.Add(this.screenOneLabel2);
            this.Controls.Add(this.screenOneButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.homeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button screenOneButton;
        private System.Windows.Forms.Label screenOneLabel2;
        private System.Windows.Forms.Label screenOneLabel3;
        private System.Windows.Forms.Label screenOneLabel4;
        private System.Windows.Forms.Button ScreenTwoButton;
        private System.Windows.Forms.Label ScreenTwoLabel;
    }
}

