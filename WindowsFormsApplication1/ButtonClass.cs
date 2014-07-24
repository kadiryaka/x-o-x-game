using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ButtonClass
    {
        Button[] array = new Button[9];
        public ButtonClass()
        {
            
            array[0] = Form1.frm.btn1;
            array[1] = Form1.frm.btn2;
            array[2] = Form1.frm.btn3;
            array[3] = Form1.frm.btn4;
            array[4] = Form1.frm.btn5;
            array[5] = Form1.frm.btn6;
            array[6] = Form1.frm.btn7;
            array[7] = Form1.frm.btn8;
            array[8] = Form1.frm.btn9;
        }
        public void Yeniden()
        {
            for (int i = 0; i < 9; i++)
            {
                array[i].Enabled = true;
                array[i].Text = "";
            }
        }
        
    }
}
