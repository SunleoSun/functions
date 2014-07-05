namespace glWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fnudXmin = new System.Windows.Forms.NumericUpDown();
            this.fnudXmax = new System.Windows.Forms.NumericUpDown();
            this.fnudH = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flbList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.view = new OpenGL.ViewGL();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudH)).BeginInit();
            this.SuspendLayout();
            // 
            // fnudXmin
            // 
            this.fnudXmin.DecimalPlaces = 3;
            this.fnudXmin.Location = new System.Drawing.Point(27, 42);
            this.fnudXmin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudXmin.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudXmin.Name = "fnudXmin";
            this.fnudXmin.Size = new System.Drawing.Size(132, 24);
            this.fnudXmin.TabIndex = 1;
            // 
            // fnudXmax
            // 
            this.fnudXmax.DecimalPlaces = 3;
            this.fnudXmax.Location = new System.Drawing.Point(27, 110);
            this.fnudXmax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudXmax.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudXmax.Name = "fnudXmax";
            this.fnudXmax.Size = new System.Drawing.Size(132, 24);
            this.fnudXmax.TabIndex = 2;
            // 
            // fnudH
            // 
            this.fnudH.DecimalPlaces = 5;
            this.fnudH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.fnudH.Location = new System.Drawing.Point(26, 177);
            this.fnudH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fnudH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.fnudH.Name = "fnudH";
            this.fnudH.Size = new System.Drawing.Size(132, 24);
            this.fnudH.TabIndex = 3;
            this.fnudH.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Задать параметры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "XMin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "XMax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шаг:";
            // 
            // flbList
            // 
            this.flbList.Enabled = false;
            this.flbList.FormattingEnabled = true;
            this.flbList.ItemHeight = 18;
            this.flbList.Location = new System.Drawing.Point(25, 408);
            this.flbList.Name = "flbList";
            this.flbList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.flbList.Size = new System.Drawing.Size(133, 274);
            this.flbList.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Найти корни";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Корни функции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "(точность расчетов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "зависит от величины";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "шага):";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(642, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "F(x) = tg(x/2) - ctg(x/2) + x";
            // 
            // view
            // 
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.view.H = 0.0001;
            this.view.Location = new System.Drawing.Point(184, 42);
            this.view.Name = "view";
            this.view.Num_points = 10000;
            this.view.Size = new System.Drawing.Size(1063, 679);
            this.view.TabIndex = 0;
            this.view.xMax = 2;
            this.view.xMin = 1;
            this.view.Load += new System.EventHandler(this.view_Load);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1278, 748);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flbList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fnudH);
            this.Controls.Add(this.fnudXmax);
            this.Controls.Add(this.fnudXmin);
            this.Controls.Add(this.view);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(700, 766);
            this.Name = "MainForm";
            this.Text = "OpenGL Form";
            this.SizeChanged += new System.EventHandler(this.Sized);
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenGL.ViewGL view;
        private System.Windows.Forms.NumericUpDown fnudXmin;
        private System.Windows.Forms.NumericUpDown fnudXmax;
        private System.Windows.Forms.NumericUpDown fnudH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox flbList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

