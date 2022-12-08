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
    public partial class _41_50 : Form
    {
        public _41_50()
        {
            InitializeComponent();
        }

        private void _31_40_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void _41_50_Click(object sender, EventArgs e)
        {
            int sorszam = int.Parse((sender as ToolStripMenuItem).Text);

            var megjelenit = new megjelenit(sorszam);
            megjelenit.Show();
        }
    }
}
