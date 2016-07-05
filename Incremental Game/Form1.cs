using System.Windows.Forms;

namespace Incremental_Game
{
    public partial class Form1 : Form
    {
        private Field _field = new Field();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            screenOneLabel2.Text = _field.GetCurrentPoints();
            screenOneLabel4.Text = _field.GetCurrentLevel().ToString();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("ScoreClick");
            screenOneLabel2.Text = _field.GetCurrentPoints();
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
            ScreenTwoButton.Enabled = false;
            ScreenTwoButton.Visible = false;
            ScreenTwoLabel.Enabled = false;
            ScreenTwoLabel.Visible = false;
        }

        private void upgradeButton_Click(object sender, System.EventArgs e)
        {
            var TotalLevelPlusOne = _field.GetCurrentLevel() + 1;
            screenOneButton.Enabled = false;
            screenOneButton.Visible = false;
            ScreenTwoButton.Enabled = true;
            ScreenTwoButton.Visible = true;
            ScreenTwoLabel.Text = @"Level up to " + TotalLevelPlusOne + @"
"+@"This will cost you " + _field.GetUpgradeCost("Click");
            ScreenTwoLabel.Enabled = true;
            ScreenTwoLabel.Visible = true;
        }

        private void ScreenTwoButton_Click(object sender, System.EventArgs e)
        {
            _field.ClickReceive("UpgradeClick");
            var TotalLevelPlusOne = _field.GetCurrentLevel() + 1;
            screenOneLabel2.Text = _field.GetCurrentPoints();
            screenOneLabel4.Text = _field.GetCurrentLevel().ToString();
            ScreenTwoLabel.Text = @"Level up to " + TotalLevelPlusOne + @"
" + @"This will cost you " + _field.GetUpgradeCost("Click");
        }
    }
}
