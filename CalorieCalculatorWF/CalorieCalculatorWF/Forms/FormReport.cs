using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWF.Forms
{
    public partial class FormReport : Form
    {
        public ReportPresenter reportPresenter;
        public FormReport()
        {
            InitializeComponent();
            Repository repository = new Repository();
            reportPresenter = new ReportPresenter(this, repository);
        }


        private void BtnShowChart_Click(object sender, EventArgs e)
        {
            DateTime min = DateTime.Parse(dtpBegin.Value.ToShortDateString());
            DateTime max = DateTime.Parse(dtpEnd.Value.ToShortDateString());
            List<DateTime> dates = reportPresenter.DateList(min, max);
            List<int?> bmr = reportPresenter.BmrCount(dates);
            for (int i = 0; i < dates.Count; i++)
            {
                chartReport.Series[0].Points.AddXY(dates[i], bmr[i]);
            }
        }
    }
}
