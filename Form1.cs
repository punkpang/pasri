using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llpanel.Height = home.Height;
            llpanel.Top = home.Top;
            home_Control1.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            llpanel.Height = home.Height;
            llpanel.Top = home.Top;
            home_Control1.BringToFront();
        }

        private void room_Click(object sender, EventArgs e)
        {
            llpanel.Height = me.Height;
            llpanel.Top = me.Top;
            me11.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // เป็นปุ่มออก
        }

        private void llpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Control1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void reserve_Click(object sender, EventArgs e)
        {
            llpanel.Height = prakan.Height;
            llpanel.Top = prakan.Top;
            prakan22.BringToFront();
        }

        private void me11_Load(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            llpanel.Height = sub.Height;
            llpanel.Top = sub.Top;
            sub33.BringToFront();
        }

        private void jak_Click(object sender, EventArgs e)
        {
            llpanel.Height = jak.Height;
            llpanel.Top = jak.Top;
            jak44.BringToFront();
        }

        private void lod_Click(object sender, EventArgs e)
        {
            llpanel.Height = lod.Height;
            llpanel.Top = lod.Top;
            lod55.BringToFront();
        }

        private void lod55_Load(object sender, EventArgs e)
        {

        }

        private void jak44_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mix_Click(object sender, EventArgs e)
        {
            
        }

        private void billControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            llpanel.Height = mix.Height;
            llpanel.Top = mix.Top;
            userControl21.BringToFront();
        }
    }
}
