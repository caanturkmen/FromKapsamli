using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromKapsamli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno="", adsoyadı="", cinsiyet="", mezuniyet="", diller="", programlama="";
            tcno = textBox1.Text;
            adsoyadı = textBox2.Text;
            if (radioButton1.Checked==true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if(radioButton2.Checked==true)
            {
                cinsiyet = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                mezuniyet = radioButton3.Text;
            }
            else if (radioButton4.Checked==true)
            {
                mezuniyet = radioButton4.Text;
            }
            else if (radioButton5.Checked==true)
            {
                mezuniyet = radioButton5.Text;
            }
            else if (radioButton6.Checked==true)
            {
                mezuniyet = radioButton6.Text;
            }
            if (checkBox1.Checked==true)
                diller = diller + "," + checkBox1.Text;
            if (checkBox2.Checked == true)
                diller = diller + "," + checkBox2.Text;
            if (checkBox3.Checked == true)
                diller = diller + "," + checkBox3.Text;
            if (checkBox4.Checked == true)
                diller = diller + "," + checkBox4.Text;
            diller = diller.Substring(1);

            if (checkBox5.Checked == true)
                programlama = programlama + "," + checkBox5.Text;
            if (checkBox6.Checked == true)
                programlama = programlama + "," + checkBox6.Text;
            if (checkBox7.Checked == true)
                programlama = programlama + "," + checkBox7.Text;
            if (checkBox8.Checked == true)
                programlama = programlama + "," + checkBox8.Text;
            programlama = programlama.Substring(1);

            listBox1.Items.Add("TC No:" + tcno + " | " + "Adı Soyadı:" + adsoyadı + " | " + "Cinsiyeti:" + cinsiyet + " | " + "Diller:" + diller + " | " + "Programlama Dilleri:" + programlama);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
