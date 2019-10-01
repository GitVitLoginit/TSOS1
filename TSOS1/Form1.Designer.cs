namespace TSOS1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericPhaze = new System.Windows.Forms.NumericUpDown();
            this.numericFreqiency = new System.Windows.Forms.NumericUpDown();
            this.numericAmplitude = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNoize = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxSignals = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondFrequency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThirdFrequency = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.FourthFrequency = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Amplitude4 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Amplitude3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Amplitude2 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFrequency = new System.Windows.Forms.RadioButton();
            this.radioButtonAmplitude = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreqiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude2)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(-10, 4);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1221, 427);
            this.zedGraphControl1.TabIndex = 24;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 467);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Phaze";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 467);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Frequency";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 523);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Amplitude";
            // 
            // numericPhaze
            // 
            this.numericPhaze.Location = new System.Drawing.Point(458, 483);
            this.numericPhaze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericPhaze.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPhaze.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPhaze.Name = "numericPhaze";
            this.numericPhaze.Size = new System.Drawing.Size(90, 20);
            this.numericPhaze.TabIndex = 28;
            this.numericPhaze.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPhaze.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // numericFreqiency
            // 
            this.numericFreqiency.Location = new System.Drawing.Point(608, 483);
            this.numericFreqiency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericFreqiency.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericFreqiency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFreqiency.Name = "numericFreqiency";
            this.numericFreqiency.Size = new System.Drawing.Size(90, 20);
            this.numericFreqiency.TabIndex = 29;
            this.numericFreqiency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFreqiency.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // numericAmplitude
            // 
            this.numericAmplitude.Location = new System.Drawing.Point(458, 540);
            this.numericAmplitude.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericAmplitude.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericAmplitude.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericAmplitude.Name = "numericAmplitude";
            this.numericAmplitude.Size = new System.Drawing.Size(90, 20);
            this.numericAmplitude.TabIndex = 30;
            this.numericAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmplitude.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // checkBoxNoize
            // 
            this.checkBoxNoize.AutoSize = true;
            this.checkBoxNoize.Location = new System.Drawing.Point(458, 584);
            this.checkBoxNoize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxNoize.Name = "checkBoxNoize";
            this.checkBoxNoize.Size = new System.Drawing.Size(62, 17);
            this.checkBoxNoize.TabIndex = 31;
            this.checkBoxNoize.Text = "Noize ?";
            this.checkBoxNoize.UseVisualStyleBackColor = true;
            this.checkBoxNoize.CheckedChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(396, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 37);
            this.button2.TabIndex = 32;
            this.button2.Text = "Play sound";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxSignals
            // 
            this.comboBoxSignals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignals.FormattingEnabled = true;
            this.comboBoxSignals.Items.AddRange(new object[] {
            "Sin",
            "Rect",
            "Triangle",
            "Saw",
            "SinSaw",
            "SinRect",
            "SinTriangle",
            "SawRect",
            "SinRectSaw",
            "RectTriangleSaw",
            "SinRectTriangleSaw"});
            this.comboBoxSignals.Location = new System.Drawing.Point(608, 540);
            this.comboBoxSignals.Name = "comboBoxSignals";
            this.comboBoxSignals.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSignals.TabIndex = 33;
            this.comboBoxSignals.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignals_SelectedIndexChanged);
            this.comboBoxSignals.SelectedValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Stop sound";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1009, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "PoliSygnals settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecondFrequency
            // 
            this.SecondFrequency.Location = new System.Drawing.Point(953, 489);
            this.SecondFrequency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecondFrequency.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SecondFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecondFrequency.Name = "SecondFrequency";
            this.SecondFrequency.Size = new System.Drawing.Size(90, 20);
            this.SecondFrequency.TabIndex = 40;
            this.SecondFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecondFrequency.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 474);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Frequency 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(965, 523);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Frequency 3";
            // 
            // ThirdFrequency
            // 
            this.ThirdFrequency.Location = new System.Drawing.Point(953, 540);
            this.ThirdFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.ThirdFrequency.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ThirdFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThirdFrequency.Name = "ThirdFrequency";
            this.ThirdFrequency.Size = new System.Drawing.Size(90, 20);
            this.ThirdFrequency.TabIndex = 42;
            this.ThirdFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThirdFrequency.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(965, 572);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Frequency 4";
            // 
            // FourthFrequency
            // 
            this.FourthFrequency.Location = new System.Drawing.Point(953, 587);
            this.FourthFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.FourthFrequency.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.FourthFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FourthFrequency.Name = "FourthFrequency";
            this.FourthFrequency.Size = new System.Drawing.Size(90, 20);
            this.FourthFrequency.TabIndex = 44;
            this.FourthFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FourthFrequency.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1085, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Amplitude 4";
            // 
            // Amplitude4
            // 
            this.Amplitude4.Location = new System.Drawing.Point(1073, 587);
            this.Amplitude4.Margin = new System.Windows.Forms.Padding(2);
            this.Amplitude4.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.Amplitude4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amplitude4.Name = "Amplitude4";
            this.Amplitude4.Size = new System.Drawing.Size(90, 20);
            this.Amplitude4.TabIndex = 50;
            this.Amplitude4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amplitude4.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1085, 523);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Amplitude 3";
            // 
            // Amplitude3
            // 
            this.Amplitude3.Location = new System.Drawing.Point(1073, 541);
            this.Amplitude3.Margin = new System.Windows.Forms.Padding(2);
            this.Amplitude3.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.Amplitude3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amplitude3.Name = "Amplitude3";
            this.Amplitude3.Size = new System.Drawing.Size(90, 20);
            this.Amplitude3.TabIndex = 48;
            this.Amplitude3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amplitude3.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1085, 474);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Amplitude 2";
            // 
            // Amplitude2
            // 
            this.Amplitude2.Location = new System.Drawing.Point(1073, 489);
            this.Amplitude2.Margin = new System.Windows.Forms.Padding(2);
            this.Amplitude2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.Amplitude2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amplitude2.Name = "Amplitude2";
            this.Amplitude2.Size = new System.Drawing.Size(90, 20);
            this.Amplitude2.TabIndex = 46;
            this.Amplitude2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amplitude2.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // radioButtonFrequency
            // 
            this.radioButtonFrequency.AutoSize = true;
            this.radioButtonFrequency.Location = new System.Drawing.Point(953, 621);
            this.radioButtonFrequency.Name = "radioButtonFrequency";
            this.radioButtonFrequency.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFrequency.TabIndex = 52;
            this.radioButtonFrequency.TabStop = true;
            this.radioButtonFrequency.Text = "Frequency";
            this.radioButtonFrequency.UseVisualStyleBackColor = true;
            this.radioButtonFrequency.CheckedChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // radioButtonAmplitude
            // 
            this.radioButtonAmplitude.AutoSize = true;
            this.radioButtonAmplitude.Location = new System.Drawing.Point(1073, 621);
            this.radioButtonAmplitude.Name = "radioButtonAmplitude";
            this.radioButtonAmplitude.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAmplitude.TabIndex = 53;
            this.radioButtonAmplitude.TabStop = true;
            this.radioButtonAmplitude.Text = "Amplitude";
            this.radioButtonAmplitude.UseVisualStyleBackColor = true;
            this.radioButtonAmplitude.CheckedChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 650);
            this.Controls.Add(this.radioButtonAmplitude);
            this.Controls.Add(this.radioButtonFrequency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Amplitude4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Amplitude3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amplitude2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FourthFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThirdFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondFrequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxSignals);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxNoize);
            this.Controls.Add(this.numericAmplitude);
            this.Controls.Add(this.numericFreqiency);
            this.Controls.Add(this.numericPhaze);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zedGraphControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPhaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreqiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericPhaze;
        private System.Windows.Forms.NumericUpDown numericFreqiency;
        private System.Windows.Forms.NumericUpDown numericAmplitude;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxSignals;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxNoize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SecondFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThirdFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FourthFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Amplitude4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Amplitude3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Amplitude2;
        private System.Windows.Forms.RadioButton radioButtonFrequency;
        private System.Windows.Forms.RadioButton radioButtonAmplitude;
    }
}

