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
    public partial class UserControl2 : UserControl
    {
        string vat; //อัตราการเสียภาษีเท่าไหร่กี่เปอเซน
        double allpay; //เก็บตัวเเปลสำหรับตัวเเปที่ต้องจ่ายตังว่าต้องเสียภาษีกี่บาท
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = Program.income.ToString();
            textBox2.Text = (Program.grop1 + Program.grop2 + Program.grop3 + Program.grop4 + Program.grop5).ToString();
            textBox3.Text = (Program.income - (Program.grop1 + Program.grop2 + Program.grop3 + Program.grop4 + Program.grop5)).ToString();
            double net = int.Parse(textBox3.Text);
            
            if (net >= 0 && net < 150000)   
            {
                allpay = 0; //ค่าผลลัพธ  //เปรียบค่าบรรได เปรียบเทียบค่าว่าภาษีกี่ %
                vat = "0%";
            }
            else if (net > 150000 && net <= 300000)
            {
                allpay = (net- 150000) * 0.05;
                vat = "5%";
            }
            else if (net > 300000 && net <= 500000)
            {
                allpay = (net - 300000) * 0.1 + 7500; // 10/100
                vat = "10%";
            }
            else if (net > 500000 && net <= 750000)
            {
                allpay = (net - 500000) * 0.15 + 27500;
                vat = "15%";
            }
            else if (net > 750000 && net <= 1000000)
            {
                allpay = (net - 750000) * 0.2 + 65000;
                vat = "20%";
            }
            else if (net > 1000000 && net <= 2000000)
            {
                allpay = (net - 1000000) * 0.25 + 115000;
                vat = "25%";
            }
            else if (net > 2000000 && net <= 5000000)
            {
                allpay = (net - 2000000) * 0.3 + 365000;
                vat = "30%";
            }
            else if (net > 5000000)
            {
                allpay = (net - 5000000) * 0.35 + 1265000;
                vat = "35%";
            }
            textBox4.Text = vat;
            textBox5.Text = allpay.ToString();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
