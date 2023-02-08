namespace Game_2048
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
        private Label[,] labelsMap; 
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMap();
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize,mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i,j);
                    Controls.Add(newLabel);
                    labelsMap[i,j] = newLabel;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();

            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label.Size = new Size(140, 140);
            //label.Text = number.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;

            int x = 12 + indexColumn * 152;
            int y = 100 + indexRow * 152;

            label.Location = new Point(x, y);

            return label;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rulesOfTheGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.Show();
        }
    }
}