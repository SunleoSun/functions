using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenGL
{
    public partial class ViewGL : UserControl
    {
        public ViewGL()
        {
            InitializeComponent();
            right = (double)this.ClientRectangle.Right;
            left = (double)this.ClientRectangle.Left;
            bottom = (double)this.ClientRectangle.Bottom;
            top = (double)this.ClientRectangle.Top;
            h = 0.1;
            xmin = 1;
            xmax = 2;
            ymax = 10;
            ymin = -10;
            FindNumPoints();
            FindOneLengthX();
            FindOneLengthY();
        }

        //Найти количество точек
        private void FindNumPoints()
        {
            num_points = (int)((xMax - xMin) / H);
        }

        //Найти минимальную величину видимую в масштабе X
        private void FindOneLengthX()
        {
            if (xmin >= 0)
            {
                OneLengthX = xmax / 20;
            }
            else
            {
                OneLengthX = (xmax - xmin) / 20;
            }
        }
        /// <summary>
        /// Найти минимальную величину видимую в масштабе Y
        /// </summary>
        private void FindOneLengthY()
        {
            OneLengthY = (ymax - ymin) / 10;
        }

        double OneLengthX;
        double OneLengthY;

        double right;
        public double Right { get { return right; } }
        double left;
        public double Left { get { return left; } }
        double bottom;
        public double Bottom { get { return bottom; } }
        double top;
        public double Top { get { return top; } }
        double xmin;
        public double xMin { get { return xmin; } set{ xmin = value;}}
        double xmax;
        public double xMax { get { return xmax; } set { xmax = value; } }
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

        double [] mas_of_roots;
        /// <summary>
        /// Массив корней
        /// </summary>
        public double []Mas_of_roots
        {
            get { return mas_of_roots; }
        }
        /// <summary>
        /// Шаг между точками
        /// </summary>
        double  h;
        /// <summary>
        /// Шаг
        /// </summary>
        public double H
        {
            get { return h; }
            set { h = value; }
        }


        /// <summary> 
        /// Обработчик события WM_PAINT. Здесь выполняются все основные команды рисования OpenGL.
        /// </summary>
        private void ViewGL_Paint(object sender, PaintEventArgs e)
        {
            GL.glLoadIdentity();
            Calc_Max_Min_Y();
            FindOneLengthY();
            FindOneLengthX();
            FindNumPoints();
            if (xMin<=0)
            {
                GLU.gluOrtho2D(xMin - OneLengthX, xMax + OneLengthX, yMin - OneLengthY, yMax + OneLengthY);
            }
            else
            {
                GLU.gluOrtho2D(-OneLengthX, xMax + OneLengthX, yMin - OneLengthY, yMax + OneLengthY);
            }
            DrawCoordinates();
            DrawFunction();
            GL.glFinish();
            WGL.wglSwapBuffers(DC);
        }

        /// <summary>
        /// Функция нахождения корней
        /// </summary>
        /// <param name="x1">Начало интервала поиска</param>
        /// <param name="x2">Конец интервала поиска</param>
        private void FindRoots(double x1, double x2)
        {
            if (f(x1) * f(x2) < 0)
            {
                
                if (mas_of_roots!= null)
                {
                    foreach (double el in mas_of_roots)
                    {
                        if (el == (x1 + x2) / 2)
                        {
                            return;
                        }
                    }
                    double[] temp = new double[mas_of_roots.Length + 1];
                    for (int x = 0; x < mas_of_roots.Length; x++)
                    {
                        temp[x] = mas_of_roots[x];
                    }
                    temp[mas_of_roots.Length] = (x1 + x2) / 2;
                    mas_of_roots = temp;
                }
                else
                {
                    mas_of_roots = new double[1];
                    mas_of_roots[0] = (x1 + x2) / 2;
                }
            }
        }

        /// <summary>
        /// Нахождение минимального и максимального значения Y
        /// </summary>
        private void Calc_Max_Min_Y()
        {
            ymin = ymax = f(xMin);
            for (int z = 1; z < Num_points; z++)
            {
                if (ymin == double.NegativeInfinity)
                {
                    ymin = 0;
                }
                double x = xMin + z * H;
                double y = f(x);
                if (Math.Abs(y) > 200)
                {
                    y = Math.Sign(y) * 200;
                    continue;
                }
                if (x> xMax)
                {
                    break;
                }
                if (yMin > y)
                {
                    ymin = y;
                }
                if (yMax < y)
                {
                    ymax = y;
                }
                if (yMax < 0)
                {
                    ymax = 0;
                }
                if (yMin > 0)
                {
                    ymin = 0;
                }
            }
        }

        /// <summary>
        /// Функция для рисования функции
        /// </summary>
        private void DrawFunction()
        {
            mas_of_roots = null;
            GL.glLineWidth(2.0f);
            GL.glBegin(GL.GL_LINE_STRIP);
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            double x_start = xMin;
            double y_start = f(x_start);
            GL.glVertex2d(x_start, y_start);
            double temp_y = y_start;
            double temp_x = x_start;
            for (int z = 1; z < Num_points; z++)
            {
                double x = xMin + (double)z * H;
                double y = f(x);
                if (y > ymax || y < ymin)
                {
                    continue;
                }
                if (temp_y > y )
                {
                    GL.glEnd();
                    GL.glBegin(GL.GL_LINE_STRIP);
                    temp_x = x;
                }
                FindRoots(temp_x, x);
                temp_y = y;
                temp_x = x;

                GL.glVertex2d(x, y);
            }
            GL.glEnd();

            if (Mas_of_roots!= null)
            {
                GL.glEnable(GL.GL_POINT_SMOOTH);
                GL.glPointSize(7.0f);
                GL.glBegin(GL.GL_POINTS);
                GL.glColor3f(1.0f, 0.0f, 1.0f);
                for (int x = 0; x < Mas_of_roots.Length; x++)
                {
                    GL.glVertex2d(Mas_of_roots[x], 0);
                }
                GL.glEnd();
                GL.glDisable(GL.GL_POINT_SMOOTH);

            }
        }

        /// <summary>
        /// Функция для расчета значения Y в точке X
        /// </summary>
        /// <param name="x">Координата точки X</param>
        /// <returns></returns>
        private double f(double x)
        {
            return Math.Tan(x / 2) - 1 / Math.Tan(x / 2) + x;
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
                GL.glVertex2d(xMax - OneLengthX / 10, yMax - (OneLengthY / 5));
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax + OneLengthX / 10, yMax - (OneLengthY / 5));
            }
            else
            {
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(-OneLengthX / 10, yMax - (OneLengthY / 5));
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(OneLengthX / 10, yMax - (OneLengthY / 5));
            }
            if (xMin < 0)
            {
                GL.glVertex2d(xMin, 0);
            }
            else
                GL.glVertex2d(0, 0);
            GL.glVertex2d(xMax, 0);
            GL.glVertex2d(xMax, 0);
            GL.glVertex2d(xMax - (OneLengthX / 5), OneLengthY / 10);
            GL.glVertex2d(xMax, 0);
            GL.glVertex2d(xMax - (OneLengthX / 5), -OneLengthY / 10);
            GL.glEnd();
            OutText("0", -OneLengthX / 3, -OneLengthY / 5);
            OutText("X", xMax, -OneLengthY / 3);
            if (xMax <= 0)
            {
                OutText("Y", xMax - OneLengthX / 3, yMax);
            }
            else
            {
                OutText("Y", -OneLengthX / 3, yMax);
            }
            GL.glBegin(GL.GL_LINES);
            for (int y = 1; y < 10; y++)
            {
                if (xMax <= 0)
                {
                    GL.glVertex2d(xMax - OneLengthX / 10, yMax - (y * OneLengthY));
                    GL.glVertex2d(xMax + OneLengthX / 10, yMax - (y * OneLengthY));
                }
                else
                {
                    GL.glVertex2d(-OneLengthX / 10, yMax - (y * OneLengthY));
                    GL.glVertex2d(OneLengthX / 10, yMax - (y * OneLengthY));
                }

                GL.glEnd();

                GL.glLineWidth(1.0f);
                GL.glEnable(GL.GL_LINE_STIPPLE);
                GL.glLineStipple(1, 0xff0);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 1.0f);
                if (xMin < 0)
                {
                    GL.glVertex2d(xmin, yMax - (y * OneLengthY));
                }
                else
                    GL.glVertex2d(0, yMax - (y * OneLengthY));
                GL.glVertex2d(xmax, yMax - (y * OneLengthY));
                GL.glEnd();
                GL.glDisable(GL.GL_LINE_STIPPLE);
                if (xMax <= 0)
                {
                    if (yMax>10)
                    {
                        OutText((((yMax - (y * OneLengthY))).ToString("F1")), xMax + OneLengthX / 3.5, yMax - (y * OneLengthY));
                    }
                    else
                        OutText((((yMax - (y * OneLengthY))).ToString("F2")), xMax + OneLengthX / 3.5, yMax - (y * OneLengthY));
                }
                else
                    if (yMax > 10)
                    {
                        OutText((((yMax - (y * OneLengthY))).ToString("F1")), -OneLengthX / 1.5, yMax - (y * OneLengthY));
                    }
                    else
                        OutText((((yMax - (y * OneLengthY))).ToString("F2")), -OneLengthX / 1.5, yMax - (y * OneLengthY));
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
            }
            for (int x = 1; x < 20; x++)
            {
                GL.glLineWidth(3.0f);
                GL.glVertex2d(xMax - (x * OneLengthX), -OneLengthY / 10);
                GL.glVertex2d(xMax - (x * OneLengthX), OneLengthY / 10);
                GL.glEnd();

                GL.glLineWidth(1.0f);
                GL.glEnable(GL.GL_LINE_STIPPLE);
                GL.glLineStipple(1, 0xff0);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 1.0f);
                GL.glVertex2d(xMax - (x * OneLengthX), ymax);
                GL.glVertex2d(xMax - (x * OneLengthX), ymin);
                GL.glEnd();
                GL.glDisable(GL.GL_LINE_STIPPLE);
                if(xMax > 10)
                    OutText((((xMax - (x * OneLengthX))).ToString("F1")), xMax - (x * OneLengthX), -OneLengthY / 2.5);
                else
                    OutText((((xMax - (x * OneLengthX))).ToString("F2")), xMax - (x * OneLengthX), -OneLengthY / 2.5);
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
