using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLogin
{
    class ErrorMessage
    {
        string DATE_FORMAT = "MM/dd/yyyy";
        string TIME_FORMAT = "HH:mm:ss";

        public void ShowErrorMessage(string startSearchData, string endSearchData,
            string startSearchTime, string endSearchTime,
            int ordinalOptional, int searchDepartment, string searchUserName)
        {
            FormViewEventRecordr formViewEventRecordr = new FormViewEventRecordr();

            DateTime startSearchDataParse = DateTime
                .ParseExact(startSearchData, DATE_FORMAT, CultureInfo.InvariantCulture);
            DateTime endSearchDataParse = DateTime
                .ParseExact(endSearchData, DATE_FORMAT, CultureInfo.InvariantCulture);

            if (startSearchDataParse > endSearchDataParse)
            {
                throw new Exception("Некоректно поълнена начална или крайна дата");
            }

            DateTime startSearchTimeParse = DateTime
                .ParseExact(startSearchTime, TIME_FORMAT, CultureInfo.InvariantCulture);
            DateTime endSearchTimeParse = DateTime
                .ParseExact(endSearchTime, TIME_FORMAT, CultureInfo.InvariantCulture);

            if (startSearchTimeParse > endSearchTimeParse)
            {
                throw new Exception("Некоректно поълнен начален или краен час");
            }

            if (ordinalOptional == -1)
            {
                throw new Exception("Трябва да изберете \"ВХОД\" или \"ИЗХОД\"");
            }

            if (searchDepartment == 0)
            {
                //throw new Exception("Трябва да изберете \"отдел\"");
                //formViewEventRecordr.FormView();
            }

            if (searchUserName.Length == 0)
            {
                //throw new Exception("Трябва да изберете \"служител\"");
                //formViewEventRecordr.FormView();
            }
        }
    }
}
