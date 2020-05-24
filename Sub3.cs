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
    public partial class Sub3 : UserControl
    {
        public Sub3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int total;
            total = Program.income;
            textBox4.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int home58 = int.Parse(numericUpDown2.Text);//ราคาบ้าน
            int taxhome = int.Parse(home.Text);//ดอกเบี้ยบ้าน
            int total = int.Parse(textBox4.Text);//รายได้รวมต่อปี
            int tax20;// 20%ของอสังหาริมทรัพย์
            int tax5;
            int taxtotal;//รวมภาษี
            int total1;//รายได้สุทธิ

            tax20 = (home58 * 20) / 100;//ภาษีที่ลดหย่อนได้
            a.Text = tax20.ToString();
            tax5 = (tax20 / 5);//เฉลี่ย 5 ปี
            d.Text = tax5.ToString();
            taxtotal = (taxhome + tax5);//รวมลดหย่อนภาษี = ดอกเบี้ยบ้าน+ภาษีเฉลี่ย 5 ปี
            b.Text = taxtotal.ToString();

            total1 = total - taxtotal;//รายได้สุทธิ = รายได้รวม-รวมลดหย่อนสุทธิ
            Program.grop3 = taxtotal;
            c.Text = total1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int home62 = int.Parse(numericUpDown3.Text);//ราคาบ้าน
            int taxhome = int.Parse(home.Text);//ดอกเบี้ยบ้าน
            int total = int.Parse(textBox4.Text);//รายได้รวมต่อปี
            int tax;//ภาษีที่ลดหย่อน
            int taxtotal;//รวมภาษี
            int total2;//รายได้สุทธิ
            int a = 0;

            if (home62 < 200000) 
            {
                a = home62;
            }
            else if (home62 < 5000001)
            {
                a = 200000;
            }

            tax = a;//ภาษีที่ลดหย่อนได้
            x.Text = tax.ToString();
            taxtotal = taxhome + a;//รวมภาษีที่ลดหย่อนได้ = ดอกเบี้ยบ้าน+ภาษีที่ลดหย่อน
            y.Text = taxtotal.ToString();

            total2 = total - taxtotal;//รายได้รวม-รวมลดหย่อนสุทธิ
            Program.grop3 = taxtotal;
            z.Text = total2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            textBox4.Clear();
            a.Clear();
            b.Clear();
            c.Clear();
            d.Clear();
            x.Clear();
            y.Clear();
            z.Clear();
        }
    }
}
