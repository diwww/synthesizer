using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoundGenerator
{
    public partial class Form2 : Form
    {
        Form1 mainForm;

        // TODO : dock = fill не рефрешит чарт

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
            : this()
        {
            this.BackColor = Color.DimGray;
            mainForm = form;
            form.openFlag_gr = true;
            //chart1.AntiAliasing = AntiAliasingStyles.Graphics;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            //chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].BackColor = Color.DimGray;
            chart1.BackColor = Color.DimGray;
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            ShowTable();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            ShowTable();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.openFlag_gr = false;
        }

        private void ShowTable()
        {
            chart1.Series.Clear();
            chart1.Series.Add("WAVE");
            chart1.Series["WAVE"].ChartType = SeriesChartType.Line;
            chart1.Series["WAVE"].Color = Color.Cyan;
            chart1.Series["WAVE"].IsVisibleInLegend = false;
            chart1.Series["WAVE"].BorderWidth = 2;
            for (int i = 0; i < 2000; i++)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueXY(i, mainForm.waveData[i]);
                chart1.Series["WAVE"].Points.Add(dp);
            }
        }
    }
}
