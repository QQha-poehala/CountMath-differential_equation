namespace CountMathWf6
{
    partial class Graphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butEiler = new System.Windows.Forms.Button();
            this.butFixEiler = new System.Windows.Forms.Button();
            this.butRKM = new System.Windows.Forms.Button();
            this.butAdamson = new System.Windows.Forms.Button();
            this.butClearSolve = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.tbx0 = new System.Windows.Forms.TextBox();
            this.tby0 = new System.Windows.Forms.TextBox();
            this.tbxn = new System.Windows.Forms.TextBox();
            this.tbh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(592, 24);
            this.chartGraph.Name = "chartGraph";
            series1.BorderWidth = 6;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Точное реш.";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Эйлер";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Yellow;
            series3.Legend = "Legend1";
            series3.Name = "Исп. Эйлер";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Cyan;
            series4.Legend = "Legend1";
            series4.Name = "Р-К-М";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Navy;
            series5.Legend = "Legend1";
            series5.Name = "Адамсон 2";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Series.Add(series2);
            this.chartGraph.Series.Add(series3);
            this.chartGraph.Series.Add(series4);
            this.chartGraph.Series.Add(series5);
            this.chartGraph.Size = new System.Drawing.Size(810, 555);
            this.chartGraph.TabIndex = 1;
            this.chartGraph.Text = "chart2";
            // 
            // butEiler
            // 
            this.butEiler.Location = new System.Drawing.Point(54, 140);
            this.butEiler.Name = "butEiler";
            this.butEiler.Size = new System.Drawing.Size(91, 50);
            this.butEiler.TabIndex = 2;
            this.butEiler.Text = "Эйлер";
            this.butEiler.UseVisualStyleBackColor = true;
            this.butEiler.Click += new System.EventHandler(this.butEiler_Click);
            // 
            // butFixEiler
            // 
            this.butFixEiler.Location = new System.Drawing.Point(161, 140);
            this.butFixEiler.Name = "butFixEiler";
            this.butFixEiler.Size = new System.Drawing.Size(91, 54);
            this.butFixEiler.TabIndex = 3;
            this.butFixEiler.Text = "Испр. Эйлер";
            this.butFixEiler.UseVisualStyleBackColor = true;
            this.butFixEiler.Click += new System.EventHandler(this.butFixEiler_Click);
            // 
            // butRKM
            // 
            this.butRKM.Location = new System.Drawing.Point(272, 140);
            this.butRKM.Name = "butRKM";
            this.butRKM.Size = new System.Drawing.Size(91, 54);
            this.butRKM.TabIndex = 4;
            this.butRKM.Text = "Р-К-М";
            this.butRKM.UseVisualStyleBackColor = true;
            this.butRKM.Click += new System.EventHandler(this.butRKM_Click);
            // 
            // butAdamson
            // 
            this.butAdamson.Location = new System.Drawing.Point(390, 140);
            this.butAdamson.Name = "butAdamson";
            this.butAdamson.Size = new System.Drawing.Size(91, 50);
            this.butAdamson.TabIndex = 5;
            this.butAdamson.Text = "Адамсон 2";
            this.butAdamson.UseVisualStyleBackColor = true;
            this.butAdamson.Click += new System.EventHandler(this.butAdamson_Click);
            // 
            // butClearSolve
            // 
            this.butClearSolve.Location = new System.Drawing.Point(193, 227);
            this.butClearSolve.Name = "butClearSolve";
            this.butClearSolve.Size = new System.Drawing.Size(123, 67);
            this.butClearSolve.TabIndex = 6;
            this.butClearSolve.Text = "Точное решение";
            this.butClearSolve.UseVisualStyleBackColor = true;
            this.butClearSolve.Click += new System.EventHandler(this.butClearSolve_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(491, 549);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(84, 30);
            this.butClear.TabIndex = 7;
            this.butClear.Text = "Очистка";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // tbx0
            // 
            this.tbx0.Location = new System.Drawing.Point(54, 64);
            this.tbx0.Name = "tbx0";
            this.tbx0.Size = new System.Drawing.Size(44, 22);
            this.tbx0.TabIndex = 8;
            this.tbx0.Text = "0";
            // 
            // tby0
            // 
            this.tby0.Location = new System.Drawing.Point(139, 64);
            this.tby0.Name = "tby0";
            this.tby0.Size = new System.Drawing.Size(44, 22);
            this.tby0.TabIndex = 9;
            this.tby0.Text = "0";
            // 
            // tbxn
            // 
            this.tbxn.Location = new System.Drawing.Point(230, 64);
            this.tbxn.Name = "tbxn";
            this.tbxn.Size = new System.Drawing.Size(44, 22);
            this.tbxn.TabIndex = 10;
            this.tbxn.Text = "10";
            // 
            // tbh
            // 
            this.tbh.Location = new System.Drawing.Point(319, 64);
            this.tbh.Name = "tbh";
            this.tbh.Size = new System.Drawing.Size(44, 22);
            this.tbh.TabIndex = 11;
            this.tbh.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "xn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "y0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "x0";
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbh);
            this.Controls.Add(this.tbxn);
            this.Controls.Add(this.tby0);
            this.Controls.Add(this.tbx0);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butClearSolve);
            this.Controls.Add(this.butAdamson);
            this.Controls.Add(this.butRKM);
            this.Controls.Add(this.butFixEiler);
            this.Controls.Add(this.butEiler);
            this.Controls.Add(this.chartGraph);
            this.Name = "Graphics";
            this.Text = "Решение ДУ";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Button butEiler;
        private System.Windows.Forms.Button butFixEiler;
        private System.Windows.Forms.Button butRKM;
        private System.Windows.Forms.Button butAdamson;
        private System.Windows.Forms.Button butClearSolve;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.TextBox tbx0;
        private System.Windows.Forms.TextBox tby0;
        private System.Windows.Forms.TextBox tbxn;
        private System.Windows.Forms.TextBox tbh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

