using System;
using System.Windows.Forms;

namespace EventsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Move(object sender, EventArgs e)
        {
            L3.Text = Location.X.ToString();
            L4.Text = Location.Y.ToString();
        }
        private void B1_Click(object sender, EventArgs e)
        {
            using (Form f2 = new Form())
            {
                f2.Text = "Second Form";
                f2.StartPosition = FormStartPosition.CenterScreen;
                // f2.Controls.Add(...);
                f2.ShowDialog();
            }
        }
        private void B2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /////////////////////////////////////////////////
        private void B2_M(object sender, EventArgs e)
        {
            B2.BackColor = System.Drawing.Color.Red;
        }
        private void B2_L(object sender, EventArgs e)
        {
            B2.BackColor = System.Drawing.Color.Green;
        }
        /////////////////////////////////////////////////
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            string sX = Cursor.Position.X.ToString();
            string sY = Cursor.Position.Y.ToString();
            Text = "Main Form (X:" + sX + " Y:" + sY + ")";
        }
    }
}
