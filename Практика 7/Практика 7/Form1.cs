using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      dataGridView1.RowCount = 10;
      dataGridView1.ColumnCount = 10;
      dataGridView2.RowCount = dataGridView1.RowCount;
      dataGridView2.ColumnCount = dataGridView1.ColumnCount;
      int[,] arr = new int[10, 10];
      Random rand = new Random();
      for (int i = 0; i < dataGridView1.RowCount; i++)
      {
        for (int j = 0; j < dataGridView1.ColumnCount; j++)
        {
          arr[i, j] = rand.Next(-10, 11);
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(arr[i, j]);
        }
      }
      int max = int.MinValue, min = int.MaxValue;
      int max_index = -1, min_index = -1;
      for (int i = 0; i < dataGridView1.RowCount; i++)
      {
        for (int j = 0; j < dataGridView1.ColumnCount; j++)
        {
          if (arr[i, j] < min)
          {
            min = arr[i, j];
            min_index = i;
          }
          if (arr[i, j] > max)
          {
            max = arr[i, j];
            max_index = i;
          }
        }
      }
      int[] arr_buff = new int[dataGridView2.ColumnCount];
      for (int i = 0; i < dataGridView2.ColumnCount; i++)
      {
        arr_buff[i] = arr[min_index, i];
        arr[min_index, i] = arr[max_index,i];
        arr[max_index, i] = arr_buff[i];
      }
      for (int i = 0; i < dataGridView2.RowCount; i++)
      {
        for (int j = 0; j < dataGridView2.ColumnCount; j++)
        {
          dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(arr[i, j]);
        }
      }
    }
  }
}
