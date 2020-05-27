using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class me1 : UserControl
    {
        public me1()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void me1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //รายได้รายปี 


            int total;  //ค่าจากกล่องเท็คบล็อคที่เขาเเทนค่ามา
            total = int.Parse(textBox11.Text); //ดึงค่าโดยเเปลงจากข้อความมาเป็นตัวเลข
            Program.income = total;  //โททอมาเก็บไว้ในอินคัมเเล้วเอาอินคัมเเสดงไปยังอื่นๆได้ 
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a1 = int.Parse(numericUpDown1.Text);//บุตรเกิดก่อน61
            int a2 = int.Parse(numericUpDown2.Text);//บุตรเกิดหลัง61
            int a3 = int.Parse(textBox2.Text);//ค่าฝากครรภ์
            int a4 = int.Parse(textBox3.Text);//อุปการะคนพิการ
            int a5;
            int a6;
            int m = 0;//กำหนดค่าเริ่มต้น = 0
            int n = 0;  
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int total;
            if (checkBox9.Checked) //เพิ่มค่า  //ถ้าโสด =0
            {
                m = 0;
            }
            if (checkBox10.Checked) //มีรายได้
            {
                n = 0;
            }
            if (checkBox11.Checked) //คู่สมรสไม่มีรายได้จะเพิ่มให้ 60000  //ลดหย่อน
            {
                o = 60000;
            }
            if (checkBox1.Checked) //ช่วงการเชคว่ามีบุตรกี่คน //30000
            {
                p = 0;
            }
            if (checkBox2.Checked) //บุตรเกิดก่อน 2561
            {
                q = 30000;
            }
            if (checkBox3.Checked) //เกิดหลัง
            {
                r = 60000;
            }
            if (checkBox4.Checked) //ไม่มี
            {
                s = 0;
            }
            if (checkBox5.Checked) //บิดา
            {
                t = 30000;
            }
            if (checkBox6.Checked) //มารดา
            {
                u = 30000;
            }
            if (checkBox7.Checked) //บิดาคู่สมรส
            {
                v = 30000;
            }
            if (checkBox8.Checked) //มารดาคู่สมรส
            {
                w = 30000;
            }
            a5 = a1 * 30000; //ก่อน2561 ก็จะคูณลดหย่อนต่างกัน
            a6 = a2 * 60000; //หลัง 2562

            total = a3 + a4 + a5 + +a6 + m + n + o + p + q + r + s + t + u + v + w;
            Program.grop1 = total; //เก็บไว้ใน กรู๊ป เพื่อจะโชว์หน้าสุดท้าย
            textBox4.Text = total.ToString();  //ใช้ดึงทุกฟอร์มได้

            int b1 = int.Parse(textBox11.Text);//รายได้สุทธิ
            int b2 = int.Parse(textBox4.Text); //ภาษาลดหย่อน
            int outcome; 
            outcome = b1 - b2;
            textBox5.Text = outcome.ToString(); //มันเป็นตัวเลขจะเเสดงมาเป็น txtไม่ได้


            int tt = int.Parse(textBox5.Text);//ภาษีที่ต้องจ่าย(รายได้สุทธิ)
            int vat1; //เป็นการหาค่าบันได  ในพาเเนวนี้ในการคำนวนออกมา/อัตราภาษีเป็น %


            if (tt > 5000000)
            {
                vat1 = (tt * 35) / 100;
                textBox6.Text = vat1.ToString(); //เป็นเปอร์เซนของภาษีเเต่ละขั้นๆ ขั้นนี้ๆ เป็นเปอร์เซน

            }
            else if (tt >= 2000001)
            {
                vat1 = (tt * 30) / 100;
                textBox6.Text = vat1.ToString(); //เป็นเปอเซน
            }
            else if (tt >= 1000001)
            {
                vat1 = (tt * 25) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 750001)
            {
                vat1 = (tt * 20) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 500001)
            {
                vat1 = (tt * 15) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 300001)
            {
                vat1 = (tt * 10) / 100;
                textBox6.Text = vat1.ToString();
            }
            else if (tt >= 150001)
            {
                vat1 = (tt * 5) / 100;
                textBox6.Text = vat1.ToString();
            }
            else
            {
                vat1 = 0; // ไม่ต้องเสียภาษี มันก็จะเท่ากับ 0
                textBox6.Text = vat1.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
