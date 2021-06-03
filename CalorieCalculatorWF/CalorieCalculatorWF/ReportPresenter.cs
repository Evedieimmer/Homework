using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWF.Forms;
using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public class ReportPresenter
    {
        public Repository Repository;
        public FormReport View;

        public ReportPresenter(FormReport view, Repository repository)
        {
            Repository = repository;
            View = view;
        }
    }
}
