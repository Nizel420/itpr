using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_5
{
  public partial class Form1 : Form
  {
    public Form1()
    { 
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      int Index = listBox1.SelectedIndex;
      string working_string = (string)listBox1.Items[Index];
      int len = working_string.Length;
      int count = 0;
      for(int i=0;i<len;i++)
      {
        if((working_string[i]=='!') || (working_string[i]== '.') || (working_string[i]== '?'))
          {
          count += 1;
          }
      }
      label1.Text = "Количество предложений: " + count.ToString();
    }
  }
}
