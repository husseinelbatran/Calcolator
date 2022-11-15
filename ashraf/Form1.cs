using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ashraf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textstor.Text != "")
            {
                num = float.Parse(textstor.Text);
                textresult.Text = textstor.Text + "*";
                textstor.Clear();
                count = 3;

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "0";

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "5";

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "4";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textstor.Text = textstor.Text + "9";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textresult.Clear();
            textstor.Clear();
        }
        float num;
        int count;
        private void btnsub_Click(object sender, EventArgs e)
        {
            if (textstor.Text != "")
            {
                num = float.Parse(textstor.Text);
                textresult.Text = textstor.Text + "-";
                textstor.Clear();
                count = 1;

            }
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            if (textstor.Text != "")
            {
                num = float.Parse(textstor.Text);
                textresult.Text = textstor.Text + "+";
                textstor.Clear();
                count = 2;

            }

        }

        private void btndivison_Click(object sender, EventArgs e)
        {
            if (textstor.Text != "")
            {
                num = float.Parse(textstor.Text);
                textresult.Text = textstor.Text + "/";
                textstor.Clear();
                count = 4;

            }
        }

        private void btnremender_Click(object sender, EventArgs e)
        {
            if (textstor.Text != "")
            {
                num = float.Parse(textstor.Text);
                textresult.Text = textstor.Text + "%";
                textstor.Clear();
                count = 5;

            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(textstor.Text);
                    textresult.Text = textresult.Text + textstor.Text + " = " + ans;
                    textstor.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(textstor.Text);
                    textresult.Text = textresult.Text + textstor.Text + " = " + ans;
                    textstor.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textstor.Text);
                    textresult.Text = textresult.Text + textstor.Text + " = " + ans;
                    textstor.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textstor.Text);
                    textresult.Text = textresult.Text + textstor.Text + " = " + ans;
                    textstor.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(textstor.Text);
                    textresult.Text = textresult.Text + textstor.Text + " = " + ans;
                    textstor.Text = ans.ToString();
                    break;
            }
        }
    }
}
