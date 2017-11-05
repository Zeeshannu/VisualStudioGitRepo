using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    [DefaultEvent("Scrolled")]
    public partial class Marquee : UserControl
    {
        ScrollEventArgs obj= new ScrollEventArgs();
        //event
        public event EventHandler<ScrollEventArgs> Scrolled;   //generic and basic

        public enum speed
        {
            fast,
            slow
        }

        //Properties
        public speed scrollSpeed { get; set; }
        [Description ("scroll speed")]

        public bool hover { get; set; }
       
          //************LABEL PROPERTY IN TOOLS*****************
        string _label;
        [Description("Marquee scroll text.")]
        public string ScrollText
        {
            get { return _label; }
            set
            {
                _label = value;
                this.Invalidate();  // means Onpaint forcefully called
            }
        }
        //*************

        int x = -1;
        protected override void OnPaint(PaintEventArgs e)  // .Net itself giving us graphic context in "e"
        {
            x++;
            base.OnPaint(e); // used to make previous setting as it is,

            SolidBrush brush = new SolidBrush(this.ForeColor);
            Font font = new Font(this.Font.FontFamily, 30);
            SizeF sizef = e.Graphics.MeasureString(_label, font);

            Point point = new Point
                (x,
                (ClientSize.Height - (int)sizef.Height) / 2
                );
            e.Graphics.DrawString(_label, font, brush, point);

            if (x == ClientSize.Width)
            {
                x = 0;
                obj.count+=1;
                Scrolled.Invoke(this, obj);
            }
        }

      

        public Marquee()
        {
            InitializeComponent();
        }

        private void Marquee_Load(object sender, EventArgs e)
        {
            obj.count = 0;
            if (!DesignMode)
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!hover)
            {
                if (scrollSpeed == speed.fast)
                {
                    timer1.Interval = 1;
                }
                else
                {
                    timer1.Interval = 100;
                }
                this.Invalidate(); //redraw
            }
        }
    }
    public class ScrollEventArgs : EventArgs
    {
        public int count { get; set; }
    }
}
