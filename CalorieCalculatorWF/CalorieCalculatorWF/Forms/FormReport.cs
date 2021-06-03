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


    }
}
