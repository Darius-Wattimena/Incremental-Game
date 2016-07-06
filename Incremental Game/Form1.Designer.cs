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
            this.components = new System.ComponentModel.Container();
            this.homeButton = new System.Windows.Forms.Button();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.screenOneButton = new System.Windows.Forms.Button();
            this.screenOneLabel2 = new System.Windows.Forms.Label();
            this.screenOneLabel3 = new System.Windows.Forms.Label();
            this.screenOneLabel4 = new System.Windows.Forms.Label();
            this.ScreenTwoButton1 = new System.Windows.Forms.Button();
            this.ScreenTwoLabel1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScreenTwoButton2 = new System.Windows.Forms.Button();
            this.ScreenTwoLabel2 = new System.Windows.Forms.Label();
            this.ScreenTwoButton3 = new System.Windows.Forms.Button();
            this.ScreenTwoButton4 = new System.Windows.Forms.Button();
            this.ScreenTwoLabel3 = new System.Windows.Forms.Label();
            this.ScreenTwoLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 86);
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
            this.upgradeButton.Size = new System.Drawing.Size(100, 86);
            this.upgradeButton.TabIndex = 1;
            this.upgradeButton.Text = "Upgrades";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = global::Incremental_Game.Properties.Resources.datBoi;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(224, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 86);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.screenOneLabel2.Location = new System.Drawing.Point(12, 101);
            this.screenOneLabel2.Name = "screenOneLabel2";
            this.screenOneLabel2.Size = new System.Drawing.Size(72, 25);
            this.screenOneLabel2.TabIndex = 5;
            this.screenOneLabel2.Tag = "";
            this.screenOneLabel2.Text = "Points";
            // 
            // screenOneLabel3
            // 
            this.screenOneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOneLabel3.Location = new System.Drawing.Point(199, 101);
            this.screenOneLabel3.Name = "screenOneLabel3";
            this.screenOneLabel3.Size = new System.Drawing.Size(70, 25);
            this.screenOneLabel3.TabIndex = 6;
            this.screenOneLabel3.Tag = "";
            this.screenOneLabel3.Text = "Level:";
            // 
            // screenOneLabel4
            // 
            this.screenOneLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOneLabel4.Location = new System.Drawing.Point(275, 101);
            this.screenOneLabel4.Name = "screenOneLabel4";
            this.screenOneLabel4.Size = new System.Drawing.Size(40, 25);
            this.screenOneLabel4.TabIndex = 7;
            this.screenOneLabel4.Tag = "";
            this.screenOneLabel4.Text = "Lvl";
            // 
            // ScreenTwoButton1
            // 
            this.ScreenTwoButton1.Enabled = false;
            this.ScreenTwoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton1.Location = new System.Drawing.Point(12, 129);
            this.ScreenTwoButton1.Name = "ScreenTwoButton1";
            this.ScreenTwoButton1.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton1.TabIndex = 8;
            this.ScreenTwoButton1.Text = "Upgrade Click Power";
            this.ScreenTwoButton1.UseVisualStyleBackColor = true;
            this.ScreenTwoButton1.Visible = false;
            this.ScreenTwoButton1.Click += new System.EventHandler(this.ScreenTwoButton_Click);
            // 
            // ScreenTwoLabel1
            // 
            this.ScreenTwoLabel1.Enabled = false;
            this.ScreenTwoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabel1.Location = new System.Drawing.Point(118, 129);
            this.ScreenTwoLabel1.Name = "ScreenTwoLabel1";
            this.ScreenTwoLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabel1.Size = new System.Drawing.Size(206, 46);
            this.ScreenTwoLabel1.TabIndex = 9;
            this.ScreenTwoLabel1.Tag = "";
            this.ScreenTwoLabel1.Text = "Level up to: 10 \r\nWill cost you: 500";
            this.ScreenTwoLabel1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScreenTwoButton2
            // 
            this.ScreenTwoButton2.Enabled = false;
            this.ScreenTwoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton2.Location = new System.Drawing.Point(12, 181);
            this.ScreenTwoButton2.Name = "ScreenTwoButton2";
            this.ScreenTwoButton2.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton2.TabIndex = 10;
            this.ScreenTwoButton2.Text = "Upgrade Shervin";
            this.ScreenTwoButton2.UseVisualStyleBackColor = true;
            this.ScreenTwoButton2.Visible = false;
            // 
            // ScreenTwoLabel2
            // 
            this.ScreenTwoLabel2.Enabled = false;
            this.ScreenTwoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabel2.Location = new System.Drawing.Point(118, 181);
            this.ScreenTwoLabel2.Name = "ScreenTwoLabel2";
            this.ScreenTwoLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabel2.Size = new System.Drawing.Size(206, 46);
            this.ScreenTwoLabel2.TabIndex = 11;
            this.ScreenTwoLabel2.Tag = "";
            this.ScreenTwoLabel2.Text = "Level up to: 10 \r\nWill cost you: 500";
            this.ScreenTwoLabel2.Visible = false;
            // 
            // ScreenTwoButton3
            // 
            this.ScreenTwoButton3.Enabled = false;
            this.ScreenTwoButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton3.Location = new System.Drawing.Point(12, 233);
            this.ScreenTwoButton3.Name = "ScreenTwoButton3";
            this.ScreenTwoButton3.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton3.TabIndex = 12;
            this.ScreenTwoButton3.Text = "Upgrade Shervin";
            this.ScreenTwoButton3.UseVisualStyleBackColor = true;
            this.ScreenTwoButton3.Visible = false;
            // 
            // ScreenTwoButton4
            // 
            this.ScreenTwoButton4.Enabled = false;
            this.ScreenTwoButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton4.Location = new System.Drawing.Point(12, 285);
            this.ScreenTwoButton4.Name = "ScreenTwoButton4";
            this.ScreenTwoButton4.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton4.TabIndex = 13;
            this.ScreenTwoButton4.Text = "Upgrade Shervin";
            this.ScreenTwoButton4.UseVisualStyleBackColor = true;
            this.ScreenTwoButton4.Visible = false;
            // 
            // ScreenTwoLabel3
            // 
            this.ScreenTwoLabel3.Enabled = false;
            this.ScreenTwoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabel3.Location = new System.Drawing.Point(118, 233);
            this.ScreenTwoLabel3.Name = "ScreenTwoLabel3";
            this.ScreenTwoLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabel3.Size = new System.Drawing.Size(206, 46);
            this.ScreenTwoLabel3.TabIndex = 14;
            this.ScreenTwoLabel3.Tag = "";
            this.ScreenTwoLabel3.Text = "Level up to: 10 \r\nWill cost you: 500";
            this.ScreenTwoLabel3.Visible = false;
            // 
            // ScreenTwoLabel4
            // 
            this.ScreenTwoLabel4.Enabled = false;
            this.ScreenTwoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabel4.Location = new System.Drawing.Point(118, 285);
            this.ScreenTwoLabel4.Name = "ScreenTwoLabel4";
            this.ScreenTwoLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabel4.Size = new System.Drawing.Size(206, 46);
            this.ScreenTwoLabel4.TabIndex = 15;
            this.ScreenTwoLabel4.Tag = "";
            this.ScreenTwoLabel4.Text = "Level up to: 10 \r\nWill cost you: 500";
            this.ScreenTwoLabel4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 483);
            this.Controls.Add(this.ScreenTwoLabel4);
            this.Controls.Add(this.ScreenTwoLabel3);
            this.Controls.Add(this.ScreenTwoButton4);
            this.Controls.Add(this.ScreenTwoButton3);
            this.Controls.Add(this.ScreenTwoLabel2);
            this.Controls.Add(this.ScreenTwoButton2);
            this.Controls.Add(this.ScreenTwoLabel1);
            this.Controls.Add(this.ScreenTwoButton1);
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
        private System.Windows.Forms.Button ScreenTwoButton1;
        private System.Windows.Forms.Label ScreenTwoLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ScreenTwoButton2;
        private System.Windows.Forms.Label ScreenTwoLabel2;
        private System.Windows.Forms.Button ScreenTwoButton3;
        private System.Windows.Forms.Button ScreenTwoButton4;
        private System.Windows.Forms.Label ScreenTwoLabel3;
        private System.Windows.Forms.Label ScreenTwoLabel4;
    }
}

