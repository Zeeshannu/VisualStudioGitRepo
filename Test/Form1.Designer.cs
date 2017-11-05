namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.marquee1 = new Test.Marquee();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // marquee1
            // 
            this.marquee1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marquee1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marquee1.hover = false;
            this.marquee1.Location = new System.Drawing.Point(1, 2);
            this.marquee1.Name = "marquee1";
            this.marquee1.scrollSpeed = Test.Marquee.speed.fast;
            this.marquee1.ScrollText = "Zeeshan";
            this.marquee1.Size = new System.Drawing.Size(371, 90);
            this.marquee1.TabIndex = 0;
            this.marquee1.Scrolled += new System.EventHandler<Test.ScrollEventArgs>(this.marquee1_Scrolled);
            this.marquee1.MouseEnter += new System.EventHandler(this.marquee1_MouseEnter);
            this.marquee1.MouseLeave += new System.EventHandler(this.marquee1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marquee1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Marquee marquee1;
        private System.Windows.Forms.Label label1;
    }
}

