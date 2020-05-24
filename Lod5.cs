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
    public partial class Lod5 : UserControl
    {
        public Lod5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            total = Program.income;
            textBox4.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int help = int.Parse(numericUpDown1.Text); //ชอปช่วยชาติ
            int studysport = int.Parse(numericUpDown2.Text);
            int book = int.Parse(numericUpDown3.Text);
            int otop = int.Parse(numericUpDown4.Text);
            int travel1 = int.Parse(numericUpDown5.Text); //หลัก
            int travel2 = int.Parse(numericUpDown6.Text); //รอง
            int home = int.Parse(numericUpDown7.Text); //ค่าซ่อมบ้าน
            int car = int.Parse(numericUpDown8.Text); //ค่าซ่อมรถ
            int tot = int.Parse(textBox4.Text);//รายได้พึงประเมิน
            int total;//รายได้สุทธิ
            int tax;//ภาษีที่ลดหย่อนได้
            int i = 0;
            int j = 0;

            if ((travel1 + travel2) < 20000)  //เที่ยวเเล้วรวมกันไม่เกิน 20000 เอามาเชคมัน
            {
                i = (travel1 + travel2); //ถ้าเกินก็เอา
            }
            else if ((travel1 + travel2) > 20001)
            {
                i = 20000;  //ถ้าเกินก็เอา
            }
            if ((home + car) < 100000)
            {
                j = (home + car);
            }
            else if ((home + car) > 100001) //ถ้าเกิน 1เเสนก็ให้ 1เเสน
            {
                j = 100000; 
            }

            tax = help + studysport + book + otop + i + j; //1+2+3+4
            Program.grop5 = tax;
            textBox5.Text = tax.ToString();

            total = tot - tax;
            textBox6.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Lod5_Load(object sender, EventArgs e)
        {

        }
    }
}
