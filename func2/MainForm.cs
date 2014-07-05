using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using OpenGL;

namespace glWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.view.Invalidate(null, false);
        }
        bool Click = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Click = false;
            this.view.A = (double)fnudA.Value;
            this.view.B = (double)fnudB.Value;
            this.view.xMin= (double)fnudXmin.Value;
            this.view.xMax = (double)fnudXmax.Value;
            this.view.H = (double)fnudH.Value;
            this.flbList.Items.Clear();
            if (double.IsNaN(Math.Sqrt((Math.Pow(view.xMin, 2) * Math.Pow(view.B, 2)) / Math.Pow(view.A, 2) - Math.Pow(view.B, 2)))
                || double.IsNaN(Math.Sqrt((Math.Pow(view.xMax, 2) * Math.Pow(view.B, 2)) / Math.Pow(view.A, 2) - Math.Pow(view.B, 2))))
            {
                MessageBox.Show("Корень из отрицательного числа!");
                return;
            }
            if (double.IsInfinity(Math.Sqrt((Math.Pow(view.xMin, 2) * Math.Pow(view.B, 2)) / Math.Pow(view.A, 2) - Math.Pow(view.B, 2)))
                || double.IsInfinity(Math.Sqrt((Math.Pow(view.xMax, 2) * Math.Pow(view.B, 2)) / Math.Pow(view.A, 2) - Math.Pow(view.B, 2))))
            {
                MessageBox.Show("Деление на ноль!");
                return;
            }

            if (fnudXmin.Value < fnudXmax.Value)
            {
                this.view.Refresh();
                this.view.Refresh();
                ListFill();
            }
            else
                MessageBox.Show("XMin должен быть меньше XMax.", "Неверное задание параметров ");
            
        }

        private void view_Load(object sender, EventArgs e)
        {
            fnudXmin.Value = (decimal)this.view.xMin;
            fnudXmax.Value = (decimal)this.view.xMax;
            fnudH.Value = (decimal)this.view.H;
            fnudA.Value = (decimal)this.view.A;
            fnudB.Value = (decimal)this.view.B;
        }




        private void Sized(object sender, EventArgs e)
        {
            this.fnudH.Value = (decimal)this.view.H;
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
                double OnePixelX = 0;
                double OnePixelY = 0;
                bool xMinLessZero = false;
                if (view.xMin <= 0)
                {
                    xMinLessZero = true;
                    OnePixelX = ((view.xMax + view.OneLengthX) - (view.xMin - view.OneLengthX)) / view.Width;
                    OnePixelY = ((view.yMax + view.OneLengthY) - (view.yMin - view.OneLengthY)) / view.Height;
                }
                else
                {
                    xMinLessZero = false;
                    OnePixelX = ((view.xMax + view.OneLengthX) - (-view.OneLengthX)) / view.Width;
                    OnePixelY = ((view.yMax + view.OneLengthY) - (view.yMin - view.OneLengthY)) / view.Height;
                }
                if (fcbMain.SelectedItem == fcbMain.Items[0])
                {
                    view.CurrentFigureType = OpenGL.ViewGL.CurrentFigure.Hyperbole;
                if (double.IsNaN(view.X1) && double.IsNaN(view.X2))
                {
                    if (xMinLessZero)
                    {
                        view.X1 = view.xMin + (e.X * OnePixelX - view.OneLengthX);
                        fnudX1.Value = (decimal)view.X1;
                    }
                    else
                    {
                        view.X1 = e.X * OnePixelX - view.OneLengthX;
                        fnudX1.Value = (decimal)view.X1;
                    }

                    view.Y1 = view.yMax - (e.Y * OnePixelY - view.OneLengthY);
                    fnudY1.Value = (decimal)view.Y1;
                }
                else
                    if (!double.IsNaN(view.X1) && double.IsNaN(view.X2))
                    {
                        if (xMinLessZero)
                        {
                            view.X2 = view.xMin + (e.X * OnePixelX - view.OneLengthX);
                            fnudX2.Value = (decimal)view.X2;
                        }
                        else
                        {
                            view.X2 = e.X * OnePixelX - view.OneLengthX;
                            fnudX2.Value = (decimal)view.X2;
                        }

                        view.Y2 = view.yMax - (e.Y * OnePixelY - view.OneLengthY);
                        fnudY2.Value = (decimal)view.Y2;
                    }
                    else
                        if (!double.IsNaN(view.X1) && !double.IsNaN(view.X2))
                        {
                            view.X2 = double.NaN;
                            view.Y2 = double.NaN;
                            if (xMinLessZero)
                            {
                                view.X1 = view.xMin + (e.X * OnePixelX - view.OneLengthX);
                                fnudX1.Value = (decimal)view.X1;
                            }
                            else
                            {
                                view.X1 = e.X * OnePixelX - view.OneLengthX;
                                fnudX1.Value = (decimal)view.X1;
                            }
                            view.Y1 = view.yMax - (e.Y * OnePixelY - view.OneLengthY);
                            fnudY1.Value = (decimal)view.Y1;

                        }

                view.Refresh();
                ListFill();
            }
            else
            {
                view.CurrentFigureType = OpenGL.ViewGL.CurrentFigure.Circle;

                if (!Click)
                    {
                        Click = true;
                        if (view.xMin <= 0 && view.yMin <=0)
                        {
                            view.Xo = view.xMin + (e.X * OnePixelX - view.OneLengthX);
                            fnudXo.Value = (decimal)view.Xo;
                            view.Yo = view.yMax - (e.Y * OnePixelY - view.OneLengthY);
                            fnudYo.Value = (decimal)view.Yo;
                        }
                        else
                        {
                        if (view.xMin <= 0 && view.yMin >0)
                        {
                            view.Xo = view.xMin + (e.X * OnePixelX - view.OneLengthX);
                            fnudXo.Value = (decimal)view.Xo;
                            view.Yo = (e.Y * OnePixelY - view.OneLengthY);
                            fnudYo.Value = (decimal)view.Yo;
                        }
                        else                        
                            if (view.xMin > 0 && view.yMin <=0)
                            {
                                view.Xo = (e.X * OnePixelX - view.OneLengthX);
                                fnudXo.Value = (decimal)view.Xo;
                                view.Yo = view.yMax - (e.Y * OnePixelY - view.OneLengthY);
                                fnudYo.Value = (decimal)view.Yo;
                            }
                            else                            
                                if (view.xMin <= 0 && view.yMin <=0)
                                {
                                    view.Xo = (e.X * OnePixelX - view.OneLengthX);
                                    fnudXo.Value = (decimal)view.Xo;
                                    view.Yo = (e.Y * OnePixelY - view.OneLengthY);
                                    fnudYo.Value = (decimal)view.Yo;
                                }
                        }
                        view.R = double.NaN;
                    }
                    else
                    {
                        Click = false;
                        if (view.xMin <= 0)
                        {
                            view.R = view.Xo - (view.xMin + (e.X * OnePixelX - view.OneLengthX));
                            fnudR.Value = (decimal)view.R;
                        }
                        else
                        {
                            view.R = view.Xo - (e.X * OnePixelX - view.OneLengthX);
                            fnudR.Value = (decimal)view.R;
                        }
                        view.Refresh();
                        view.Refresh();
                    }
            }
        }

        private void ListFill()
        {
            flbList.Items.Clear();
            for (int x = 0; x < 2; x++)
            {
                if (!double.IsNaN(view.IntersectionsX[x]))
                {
                    flbList.Items.Add("X = " + view.IntersectionsX[x].ToString());
                }
                if (!double.IsNaN(view.IntersectionsY[x]))
                {
                    flbList.Items.Add("Y = " + view.IntersectionsY[x].ToString());
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Click = false;
            this.view.A = (double)fnudA.Value;
            this.view.B = (double)fnudB.Value;
            this.view.xMin = (double)fnudXmin.Value;
            this.view.xMax = (double)fnudXmax.Value;
            this.view.H = (double)fnudH.Value;
            this.view.X1 = (double)fnudX1.Value;
            this.view.Y1 = (double)fnudY1.Value;
            this.view.X2 = (double)fnudX2.Value;
            this.view.Y2 = (double)fnudY2.Value;
            this.view.Refresh();
            ListFill();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fcbMain.SelectedItem = fcbMain.Items[0];
        }

        private void fcbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fcbMain.SelectedItem == fcbMain.Items[0])
            {
                if (fnudXmin.Value >= fnudXmax.Value)
                {
                    MessageBox.Show("XMin должен быть меньше XMax.", "Неверное задание параметров ");
                    return;
                }
                label8.Text = "F(x) = sqrt((x^2*B^2)/A^2 - B^2)";
                fgbCircle.Enabled = false;
                fgbHyperbole.Enabled = true;
                fgbIntersections.Enabled = true;
                fgbLine.Enabled = true;
                view.X1 = (double)fnudX1.Value;
                view.Y1 = (double)fnudY1.Value;
                view.X2 = (double)fnudX2.Value;
                view.Y2 = (double)fnudY2.Value;
                view.xMax = (double)fnudXmax.Value;
                view.xMin = (double)fnudXmin.Value;

                fnudH.Value = (decimal)this.view.H;
                fnudA.Value = (decimal)this.view.A;
                fnudB.Value = (decimal)this.view.B;
                view.CurrentFigureType = OpenGL.ViewGL.CurrentFigure.Hyperbole;
                view.Refresh();
            }
            else
            {
                if (fnudXmin.Value >= fnudXmax.Value)
                {
                    MessageBox.Show("XMin должен быть меньше XMax.", "Неверное задание параметров ");
                    return;
                }
                Click = false;
                if (fnudMinY.Value >= fnudMaxY.Value)
                {
                    MessageBox.Show("YMin должен быть меньше YMax.", "Неверное задание параметров ");
                    return;
                }
                label8.Text = "F(x) = Yo+/-sqrt(R^2 - (x-Xo)^2)";

                fgbCircle.Enabled = true;
                fgbHyperbole.Enabled = false;
                fgbIntersections.Enabled = false;
                fgbLine.Enabled = false;
                view.Yo = (double)fnudYo.Value;
                view.Xo = (double)fnudXo.Value;
                view.R = (double)fnudR.Value;
                this.view.yMin = (double)fnudMinY.Value;
                this.view.yMax = (double)fnudMaxY.Value;
                view.CurrentFigureType = OpenGL.ViewGL.CurrentFigure.Circle;
                view.Refresh();

            }
        }

        private void fbEnterCircle_Click(object sender, EventArgs e)
        {
            if (fnudXmin.Value >= fnudXmax.Value)
            {
                MessageBox.Show("XMin должен быть меньше XMax.", "Неверное задание параметров ");
                return;
            }
            if (fnudMinY.Value >= fnudMaxY.Value)
            {
                MessageBox.Show("YMin должен быть меньше YMax.", "Неверное задание параметров ");
                return;
            }
            Click = false;
            this.view.xMin = (double)fnudXmin.Value;
            this.view.xMax = (double)fnudXmax.Value;
            this.view.yMin = (double)fnudMinY.Value;
            this.view.yMax = (double)fnudMaxY.Value;

            view.R = (double)fnudR.Value;
            view.Xo = (double)fnudXo.Value;
            view.Yo = (double)fnudYo.Value;
            view.Refresh();
            view.Refresh();
        }


    }
}
