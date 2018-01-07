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
        public void ShowErrorMessage(string startSearchData, string endSearchData,
            string startSearchTime, string endSearchTime,
            int ordinalOptional, int searchDepartment, string searchUserName)
        {
            FormViewEventRecordr formViewEventRecordr = new FormViewEventRecordr();

            DateTime startSearchDataParse = DateTime
                .ParseExact(startSearchData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime endSearchDataParse = DateTime
                .ParseExact(endSearchData, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (startSearchDataParse > endSearchDataParse)
            {
                MessageBox.Show("Некоректно поълнена начална или крайна дата");
                
                formViewEventRecordr.FormView();
            }

            DateTime startSearchTimeParse = DateTime
                .ParseExact(startSearchTime, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime endSearchTimeParse = DateTime
                .ParseExact(endSearchTime, "HH:mm:ss", CultureInfo.InvariantCulture);

            if (startSearchTimeParse > endSearchTimeParse)
            {
                MessageBox.Show("Некоректно поълнен начален или краен час");

                formViewEventRecordr.FormView();
            }

            if (ordinalOptional == -1)
            {
                MessageBox.Show("Трябва да изберете \"ВХОД\" или \"ИЗХОД\"");

                formViewEventRecordr.FormView();
            }

            if (searchDepartment == 0)
            {
                //MessageBox.Show("Трябва да изберете \"отдел\"");
                //formViewEventRecordr.FormView();
            }
        }
    }
}
