using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ant_Algorithm_lab3
{
    struct Point
    {
        public double x;
        public double y;
    }
    public partial class MainForm : System.Windows.Forms.Form
    {
        private List<Point> graph = new List<Point>();
        private List<Point> compare = new List<Point>();
        private int cities = 0;

        private Graph gr;
        private Logger log;
        private Algorithm alg;

        public MainForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            graph.Clear();
            compare.Clear(); 
            int n = chartGraph.Series.Count;
            for (int i = 0; i < n; i++)
                chartGraph.Series.RemoveAt(0);
            n = chart.Series.Count;
            for (int i = 0; i < n; i++)
                chart.Series.RemoveAt(0);
            listBoxLog.Items.Clear();
            log = new Logger(this);
            if (cities != int.Parse(textBoxC.Text))
            {
                gr = new Graph(int.Parse(textBoxC.Text), int.Parse(textBoxD.Text));
                cities = gr.maxCities;
                //Создание городов
                gr.initGraph();

                //Вычисляем расстояние между городами
                gr.calcDistance();
            }

            alg = new Algorithm(int.Parse(textBoxC.Text), 
                int.Parse(textBoxInd.Text), 
                int.Parse(textBoxGen.Text), gr,
                double.Parse(textBoxCross.Text),
                double.Parse(textBoxMut.Text), log);
            int bestIndex = alg.Evolution();
            labelFinalTour.Text = "длина пути = " + (1/alg.health[bestIndex]).ToString();            
            Point tmp;
            int k;
            for (int i = 0; i < alg.map.maxCities; i++)
            {
                k = alg.population[bestIndex][i];
                tmp.x = Double.Parse(alg.map.cities[k].x.ToString());
                tmp.y = Double.Parse(alg.map.cities[k].y.ToString());
                graph.Add(tmp);
            }
            k = alg.population[bestIndex][0];
            tmp.x = Double.Parse(alg.map.cities[k].x.ToString());
            tmp.y = Double.Parse(alg.map.cities[k].y.ToString());
            graph.Add(tmp);
            chartGraph.Series.Add("solve");
            chartGraph.Series[chartGraph.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartGraph.Series[chartGraph.Series.Count - 1].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            drawChart(graph, chartGraph);

             chart.Series.Add((chart.Series.Count+ 1).ToString() + ". " + "Скрещ. = " + textBoxCross.Text + "; Мут. = " + textBoxMut.Text);          
            chart.Series[chart.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            drawChart(compare, chart);

            MessageBox.Show("Алгоритм выполнен!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graph.Clear();
            compare.Clear();
            int n = chartGraph.Series.Count;
            for (int i = 0; i < n; i++)
                chartGraph.Series.RemoveAt(0);
            listBoxLog.Items.Clear();
            n = chart.Series.Count;
            for (int i = 0; i < n; i++)
                chart.Series.RemoveAt(0);
            listBoxLog.Items.Clear();
            labelFinalTour.Text = "";
            button1.Enabled = false;
        }

        private void drawChart(List<Point> list, System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            int k = chart.Series.Count;
            for (int i = 0; i < list.Count; i++)
            {
                chart.Series[k - 1].Points.AddXY(list[i].x, list[i].y);
            }
        }

        public void showLog(string log)
        {
            listBoxLog.Items.Add(log);
        }

        public void addItemChart(double x, double y)
        {
            Point tmp;
            tmp.x = x+1;
            tmp.y = y;
            compare.Add(tmp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            graph.Clear();
            compare.Clear();
            alg = new Algorithm(int.Parse(textBoxC.Text),
                int.Parse(textBoxInd.Text),
                int.Parse(textBoxGen.Text), gr,
                double.Parse(textBoxCross.Text),
                double.Parse(textBoxMut.Text), log);
            listBoxLog.Items.Add("---Сравнение---");

            int bestIndex = alg.Evolution();
           
            labelFinalTour.Text = "длина пути = " + (1 / alg.health[bestIndex]).ToString();
            int  k;
            Point tmp;
            for (int i = 0; i < alg.map.maxCities; i++)
            {
                k = alg.population[bestIndex][i];
                tmp.x = Double.Parse(alg.map.cities[k].x.ToString());
                tmp.y = Double.Parse(alg.map.cities[k].y.ToString());
                graph.Add(tmp);
            }
            k = alg.population[bestIndex][0];
            tmp.x = Double.Parse(alg.map.cities[k].x.ToString());
            tmp.y = Double.Parse(alg.map.cities[k].y.ToString());
            graph.Add(tmp);
            
            chartGraph.Series.Add(chartGraph.Series.Count.ToString());
            chartGraph.Series[chartGraph.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartGraph.Series[chartGraph.Series.Count - 1].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            drawChart(graph, chartGraph);

            chart.Series.Add((chart.Series.Count + 1).ToString() + ". " + "Скрещ. = " + textBoxCross.Text + "; Мут. = " + textBoxMut.Text);
            // chart.Series.Add((chart.Series.Count + 1).ToString());
            chart.Series[chart.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            drawChart(compare, chart);

            MessageBox.Show("Алгоритм выполнен!");
        }
    }
}
