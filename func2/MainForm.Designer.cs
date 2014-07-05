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
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.fnudY2 = new System.Windows.Forms.NumericUpDown();
            this.fnudX2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fnudY1 = new System.Windows.Forms.NumericUpDown();
            this.fnudX1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fnudB = new System.Windows.Forms.NumericUpDown();
            this.fnudA = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fgbIntersections = new System.Windows.Forms.GroupBox();
            this.fgbLine = new System.Windows.Forms.GroupBox();
            this.fgbHyperbole = new System.Windows.Forms.GroupBox();
            this.fgbCircle = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fnudR = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.fnudXo = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.fnudYo = new System.Windows.Forms.NumericUpDown();
            this.fcbMain = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fbEnterCircle = new System.Windows.Forms.Button();
            this.fnudMinY = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.fnudMaxY = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.view = new OpenGL.ViewGL();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudA)).BeginInit();
            this.fgbIntersections.SuspendLayout();
            this.fgbLine.SuspendLayout();
            this.fgbHyperbole.SuspendLayout();
            this.fgbCircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudYo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnudMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudMaxY)).BeginInit();
            this.SuspendLayout();
            // 
            // fnudXmin
            // 
            this.fnudXmin.DecimalPlaces = 3;
            this.fnudXmin.Location = new System.Drawing.Point(7, 107);
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
            this.fnudXmin.Size = new System.Drawing.Size(78, 24);
            this.fnudXmin.TabIndex = 1;
            // 
            // fnudXmax
            // 
            this.fnudXmax.DecimalPlaces = 3;
            this.fnudXmax.Location = new System.Drawing.Point(7, 175);
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
            this.fnudXmax.Size = new System.Drawing.Size(78, 24);
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
            this.fnudH.Location = new System.Drawing.Point(6, 242);
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
            this.fnudH.Size = new System.Drawing.Size(79, 24);
            this.fnudH.TabIndex = 3;
            this.fnudH.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Задать параметры гиперболы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "XMin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "XMax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шаг:";
            // 
            // flbList
            // 
            this.flbList.FormattingEnabled = true;
            this.flbList.ItemHeight = 18;
            this.flbList.Location = new System.Drawing.Point(6, 77);
            this.flbList.Name = "flbList";
            this.flbList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.flbList.Size = new System.Drawing.Size(109, 94);
            this.flbList.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(117, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "F(x) = sqrt((x^2*B^2)/A^2 - B^2)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "мышкой на графике.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "также можно, нажимая";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Задавать параметры отрезка";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 51);
            this.button3.TabIndex = 28;
            this.button3.Text = "Задать параметры отрезка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fnudY2
            // 
            this.fnudY2.DecimalPlaces = 3;
            this.fnudY2.Location = new System.Drawing.Point(140, 174);
            this.fnudY2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudY2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudY2.Name = "fnudY2";
            this.fnudY2.Size = new System.Drawing.Size(72, 24);
            this.fnudY2.TabIndex = 25;
            // 
            // fnudX2
            // 
            this.fnudX2.DecimalPlaces = 3;
            this.fnudX2.Location = new System.Drawing.Point(19, 174);
            this.fnudX2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudX2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudX2.Name = "fnudX2";
            this.fnudX2.Size = new System.Drawing.Size(72, 24);
            this.fnudX2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "X2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Y2:";
            // 
            // fnudY1
            // 
            this.fnudY1.DecimalPlaces = 3;
            this.fnudY1.Location = new System.Drawing.Point(140, 110);
            this.fnudY1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudY1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudY1.Name = "fnudY1";
            this.fnudY1.Size = new System.Drawing.Size(72, 24);
            this.fnudY1.TabIndex = 20;
            // 
            // fnudX1
            // 
            this.fnudX1.DecimalPlaces = 3;
            this.fnudX1.Location = new System.Drawing.Point(19, 110);
            this.fnudX1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudX1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudX1.Name = "fnudX1";
            this.fnudX1.Size = new System.Drawing.Size(72, 24);
            this.fnudX1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "X1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Y1:";
            // 
            // fnudB
            // 
            this.fnudB.DecimalPlaces = 1;
            this.fnudB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fnudB.Location = new System.Drawing.Point(143, 57);
            this.fnudB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudB.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.fnudB.Name = "fnudB";
            this.fnudB.Size = new System.Drawing.Size(72, 24);
            this.fnudB.TabIndex = 18;
            // 
            // fnudA
            // 
            this.fnudA.DecimalPlaces = 1;
            this.fnudA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fnudA.Location = new System.Drawing.Point(22, 57);
            this.fnudA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudA.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.fnudA.Name = "fnudA";
            this.fnudA.Size = new System.Drawing.Size(72, 24);
            this.fnudA.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "b:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "a:";
            // 
            // fgbIntersections
            // 
            this.fgbIntersections.Controls.Add(this.flbList);
            this.fgbIntersections.Location = new System.Drawing.Point(7, 302);
            this.fgbIntersections.Name = "fgbIntersections";
            this.fgbIntersections.Size = new System.Drawing.Size(121, 186);
            this.fgbIntersections.TabIndex = 31;
            this.fgbIntersections.TabStop = false;
            this.fgbIntersections.Text = "Точки пересечения гиперболы с отрезком";
            // 
            // fgbLine
            // 
            this.fgbLine.Controls.Add(this.label13);
            this.fgbLine.Controls.Add(this.label14);
            this.fgbLine.Controls.Add(this.label12);
            this.fgbLine.Controls.Add(this.label11);
            this.fgbLine.Controls.Add(this.fnudX1);
            this.fgbLine.Controls.Add(this.label7);
            this.fgbLine.Controls.Add(this.fnudY1);
            this.fgbLine.Controls.Add(this.label5);
            this.fgbLine.Controls.Add(this.button3);
            this.fgbLine.Controls.Add(this.label4);
            this.fgbLine.Controls.Add(this.fnudY2);
            this.fgbLine.Controls.Add(this.fnudX2);
            this.fgbLine.Location = new System.Drawing.Point(134, 217);
            this.fgbLine.Name = "fgbLine";
            this.fgbLine.Size = new System.Drawing.Size(264, 271);
            this.fgbLine.TabIndex = 32;
            this.fgbLine.TabStop = false;
            this.fgbLine.Text = "Параметры отрезка";
            // 
            // fgbHyperbole
            // 
            this.fgbHyperbole.Controls.Add(this.fnudA);
            this.fgbHyperbole.Controls.Add(this.fnudB);
            this.fgbHyperbole.Controls.Add(this.button1);
            this.fgbHyperbole.Controls.Add(this.label9);
            this.fgbHyperbole.Controls.Add(this.label10);
            this.fgbHyperbole.Location = new System.Drawing.Point(134, 53);
            this.fgbHyperbole.Name = "fgbHyperbole";
            this.fgbHyperbole.Size = new System.Drawing.Size(263, 164);
            this.fgbHyperbole.TabIndex = 33;
            this.fgbHyperbole.TabStop = false;
            this.fgbHyperbole.Text = "Параметры гиперболы";
            // 
            // fgbCircle
            // 
            this.fgbCircle.Controls.Add(this.label21);
            this.fgbCircle.Controls.Add(this.fnudMinY);
            this.fgbCircle.Controls.Add(this.label18);
            this.fgbCircle.Controls.Add(this.fnudMaxY);
            this.fgbCircle.Controls.Add(this.label20);
            this.fgbCircle.Controls.Add(this.fbEnterCircle);
            this.fgbCircle.Controls.Add(this.label17);
            this.fgbCircle.Controls.Add(this.label16);
            this.fgbCircle.Controls.Add(this.label19);
            this.fgbCircle.Controls.Add(this.fnudR);
            this.fgbCircle.Controls.Add(this.label6);
            this.fgbCircle.Controls.Add(this.fnudXo);
            this.fgbCircle.Controls.Add(this.label15);
            this.fgbCircle.Controls.Add(this.fnudYo);
            this.fgbCircle.Location = new System.Drawing.Point(12, 494);
            this.fgbCircle.Name = "fgbCircle";
            this.fgbCircle.Size = new System.Drawing.Size(385, 257);
            this.fgbCircle.TabIndex = 45;
            this.fgbCircle.TabStop = false;
            this.fgbCircle.Text = "Параметры окружности";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(331, 18);
            this.label17.TabIndex = 43;
            this.label17.Text = "нажимая мышкой на графике (расчет радиуса";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(193, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "R:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(344, 18);
            this.label19.TabIndex = 42;
            this.label19.Text = "Задавать параметры окружности также можно,";
            // 
            // fnudR
            // 
            this.fnudR.DecimalPlaces = 3;
            this.fnudR.Location = new System.Drawing.Point(196, 100);
            this.fnudR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudR.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudR.Name = "fnudR";
            this.fnudR.Size = new System.Drawing.Size(72, 24);
            this.fnudR.TabIndex = 40;
            this.fnudR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Yо:";
            // 
            // fnudXo
            // 
            this.fnudXo.DecimalPlaces = 3;
            this.fnudXo.Location = new System.Drawing.Point(22, 100);
            this.fnudXo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudXo.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudXo.Name = "fnudXo";
            this.fnudXo.Size = new System.Drawing.Size(72, 24);
            this.fnudXo.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 18);
            this.label15.TabIndex = 38;
            this.label15.Text = "Xо:";
            // 
            // fnudYo
            // 
            this.fnudYo.DecimalPlaces = 3;
            this.fnudYo.Location = new System.Drawing.Point(109, 100);
            this.fnudYo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudYo.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudYo.Name = "fnudYo";
            this.fnudYo.Size = new System.Drawing.Size(72, 24);
            this.fnudYo.TabIndex = 37;
            // 
            // fcbMain
            // 
            this.fcbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fcbMain.Items.AddRange(new object[] {
            "Гипербола",
            "Окружность"});
            this.fcbMain.Location = new System.Drawing.Point(6, 49);
            this.fcbMain.Name = "fcbMain";
            this.fcbMain.Size = new System.Drawing.Size(109, 26);
            this.fcbMain.TabIndex = 34;
            this.fcbMain.SelectedIndexChanged += new System.EventHandler(this.fcbMain_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fnudXmin);
            this.groupBox4.Controls.Add(this.fcbMain);
            this.groupBox4.Controls.Add(this.fnudH);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.fnudXmax);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(7, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 278);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Основные параметры";
            // 
            // fbEnterCircle
            // 
            this.fbEnterCircle.Location = new System.Drawing.Point(21, 198);
            this.fbEnterCircle.Name = "fbEnterCircle";
            this.fbEnterCircle.Size = new System.Drawing.Size(332, 53);
            this.fbEnterCircle.TabIndex = 45;
            this.fbEnterCircle.Text = "Задать параметры окружности";
            this.fbEnterCircle.UseVisualStyleBackColor = true;
            this.fbEnterCircle.Click += new System.EventHandler(this.fbEnterCircle_Click);
            // 
            // fnudMinY
            // 
            this.fnudMinY.DecimalPlaces = 3;
            this.fnudMinY.Location = new System.Drawing.Point(25, 155);
            this.fnudMinY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudMinY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudMinY.Name = "fnudMinY";
            this.fnudMinY.Size = new System.Drawing.Size(69, 24);
            this.fnudMinY.TabIndex = 46;
            this.fnudMinY.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 18);
            this.label18.TabIndex = 48;
            this.label18.Text = "YMin:";
            // 
            // fnudMaxY
            // 
            this.fnudMaxY.DecimalPlaces = 3;
            this.fnudMaxY.Location = new System.Drawing.Point(109, 155);
            this.fnudMaxY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fnudMaxY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.fnudMaxY.Name = "fnudMaxY";
            this.fnudMaxY.Size = new System.Drawing.Size(72, 24);
            this.fnudMaxY.TabIndex = 47;
            this.fnudMaxY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(106, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 18);
            this.label20.TabIndex = 49;
            this.label20.Text = "YMax:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(205, 18);
            this.label21.TabIndex = 50;
            this.label21.Text = "происходит по оси абсцисс)";
            // 
            // view
            // 
            this.view.A = 1;
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.view.B = 1;
            this.view.H = 0.001;
            this.view.Location = new System.Drawing.Point(422, 16);
            this.view.Name = "view";
            this.view.Num_points = 1000;
            this.view.OneLengthX = 0.1;
            this.view.OneLengthY = 0.3461792021482516;
            this.view.R = 0;
            this.view.Size = new System.Drawing.Size(549, 735);
            this.view.TabIndex = 0;
            this.view.X1 = double.NaN;
            this.view.X2 = double.NaN;
            this.view.xMax = 2;
            this.view.xMin = 1;
            this.view.Xo = 0;
            this.view.Y1 = double.NaN;
            this.view.Y2 = double.NaN;
            this.view.yMax = 1.7308960107412579;
            this.view.yMin = -1.7308960107412579;
            this.view.Yo = 0;
            this.view.Load += new System.EventHandler(this.view_Load);
            this.view.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(983, 757);
            this.Controls.Add(this.fgbCircle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.fgbHyperbole);
            this.Controls.Add(this.fgbLine);
            this.Controls.Add(this.fgbIntersections);
            this.Controls.Add(this.view);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(700, 792);
            this.Name = "MainForm";
            this.Text = "OpenGL Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.Sized);
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudA)).EndInit();
            this.fgbIntersections.ResumeLayout(false);
            this.fgbLine.ResumeLayout(false);
            this.fgbLine.PerformLayout();
            this.fgbHyperbole.ResumeLayout(false);
            this.fgbHyperbole.PerformLayout();
            this.fgbCircle.ResumeLayout(false);
            this.fgbCircle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudXo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudYo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnudMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudMaxY)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown fnudA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown fnudB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown fnudY2;
        private System.Windows.Forms.NumericUpDown fnudX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown fnudY1;
        private System.Windows.Forms.NumericUpDown fnudX1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox fgbIntersections;
        private System.Windows.Forms.GroupBox fgbLine;
        private System.Windows.Forms.GroupBox fgbHyperbole;
        private System.Windows.Forms.ComboBox fcbMain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown fnudXo;
        private System.Windows.Forms.NumericUpDown fnudYo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown fnudR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox fgbCircle;
        private System.Windows.Forms.Button fbEnterCircle;
        private System.Windows.Forms.NumericUpDown fnudMinY;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown fnudMaxY;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

