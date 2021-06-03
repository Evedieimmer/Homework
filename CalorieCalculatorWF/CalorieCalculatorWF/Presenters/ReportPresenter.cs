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


        public List<ChartValue> GetChartValues(DateTime min, DateTime max)
        {
            DateTime dateMin = DateTime.Parse(min.ToShortDateString());
            DateTime dateMax = DateTime.Parse(max.ToShortDateString());
            List<ChartValue> list = new List<ChartValue>();
            foreach(var i in list)
            {
                if (dateMin < dateMax)
                {
                    i.dateDiary = dateMin;
                    i.calorieDay = Repository.GetSummBmr(IdUser.Id, dateMin);
                    dateMin.AddDays(1);
                };
            }
            return list.ToList();
        } 
    }
}
