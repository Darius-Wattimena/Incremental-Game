using System.Windows.Forms;

namespace Incremental_Game
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        private Field _field = new Field();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            screenOneLabel2.Text = _field.GetCurrentPoints().ToString();
            screenOneLabel4.Text = _field.GetCurrentLevel().ToString();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("ScoreClick");
            screenOneLabel2.Text = _field.GetCurrentPoints().ToString();
        }

        private void homeButton_Click(object sender, System.EventArgs e)
        {
            screenOneButton.Enabled = true;
            screenOneButton.Visible = true;
            screenOneLabel2.Enabled = true;
            screenOneLabel2.Visible = true;
            screenOneLabel3.Enabled = true;
            screenOneLabel3.Visible = true;
            screenOneLabel4.Enabled = true;
            screenOneLabel4.Visible = true;
            ScreenTwoButton1.Enabled = false;
            ScreenTwoButton1.Visible = false;
            ScreenTwoButton2.Enabled = false;
            ScreenTwoButton2.Visible = false;
            ScreenTwoButton3.Enabled = false;
            ScreenTwoButton3.Visible = false;
            ScreenTwoButton4.Enabled = false;
            ScreenTwoButton4.Visible = false;
            ScreenTwoLabel1.Enabled = false;
            ScreenTwoLabel1.Visible = false;
            ScreenTwoLabel2.Enabled = false;
            ScreenTwoLabel2.Visible = false;
            ScreenTwoLabel3.Enabled = false;
            ScreenTwoLabel3.Visible = false;
            ScreenTwoLabel4.Enabled = false;
            ScreenTwoLabel4.Visible = false;
        }

        private void upgradeButton_Click(object sender, System.EventArgs e)
        {
            var totalLevelPlusOne = _field.GetCurrentLevel() + 1;
            screenOneButton.Enabled = false;
            screenOneButton.Visible = false;
            ScreenTwoLabel1.Text = @"Level up to " + totalLevelPlusOne + @"
"+@"This will cost you " + _field.GetUpgradeCost("Click");
            ScreenTwoButton1.Enabled = true;
            ScreenTwoButton1.Visible = true;
            ScreenTwoButton2.Enabled = true;
            ScreenTwoButton2.Visible = true;
            ScreenTwoButton3.Enabled = true;
            ScreenTwoButton3.Visible = true;
            ScreenTwoButton4.Enabled = true;
            ScreenTwoButton4.Visible = true;
            ScreenTwoLabel1.Enabled = true;
            ScreenTwoLabel1.Visible = true;
            ScreenTwoLabel2.Enabled = true;
            ScreenTwoLabel2.Visible = true;
            ScreenTwoLabel3.Enabled = true;
            ScreenTwoLabel3.Visible = true;
            ScreenTwoLabel4.Enabled = true;
            ScreenTwoLabel4.Visible = true;
        }

        private void ScreenTwoButton_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("UpgradeClick");
            var totalLevelPlusOne = _field.GetCurrentLevel() + 1;
            screenOneLabel2.Text = _field.GetCurrentPoints().ToString();
            screenOneLabel4.Text = _field.GetCurrentLevel().ToString();
            ScreenTwoLabel1.Text = @"Level up to " + totalLevelPlusOne + @"
" + @"This will cost you " + _field.GetUpgradeCost("Click");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            soundPlayer.SoundLocation= "https://dl.dropbox.com/s/4wga8bmjhlfd9qb/datBoi.wav";
            soundPlayer.Play();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

        }
    }
}
