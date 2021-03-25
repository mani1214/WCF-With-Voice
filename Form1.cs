using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            sp.SpeakAsync(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp.Resume();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
        }
    }
}
