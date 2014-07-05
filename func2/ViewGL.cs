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
            a = 10;
            b = 10;
            h = 0.1;
            xmin = 1;
            xmax = 2;
            ymax = 10;
            ymin = -10;
            R = 0;
            Xo = 0;
            Yo = 0;
            x1 = double.NaN;
            y1 = double.NaN;
            x2 = double.NaN;
            y2 = double.NaN;
            intersectionsY = new double[2];
            intersectionsX = new double[2];
            CurrentFigureType = CurrentFigure.Hyperbole;
            for (int x=0; x< 2;x++)
            {
            	intersectionsY[x] = double.NaN;
                intersectionsX[x] = double.NaN;
            }
            FindNumPoints();
            FindOneLengthX();
            FindOneLengthY();
        }
        public enum CurrentFigure { Hyperbole,Circle}
        public CurrentFigure CurrentFigureType;
        double[] intersectionsY;
        public double[] IntersectionsY
        {
            get { return intersectionsY; }
        }
        double[] intersectionsX;
        public double[] IntersectionsX
        {
            get { return intersectionsX; }
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

        double x1;
        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        double y1;
        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        double x2;
        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        double y2;
        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        double b;
        public double B
        {
            get { return b; }
            set { b = value; }
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
        public double xMax { get { return xmax; } set { if (xMin==0)
            {
                xmin += 0.0001;
            }xmax = value; } }
        double ymin;
        public double yMin { get { return ymin; } set { ymin = value; } }
        double ymax;
        public double yMax { get { return ymax; } set { ymax = value; } }

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
            if (CurrentFigureType == CurrentFigure.Hyperbole)
            {
                Calc_Max_Min_Y();
            }
            FindOneLengthY();
            FindOneLengthX();
            FindNumPoints();
            if (xMin<=0)
            {
                GLU.gluOrtho2D(xMin - oneLengthX, xMax + oneLengthX, yMin - oneLengthY, yMax + oneLengthY);
            }
            else
            {
                GLU.gluOrtho2D(-oneLengthX, xMax + oneLengthX, yMin - oneLengthY, yMax + oneLengthY);
            }
            DrawCoordinates();
            if (CurrentFigureType == CurrentFigure.Hyperbole)
            {
                DrawHyperboleFunction();
                DrawLine();
            }
            else
                DrawCircleFunction();


            GL.glFinish();
            WGL.wglSwapBuffers(DC);
        }


        /// <summary>
        /// Нахождение минимального и максимального значения Y
        /// </summary>
        private void Calc_Max_Min_Y()
        {
            ymin = -1; ymax = 1;
            for (int z = 1; z < Num_points; z++)
            {
                if (ymin == double.NegativeInfinity)
                {
                    ymin = 0;
                }
                double x = xMin + z * H;
                double y = 0;
                double y1 = 0;
                if (CurrentFigureType == CurrentFigure.Hyperbole)
                {
                     y = fHyperbole(x);
                     y1 = fHyperbole(x) * (-1);
                }
                else
                {
                     y = fCircle(x);
                     y1 = fCircle2(x);
                }
                if (double.IsNaN(y)||double.IsNaN(y1))
                {
                	continue;
                }
                if (Math.Abs(y) > 200)
                {
                    y = Math.Sign(y) * 200;
                    y1 = Math.Sign(y1) * 200;
                    continue;
                }
                if (x> xMax)
                {
                    break;
                }
                if (yMin > y1)
                {
                    ymin = y1;
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
        private void CalcIntersections()
        {
            double Aline = (Y1 - Y2) / (X1 - X2);
            double Bline = Y1 - (Y1 - Y2) / (X1 - X2) * X1;
            double a = Aline * Aline * A * A - B*B;
            double b = 2 * Aline * Bline * A*A;
            double c = Bline * Bline * A * A + B * B * A * A;
            double Discriminant = b * b - 4 * a * c;
            if (Discriminant < 0)
            {
            	for (int x=0; x< 2;x++)
            	{
                    intersectionsX[x] = double.NaN;
                    intersectionsY[x] = double.NaN;
            	}
            }
            else
                    if (Discriminant > 0)
                    {
                        intersectionsX[0] = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                        intersectionsY[0] = Aline * intersectionsX[0] + Bline;
                        intersectionsX[1] = (-b - Math.Sqrt(Discriminant)) / (2 * a);
                        intersectionsY[1] = Aline * intersectionsX[1] + Bline;
                        if (X2<X1)
                        {
                            if (intersectionsX[0] > X1 || intersectionsX[0] < X2)
                        	{
                                intersectionsX[0] = double.NaN; intersectionsY[0] = double.NaN;
                        	}
                            if (intersectionsX[1] > X1 || intersectionsX[1] < X2)
                            {
                                intersectionsX[1] = double.NaN; intersectionsY[1] = double.NaN;
                            }
                        }
                        else
                        {
                            if (intersectionsX[0] < X1 || intersectionsX[0] > X2)
                            {
                                intersectionsX[0] = double.NaN; intersectionsY[0] = double.NaN;
                            }
                            if (intersectionsX[1] < X1 || intersectionsX[1] > X2)
                            {
                                intersectionsX[1] = double.NaN; intersectionsY[1] = double.NaN;
                            }
                        }
                        GL.glPointSize(5.0f);
                        GL.glBegin(GL.GL_POINTS);
                        GL.glColor3f(0.2f, 1.0f, 1.0f);
                        GL.glVertex2d(intersectionsX[0], intersectionsY[0]);
                        GL.glVertex2d(intersectionsX[1], intersectionsY[1]);
                        GL.glEnd();
                    }
        }
        private void DrawLine()
        {
            if (!double.IsNaN(X1) && double.IsNaN(X2))
            {
                GL.glPointSize(5.0f);
                GL.glBegin(GL.GL_POINTS);
                GL.glColor3f(1.0f, 0.0f, 0.0f);
                GL.glVertex2d(X1, Y1);
                GL.glEnd();
            }
            if (!double.IsNaN(X1) && !double.IsNaN(X2))
            {
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 0.0f, 0.0f);
                GL.glVertex2d(X1, Y1);
                GL.glVertex2d(X2, Y2);
                GL.glEnd();
                CalcIntersections();
            }
        }
        /// <summary>
        /// Функция для рисования гиперболы
        /// </summary>
        private void DrawHyperboleFunction()
        {
            {
                GL.glLineWidth(2.0f);
                GL.glBegin(GL.GL_LINE_STRIP);
                GL.glColor3f(1.0f, 0.0f, 0.0f);
                double x_start;
                x_start = xMin;
                double y_start = 0;
                for (int z = 1; z < Num_points; z++)
                {
                    x_start = xMin + (double)z * H;
                    y_start = fHyperbole(x_start);
                    if (double.IsNaN(y_start))
                    {
                        continue;
                    }
                    GL.glVertex2d(x_start, y_start);
                    break;
                }
                for (int z = 1; z < Num_points; z++)
                {
                    double x = x_start + (double)z * H;
                    double y = fHyperbole(x);
                    if (double.IsNaN(y))
                    {
                        GL.glEnd();
                        GL.glBegin(GL.GL_LINE_STRIP);
                        continue;
                    }
                    if (y > ymax - ymax / 200 || y < ymin - ymin / 200)
                    {
                        continue;
                    }
                    GL.glVertex2d(x, y);
                }
                GL.glEnd();

            }
            mas_of_roots = null;
            {
                GL.glLineWidth(2.0f);
                GL.glBegin(GL.GL_LINE_STRIP);
                GL.glColor3f(1.0f, 0.0f, 0.0f);
                double x_start;
                x_start = xMin;
                double y_start = 0;
                for (int z = 1; z < Num_points; z++)
                {
                    x_start = x_start + (double)z * H;
                    y_start = fHyperbole(x_start)*-1;
                    if (double.IsNaN(y_start))
                    {
                        continue;
                    }
                    GL.glVertex2d(x_start, y_start);
                    break;
                }

                for (int z = 1; z < Num_points; z++)
                {
                    double x = xMin + (double)z * H;
                    double y = fHyperbole(x)*-1;
                    if (double.IsNaN(y))
                    {
                        GL.glEnd();
                        GL.glBegin(GL.GL_LINE_STRIP);
                        continue;
                    }

                    if (y > ymax - ymax / 200 || y < ymin - ymin / 200)
                    {
                        continue;
                    }
                    GL.glVertex2d(x, y);
                }
                GL.glEnd();
            }
        }
        /// <summary>
        /// Функция для рисования окпужности
        /// </summary>
        private void DrawCircleFunction()
        {
            GL.glLineWidth(2.0f);
            GL.glBegin(GL.GL_LINE_STRIP);
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            double x_start;
            x_start = xMin;
            double y_start = fCircle(xMin);
            GL.glVertex2d(x_start, y_start);
            for (int z = 1; z < Num_points; z++)
            {
                double x = x_start + h * z;
                if (x > xMax || x < xMin)
                {
                    GL.glEnd();
                    GL.glBegin(GL.GL_LINE_STRIP);
                	continue;
                }
                double y = fCircle(x);
                if (y > yMax || y < yMin)
                {
                    GL.glEnd();
                    GL.glBegin(GL.GL_LINE_STRIP);
                    continue;
                }

                GL.glVertex2d(x, y);
            }
            GL.glEnd();

            GL.glBegin(GL.GL_LINE_STRIP);
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            y_start = fCircle2(xMin);
            GL.glVertex2d(x_start, y_start);
            for (int z = 1; z < Num_points; z++)
            {
                double x = x_start + h * z;
                if (x > xMax || x < xMin)
                {
                    GL.glEnd();
                    GL.glBegin(GL.GL_LINE_STRIP);
                    continue;
                }
                double y = fCircle2(x);
                if (y > yMax || y < yMin)
                {
                    GL.glEnd();
                    GL.glBegin(GL.GL_LINE_STRIP);
                    continue;
                }
                GL.glVertex2d(x, y);
            }
            GL.glEnd();

            GL.glEnable(GL.GL_POINT_SMOOTH);
            GL.glPointSize(3);
            GL.glBegin(GL.GL_POINTS);
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex2d(Xo, Yo);
            GL.glEnd();
            GL.glDisable(GL.GL_POINT_SMOOTH);
        }

        /// <summary>
        /// Функция для расчета значения Y в точке X для функции гиперболы
        /// </summary>
        /// <param name="x">Координата точки X</param>
        /// <returns></returns>
        private double fHyperbole(double x)
        {
            return Math.Sqrt((Math.Pow(x, 2) * Math.Pow(B, 2)) / Math.Pow(A, 2) - Math.Pow(B,2));
        }

        /// <summary>
        /// Функция для расчета значения Y в точке X для функции окружности
        /// </summary>
        /// <param name="x">Координата точки X</param>
        /// <returns></returns>
        private double fCircle(double x)
        {
            return Yo + Math.Sqrt((R * R) - ((x - Xo) * (x - Xo)));
        }
        /// <summary>
        /// Функция для расчета значения Y в точке X для функции окружности
        /// </summary>
        /// <param name="x">Координата точки X</param>
        /// <returns></returns>
        private double fCircle2(double x)
        {
            return Yo - Math.Sqrt((R * R) - ((x - Xo) * (x - Xo)));
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
            if (yMin>0)
            {
                GL.glVertex2d(xMin, yMin);
                GL.glVertex2d(xMax, yMin);
            }
            else
                if (yMax < 0)
                {
                    GL.glVertex2d(xMin, yMax);
                    GL.glVertex2d(xMax, yMax);
                }
                else
                    if (xMin < 0)
                    {
                        GL.glVertex2d(xMin, 0);
                        GL.glVertex2d(xMax, 0);
                    }
                    else
                    {
                        GL.glVertex2d(0, 0);
                        GL.glVertex2d(xMax, 0);
                    }
            GL.glEnd();

            OutText("0", -oneLengthX / 3, -oneLengthY / 5);
            if (yMax < 0)
            {
                OutText("X", xMax, yMax - oneLengthY / 3);
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax - (oneLengthX / 5), yMax-oneLengthY / 10);
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax - (oneLengthX / 5), yMax - - oneLengthY / 10);
                GL.glEnd();

            }
            else
                if (yMin > 0)
                {
                    OutText("X", xMax, yMin - oneLengthY / 3);
                    GL.glLineWidth(3.0f);
                    GL.glBegin(GL.GL_LINES);
                    GL.glColor3f(1.0f, 1.0f, 0.0f);
                    GL.glVertex2d(xMax, yMin);
                    GL.glVertex2d(xMax - (oneLengthX / 5), yMin + oneLengthY / 10);
                    GL.glVertex2d(xMax, yMin);
                    GL.glVertex2d(xMax - (oneLengthX / 5), yMin + -oneLengthY / 10);
                    GL.glEnd();

                }
                else
                {
                    OutText("X", xMax, -oneLengthY / 3);
                    GL.glLineWidth(3.0f);
                    GL.glBegin(GL.GL_LINES);
                    GL.glColor3f(1.0f, 1.0f, 0.0f);
                    GL.glVertex2d(xMax, 0);
                    GL.glVertex2d(xMax - (oneLengthX / 5), oneLengthY / 10);
                    GL.glVertex2d(xMax, 0);
                    GL.glVertex2d(xMax - (oneLengthX / 5), -oneLengthY / 10);
                    GL.glEnd();
                }
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
                    if (yMax>10)
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
                if (yMax<0)
                {
                    GL.glVertex2d(xMax - (x * oneLengthX), yMax - oneLengthY / 10);
                    GL.glVertex2d(xMax - (x * oneLengthX), yMax+oneLengthY / 10);
                }
                else
                    if (yMin > 0)
                    {
                        GL.glVertex2d(xMax - (x * oneLengthX), yMin - oneLengthY / 10);
                        GL.glVertex2d(xMax - (x * oneLengthX), yMin + oneLengthY / 10);
                    }
                    else
                    {
                        GL.glVertex2d(xMax - (x * oneLengthX), -oneLengthY / 10);
                        GL.glVertex2d(xMax - (x * oneLengthX), oneLengthY / 10);
                    }
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
                if (yMax < 0)
                {
                    if (xMax > 10)
                        OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), yMax - oneLengthY / 2.5);
                    else
                        OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), yMax - oneLengthY / 2.5);

                }
                else
                    if (yMin > 0)
                    {
                        if (xMax > 10)
                            OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), yMin - oneLengthY / 2.5);
                        else
                            OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), yMin - oneLengthY / 2.5);
                    }
                    else
                    {
                        if (xMax > 10)
                            OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), -oneLengthY / 2.5);
                        else
                            OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), -oneLengthY / 2.5);
                    }
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
            if (this.ClientSize.Width > 900)
            {
                h = 0.00001;
                this.Refresh();
            }
            else
                if (this.ClientSize.Width > 700)
                {
                    h = 0.0001;
                    this.Refresh();

                }
                else
                    if (this.ClientSize.Width > 500)
                    {
                        h = 0.001;
                        this.Refresh();

                    }
                    else
                        if (this.ClientSize.Width > 300)
                        {
                            h = 0.01;
                            this.Refresh();

                        }
                        else
                            if (this.ClientSize.Width > 100)
                            {
                                h = 0.1;
                                this.Refresh();

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
