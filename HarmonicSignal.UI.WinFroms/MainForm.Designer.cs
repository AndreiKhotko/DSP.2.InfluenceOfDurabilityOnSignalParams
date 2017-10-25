namespace HarmonicSignal.UI.WinFroms
{
    partial class MainForm
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
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.cBoxPhase = new System.Windows.Forms.ComboBox();
            this.cBoxN = new System.Windows.Forms.ComboBox();
            this.lblInfoForUser = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblKResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(36, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "ErrorRMSValueA";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "ErrorRMSValueB";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "ErrorAmplitude";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(671, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(788, 278);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Параметры";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(735, 170);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(36, 13);
            this.lblPhase.TabIndex = 9;
            this.lblPhase.Text = "Phase";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(757, 199);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(14, 13);
            this.lblN.TabIndex = 10;
            this.lblN.Text = "N";
            // 
            // cBoxPhase
            // 
            this.cBoxPhase.FormattingEnabled = true;
            this.cBoxPhase.Location = new System.Drawing.Point(777, 167);
            this.cBoxPhase.Name = "cBoxPhase";
            this.cBoxPhase.Size = new System.Drawing.Size(120, 21);
            this.cBoxPhase.TabIndex = 11;
            // 
            // cBoxN
            // 
            this.cBoxN.FormattingEnabled = true;
            this.cBoxN.Location = new System.Drawing.Point(777, 196);
            this.cBoxN.Name = "cBoxN";
            this.cBoxN.Size = new System.Drawing.Size(120, 21);
            this.cBoxN.TabIndex = 12;
            this.cBoxN.SelectedIndexChanged += new System.EventHandler(this.cBoxN_SelectedIndexChanged);
            // 
            // lblInfoForUser
            // 
            this.lblInfoForUser.AutoSize = true;
            this.lblInfoForUser.Location = new System.Drawing.Point(782, 184);
            this.lblInfoForUser.Name = "lblInfoForUser";
            this.lblInfoForUser.Size = new System.Drawing.Size(0, 13);
            this.lblInfoForUser.TabIndex = 14;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(785, 235);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(79, 13);
            this.lblK.TabIndex = 15;
            this.lblK.Text = "K = 3 * N / 4 =";
            // 
            // lblKResult
            // 
            this.lblKResult.AutoSize = true;
            this.lblKResult.Location = new System.Drawing.Point(878, 235);
            this.lblKResult.Name = "lblKResult";
            this.lblKResult.Size = new System.Drawing.Size(0, 13);
            this.lblKResult.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HarmonicSignal.UI.WinFroms.Properties.Resources.Function;
            this.pictureBox1.Location = new System.Drawing.Point(749, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Гармонический сигнал:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKResult);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblInfoForUser);
            this.Controls.Add(this.cBoxN);
            this.Controls.Add(this.cBoxPhase);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.chart);
            this.Name = "MainForm";
            this.Text = "ЦОС: Лабораторная работа 2 - Влияние длительности сигнала на параметры сигнала";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ComboBox cBoxPhase;
        private System.Windows.Forms.ComboBox cBoxN;
        private System.Windows.Forms.Label lblInfoForUser;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblKResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

