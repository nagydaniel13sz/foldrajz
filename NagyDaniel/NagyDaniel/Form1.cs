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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lekerdezesek.Load();
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var _1_10 = new _1_10();
            _1_10.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var _11_20 = new _11_20();
            _11_20.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var _21_30 = new _21_30();
            _21_30.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var _31_40 = new _31_40();
            _31_40.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var _41_50 = new _41_50();
            _41_50.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var _51_60 = new _51_60();
            _51_60.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var _61_64 = new _61_64();
            _61_64.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
