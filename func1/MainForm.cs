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


        private void button1_Click(object sender, EventArgs e)
        {
            this.flbList.Enabled = false;
            this.flbList.Items.Clear();
            if (fnudXmin.Value < fnudXmax.Value)
            {
                this.view.xMin = (double)fnudXmin.Value;
                this.view.xMax = (double)fnudXmax.Value;
                this.view.H = (double)fnudH.Value;
                this.view.Refresh();
                this.view.Refresh();
            }
            else
                MessageBox.Show("XMin должен быть меньше XMax.", "Неверное задание параметров ");
            
        }

        private void view_Load(object sender, EventArgs e)
        {
            fnudXmin.Value = (decimal)this.view.xMin;
            fnudXmax.Value = (decimal)this.view.xMax;
            fnudH.Value = (decimal)this.view.H;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.flbList.Enabled = true;
            this.flbList.Items.Clear();
            if (this.view.Mas_of_roots != null)
            {
                for (int x = 0; x < this.view.Mas_of_roots.Length; x++)
                {
                    flbList.Items.Add("X= " + this.view.Mas_of_roots[x].ToString("F4"));
                }
            }
            else
                flbList.Items.Add("КОРНЕЙ НЕТ");
            
        }



        private void Sized(object sender, EventArgs e)
        {
            this.fnudH.Value = (decimal)this.view.H;
        }
    }
}
