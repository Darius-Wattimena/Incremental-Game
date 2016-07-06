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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScreenTwoButton2 = new System.Windows.Forms.Button();
            this.ScreenTwoLabelShervin1 = new System.Windows.Forms.Label();
            this.ScreenTwoButton3 = new System.Windows.Forms.Button();
            this.ScreenTwoButton4 = new System.Windows.Forms.Button();
            this.ScreenTwoLabelClick1 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelRuben1 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelFrank1 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelClick3 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelClick2 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelShervin2 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelShervin3 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelRuben2 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelRuben3 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelFrank2 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelFrank3 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelFrank4 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelRuben4 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelShervin4 = new System.Windows.Forms.Label();
            this.ScreenTwoLabelClick4 = new System.Windows.Forms.Label();
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
            this.screenOneLabel2.Size = new System.Drawing.Size(148, 25);
            this.screenOneLabel2.TabIndex = 5;
            this.screenOneLabel2.Tag = "";
            this.screenOneLabel2.Text = "Points";
            // 
            // screenOneLabel3
            // 
            this.screenOneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenOneLabel3.Location = new System.Drawing.Point(157, 101);
            this.screenOneLabel3.Name = "screenOneLabel3";
            this.screenOneLabel3.Size = new System.Drawing.Size(124, 25);
            this.screenOneLabel3.TabIndex = 6;
            this.screenOneLabel3.Tag = "";
            this.screenOneLabel3.Text = "Click Level:";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScreenTwoButton2
            // 
            this.ScreenTwoButton2.Enabled = false;
            this.ScreenTwoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton2.Location = new System.Drawing.Point(12, 211);
            this.ScreenTwoButton2.Name = "ScreenTwoButton2";
            this.ScreenTwoButton2.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton2.TabIndex = 10;
            this.ScreenTwoButton2.Text = "Upgrade Shervin";
            this.ScreenTwoButton2.UseVisualStyleBackColor = true;
            this.ScreenTwoButton2.Visible = false;
            this.ScreenTwoButton2.Click += new System.EventHandler(this.ScreenTwoButton2_Click);
            // 
            // ScreenTwoLabelShervin1
            // 
            this.ScreenTwoLabelShervin1.Enabled = false;
            this.ScreenTwoLabelShervin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelShervin1.Location = new System.Drawing.Point(118, 211);
            this.ScreenTwoLabelShervin1.Name = "ScreenTwoLabelShervin1";
            this.ScreenTwoLabelShervin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelShervin1.Size = new System.Drawing.Size(206, 55);
            this.ScreenTwoLabelShervin1.TabIndex = 11;
            this.ScreenTwoLabelShervin1.Tag = "";
            this.ScreenTwoLabelShervin1.Text = "Description";
            this.ScreenTwoLabelShervin1.Visible = false;
            // 
            // ScreenTwoButton3
            // 
            this.ScreenTwoButton3.Enabled = false;
            this.ScreenTwoButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton3.Location = new System.Drawing.Point(12, 292);
            this.ScreenTwoButton3.Name = "ScreenTwoButton3";
            this.ScreenTwoButton3.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton3.TabIndex = 12;
            this.ScreenTwoButton3.Text = "Upgrade Ruben";
            this.ScreenTwoButton3.UseVisualStyleBackColor = true;
            this.ScreenTwoButton3.Visible = false;
            this.ScreenTwoButton3.Click += new System.EventHandler(this.ScreenTwoButton3_Click);
            // 
            // ScreenTwoButton4
            // 
            this.ScreenTwoButton4.Enabled = false;
            this.ScreenTwoButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoButton4.Location = new System.Drawing.Point(12, 374);
            this.ScreenTwoButton4.Name = "ScreenTwoButton4";
            this.ScreenTwoButton4.Size = new System.Drawing.Size(100, 46);
            this.ScreenTwoButton4.TabIndex = 13;
            this.ScreenTwoButton4.Text = "Upgrade Frank";
            this.ScreenTwoButton4.UseVisualStyleBackColor = true;
            this.ScreenTwoButton4.Visible = false;
            this.ScreenTwoButton4.Click += new System.EventHandler(this.ScreenTwoButton4_Click);
            // 
            // ScreenTwoLabelClick1
            // 
            this.ScreenTwoLabelClick1.Enabled = false;
            this.ScreenTwoLabelClick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelClick1.Location = new System.Drawing.Point(118, 129);
            this.ScreenTwoLabelClick1.Name = "ScreenTwoLabelClick1";
            this.ScreenTwoLabelClick1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelClick1.Size = new System.Drawing.Size(206, 55);
            this.ScreenTwoLabelClick1.TabIndex = 14;
            this.ScreenTwoLabelClick1.Tag = "";
            this.ScreenTwoLabelClick1.Text = "Description";
            this.ScreenTwoLabelClick1.Visible = false;
            // 
            // ScreenTwoLabelRuben1
            // 
            this.ScreenTwoLabelRuben1.Enabled = false;
            this.ScreenTwoLabelRuben1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelRuben1.Location = new System.Drawing.Point(118, 292);
            this.ScreenTwoLabelRuben1.Name = "ScreenTwoLabelRuben1";
            this.ScreenTwoLabelRuben1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelRuben1.Size = new System.Drawing.Size(206, 55);
            this.ScreenTwoLabelRuben1.TabIndex = 15;
            this.ScreenTwoLabelRuben1.Tag = "";
            this.ScreenTwoLabelRuben1.Text = "Description";
            this.ScreenTwoLabelRuben1.Visible = false;
            // 
            // ScreenTwoLabelFrank1
            // 
            this.ScreenTwoLabelFrank1.Enabled = false;
            this.ScreenTwoLabelFrank1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelFrank1.Location = new System.Drawing.Point(118, 374);
            this.ScreenTwoLabelFrank1.Name = "ScreenTwoLabelFrank1";
            this.ScreenTwoLabelFrank1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelFrank1.Size = new System.Drawing.Size(206, 55);
            this.ScreenTwoLabelFrank1.TabIndex = 16;
            this.ScreenTwoLabelFrank1.Tag = "";
            this.ScreenTwoLabelFrank1.Text = "Description";
            this.ScreenTwoLabelFrank1.Visible = false;
            // 
            // ScreenTwoLabelClick3
            // 
            this.ScreenTwoLabelClick3.Enabled = false;
            this.ScreenTwoLabelClick3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelClick3.Location = new System.Drawing.Point(118, 184);
            this.ScreenTwoLabelClick3.Name = "ScreenTwoLabelClick3";
            this.ScreenTwoLabelClick3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelClick3.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelClick3.TabIndex = 17;
            this.ScreenTwoLabelClick3.Tag = "";
            this.ScreenTwoLabelClick3.Text = "Price";
            this.ScreenTwoLabelClick3.Visible = false;
            // 
            // ScreenTwoLabelClick2
            // 
            this.ScreenTwoLabelClick2.Enabled = false;
            this.ScreenTwoLabelClick2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelClick2.Location = new System.Drawing.Point(12, 184);
            this.ScreenTwoLabelClick2.Name = "ScreenTwoLabelClick2";
            this.ScreenTwoLabelClick2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelClick2.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelClick2.TabIndex = 18;
            this.ScreenTwoLabelClick2.Tag = "";
            this.ScreenTwoLabelClick2.Text = "Current Level";
            this.ScreenTwoLabelClick2.Visible = false;
            // 
            // ScreenTwoLabelShervin2
            // 
            this.ScreenTwoLabelShervin2.Enabled = false;
            this.ScreenTwoLabelShervin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelShervin2.Location = new System.Drawing.Point(12, 266);
            this.ScreenTwoLabelShervin2.Name = "ScreenTwoLabelShervin2";
            this.ScreenTwoLabelShervin2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelShervin2.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelShervin2.TabIndex = 20;
            this.ScreenTwoLabelShervin2.Tag = "";
            this.ScreenTwoLabelShervin2.Text = "Current Level";
            this.ScreenTwoLabelShervin2.Visible = false;
            // 
            // ScreenTwoLabelShervin3
            // 
            this.ScreenTwoLabelShervin3.Enabled = false;
            this.ScreenTwoLabelShervin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelShervin3.Location = new System.Drawing.Point(118, 266);
            this.ScreenTwoLabelShervin3.Name = "ScreenTwoLabelShervin3";
            this.ScreenTwoLabelShervin3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelShervin3.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelShervin3.TabIndex = 19;
            this.ScreenTwoLabelShervin3.Tag = "";
            this.ScreenTwoLabelShervin3.Text = "Price";
            this.ScreenTwoLabelShervin3.Visible = false;
            // 
            // ScreenTwoLabelRuben2
            // 
            this.ScreenTwoLabelRuben2.Enabled = false;
            this.ScreenTwoLabelRuben2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelRuben2.Location = new System.Drawing.Point(12, 347);
            this.ScreenTwoLabelRuben2.Name = "ScreenTwoLabelRuben2";
            this.ScreenTwoLabelRuben2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelRuben2.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelRuben2.TabIndex = 22;
            this.ScreenTwoLabelRuben2.Tag = "";
            this.ScreenTwoLabelRuben2.Text = "Current Level";
            this.ScreenTwoLabelRuben2.Visible = false;
            // 
            // ScreenTwoLabelRuben3
            // 
            this.ScreenTwoLabelRuben3.Enabled = false;
            this.ScreenTwoLabelRuben3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelRuben3.Location = new System.Drawing.Point(118, 347);
            this.ScreenTwoLabelRuben3.Name = "ScreenTwoLabelRuben3";
            this.ScreenTwoLabelRuben3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelRuben3.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelRuben3.TabIndex = 21;
            this.ScreenTwoLabelRuben3.Tag = "";
            this.ScreenTwoLabelRuben3.Text = "Price";
            this.ScreenTwoLabelRuben3.Visible = false;
            // 
            // ScreenTwoLabelFrank2
            // 
            this.ScreenTwoLabelFrank2.Enabled = false;
            this.ScreenTwoLabelFrank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelFrank2.Location = new System.Drawing.Point(12, 429);
            this.ScreenTwoLabelFrank2.Name = "ScreenTwoLabelFrank2";
            this.ScreenTwoLabelFrank2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelFrank2.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelFrank2.TabIndex = 24;
            this.ScreenTwoLabelFrank2.Tag = "";
            this.ScreenTwoLabelFrank2.Text = "Current Level";
            this.ScreenTwoLabelFrank2.Visible = false;
            // 
            // ScreenTwoLabelFrank3
            // 
            this.ScreenTwoLabelFrank3.Enabled = false;
            this.ScreenTwoLabelFrank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelFrank3.Location = new System.Drawing.Point(118, 429);
            this.ScreenTwoLabelFrank3.Name = "ScreenTwoLabelFrank3";
            this.ScreenTwoLabelFrank3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelFrank3.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelFrank3.TabIndex = 23;
            this.ScreenTwoLabelFrank3.Tag = "";
            this.ScreenTwoLabelFrank3.Text = "Price";
            this.ScreenTwoLabelFrank3.Visible = false;
            // 
            // ScreenTwoLabelFrank4
            // 
            this.ScreenTwoLabelFrank4.Enabled = false;
            this.ScreenTwoLabelFrank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelFrank4.Location = new System.Drawing.Point(221, 429);
            this.ScreenTwoLabelFrank4.Name = "ScreenTwoLabelFrank4";
            this.ScreenTwoLabelFrank4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelFrank4.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelFrank4.TabIndex = 28;
            this.ScreenTwoLabelFrank4.Tag = "";
            this.ScreenTwoLabelFrank4.Text = "Profit";
            this.ScreenTwoLabelFrank4.Visible = false;
            // 
            // ScreenTwoLabelRuben4
            // 
            this.ScreenTwoLabelRuben4.Enabled = false;
            this.ScreenTwoLabelRuben4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelRuben4.Location = new System.Drawing.Point(221, 347);
            this.ScreenTwoLabelRuben4.Name = "ScreenTwoLabelRuben4";
            this.ScreenTwoLabelRuben4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelRuben4.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelRuben4.TabIndex = 27;
            this.ScreenTwoLabelRuben4.Tag = "";
            this.ScreenTwoLabelRuben4.Text = "Profit";
            this.ScreenTwoLabelRuben4.Visible = false;
            // 
            // ScreenTwoLabelShervin4
            // 
            this.ScreenTwoLabelShervin4.Enabled = false;
            this.ScreenTwoLabelShervin4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelShervin4.Location = new System.Drawing.Point(221, 266);
            this.ScreenTwoLabelShervin4.Name = "ScreenTwoLabelShervin4";
            this.ScreenTwoLabelShervin4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelShervin4.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelShervin4.TabIndex = 26;
            this.ScreenTwoLabelShervin4.Tag = "";
            this.ScreenTwoLabelShervin4.Text = "Profit";
            this.ScreenTwoLabelShervin4.Visible = false;
            // 
            // ScreenTwoLabelClick4
            // 
            this.ScreenTwoLabelClick4.Enabled = false;
            this.ScreenTwoLabelClick4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTwoLabelClick4.Location = new System.Drawing.Point(221, 184);
            this.ScreenTwoLabelClick4.Name = "ScreenTwoLabelClick4";
            this.ScreenTwoLabelClick4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTwoLabelClick4.Size = new System.Drawing.Size(100, 24);
            this.ScreenTwoLabelClick4.TabIndex = 25;
            this.ScreenTwoLabelClick4.Tag = "";
            this.ScreenTwoLabelClick4.Text = "Profit";
            this.ScreenTwoLabelClick4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 483);
            this.Controls.Add(this.ScreenTwoLabelFrank4);
            this.Controls.Add(this.ScreenTwoLabelRuben4);
            this.Controls.Add(this.ScreenTwoLabelShervin4);
            this.Controls.Add(this.ScreenTwoLabelClick4);
            this.Controls.Add(this.ScreenTwoLabelFrank2);
            this.Controls.Add(this.ScreenTwoLabelFrank3);
            this.Controls.Add(this.ScreenTwoLabelRuben2);
            this.Controls.Add(this.ScreenTwoLabelRuben3);
            this.Controls.Add(this.ScreenTwoLabelShervin2);
            this.Controls.Add(this.ScreenTwoLabelShervin3);
            this.Controls.Add(this.ScreenTwoLabelClick2);
            this.Controls.Add(this.ScreenTwoLabelClick3);
            this.Controls.Add(this.ScreenTwoLabelFrank1);
            this.Controls.Add(this.ScreenTwoLabelRuben1);
            this.Controls.Add(this.ScreenTwoLabelClick1);
            this.Controls.Add(this.ScreenTwoButton4);
            this.Controls.Add(this.ScreenTwoButton3);
            this.Controls.Add(this.ScreenTwoLabelShervin1);
            this.Controls.Add(this.ScreenTwoButton2);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ScreenTwoButton2;
        private System.Windows.Forms.Label ScreenTwoLabelShervin1;
        private System.Windows.Forms.Button ScreenTwoButton3;
        private System.Windows.Forms.Button ScreenTwoButton4;
        private System.Windows.Forms.Label ScreenTwoLabelClick1;
        private System.Windows.Forms.Label ScreenTwoLabelRuben1;
        private System.Windows.Forms.Label ScreenTwoLabelFrank1;
        private System.Windows.Forms.Label ScreenTwoLabelClick3;
        private System.Windows.Forms.Label ScreenTwoLabelClick2;
        private System.Windows.Forms.Label ScreenTwoLabelShervin2;
        private System.Windows.Forms.Label ScreenTwoLabelShervin3;
        private System.Windows.Forms.Label ScreenTwoLabelRuben2;
        private System.Windows.Forms.Label ScreenTwoLabelRuben3;
        private System.Windows.Forms.Label ScreenTwoLabelFrank2;
        private System.Windows.Forms.Label ScreenTwoLabelFrank3;
        private System.Windows.Forms.Label ScreenTwoLabelFrank4;
        private System.Windows.Forms.Label ScreenTwoLabelRuben4;
        private System.Windows.Forms.Label ScreenTwoLabelShervin4;
        private System.Windows.Forms.Label ScreenTwoLabelClick4;
    }
}

