using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_10
{
  public partial class Form1 : Form
  {

    private int BalLWidth = 300;
    private int BallHeight = 300;
    private int BallPosX = 0;
    private int BallPosY = 0;
    private int moveStepX = 14;
    private int moveStepY = 14;

    public Form1()
    {
      InitializeComponent();
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint,true);
      this.UpdateStyles();
      timer1.Interval = 30;
      timer1.Enabled = true;
    }

    private void Ball(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
      e.Graphics.Clear(this.BackColor);
      e.Graphics.FillEllipse(Brushes.Gray, BallPosX, BallPosY, BalLWidth, BallHeight);
      e.Graphics.DrawEllipse(new Pen(Brushes.Black,2) , BallPosX, BallPosY, BalLWidth, BallHeight);
    }

    private void MoveBall(object sender, EventArgs e)
    {
      //корды
      BallPosX += moveStepX;
      if (
        BallPosX < 0 ||
        BallPosX + BalLWidth > this.ClientSize.Width
        )
      {
        moveStepX = -moveStepX;
        BallPosX += moveStepX;
      }
      BallPosY += moveStepY;
      if (
        BallPosY < 0 ||
        BallPosY + BallHeight > this.ClientSize.Height
        )
      {
        moveStepY = -moveStepY;
        BallPosY += moveStepY;
      }
      //рисунок
      this.Invalidate();
    }
  }
}
