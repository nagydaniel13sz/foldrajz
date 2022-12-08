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
    public partial class _51_60 : Form
    {
        public _51_60()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void _51_60_Click(object sender, EventArgs e)
        {
            int sorszam = int.Parse((sender as ToolStripMenuItem).Text);

            var megjelenit = new megjelenit(sorszam);
            megjelenit.Show();
        }
    }
}
