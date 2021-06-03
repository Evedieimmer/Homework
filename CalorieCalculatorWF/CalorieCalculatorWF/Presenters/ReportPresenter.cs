using CalorieCalculatorWF.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
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


        //public List<ChartValue> GetChartValues(DateTime min, DateTime max)
        //{
        //    DateTime dateMin = DateTime.Parse(min.ToShortDateString());
        //    DateTime dateMax = DateTime.Parse(max.ToShortDateString());
        //    List<ChartValue> list = new List<ChartValue>();
        //    foreach (var i in list)
        //    {
        //        if (dateMin < dateMax)
        //        {
        //            i.dateDiary = dateMin;
        //            i.calorieDay = Repository.GetSummBmr(IdUser.Id, dateMin);
        //            dateMin.AddDays(1);
        //        };
        //    }
        //    return list.ToList();
        //}

        public List<DateTime> DateList(DateTime min, DateTime max)
        {
            List<DateTime> dates = new List<DateTime>();
            for (DateTime date = min; date <= max; date = date.AddDays(1))
            {
                dates.Add(date);
            }
            return dates;
        }

        public List<int?> BmrCount(List<DateTime> dateList)
        {
            List<int?> bmrCount = new List<int?>();
            for (int i = 0; i < dateList.Count; i++)
            {
                bmrCount.Add(Repository.GetSummBmr(IdUser.Id, dateList[i]));
            }
            return bmrCount;
        }

    }
}
