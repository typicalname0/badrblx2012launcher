using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace badrblx2012launcher
{
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            Process.Start("robloxapp.exe", "-script dofile(\"http://arandomphpfile.com/phpfile=" + userform.Text + "&ip=" + ipform.Text + "&port=" + portform.Text + "&id=" + rng.Next(0, 291943).ToString() + "&charapp=" + charappform.Text + "\"");
            timer1.Start(); // pretty much just edit the line above, theres not that much
        }

        private void creidts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void launcher_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }
    }
}
