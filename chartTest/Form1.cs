using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static proj_Sortowanie.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proj_Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonSort_Click(null, null);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDownStart.Value;
            int[] tab = new int[n];
            int[] tmp = new int[n];

            if (checkBox1.Checked)
            {
                tab = new BubbleSort(n, true).arr;
            }
            else if (checkBox2.Checked)
            {
                tab = new BubbleSort(n, false).arr;
            }
            else
            {
                Random r = new Random();
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = r.Next(1, tab.Length);
                }
            }

            chart.ChartAreas.First().AxisX.Title = "Liczba elementow";
            chart.ChartAreas.First().AxisX.CustomLabels.Clear();

            chart.ChartAreas.First().AxisY.Title = "Czas trwania";
            chart.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";

            chart.Series.Clear();

            //* ------------------------ *//

            if (checkBox4.Checked)
            {
                int j = 1;
                Series s = new Series();
                s.ChartType = SeriesChartType.Line;

                for (int x = 1; x <= (int)numericUpDown1.Value; x++)
                {
                    BubbleSort BubbleSorting = new BubbleSort(tab);
                    BubbleSorting.Sort();
                    DataPoint d = new DataPoint(j, BubbleSorting.Duration);

                    d.Label = (BubbleSorting.Duration).ToString();
                    d.MarkerStyle = MarkerStyle.Circle;
                    d.MarkerSize = 10;
                    d.MarkerColor = Color.Blue;

                    s.Points.Add(d);

                    chart.ChartAreas.First().AxisX.CustomLabels.Add(j - 0.5, j + 0.5, n.ToString());


                    j++;

                    n *= (int)numericUpDownMnoznik.Value;
                }
               

                chart.Series.Add(s);
                chart.ChartAreas.First().RecalculateAxesScale();
                n = 0;
            }

            if (checkBox5.Checked)
            {
                Series s = new Series();
                s.ChartType = SeriesChartType.Line;

                int j = 1;
                for (int x = 1; x <= (int)numericUpDown1.Value; x++)
                {
                    SelectionSort SelectionSorting = new SelectionSort(tab);
                    SelectionSorting.Sort();
                    DataPoint d = new DataPoint(j, SelectionSorting.Duration);

                    d.Label = (SelectionSorting.Duration).ToString();
                    d.MarkerStyle = MarkerStyle.Circle;
                    d.MarkerSize = 10;
                    d.MarkerColor = Color.Blue;

                    s.Points.Add(d);

                    if (!(checkBox4.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked)) { 
                    chart.ChartAreas.First().AxisX.CustomLabels.Add(j - 0.5, j + 0.5, n.ToString());
                    }

                    j++;

                    n *= (int)numericUpDownMnoznik.Value;
                }

                chart.Series.Add(s);
                chart.ChartAreas.First().RecalculateAxesScale();
            }

            if (checkBox6.Checked)
            {
                Series s = new Series();
                s.ChartType = SeriesChartType.Line;

                int j = 1;
                for (int x = 1; x <= (int)numericUpDown1.Value; x++)
                {
                    QuickSort QuickSorting = new QuickSort(tab);
                    QuickSorting.Sort();
                    DataPoint d = new DataPoint(j, QuickSorting.Duration);

                    d.Label = (QuickSorting.Duration).ToString();
                    d.MarkerStyle = MarkerStyle.Circle;
                    d.MarkerSize = 10;
                    d.MarkerColor = Color.Blue;

                    s.Points.Add(d);

                    if (!(checkBox4.Checked || checkBox5.Checked || checkBox7.Checked || checkBox8.Checked))
                    {
                        chart.ChartAreas.First().AxisX.CustomLabels.Add(j - 0.5, j + 0.5, n.ToString());
                    }
                    j++;

                    n *= (int)numericUpDownMnoznik.Value;
                }

                chart.Series.Add(s);
                chart.ChartAreas.First().RecalculateAxesScale();
            }

            if (checkBox7.Checked)
            {
                Series s = new Series();
                s.ChartType = SeriesChartType.Line;

                int j = 1;
                for (int x = 1; x <= (int)numericUpDown1.Value; x++)
                {
                    MergeSort MergeSorting = new MergeSort(tab);
                    MergeSorting.Sort();
                    DataPoint d = new DataPoint(j, MergeSorting.Duration);

                    d.Label = (MergeSorting.Duration).ToString();
                    d.MarkerStyle = MarkerStyle.Circle;
                    d.MarkerSize = 10;
                    d.MarkerColor = Color.Blue;

                    s.Points.Add(d);

                    if (!(checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox8.Checked))
                    {
                        chart.ChartAreas.First().AxisX.CustomLabels.Add(j - 0.5, j + 0.5, n.ToString());
                    }
                    j++;

                    n *= (int)numericUpDownMnoznik.Value;
                }

                chart.Series.Add(s);
                chart.ChartAreas.First().RecalculateAxesScale();
            }

            if (checkBox8.Checked)
            {
                Series s = new Series();
                s.ChartType = SeriesChartType.Line;

                int j = 1;
                for (int x = 1; x <= (int)numericUpDown1.Value; x++)
                {
                    InsertSort InsertSorting = new InsertSort(tab);
                    InsertSorting.Sort();
                    DataPoint d = new DataPoint(j, InsertSorting.Duration);

                    d.Label = (InsertSorting.Duration).ToString();
                    d.MarkerStyle = MarkerStyle.Circle;
                    d.MarkerSize = 10;
                    d.MarkerColor = Color.Blue;

                    s.Points.Add(d);

                    if (!(checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked))
                    {
                        chart.ChartAreas.First().AxisX.CustomLabels.Add(j - 0.5, j + 0.5, n.ToString());
                    }
                    j++;

                    n *= (int)numericUpDownMnoznik.Value;
                }

                chart.Series.Add(s);
                chart.ChartAreas.First().RecalculateAxesScale();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
        
}
