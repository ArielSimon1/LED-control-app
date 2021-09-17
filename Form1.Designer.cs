namespace Device_LED_Control
{
    partial class Mainwindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwindow));
            this.led1_freq = new System.Windows.Forms.NumericUpDown();
            this.led1_label = new System.Windows.Forms.Label();
            this.led1_statusbut = new System.Windows.Forms.Button();
            this.led2_freq = new System.Windows.Forms.NumericUpDown();
            this.led2_label = new System.Windows.Forms.Label();
            this.led2_statusbut = new System.Windows.Forms.Button();
            this.led3_freq = new System.Windows.Forms.NumericUpDown();
            this.led3_label = new System.Windows.Forms.Label();
            this.led3_statusbut = new System.Windows.Forms.Button();
            this.led4_freq = new System.Windows.Forms.NumericUpDown();
            this.led4_label = new System.Windows.Forms.Label();
            this.led5_freq = new System.Windows.Forms.NumericUpDown();
            this.led4_statusbut = new System.Windows.Forms.Button();
            this.led6_freq = new System.Windows.Forms.NumericUpDown();
            this.led5_label = new System.Windows.Forms.Label();
            this.led5_statusbut = new System.Windows.Forms.Button();
            this.led6_label = new System.Windows.Forms.Label();
            this.led6_statusbut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.port_comboBox = new System.Windows.Forms.ComboBox();
            this.port_label = new System.Windows.Forms.Label();
            this.port_but = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.turnAllON = new System.Windows.Forms.Button();
            this.turnAllOFF = new System.Windows.Forms.Button();
            this.Cycle = new System.Windows.Forms.Label();
            this.Hz_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Hz = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.Label();
            this.Break_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Cycles = new System.Windows.Forms.Label();
            this.CyclesUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlinkTime = new System.Windows.Forms.Label();
            this.Time_UpDown = new System.Windows.Forms.NumericUpDown();
            this.CycleStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.led1_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led4_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led5_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led6_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hz_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Break_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // led1_freq
            // 
            this.led1_freq.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.led1_freq.Location = new System.Drawing.Point(83, 71);
            this.led1_freq.Margin = new System.Windows.Forms.Padding(2);
            this.led1_freq.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.led1_freq.Name = "led1_freq";
            this.led1_freq.Size = new System.Drawing.Size(90, 20);
            this.led1_freq.TabIndex = 1;
            this.led1_freq.ValueChanged += new System.EventHandler(this.led1_freq_ValueChanged);
            // 
            // led1_label
            // 
            this.led1_label.AutoSize = true;
            this.led1_label.Location = new System.Drawing.Point(22, 54);
            this.led1_label.Margin = new System.Windows.Forms.Padding(0);
            this.led1_label.Name = "led1_label";
            this.led1_label.Size = new System.Drawing.Size(40, 13);
            this.led1_label.TabIndex = 0;
            this.led1_label.Text = "LED 1:";
            // 
            // led1_statusbut
            // 
            this.led1_statusbut.ForeColor = System.Drawing.Color.Black;
            this.led1_statusbut.Location = new System.Drawing.Point(22, 71);
            this.led1_statusbut.Margin = new System.Windows.Forms.Padding(2);
            this.led1_statusbut.Name = "led1_statusbut";
            this.led1_statusbut.Size = new System.Drawing.Size(56, 19);
            this.led1_statusbut.TabIndex = 2;
            this.led1_statusbut.Text = "OFF";
            this.led1_statusbut.UseVisualStyleBackColor = true;
            this.led1_statusbut.Click += new System.EventHandler(this.led1statusbut_Click);
            // 
            // led2_freq
            // 
            this.led2_freq.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.led2_freq.Location = new System.Drawing.Point(83, 118);
            this.led2_freq.Margin = new System.Windows.Forms.Padding(2);
            this.led2_freq.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.led2_freq.Name = "led2_freq";
            this.led2_freq.Size = new System.Drawing.Size(90, 20);
            this.led2_freq.TabIndex = 1;
            this.led2_freq.ValueChanged += new System.EventHandler(this.led2_freq_ValueChanged);
            // 
            // led2_label
            // 
            this.led2_label.AutoSize = true;
            this.led2_label.Location = new System.Drawing.Point(22, 101);
            this.led2_label.Margin = new System.Windows.Forms.Padding(0);
            this.led2_label.Name = "led2_label";
            this.led2_label.Size = new System.Drawing.Size(40, 13);
            this.led2_label.TabIndex = 0;
            this.led2_label.Text = "LED 2:";
            // 
            // led2_statusbut
            // 
            this.led2_statusbut.ForeColor = System.Drawing.Color.Black;
            this.led2_statusbut.Location = new System.Drawing.Point(22, 118);
            this.led2_statusbut.Margin = new System.Windows.Forms.Padding(2);
            this.led2_statusbut.Name = "led2_statusbut";
            this.led2_statusbut.Size = new System.Drawing.Size(56, 19);
            this.led2_statusbut.TabIndex = 2;
            this.led2_statusbut.Text = "OFF";
            this.led2_statusbut.UseVisualStyleBackColor = true;
            this.led2_statusbut.Click += new System.EventHandler(this.led2_statusbut_Click);
            // 
            // led3_freq
            // 
            this.led3_freq.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.led3_freq.Location = new System.Drawing.Point(83, 165);
            this.led3_freq.Margin = new System.Windows.Forms.Padding(2);
            this.led3_freq.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.led3_freq.Name = "led3_freq";
            this.led3_freq.Size = new System.Drawing.Size(90, 20);
            this.led3_freq.TabIndex = 1;
            this.led3_freq.ValueChanged += new System.EventHandler(this.led3_freq_ValueChanged);
            // 
            // led3_label
            // 
            this.led3_label.AutoSize = true;
            this.led3_label.Location = new System.Drawing.Point(22, 148);
            this.led3_label.Margin = new System.Windows.Forms.Padding(0);
            this.led3_label.Name = "led3_label";
            this.led3_label.Size = new System.Drawing.Size(40, 13);
            this.led3_label.TabIndex = 0;
            this.led3_label.Text = "LED 3:";
            // 
            // led3_statusbut
            // 
            this.led3_statusbut.ForeColor = System.Drawing.Color.Black;
            this.led3_statusbut.Location = new System.Drawing.Point(22, 165);
            this.led3_statusbut.Margin = new System.Windows.Forms.Padding(2);
            this.led3_statusbut.Name = "led3_statusbut";
            this.led3_statusbut.Size = new System.Drawing.Size(56, 19);
            this.led3_statusbut.TabIndex = 2;
            this.led3_statusbut.Text = "OFF";
            this.led3_statusbut.UseVisualStyleBackColor = true;
            this.led3_statusbut.Click += new System.EventHandler(this.led3_statusbut_Click);
            // 
            // led4_freq
            // 
            this.led4_freq.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.led4_freq.Location = new System.Drawing.Point(83, 212);
            this.led4_freq.Margin = new System.Windows.Forms.Padding(2);
            this.led4_freq.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.led4_freq.Name = "led4_freq";
            this.led4_freq.Size = new System.Drawing.Size(90, 20);
            this.led4_freq.TabIndex = 1;
            this.led4_freq.ValueChanged += new System.EventHandler(this.led4_freq_ValueChanged);
            // 
            // led4_label
            // 
            this.led4_label.AutoSize = true;
            this.led4_label.Location = new System.Drawing.Point(22, 195);
            this.led4_label.Margin = new System.Windows.Forms.Padding(0);
            this.led4_label.Name = "led4_label";
            this.led4_label.Size = new System.Drawing.Size(40, 13);
            this.led4_label.TabIndex = 0;
            this.led4_label.Text = "LED 4:";
            // 
            // led5_freq
            // 
            this.led5_freq.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.led5_freq.Location = new System.Drawing.Point(83, 259);
            this.led5_freq.Margin = new System.Windows.Forms.Padding(2);
            this.led5_freq.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.led5_freq.Name = "led5_freq";
            this.led5_freq.Size = new System.Drawing.Size(90, 20);
            this.led5_freq.TabIndex = 1;
            this.led5_freq.ValueChanged += new System.EventHandler(this.led5_freq_ValueChanged);
            // 
            // led4_statusbut
            // 
            this.led4_statusbut.ForeColor = System.Drawing.Color.Black;
            this.led4_statusbut.Location = new System.Drawing.Point(22, 212);
            this.led4_statusbut.Margin = new System.Windows.Forms.Padding(2);
            this.led4_statusbut.Name = "led4_statusbut";
            this.led4_statusbut.Size = new System.Drawing.Size(56, 19);
            this.led4_statusbut.TabIndex = 2;
            this.led4_statusbut.Text = "OFF";
            this.led4_statusbut.UseVisualStyleBackColor = true;
            this.led4_statusbut.Click += new System.EventHandler(this.led4_statusbut_Click);
            // 
            // led6_freq
            // 
            this.led6_freq.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.led6_freq.Location = new System.Drawing.Point(83, 306);
            this.led6_freq.Margin = new System.Windows.Forms.Padding(2);
            this.led6_freq.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.led6_freq.Name = "led6_freq";
            this.led6_freq.Size = new System.Drawing.Size(90, 20);
            this.led6_freq.TabIndex = 1;
            this.led6_freq.ValueChanged += new System.EventHandler(this.led6_freq_ValueChanged);
            // 
            // led5_label
            // 
            this.led5_label.AutoSize = true;
            this.led5_label.Location = new System.Drawing.Point(22, 242);
            this.led5_label.Margin = new System.Windows.Forms.Padding(0);
            this.led5_label.Name = "led5_label";
            this.led5_label.Size = new System.Drawing.Size(40, 13);
            this.led5_label.TabIndex = 0;
            this.led5_label.Text = "LED 5:";
            // 
            // led5_statusbut
            // 
            this.led5_statusbut.ForeColor = System.Drawing.Color.Black;
            this.led5_statusbut.Location = new System.Drawing.Point(22, 259);
            this.led5_statusbut.Margin = new System.Windows.Forms.Padding(2);
            this.led5_statusbut.Name = "led5_statusbut";
            this.led5_statusbut.Size = new System.Drawing.Size(56, 19);
            this.led5_statusbut.TabIndex = 2;
            this.led5_statusbut.Text = "OFF";
            this.led5_statusbut.UseVisualStyleBackColor = true;
            this.led5_statusbut.Click += new System.EventHandler(this.led5_statusbut_Click);
            // 
            // led6_label
            // 
            this.led6_label.AutoSize = true;
            this.led6_label.Location = new System.Drawing.Point(22, 289);
            this.led6_label.Margin = new System.Windows.Forms.Padding(0);
            this.led6_label.Name = "led6_label";
            this.led6_label.Size = new System.Drawing.Size(40, 13);
            this.led6_label.TabIndex = 0;
            this.led6_label.Text = "LED 6:";
            // 
            // led6_statusbut
            // 
            this.led6_statusbut.ForeColor = System.Drawing.Color.Black;
            this.led6_statusbut.Location = new System.Drawing.Point(22, 306);
            this.led6_statusbut.Margin = new System.Windows.Forms.Padding(2);
            this.led6_statusbut.Name = "led6_statusbut";
            this.led6_statusbut.Size = new System.Drawing.Size(56, 19);
            this.led6_statusbut.TabIndex = 2;
            this.led6_statusbut.Text = "OFF";
            this.led6_statusbut.UseVisualStyleBackColor = true;
            this.led6_statusbut.Click += new System.EventHandler(this.led6_statusbut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ms";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // port_comboBox
            // 
            this.port_comboBox.FormattingEnabled = true;
            this.port_comboBox.Location = new System.Drawing.Point(83, 12);
            this.port_comboBox.Name = "port_comboBox";
            this.port_comboBox.Size = new System.Drawing.Size(73, 21);
            this.port_comboBox.TabIndex = 4;
            this.port_comboBox.SelectionChangeCommitted += new System.EventHandler(this.port_comboBox_SelectionChangeCommitted);
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_label.Location = new System.Drawing.Point(22, 13);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(50, 17);
            this.port_label.TabIndex = 5;
            this.port_label.Text = "P o r t:";
            this.port_label.Click += new System.EventHandler(this.port_label_Click);
            // 
            // port_but
            // 
            this.port_but.BackColor = System.Drawing.Color.Red;
            this.port_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.port_but.Location = new System.Drawing.Point(162, 13);
            this.port_but.Margin = new System.Windows.Forms.Padding(0);
            this.port_but.Name = "port_but";
            this.port_but.Size = new System.Drawing.Size(28, 20);
            this.port_but.TabIndex = 6;
            this.port_but.UseVisualStyleBackColor = false;
            this.port_but.Click += new System.EventHandler(this.port_but_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // turnAllON
            // 
            this.turnAllON.Location = new System.Drawing.Point(25, 341);
            this.turnAllON.Name = "turnAllON";
            this.turnAllON.Size = new System.Drawing.Size(148, 23);
            this.turnAllON.TabIndex = 7;
            this.turnAllON.Text = "Turn all ON";
            this.turnAllON.UseVisualStyleBackColor = true;
            this.turnAllON.Click += new System.EventHandler(this.button1_Click);
            // 
            // turnAllOFF
            // 
            this.turnAllOFF.Location = new System.Drawing.Point(25, 370);
            this.turnAllOFF.Name = "turnAllOFF";
            this.turnAllOFF.Size = new System.Drawing.Size(148, 23);
            this.turnAllOFF.TabIndex = 7;
            this.turnAllOFF.Text = "Turn all OFF";
            this.turnAllOFF.UseVisualStyleBackColor = true;
            this.turnAllOFF.Click += new System.EventHandler(this.turnAllOFF_Click);
            // 
            // Cycle
            // 
            this.Cycle.AutoSize = true;
            this.Cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cycle.Location = new System.Drawing.Point(85, 429);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(113, 16);
            this.Cycle.TabIndex = 20;
            this.Cycle.Text = "Define Led Cycle:";
            // 
            // Hz_UpDown
            // 
            this.Hz_UpDown.Location = new System.Drawing.Point(175, 461);
            this.Hz_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.Hz_UpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Hz_UpDown.Name = "Hz_UpDown";
            this.Hz_UpDown.Size = new System.Drawing.Size(54, 20);
            this.Hz_UpDown.TabIndex = 21;
            this.Hz_UpDown.ValueChanged += new System.EventHandler(this.Hz_UpDown_ValueChanged);
            // 
            // Hz
            // 
            this.Hz.AutoSize = true;
            this.Hz.Location = new System.Drawing.Point(85, 463);
            this.Hz.Name = "Hz";
            this.Hz.Size = new System.Drawing.Size(85, 13);
            this.Hz.TabIndex = 22;
            this.Hz.Text = "Frequency f (Hz)";
            this.Hz.Click += new System.EventHandler(this.label7_Click);
            // 
            // Interval
            // 
            this.Interval.AutoSize = true;
            this.Interval.Location = new System.Drawing.Point(87, 494);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(49, 13);
            this.Interval.TabIndex = 23;
            this.Interval.Text = "Break (s)";
            this.Interval.Click += new System.EventHandler(this.label8_Click);
            // 
            // Break_UpDown
            // 
            this.Break_UpDown.Location = new System.Drawing.Point(175, 492);
            this.Break_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.Break_UpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Break_UpDown.Name = "Break_UpDown";
            this.Break_UpDown.Size = new System.Drawing.Size(54, 20);
            this.Break_UpDown.TabIndex = 24;
            this.Break_UpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Cycles
            // 
            this.Cycles.AutoSize = true;
            this.Cycles.Location = new System.Drawing.Point(258, 494);
            this.Cycles.Name = "Cycles";
            this.Cycles.Size = new System.Drawing.Size(89, 13);
            this.Cycles.TabIndex = 25;
            this.Cycles.Text = "Number of cycles";
            // 
            // CyclesUpDown
            // 
            this.CyclesUpDown.Location = new System.Drawing.Point(352, 492);
            this.CyclesUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.CyclesUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CyclesUpDown.Name = "CyclesUpDown";
            this.CyclesUpDown.Size = new System.Drawing.Size(55, 20);
            this.CyclesUpDown.TabIndex = 26;
            this.CyclesUpDown.ValueChanged += new System.EventHandler(this.CyclesUpDown_ValueChanged);
            // 
            // BlinkTime
            // 
            this.BlinkTime.AutoSize = true;
            this.BlinkTime.Location = new System.Drawing.Point(258, 463);
            this.BlinkTime.Name = "BlinkTime";
            this.BlinkTime.Size = new System.Drawing.Size(44, 13);
            this.BlinkTime.TabIndex = 28;
            this.BlinkTime.Text = "Time (s)";
            this.BlinkTime.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // Time_UpDown
            // 
            this.Time_UpDown.Location = new System.Drawing.Point(352, 461);
            this.Time_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.Time_UpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Time_UpDown.Name = "Time_UpDown";
            this.Time_UpDown.Size = new System.Drawing.Size(55, 20);
            this.Time_UpDown.TabIndex = 27;
            this.Time_UpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // CycleStart
            // 
            this.CycleStart.Location = new System.Drawing.Point(259, 528);
            this.CycleStart.Name = "CycleStart";
            this.CycleStart.Size = new System.Drawing.Size(148, 23);
            this.CycleStart.TabIndex = 29;
            this.CycleStart.Text = "Start Led Cycle";
            this.CycleStart.UseVisualStyleBackColor = true;
            this.CycleStart.Click += new System.EventHandler(this.CycleStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(239, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "(C) Ariel Simon and Shlomi Abuchatzera";
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CycleStart);
            this.Controls.Add(this.BlinkTime);
            this.Controls.Add(this.Time_UpDown);
            this.Controls.Add(this.CyclesUpDown);
            this.Controls.Add(this.Cycles);
            this.Controls.Add(this.Break_UpDown);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.Hz);
            this.Controls.Add(this.Hz_UpDown);
            this.Controls.Add(this.Cycle);
            this.Controls.Add(this.turnAllOFF);
            this.Controls.Add(this.turnAllON);
            this.Controls.Add(this.port_but);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.port_comboBox);
            this.Controls.Add(this.led6_statusbut);
            this.Controls.Add(this.led3_statusbut);
            this.Controls.Add(this.led6_label);
            this.Controls.Add(this.led3_label);
            this.Controls.Add(this.led5_statusbut);
            this.Controls.Add(this.led2_statusbut);
            this.Controls.Add(this.led5_label);
            this.Controls.Add(this.led2_label);
            this.Controls.Add(this.led6_freq);
            this.Controls.Add(this.led3_freq);
            this.Controls.Add(this.led4_statusbut);
            this.Controls.Add(this.led5_freq);
            this.Controls.Add(this.led1_statusbut);
            this.Controls.Add(this.led4_label);
            this.Controls.Add(this.led2_freq);
            this.Controls.Add(this.led4_freq);
            this.Controls.Add(this.led1_label);
            this.Controls.Add(this.led1_freq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mainwindow";
            this.Text = "LED Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainwindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.led1_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led4_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led5_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led6_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hz_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Break_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown led1_freq;
        private System.Windows.Forms.Label led1_label;
        private System.Windows.Forms.Button led1_statusbut;
        private System.Windows.Forms.NumericUpDown led2_freq;
        private System.Windows.Forms.Label led2_label;
        private System.Windows.Forms.Button led2_statusbut;
        private System.Windows.Forms.NumericUpDown led3_freq;
        private System.Windows.Forms.Label led3_label;
        private System.Windows.Forms.Button led3_statusbut;
        private System.Windows.Forms.NumericUpDown led4_freq;
        private System.Windows.Forms.Label led4_label;
        private System.Windows.Forms.NumericUpDown led5_freq;
        private System.Windows.Forms.Button led4_statusbut;
        private System.Windows.Forms.NumericUpDown led6_freq;
        private System.Windows.Forms.Label led5_label;
        private System.Windows.Forms.Button led5_statusbut;
        private System.Windows.Forms.Label led6_label;
        private System.Windows.Forms.Button led6_statusbut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox port_comboBox;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Button port_but;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button turnAllON;
        private System.Windows.Forms.Button turnAllOFF;
        private System.Windows.Forms.Label Cycle;
        private System.Windows.Forms.NumericUpDown Hz_UpDown;
        private System.Windows.Forms.Label Hz;
        private System.Windows.Forms.Label Interval;
        private System.Windows.Forms.NumericUpDown Break_UpDown;
        private System.Windows.Forms.Label Cycles;
        private System.Windows.Forms.NumericUpDown CyclesUpDown;
        private System.Windows.Forms.Label BlinkTime;
        private System.Windows.Forms.NumericUpDown Time_UpDown;
        private System.Windows.Forms.Button CycleStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}
