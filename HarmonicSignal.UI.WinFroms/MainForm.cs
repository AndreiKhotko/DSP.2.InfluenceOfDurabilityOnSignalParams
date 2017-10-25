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

namespace HarmonicSignal.UI.WinFroms
{
    public partial class MainForm : Form
    {
        private List<double> cBoxPhaseConstList;
        private List<int> cBoxNConstList;
        private List<string> chartSeriesNames;

        public MainForm()
        {
            InitializeComponent();
            InitCBoxItems();
            InitChart();

        }

        private void InitChart()
        {
            chartSeriesNames = new List<string>(new string[]
            {
                "ErrorRMSValueA",
                "ErrorRMSValueB",
                "ErrorAmplitude"
            });

            foreach (var name in chartSeriesNames)
            {
                chart.Series[name].Points.Clear();
                chart.Series[name].ChartType = SeriesChartType.Spline;
            }
        }

        private void ClearChart()
        {
            foreach (var name in chartSeriesNames)
            {
                chart.Series[name].Points.Clear();
            }
        }

        private void InitCBoxItems()
        {
            // Init cBoxPhase
            this.cBoxPhase.Items.AddRange(new object[] {
            "0",
            "PI / 8"
            });

            cBoxPhase.SelectedIndex = 0;
            cBoxPhaseConstList = new List<double>();
            cBoxPhaseConstList.AddRange(new double[] {
                0,
                Math.PI / 8
            });

            // Init cBoxN
            this.cBoxN.Items.AddRange(new object[] {
                "64",
                "128",
                "256",
                "512",
                "1024",
                "2048",
                "4096"});
            cBoxNConstList = new List<int>();
            cBoxNConstList.AddRange(new int[] {
                64,
                128,
                256,
                512,
                1024,
                2048,
                4096
            });

            cBoxN.SelectedIndex = 0;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            ClearChart();

            var phase = GetPhaseValue();
            var N = GetNValue();
            var K = 3 * N / 4;
            int increment_m = N * 1 / 32;
            var function = new HarmonicSignal.Function(N, K, K, phase);

            for (int m = 1; m <= 5 * N; m += increment_m)
            {
                function.M = m;

                var rmsA = function.RootMeanSquareValueA;
                var rmsB = function.RootMeanSquareValueB;
                var amplitude = function.Amplitude;

                var errorRmsA = 0.707 - rmsA;
                var errorRmsB = 0.707 - rmsB;
                var errorAmplitude = 1 - amplitude;

                chart.Series[chartSeriesNames[0]].Points.AddXY(m, errorRmsA);
                chart.Series[chartSeriesNames[1]].Points.AddXY(m, errorRmsB);
                chart.Series[chartSeriesNames[2]].Points.AddXY(m, errorAmplitude);
            }
        }

        private double GetPhaseValue() => cBoxPhaseConstList[cBoxPhase.SelectedIndex];
        private int GetNValue() => cBoxNConstList[cBoxN.SelectedIndex];

        private void cBoxN_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKResult.Text = (3 * GetNValue() / 4).ToString();
        }
    }
}
