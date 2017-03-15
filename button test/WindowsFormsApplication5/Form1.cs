using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Hello1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Hello2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Hello3");
        }
    }
}
