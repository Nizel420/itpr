using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_9
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      this.BackColor = Color.Red;
      Graphics g = e.Graphics;
      Brush pen=Brushes.Yellow;
      Pen Brush = new Pen(Brushes.Yellow, 20);
      Point point1 = new Point(115, 0);
      Point point2 = new Point(103, 35);
      Point point3 = new Point(65, 40);
      Point point4 = new Point(100, 60);
      Point point5 = new Point(85, 100);
      Point point6 = new Point(115, 75);
      Point point7 = new Point(145, 100);
      Point point8 = new Point(130, 60);
      Point point9 = new Point(165, 40);
      Point point10 = new Point(127, 35);
      Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7,point8,point9,point10 };
      g.FillRectangle(pen, 100 ,120 ,30 , 180);
      g.FillRectangle(pen, 60, 130, 115, 40);
      g.FillRectangle(pen, 50, 250, 130, 20);
      g.DrawArc(Brush, 170, 190, 80, 90, -50, 230);
      SolidBrush pentwo = new SolidBrush(Color.Yellow);
      g.FillPolygon(pentwo, curvePoints);
    }
  }
}
