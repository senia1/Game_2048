using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_2048
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void resultsCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var users = UserManager.GetAll();

            foreach (var user in users)
            {
                resultsDataGridView.Rows.Add(user.Name, user.Score);
            }
        }
    }
}
