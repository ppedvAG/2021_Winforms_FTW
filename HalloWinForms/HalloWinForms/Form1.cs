using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeinTollesZeug;

namespace HalloWinForms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label4.Text = Properties.Resources.HalloText;

            this.BackColor = Properties.Settings.Default.MeineFarbe;
            label5.Text = Properties.Settings.Default.CoolerText;

#if DEBUG
            this.BackColor = Color.Chocolate;
#endif
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //Console.Beep(300, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Console.Beep(659, 125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(523, 125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(784, 125);
                Thread.Sleep(375);
                Console.Beep(392, 125);
                Thread.Sleep(375);
                Console.Beep(523, 125);
                Thread.Sleep(250);
                Console.Beep(392, 125);
                Thread.Sleep(250);
                Console.Beep(330, 125);
                Thread.Sleep(250);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(494, 125);
                Thread.Sleep(125);
                Console.Beep(466, 125);
                Thread.Sleep(42);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(392, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(880, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                Thread.Sleep(125);
                Console.Beep(523, 125);
                Thread.Sleep(250);
                Console.Beep(392, 125);
                Thread.Sleep(250);
                Console.Beep(330, 125);
                Thread.Sleep(250);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(494, 125);
                Thread.Sleep(125);
                Console.Beep(466, 125);
                Thread.Sleep(42);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(392, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(880, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                Thread.Sleep(375);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(698, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(698, 125);
                Thread.Sleep(625);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(622, 125);
                Thread.Sleep(250);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(523, 125);
                Thread.Sleep(1125);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(698, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(698, 125);
                Thread.Sleep(625);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(622, 125);
                Thread.Sleep(250);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(523, 125);
                Thread.Sleep(625);
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 2;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void allesLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }


        private void button13_Click(object sender, EventArgs e)
        {
            var result = FindAndSelectTreeNode(treeView1.Nodes, "DE");

            if (result != null)
            {
                MessageBox.Show(result.Text + " " + result.Index.ToString());
                treeView1.Focus(); //damit beim select es blau in hintergrund wird
                treeView1.SelectedNode = result;
            }
        }

        /// <summary>
        /// Sucht rekursiv nach dem Knotentext und gibt diesen zurück
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="nodes">Zu durchsuchenden Knoten </param>
        /// <param name="such">Suchtext</param>
        /// <returns>Der erste Knoten mit dem gesuchten Text</returns>
        public TreeNode FindAndSelectTreeNode(TreeNodeCollection nodes, string such)
        {


            foreach (TreeNode node in nodes)
            {
                if (node.Text == such)
                    return node;

                var r = FindAndSelectTreeNode(node.Nodes, such);
                if (r != null)
                    return r;
            }

            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Button() { Text = "Neue Button", AutoSize = true });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.DateTime datum;

        }

        MeinTollesZeug.MeinTolleKLasse mtk = new MeinTollesZeug.MeinTolleKLasse();
        private object mkt;

        private void button10_Click(object sender, EventArgs e)
        {
            mtk.MachMuhhhhh();
            label4.Text = mtk.Text;
            int zahl1 = 15;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        int zahl1 = 25;
                    }
                }

                for (int i = 0; i < 12; i++)
                {

                }
                for (int i = 0; i < 12; i++)
                {

                }
            }
            mtk.Text = textBox1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int Zahl = 12;
            decimal Geld = 124m;
            double Wert = 124;

            MeinTolleKLasse mtk = null;//deklaration
            mtk = new MeinTolleKLasse(); //instanzierung            

            mtk.Text = "AAAAHHHH";

            mtk.SetOrt("Bayern");


            mtk.GetOrt();
            MessageBox.Show(mtk.GetOrt());

            mtk.Plz = "123456";
            MessageBox.Show(mtk.Plz);

            mtk.Bundesland = "BW";
            MessageBox.Show(mtk.Bundesland);


            ZeigeText(mtk);
            ZeigeText(mtk);

            ZeigeZahl(Zahl);
            ZeigeZahl(Zahl);

            List<MeinTolleKLasse> uff = new List<MeinTolleKLasse>();
            while (true)
            {
                uff.Add(new MeinTolleKLasse("Fred"));
            }
        }

        public void ZeigeZahl(int z)
        {
            MessageBox.Show(z.ToString());
            z += 100;
        }

        private void ZeigeText(MeinTolleKLasse wurscht)
        {
            MessageBox.Show(wurscht.Text);
            wurscht.Text = "BBBBBBBB";
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Mittlere Maustaste");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var num = 4375 / int.Parse("0");
        }
    }
}
