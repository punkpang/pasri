using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Prakan2 : UserControl
    {
        public Prakan2()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Prakan2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                int a6 = int.Parse(textBox4.Text);
                if (a6 <= 9000) //มีการลดหย่อนไม่เกิน 5000ก็เอาค่านั้นมา
                {
                    a.Text = a6.ToString();
                }
                else  //ถ้ามันเกินก็ปัด ตามค่านั้น เช่น 60000
                {
                    a.Text = "9000";
                }
            }
            if (checkBox2.Checked)
            {
                int bb = int.Parse(textBox5.Text);
                if (bb <= 100000)
                {
                    b.Text = bb.ToString();
                }
                else
                {
                    b.Text = "100000";
                }
            }
            if (checkBox3.Checked)
            {
                int cc = int.Parse(b.Text);
                int bb;
                if (cc <= 100000)
                {
                    bb = 100000 - cc;
                    c.Text = bb.ToString();

                    if (bb <= 15000)
                    {
                        c.Text = bb.ToString();
                    }
                    else
                    {
                        c.Text = "15000";
                    }
                }
                if (checkBox4.Checked)
                {
                    int dd = int.Parse(textBox7.Text);
                    if (dd <= 15000)
                    {
                        d.Text = dd.ToString();
                    }
                    else
                    {
                        d.Text = "15000";
                    }
                }
                if (checkBox5.Checked)
                {
                    int pe = int.Parse(textBox8.Text);
                    if (pe <= 10000)
                    {
                        e5.Text = pe.ToString();
                    }
                    else
                    {
                        e5.Text = "10000";
                    }
                }
                if (checkBox6.Checked)
                {
                    int ff = int.Parse(textBox9.Text);
                    if (ff <= 10000)
                    {
                        f.Text = ff.ToString();
                    }
                    else
                    {
                        f.Text = "10000";
                    }
                }
                if (checkBox7.Checked)
                {
                    int gg = int.Parse(textBox10.Text);
                    if (gg <= 500000)
                    {
                        g.Text = gg.ToString();
                    }
                    else
                    {
                        g.Text = "500000";
                    }
                }
                int p;
                int aa = int.Parse(a.Text); 
                int ab = int.Parse(b.Text);
                int ac = int.Parse(c.Text);
                int ad = int.Parse(d.Text);
                int ae = int.Parse(e5.Text);
                int af = int.Parse(f.Text);
                int ag = int.Parse(g.Text);
                p = aa + ab + ac + ad + ae + af + ag; //รวมประกันเเต่ละอัน
                Program.grop2 = p;
                textBox11.Text = p.ToString();

                int b1 = int.Parse(total.Text);
                int b2 = int.Parse(textBox11.Text);
                int outcome;
                outcome = b1 - b2;
                tot.Text = outcome.ToString();

                int tt = int.Parse(tot.Text);
                int vat1;

                if (tt > 5000000) //ขั้นภาษี 
                {
                    vat1 = (tt * 35) / 100;
                    textBox12.Text = vat1.ToString();

                }
                else if (tt >= 2000001)
                {
                    vat1 = (tt * 30) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 1000001)
                {
                    vat1 = (tt * 25) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 750001)
                {
                    vat1 = (tt * 20) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 500001)
                {
                    vat1 = (tt * 15) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 300001)
                {
                    vat1 = (tt * 10) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else if (tt >= 150001)
                {
                    vat1 = (tt * 5) / 100;
                    textBox12.Text = vat1.ToString();
                }
                else
                {
                    vat1 = 0;
                    textBox12.Text = vat1.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int outcome;
           
            outcome = Program.income;
            total.Text = outcome.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            total.Clear();
            tot.Clear();
            textBox12.Clear();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void tot_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

