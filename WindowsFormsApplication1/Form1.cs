using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Form1 frm;
        int harfKontrol = 0,xskor=0,oskor=0;
        ButtonClass btnClass;
        
        public Form1()
        {
            InitializeComponent();
            frm = this;
            btnClass = new ButtonClass();
            lblXskor.Text = xskor.ToString();
            lblOskor.Text = oskor.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ActiveControl = lblX;
            lblX.Focus();
            //harfkontrol modu 0 olursa demek ki sıra X te. değilse O da.
            if (harfKontrol % 2 == 0)
                btn.Text = "X";
            else
                btn.Text = "O";
            btn.Enabled=false;
            
            if (((btn1.Text == btn2.Text) && btn1.Text == btn3.Text && btn3.Text != "") || ((btn6.Text == btn9.Text) && btn6.Text == btn3.Text && btn3.Text != "") || ((btn7.Text == btn8.Text) && btn7.Text == btn9.Text && btn9.Text != "") || ((btn1.Text == btn4.Text) && btn1.Text == btn7.Text && btn7.Text != "") || ((btn1.Text == btn5.Text) && btn1.Text == btn9.Text && btn9.Text != "") || ((btn5.Text == btn7.Text) && btn5.Text == btn3.Text && btn3.Text != "") || ((btn5.Text == btn2.Text) && btn2.Text == btn8.Text && btn2.Text != "") || ((btn4.Text == btn5.Text) && btn4.Text == btn6.Text && btn4.Text != ""))
            {
                if (harfKontrol % 2 == 0) { xskor++; lblXskor.Text = xskor.ToString(); MessageBox.Show("Oyunu X kazandı"); harfKontrol = 0; }
                else { oskor++; lblOskor.Text = oskor.ToString(); MessageBox.Show("Oyunu O kazandı"); harfKontrol = 1; }
                
                YenidenOyna();
            }

            if (btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false)
            {
                xskor++; lblXskor.Text = xskor.ToString();
                oskor++; lblOskor.Text = oskor.ToString();
                MessageBox.Show("Oyun berabere bitti");
                harfKontrol++;  //diğer harfe geçiş sağlanmış oluyor
                YenidenOyna();
            }
            harfKontrol++;  //diğer harfe geçiş sağlanmış oluyor


        }
        public void YenidenOyna()
        {
            btnClass.Yeniden();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = lblX;
            lblX.Focus();
        }
        
    }
}
