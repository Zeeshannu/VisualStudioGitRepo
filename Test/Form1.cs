using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void marquee1_Load(object sender, EventArgs e)
        {

        }

        private void marquee1_Scrolled(object sender, ScrollEventArgs e)
        {
            label1.Text = e.count.ToString();
        }

        private void marquee1_MouseEnter(object sender, EventArgs e)
        {
            marquee1.hover = true;
        }

        private void marquee1_MouseLeave(object sender, EventArgs e)
        {
            marquee1.hover = false;
        }

       
    }
}
