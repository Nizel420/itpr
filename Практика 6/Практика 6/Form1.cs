using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_6
{
  public partial class Form1 : Form
  {
    int[] arr = new int[15];
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for(int i = 0; i < arr.Length; i++)
      {
        arr[i] = rand.Next(-100, 100);
        textBox1.Text += "Mas[" + Convert.ToString(i+1) + "] = " + Convert.ToString(arr[i]) + Environment.NewLine;
      }

    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] < 0) arr[i] = 0;

        textBox2.Text += "Mas[" + Convert.ToString(i+1) + "] = " + Convert.ToString(arr[i]) + Environment.NewLine;
      }
    }
  }
}
