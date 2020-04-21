using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form1 : Form
    {
        private Vector vector;

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Vector A = new Vector(Convert.ToDouble(axtextBox.Text), Convert.ToDouble(aytextBox.Text), Convert.ToDouble(aztextBox.Text));
            Vector B = new Vector(Convert.ToDouble(bxtextBox.Text), Convert.ToDouble(bytextBox.Text), Convert.ToDouble(bztextBox.Text));
            Vector C = (A + B) * B;
            richTextBox1.Text += Convert.ToString("c =  {" + C.x + "; " + C.y + "; " + C.z + "}       ") + Convert.ToString("f =  " + A % C) + Environment.NewLine;
            richTextBox1.Text += "a = " + Vector.OutPut(A) + Environment.NewLine + "b = " + Vector.OutPut(B) + Environment.NewLine;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
