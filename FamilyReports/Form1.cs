using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyReports
{
    public partial class FamilyAccounting : Form
    {
        public FamilyAccounting()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            RomanReport1 reportViewer = new RomanReport1();
            reportViewer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarasReport1 reportViewer = new TarasReport1();
            reportViewer.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RomanReport2 reportViewer = new RomanReport2();
            reportViewer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IrynaReport reportViewer = new IrynaReport();
            reportViewer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DmytroReport reportViewer = new DmytroReport();
            reportViewer.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NazarReport reportViewer = new NazarReport();
            reportViewer.Show();
        }
    }
}
