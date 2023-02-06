
namespace Game_2048
{
    public partial class WelcomeForm : Form
    {
        public List<System.Windows.Forms.RadioButton> radioButtons;
        public WelcomeForm()
        {
            InitializeComponent();
            radioButtons = new List<System.Windows.Forms.RadioButton>
            {
                radioButton1, radioButton2, radioButton3, radioButton4
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Please, enter your name");
            }
            else
            {
                Close();
            }
        }
    }
}
