using System;
using System.Drawing;
using System.Windows.Forms;

namespace LegendTitleSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            #region #LegendTitleOptions
            // Specify legend title's text.
            chart.Legend.Title.Text = "Area of countries";
            // Show legend title.
            chart.Legend.Title.Visible = true;
            // Configure legend title appearance.
            chart.Legend.Title.Alignment = StringAlignment.Near;
            chart.Legend.Title.MaxLineCount = 3;
            chart.Legend.Title.WordWrap = true;
            #endregion #LegendTitleOptions
        }
    }
}
