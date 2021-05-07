using System;
using System.Windows.Forms;

namespace HalloWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new Label() { Text = "Hallo", Left = 34 });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            splitContainer1.Panel2.Controls.Add(new UserControl1() { Dock = DockStyle.Fill });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            splitContainer1.Panel2.Controls.Add(new UserControl2() { Dock = DockStyle.Fill });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Width = 800;
            form.Height = 600;
            form.Controls.Add(new UserControl1() { Dock = DockStyle.Fill });
            form.Show();
        }
    }
}
