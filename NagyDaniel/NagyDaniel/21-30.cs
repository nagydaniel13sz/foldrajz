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
    public partial class _21_30 : Form
    {
        public _21_30()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int sorszam = int.Parse((sender as ToolStripMenuItem).Text);

            var megjelenit = new megjelenit(sorszam);
            megjelenit.Show();
        }
    }
}
