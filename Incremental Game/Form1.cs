using System.Windows.Forms;

namespace Incremental_Game
{
    public partial class Form1 : Form
    {
        private readonly System.Media.SoundPlayer _soundPlayer = new System.Media.SoundPlayer();
        private readonly Field _field = new Field();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            screenOneLabel2.Text = _field.GetCurrentPoints().ToString();
            screenOneLabel4.Text = _field.GetCurrentLevel("Click");
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("ScoreClick");
            screenOneLabel2.Text = _field.GetCurrentPoints().ToString();
        }

        private void homeButton_Click(object sender, System.EventArgs e)
        {
            ChangeButtons(true);
        }

        private void upgradeButton_Click(object sender, System.EventArgs e)
        {
            ChangeButtons(false);
            RefreshPrices();
        }

        private void ScreenTwoButton_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("UpgradeClick");
            RefreshPrices();
        }
        private void ScreenTwoButton2_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("UpgradeShervin");
            RefreshPrices();
        }

        private void ScreenTwoButton3_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("UpgradeRuben");
            RefreshPrices();
        }

        private void ScreenTwoButton4_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("UpgradeFrank");
            RefreshPrices();
        }
        private void button3_Click(object sender, System.EventArgs e)
        {
            _soundPlayer.SoundLocation= "https://dl.dropbox.com/s/4wga8bmjhlfd9qb/datBoi.wav";
            _soundPlayer.Play();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

        }

        public void RefreshPrices()
        {
            screenOneLabel2.Text = _field.GetCurrentPoints().ToString();
            screenOneLabel4.Text = _field.GetCurrentLevel("Click");
            ScreenTwoLabelClick1.Text = _field.GetUpgradeData("Click", "Description");
            ScreenTwoLabelClick2.Text = @"Current Level: " + _field.GetCurrentLevel("Click");
            ScreenTwoLabelClick3.Text = @"Price: " + _field.GetUpgradeData("Click", "Price");
            ScreenTwoLabelShervin1.Text = _field.GetUpgradeData("Shervin", "Description");
            ScreenTwoLabelShervin2.Text = @"Current Level: " + _field.GetCurrentLevel("Shervin");
            ScreenTwoLabelShervin3.Text = @"Price: " + _field.GetUpgradeData("Shervin", "Price");
            ScreenTwoLabelRuben1.Text = _field.GetUpgradeData("Ruben", "Description");
            ScreenTwoLabelRuben2.Text = @"Current Level: " + _field.GetCurrentLevel("Ruben");
            ScreenTwoLabelRuben3.Text = @"Price: " + _field.GetUpgradeData("Ruben", "Price");
            ScreenTwoLabelFrank1.Text = _field.GetUpgradeData("Frank", "Description");
            ScreenTwoLabelFrank2.Text = @"Current Level: " + _field.GetCurrentLevel("Frank");
            ScreenTwoLabelFrank3.Text = @"Price: " + _field.GetUpgradeData("Frank", "Price");

        }

        public void ChangeButtons(bool screenOne)
        {
            if (screenOne)
            {
                screenOneButton.Enabled = true;
                screenOneButton.Visible = true;
                ScreenTwoButton1.Enabled = false;
                ScreenTwoButton1.Visible = false;
                ScreenTwoButton2.Enabled = false;
                ScreenTwoButton2.Visible = false;
                ScreenTwoButton3.Enabled = false;
                ScreenTwoButton3.Visible = false;
                ScreenTwoButton4.Enabled = false;
                ScreenTwoButton4.Visible = false;
                ScreenTwoLabelClick1.Enabled = false;
                ScreenTwoLabelClick1.Visible = false;
                ScreenTwoLabelClick2.Enabled = false;
                ScreenTwoLabelClick2.Visible = false;
                ScreenTwoLabelClick3.Enabled = false;
                ScreenTwoLabelClick3.Visible = false;
                ScreenTwoLabelShervin1.Enabled = false;
                ScreenTwoLabelShervin1.Visible = false;
                ScreenTwoLabelShervin2.Enabled = false;
                ScreenTwoLabelShervin2.Visible = false;
                ScreenTwoLabelShervin3.Enabled = false;
                ScreenTwoLabelShervin3.Visible = false;
                ScreenTwoLabelRuben1.Enabled = false;
                ScreenTwoLabelRuben1.Visible = false;
                ScreenTwoLabelRuben2.Enabled = false;
                ScreenTwoLabelRuben2.Visible = false;
                ScreenTwoLabelRuben3.Enabled = false;
                ScreenTwoLabelRuben3.Visible = false;
                ScreenTwoLabelFrank1.Enabled = false;
                ScreenTwoLabelFrank1.Visible = false;
                ScreenTwoLabelFrank2.Enabled = false;
                ScreenTwoLabelFrank2.Visible = false;
                ScreenTwoLabelFrank3.Enabled = false;
                ScreenTwoLabelFrank3.Visible = false;
            }
            else
            {
                screenOneButton.Enabled = false;
                screenOneButton.Visible = false;
                ScreenTwoButton1.Enabled = true;
                ScreenTwoButton1.Visible = true;
                ScreenTwoButton2.Enabled = true;
                ScreenTwoButton2.Visible = true;
                ScreenTwoButton3.Enabled = true;
                ScreenTwoButton3.Visible = true;
                ScreenTwoButton4.Enabled = true;
                ScreenTwoButton4.Visible = true;
                ScreenTwoLabelClick1.Enabled = true;
                ScreenTwoLabelClick1.Visible = true;
                ScreenTwoLabelClick2.Enabled = true;
                ScreenTwoLabelClick2.Visible = true;
                ScreenTwoLabelClick3.Enabled = true;
                ScreenTwoLabelClick3.Visible = true;
                ScreenTwoLabelShervin1.Enabled = true;
                ScreenTwoLabelShervin1.Visible = true;
                ScreenTwoLabelShervin2.Enabled = true;
                ScreenTwoLabelShervin2.Visible = true;
                ScreenTwoLabelShervin3.Enabled = true;
                ScreenTwoLabelShervin3.Visible = true;
                ScreenTwoLabelRuben1.Enabled = true;
                ScreenTwoLabelRuben1.Visible = true;
                ScreenTwoLabelRuben2.Enabled = true;
                ScreenTwoLabelRuben2.Visible = true;
                ScreenTwoLabelRuben3.Enabled = true;
                ScreenTwoLabelRuben3.Visible = true;
                ScreenTwoLabelFrank1.Enabled = true;
                ScreenTwoLabelFrank1.Visible = true;
                ScreenTwoLabelFrank2.Enabled = true;
                ScreenTwoLabelFrank2.Visible = true;
                ScreenTwoLabelFrank3.Enabled = true;
                ScreenTwoLabelFrank3.Visible = true;
            }
        }
    }
}
