namespace Ant_Algorithm_lab3
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.page = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxParam = new System.Windows.Forms.GroupBox();
            this.textBoxGen = new System.Windows.Forms.TextBox();
            this.textBoxInd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMut = new System.Windows.Forms.TextBox();
            this.textBoxCross = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelFinalTour = new System.Windows.Forms.Label();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.page.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.groupBoxParam.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // page
            // 
            this.page.Controls.Add(this.tabPage1);
            this.page.Controls.Add(this.tabPage2);
            this.page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page.Location = new System.Drawing.Point(0, 0);
            this.page.Name = "page";
            this.page.RightToLeftLayout = true;
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(833, 446);
            this.page.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.chart);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBoxData);
            this.tabPage1.Controls.Add(this.groupBoxParam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сравнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(305, 27);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(512, 370);
            this.chart.TabIndex = 11;
            this.chart.Text = "chart2";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(93, 380);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 380);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Графики";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBoxD);
            this.groupBoxData.Controls.Add(this.textBoxC);
            this.groupBoxData.Controls.Add(this.label7);
            this.groupBoxData.Controls.Add(this.label6);
            this.groupBoxData.Location = new System.Drawing.Point(12, 235);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(287, 139);
            this.groupBoxData.TabIndex = 6;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Исходные данные";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(144, 61);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(123, 20);
            this.textBoxD.TabIndex = 3;
            this.textBoxD.Text = "100";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(144, 29);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(123, 20);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.Text = "40";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Макс. дистанция = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Количество городов = ";
            // 
            // groupBoxParam
            // 
            this.groupBoxParam.Controls.Add(this.textBoxGen);
            this.groupBoxParam.Controls.Add(this.textBoxInd);
            this.groupBoxParam.Controls.Add(this.label8);
            this.groupBoxParam.Controls.Add(this.textBoxMut);
            this.groupBoxParam.Controls.Add(this.textBoxCross);
            this.groupBoxParam.Controls.Add(this.label2);
            this.groupBoxParam.Controls.Add(this.label5);
            this.groupBoxParam.Controls.Add(this.label1);
            this.groupBoxParam.Location = new System.Drawing.Point(12, 16);
            this.groupBoxParam.Name = "groupBoxParam";
            this.groupBoxParam.Size = new System.Drawing.Size(287, 213);
            this.groupBoxParam.TabIndex = 5;
            this.groupBoxParam.TabStop = false;
            this.groupBoxParam.Text = "Параметры";
            // 
            // textBoxGen
            // 
            this.textBoxGen.Location = new System.Drawing.Point(144, 142);
            this.textBoxGen.Name = "textBoxGen";
            this.textBoxGen.Size = new System.Drawing.Size(123, 20);
            this.textBoxGen.TabIndex = 2;
            this.textBoxGen.Text = "1000";
            // 
            // textBoxInd
            // 
            this.textBoxInd.Location = new System.Drawing.Point(144, 105);
            this.textBoxInd.Name = "textBoxInd";
            this.textBoxInd.Size = new System.Drawing.Size(123, 20);
            this.textBoxInd.TabIndex = 2;
            this.textBoxInd.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Макс. число поколений = ";
            // 
            // textBoxMut
            // 
            this.textBoxMut.Location = new System.Drawing.Point(144, 63);
            this.textBoxMut.Name = "textBoxMut";
            this.textBoxMut.Size = new System.Drawing.Size(123, 20);
            this.textBoxMut.TabIndex = 3;
            this.textBoxMut.Text = "0,2";
            // 
            // textBoxCross
            // 
            this.textBoxCross.Location = new System.Drawing.Point(144, 31);
            this.textBoxCross.Name = "textBoxCross";
            this.textBoxCross.Size = new System.Drawing.Size(123, 20);
            this.textBoxCross.TabIndex = 2;
            this.textBoxCross.Text = "0,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вер-ть мутации = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Размер популяции = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вер-ть скрещивания =  ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelFinalTour);
            this.tabPage2.Controls.Add(this.chartGraph);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.listBoxLog);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Решение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelFinalTour
            // 
            this.labelFinalTour.AutoSize = true;
            this.labelFinalTour.Location = new System.Drawing.Point(458, 22);
            this.labelFinalTour.Name = "labelFinalTour";
            this.labelFinalTour.Size = new System.Drawing.Size(0, 13);
            this.labelFinalTour.TabIndex = 12;
            // 
            // chartGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea2);
            this.chartGraph.Location = new System.Drawing.Point(321, 38);
            this.chartGraph.Name = "chartGraph";
            this.chartGraph.Size = new System.Drawing.Size(465, 376);
            this.chartGraph.TabIndex = 11;
            this.chartGraph.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Алгоритм";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 9;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(19, 38);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(296, 368);
            this.listBoxLog.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Решение задачи:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 446);
            this.Controls.Add(this.page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Генетический алгоритм (задача коммивояжера)";
            this.page.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxParam.ResumeLayout(false);
            this.groupBoxParam.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl page;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TextBox textBoxGen;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxInd;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxParam;
        private System.Windows.Forms.TextBox textBoxMut;
        private System.Windows.Forms.TextBox textBoxCross;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label labelFinalTour;
        private System.Windows.Forms.Button button1;
    }
}

