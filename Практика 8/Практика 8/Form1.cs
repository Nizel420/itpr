using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Практика_8
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private double XMin = -3.14;
    private double XMax = 1.5;
    private double Step = 0.1;
    private double[] x;
    private double[] y1;
    Chart chart;
    private void CalcFunction()
    {
      int count = (int)Math.Ceiling((XMax - XMin) / Step)
      + 1;
      
      x = new double[count];
      y1 = new double[count];
      
      for (int i = 0; i < count; i++)
      {
        
        x[i] = XMin + Step * i;
        
        y1[i] = ((2*Math.Log(x[i])*Math.Cos(2*x[i])-3*Math.Pow((x[i]+1),2)/(x[i]-1)))/(2+Math.Sqrt(x[i]));
      }
    }
    private void CreateChart()
    {
      
      chart = new Chart();
      
      chart.Parent = this;
      
      chart.SetBounds(10, 10, ClientSize.Width - 20,
      ClientSize.Height - 20);
      
      ChartArea area = new ChartArea();      
      area.Name = "myGraph";      
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;      
      area.AxisX.MajorGrid.Interval = Step;      
      chart.ChartAreas.Add(area);      
      Series series1 = new Series();      
      series1.ChartArea = "myGraph";      
      series1.ChartType = SeriesChartType.Spline; 
      series1.BorderWidth = 3;      
      series1.LegendText = "вариант 7";      
      chart.Series.Add(series1);     
       Legend legend = new Legend();
      chart.Legends.Add(legend);
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      CreateChart();
      CalcFunction();
      // Добавляем вычисленные значения в графики
      chart.Series[0].Points.DataBindXY(x, y1);
    }
  }
}
