using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMusicPlayer01
{
    public partial class Form1 : Form
    {
        Music m = new Music();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                m.open(ofd1.FileName);
                textBox1.Text = ofd1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.stop();
            textBox1.Text = "";
        }
    }
}
