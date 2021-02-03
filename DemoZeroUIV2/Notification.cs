using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoZeroUIV2
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }



        private void Notification_Load(object sender, EventArgs e)
        {
      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = DemoZeroUIV2.Properties.Settings.Default.msg;
        }

        private void animator_Tick(object sender, EventArgs e)

        { 
        }
    }
}
