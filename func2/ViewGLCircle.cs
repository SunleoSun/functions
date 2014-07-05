using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenGL
{
    public partial class ViewGLCircle : UserControl
    {
        public ViewGLCircle()
        {
            InitializeComponent();
            right = (double)this.ClientRectangle.Right;
            left = (double)this.ClientRectangle.Left;
            bottom = (double)this.ClientRectangle.Bottom;
            top = (double)this.ClientRectangle.Top;
            xmin = -2;
            xmax = 2;
            ymax = xmax;
            ymin = xmin;
            Xo = 0;
            Yo = 0;
            R = 1;
            FindNumPoints();
            FindOneLengthX();
            FindOneLengthY();
        }
        double oneLengthX;
        public double OneLengthX
        {
            get { return oneLengthX; }
            set { oneLengthX = value; }
        }
        double oneLengthY;
        public double OneLengthY
        {
            get { return oneLengthY; }
            set { oneLengthY = value; }
        }
        double right;
        public double Right { get { return right; } }
        double left;
        public double Left { get { return left; } }
        double bottom;
        public double Bottom { get { return bottom; } }
        double top;
        public double Top { get { return top; } }
        double xmin;
        public double xMin
        {
            get { return xmin; }
            set
            {
                if (value == 0)
                {
                    xmin = 0.02;
                }
                else
                    xmin = value;
            }
        }
        double xmax;
        public double xMax
        {
            get { return xmax; }
            set
            {
                if (xMin == 0)
                {
                    xmin += 0.0001;
                } xmax = value;
            }
        }
        double ymin;
        public double yMin { get { return ymin; } }
        double ymax;
        public double yMax { get { return ymax; } }

        /// <summary>
        /// Количество точек графика
        /// </summary>
        int num_points;
        public int Num_points
        {
            get { return num_points; }
            set { num_points = value; }
        }

        /// <summary>
        /// Шаг между точками
        /// </summary>
        double h;
        /// <summary>
        /// Шаг
        /// </summary>
        public double H
        {
            get { return h; }
            set { h = value; }
        }

        double xo;
        public double Xo
        {
            get { return xo; }
            set { xo = value; }
        }
        double yo;
        public double Yo
        {
            get { return yo; }
            set { yo = value; }
        }
        double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        //Найти минимальную величину видимую в масштабе X
        private void FindOneLengthX()
        {
            if (xmin >= 0)
            {
                oneLengthX = xmax / 20;
            }
            else
            {
                oneLengthX = (xmax - xmin) / 20;
            }
        }
        //Найти количество точек
        private void FindNumPoints()
        {
            num_points = (int)((xMax - xMin) / H);
        }

        /// <summary>
        /// Найти минимальную величину видимую в масштабе Y
        /// </summary>
        private void FindOneLengthY()
        {
            oneLengthY = (ymax - ymin) / 10;
        }

        /// <summary> 
        /// Обработчик события WM_PAINT. Здесь выполняются все основные команды рисования OpenGL.
        /// </summary>
        private void ViewGL_Paint(object sender, PaintEventArgs e)
        {
            GL.glLoadIdentity();
            FindOneLengthY();
            FindOneLengthX();
            FindNumPoints();
            if (xMin <= 0)
            {
                GLU.gluOrtho2D(xMin - oneLengthX, xMax + oneLengthX, yMin - oneLengthY, yMax + oneLengthY);
            }
            else
            {
                GLU.gluOrtho2D(-oneLengthX, xMax + oneLengthX, yMin - oneLengthY, yMax + oneLengthY);
            }
            DrawCoordinates();
            DrawCircleFunction();
            GL.glFinish();
            WGL.wglSwapBuffers(DC);
        }


        /// <summary>
        /// Функция для рисования функции
        /// </summary>
        private void DrawCircleFunction()
        {
            GL.glLineWidth(2.0f);
            GL.glBegin(GL.GL_LINE_STRIP);
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            double x_start;
            x_start = Xo - R;
            double y_start = 0;
            GL.glVertex2d(x_start, y_start);
            for (int z = 1; z < Num_points; z++)
            {
                double x = x_start + h * z;
                double y = fCircle(x);
                GL.glVertex2d(x, y);
            }
            GL.glEnd();

            GL.glBegin(GL.GL_LINE_STRIP);
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex2d(x_start, y_start);
            for (int z = 1; z < Num_points; z++)
            {
                double x = x_start + h * z;
                double y = fCircle(x)*-1;
                GL.glVertex2d(x, y);
            }
            GL.glEnd();

        }

        /// <summary>
        /// Функция для расчета значения Y в точке X
        /// </summary>
        /// <param name="x">Координата точки X</param>
        /// <returns></returns>
        private double fCircle(double x)
        {
            return Yo + Math.Sqrt((R * R) - ((x - Xo) * (x - Xo)));
        }

        /// <summary>
        /// Функция для рисования координат, координатной сетки, чисел для подписи значений коорднинат
        /// </summary>
        private void DrawCoordinates()
        {
            GL.glLineWidth(3.0f);
            GL.glBegin(GL.GL_LINES);
            GL.glColor3f(1.0f, 1.0f, 0.0f);

            if (xMax <= 0)
            {
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax, yMin);
            }
            else
            {
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(0, yMin);
            }
            if (xMax <= 0)
            {
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax - oneLengthX / 10, yMax - (oneLengthY / 5));
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax + oneLengthX / 10, yMax - (oneLengthY / 5));
            }
            else
            {
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(-oneLengthX / 10, yMax - (oneLengthY / 5));
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(oneLengthX / 10, yMax - (oneLengthY / 5));
            }
            if (xMin < 0)
            {
                GL.glVertex2d(xMin, 0);
            }
            else
                GL.glVertex2d(0, 0);
            GL.glVertex2d(xMax, 0);
            GL.glVertex2d(xMax, 0);
            GL.glVertex2d(xMax - (oneLengthX / 5), oneLengthY / 10);
            GL.glVertex2d(xMax, 0);
            GL.glVertex2d(xMax - (oneLengthX / 5), -oneLengthY / 10);
            GL.glEnd();
            OutText("0", -oneLengthX / 3, -oneLengthY / 5);
            OutText("X", xMax, -oneLengthY / 3);
            if (xMax <= 0)
            {
                OutText("Y", xMax - oneLengthX / 3, yMax);
            }
            else
            {
                OutText("Y", -oneLengthX / 3, yMax);
            }
            GL.glBegin(GL.GL_LINES);
            for (int y = 1; y < 10; y++)
            {
                if (xMax <= 0)
                {
                    GL.glVertex2d(xMax - oneLengthX / 10, yMax - (y * oneLengthY));
                    GL.glVertex2d(xMax + oneLengthX / 10, yMax - (y * oneLengthY));
                }
                else
                {
                    GL.glVertex2d(-oneLengthX / 10, yMax - (y * oneLengthY));
                    GL.glVertex2d(oneLengthX / 10, yMax - (y * oneLengthY));
                }

                GL.glEnd();

                GL.glLineWidth(1.0f);
                GL.glEnable(GL.GL_LINE_STIPPLE);
                GL.glLineStipple(1, 0xff0);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 1.0f);
                if (xMin < 0)
                {
                    GL.glVertex2d(xmin, yMax - (y * oneLengthY));
                }
                else
                    GL.glVertex2d(0, yMax - (y * oneLengthY));
                GL.glVertex2d(xmax, yMax - (y * oneLengthY));
                GL.glEnd();
                GL.glDisable(GL.GL_LINE_STIPPLE);
                if (xMax <= 0)
                {
                    if (yMax > 10)
                    {
                        OutText((((yMax - (y * oneLengthY))).ToString("F1")), xMax + oneLengthX / 3.5, yMax - (y * oneLengthY));
                    }
                    else
                        OutText((((yMax - (y * oneLengthY))).ToString("F2")), xMax + oneLengthX / 3.5, yMax - (y * oneLengthY));
                }
                else
                    if (yMax > 10)
                    {
                        OutText((((yMax - (y * oneLengthY))).ToString("F1")), -oneLengthX / 1.5, yMax - (y * oneLengthY));
                    }
                    else
                        OutText((((yMax - (y * oneLengthY))).ToString("F2")), -oneLengthX / 1.5, yMax - (y * oneLengthY));
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
            }
            for (int x = 1; x < 20; x++)
            {
                GL.glLineWidth(3.0f);
                GL.glVertex2d(xMax - (x * oneLengthX), -oneLengthY / 10);
                GL.glVertex2d(xMax - (x * oneLengthX), oneLengthY / 10);
                GL.glEnd();

                GL.glLineWidth(1.0f);
                GL.glEnable(GL.GL_LINE_STIPPLE);
                GL.glLineStipple(1, 0xff0);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 1.0f);
                GL.glVertex2d(xMax - (x * oneLengthX), ymax);
                GL.glVertex2d(xMax - (x * oneLengthX), ymin);
                GL.glEnd();
                GL.glDisable(GL.GL_LINE_STIPPLE);
                if (xMax > 10)
                    OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), -oneLengthY / 2.5);
                else
                    OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), -oneLengthY / 2.5);
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
            }
            GL.glEnd();
        }


        private void ViewGL_Resize(object sender, EventArgs e)
        {
            GL.glViewport(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            //Автоматическое вычисление шага, в зависимости от размера окна вывода
            if (this.ClientSize.Width > 1100)
            {
                h = 0.00001;
            }
            else
                if (this.ClientSize.Width > 900)
                {
                    h = 0.0001;
                }
                else
                    if (this.ClientSize.Width > 700)
                    {
                        h = 0.001;
                    }
                    else
                        if (this.ClientSize.Width > 500)
                        {
                            h = 0.01;
                        }
                        else
                            if (this.ClientSize.Width > 100)
                            {
                                h = 0.1;
                            }
        }

        // / <summary> 
        // / Переопределение перерисовки фона для предотвращения мерцания изображения при изменении размера окна.
        // / </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            GL.glClear(GL.GL_COLOR_BUFFER_BIT);
        }
    }
}
