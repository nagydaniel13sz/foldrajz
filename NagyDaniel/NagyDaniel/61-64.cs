using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NagyDaniel
{
    public partial class _61_64 : Form
    {
        public _61_64()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void _61_64_Click(object sender, EventArgs e)
        {
            int sorszam = int.Parse((sender as ToolStripMenuItem).Text);

            var megjelenit = new megjelenit(sorszam);
            megjelenit.Show();
        }
    }
}
