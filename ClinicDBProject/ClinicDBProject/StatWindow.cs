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

namespace ClinicDBProject
{
    public partial class StatWindow : Form
    {
        public StatWindow()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1;
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void StatWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
