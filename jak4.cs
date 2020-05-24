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
    public partial class jak4 : UserControl
    {
        public jak4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            int study = int.Parse(textBox5.Text); //การศึกษา
            int government = int.Parse(textBox6.Text); //รัฐบาล
            int sport = int.Parse(textBox7.Text); //กีฬา
            int public1 = int.Parse(textBox8.Text);//สาธา
            int pabuk = int.Parse(textBox9.Text); //พายุบาปึก
            int general = int.Parse(textBox10.Text); //ทั่วไปการบริจาค
            int politics = int.Parse(numericUpDown1.Text); //การเมือง
            int to = int.Parse(textBox4.Text);//รายได้พึงประเมิน
            int a1;
            int a2;
            int a3;
            int a4;
            int a5;
            int a6;
            int a7;
            int x = 0;
            int tot;//บริจาค
            int total;//รายได้สุทธิ
            int taxtotal;//สามารถลดหย่อนได้

            a1 = (study * 2); //ลดหย่อนได้สองเท่า
            textBox11.Text = a1.ToString();
            a2 = (government * 2);
            textBox12.Text = a2.ToString();
            a3 = (sport * 2);
            textBox13.Text = a3.ToString();
            a4 = (public1 * 2);
            textBox14.Text = a4.ToString();  //ได้ค่ามาเเล้วเเสดงทางขวามือ
            a5 = pabuk;
            textBox15.Text = a5.ToString();
            a6 = general;
            textBox16.Text = a6.ToString();
            a7 = politics;
            textBox17.Text = a7.ToString();

            taxtotal = (to * 10) / 100;  //สามารถลดหย่อนได้ = รายได้รวมที่หักค่าลดหย่อนอื่นๆแล้ว

            tot = (a1 + a2 + a3 + a4 + a5 + a6 + a7);//รวมบริจาค 
            Program.grop4 = tot;
            if (tot > taxtotal) 
            {
                x = taxtotal; //สามารถลดหย่อนได้
            }
            else if (tot < taxtotal)  //ห้ามเกิน 10 % ของเงินได้
            {
                x = tot; // ถ้าเงินบริจาคมากกว่า
            }
            textBox18.Text = x.ToString();

            total = to - x;//รายได้สุทธิ = รายได้พึงประเมิน-ภาษีที่ลดหย่อนได้
            textBox19.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
