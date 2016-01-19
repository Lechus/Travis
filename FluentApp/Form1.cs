using System;
using System.Windows.Forms;

namespace FluentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Will send these data:" + Environment.NewLine + "Firstname: " + firstname.Text + "LastName: " + lastname.Text);
        }
    }
}
