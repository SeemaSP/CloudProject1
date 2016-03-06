using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace SCalc1
{
    public partial class _Default : Page
    {
        static float a, c, d;
        static char b;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button1.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button1.Text;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button2.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button2.Text;
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button3.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button3.Text;
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '+';
            TextBox1.Text += b;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button5.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button5.Text;
            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button6.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button6.Text;
            }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button7.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button7.Text;
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '-';
            TextBox1.Text += b;
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button9.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button9.Text;
            }
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button10.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button10.Text;
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button11.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button11.Text;
            }
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = '*';
            TextBox1.Text = "";
            TextBox1.Text += b;
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button13.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button13.Text;
            }
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '/';
            TextBox1.Text += b;
        }
        protected void Button16_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            if (b == '/')
            {
                d = a / c;
                TextBox1.Text += d;
                a = d;
            }
            else if (b == '+')
            {
                d = a + c;
                TextBox1.Text += d;
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                TextBox1.Text += d;
                a = d;
            }
            else
            {
                d = a * c;
                TextBox1.Text += d;
                a = d;
            }
        }
    }
}

    