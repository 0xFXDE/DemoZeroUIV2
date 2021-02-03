using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoZeroUIV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //defin ur bools here
        bool Z1Menu = true;
        
        private void Formination_Tick(object sender, EventArgs e)
        {
            if (Z1Menu)
            {
                this.Width += 5;
                this.Left += 5;
                this.Width += 5;
                if (this.Width >= 685)
                {

                    Formination.Stop();
                    Headeranimation.Start();
                    Z1Menu = false; //false is closed
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homemenu.Visible = !Homemenu.Visible;
        }
        private Point MouseDownLocation;
        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            } //detects if your left mouse button is held down

        }

        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }//sets xand y position of the form to your cursor location.
        }

        private void Homemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        WebClient weeboclient = new WebClient();
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = weeboclient.DownloadString("https://raw.githubusercontent.com/0xFXDE/DemoZeroUIV2/main/Changelog"); 
            //this loads the changelog
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("discord link");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Create("path to where u want to make the directory to ur menu");
            weeboclient.DownloadFile("link to file", "file name.dll.exe with file extension ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("location of file.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page1.Visible = !page1.Visible;
        }

        Notification notif = new Notification();
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DemoZeroUIV2.Properties.Settings.Default.msg = textBox1.Text; // use this to set the text of the notification...
            notif.Show();
        }


        bool wot1 = true;
        bool wot2 = false;
        private void Headeranimation_Tick(object sender, EventArgs e)
        {

            
                if (pictureBox1.Height.ToString() == "400")
                {
                wot1 = true;
                 }
                else if (pictureBox1.Height.ToString() == "0")
                {
                wot1 = false;
                wot2 = true;
                }
            if (wot1)
            {
                pictureBox1.Height -= 1; //1 is speed
            }
            if (wot2)
            {
                pictureBox1.Height += 1; //1 is speed, 
            }
        }
    }
}
