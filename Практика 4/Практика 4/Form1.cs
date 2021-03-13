using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private int Fac(double n)
    {
      int res = 1;
      for(int i=1;i<=n;i++)
      {
        res *= i;
      }
      return res;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      Double n = Convert.ToDouble(textBox1.Text);
      Double eps = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы: " + Environment.NewLine;
      int m = 0;
      if (radioButton2.Checked) m = 1;
      double s = 0, p = 1, ch;
      double i;
      switch (m)
      {
        case 0:
          i = 1;
          ch = 2 / Math.Sqrt(Fac(i) + 4);
          while (ch >= eps)
          {
            ch = 2 / Math.Sqrt(Fac(i) + 4);
            s += ch;
            i++;
          }
          textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
          break;
        case 1:
          for (i = 1; i <= n; i++)
          {
            ch = 2 / Math.Sqrt(Fac(i) + 4);
            p *= ch;
          }
          textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine;
          break;
      }
    }

  }
}

