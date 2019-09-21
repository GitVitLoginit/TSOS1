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
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericPhaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreqiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
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
            "Saw"});
            this.comboBoxSignals.Location = new System.Drawing.Point(608, 540);
            this.comboBoxSignals.Name = "comboBoxSignals";
            this.comboBoxSignals.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSignals.TabIndex = 33;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 682);
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
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPhaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreqiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmplitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

