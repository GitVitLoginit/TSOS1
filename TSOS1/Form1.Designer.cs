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
            this.cbSettingsMode1 = new System.Windows.Forms.ComboBox();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericPhaze = new System.Windows.Forms.NumericUpDown();
            this.numericFreqiency = new System.Windows.Forms.NumericUpDown();
            this.numericAmplitude = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreqiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1056, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSettingsMode1
            // 
            this.cbSettingsMode1.FormattingEnabled = true;
            this.cbSettingsMode1.Location = new System.Drawing.Point(811, 12);
            this.cbSettingsMode1.Name = "cbSettingsMode1";
            this.cbSettingsMode1.Size = new System.Drawing.Size(344, 24);
            this.cbSettingsMode1.TabIndex = 1;
            // 
            // trackBar7
            // 
            this.trackBar7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar7.Location = new System.Drawing.Point(811, 360);
            this.trackBar7.Maximum = 1000;
            this.trackBar7.Minimum = 10;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(104, 56);
            this.trackBar7.TabIndex = 10;
            this.trackBar7.Value = 10;
            this.trackBar7.ValueChanged += new System.EventHandler(this.trackBar7_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(808, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(992, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "0";
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar4.Location = new System.Drawing.Point(995, 145);
            this.trackBar4.Maximum = 1000;
            this.trackBar4.Minimum = 10;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 56);
            this.trackBar4.TabIndex = 18;
            this.trackBar4.Value = 10;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "0";
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar5.Location = new System.Drawing.Point(811, 245);
            this.trackBar5.Maximum = 1000;
            this.trackBar5.Minimum = 10;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 56);
            this.trackBar5.TabIndex = 20;
            this.trackBar5.Value = 10;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar5_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(992, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "0";
            // 
            // trackBar6
            // 
            this.trackBar6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar6.Location = new System.Drawing.Point(995, 245);
            this.trackBar6.Maximum = 1000;
            this.trackBar6.Minimum = 10;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 56);
            this.trackBar6.TabIndex = 22;
            this.trackBar6.Value = 10;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar6_ValueChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 12);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(750, 495);
            this.zedGraphControl1.TabIndex = 24;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Phaze";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1024, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Frequency";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(832, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Amplitude";
            // 
            // numericPhaze
            // 
            this.numericPhaze.Location = new System.Drawing.Point(811, 75);
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
            this.numericPhaze.Size = new System.Drawing.Size(120, 22);
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
            this.numericFreqiency.Location = new System.Drawing.Point(1010, 75);
            this.numericFreqiency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericFreqiency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFreqiency.Name = "numericFreqiency";
            this.numericFreqiency.Size = new System.Drawing.Size(120, 22);
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
            this.numericAmplitude.Location = new System.Drawing.Point(811, 145);
            this.numericAmplitude.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericAmplitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmplitude.Name = "numericAmplitude";
            this.numericAmplitude.Size = new System.Drawing.Size(120, 22);
            this.numericAmplitude.TabIndex = 30;
            this.numericAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmplitude.ValueChanged += new System.EventHandler(this.phazeBar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 538);
            this.Controls.Add(this.numericAmplitude);
            this.Controls.Add(this.numericFreqiency);
            this.Controls.Add(this.numericPhaze);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.cbSettingsMode1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreqiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmplitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSettingsMode1;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar6;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericPhaze;
        private System.Windows.Forms.NumericUpDown numericFreqiency;
        private System.Windows.Forms.NumericUpDown numericAmplitude;
    }
}

