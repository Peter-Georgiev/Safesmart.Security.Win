using Safesmart.Security.Translations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLogin
{

    class ExcelExport
    {
        TranslationText translationText = new TranslationText();

        public void ExportToExcel(List<PrintList> print)
        {
            // Load Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create empty workbook
            excel.Workbooks.Add();

            // Create Worksheet from active sheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;

            // I created Application and Worksheet objects before try/catch,
            // so that i can close them in finnaly block.
            // It's IMPORTANT to release these COM objects!!
            try
            {
                // ------------------------------------------------
                // Creation of header cells
                // ------------------------------------------------
                workSheet.Cells[1, "A"] = translationText.Get("excelA");
                workSheet.Cells[1, "B"] = translationText.Get("excelB");
                workSheet.Cells[1, "C"] = translationText.Get("excelC");
                workSheet.Cells[1, "D"] = translationText.Get("excelD");
                workSheet.Cells[1, "E"] = translationText.Get("excelE");

                // ------------------------------------------------
                // Populate sheet with some real data from "cars" list
                // ------------------------------------------------
                int row = 2; // start row (in row 1 are header cells)
                foreach (PrintList prn in print)
                {
                    workSheet.Cells[row, "A"] = prn.EmployeeName;
                    workSheet.Cells[row, "B"] = prn.DateTime;
                    workSheet.Cells[row, "C"] = prn.CtrlID;
                    workSheet.Cells[row, "D"] = prn.Ordinal;
                    workSheet.Cells[row, "E"] = prn.DepartmentName;

                    row++;
                }

                // Apply some predefined styles for data to look nicely :)
                workSheet.Range["A1"].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                // Define filename
                string fileName = string.Format(@"{0}\ExcelData.xlsx", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));

                // Save this data as a file
                workSheet.SaveAs(fileName);

                // Display SUCCESS message
                Console.WriteLine(string.Format("The file '{0}' is saved successfully!", fileName));
                //MessageBox.Show(string.Format("The file '{0}' is saved successfully!", fileName));
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception", "There was a PROBLEM saving Excel file!\n" + exception.Message);
                //MessageBox.Show("Exception", "There was a PROBLEM saving Excel file!\n" + exception.Message, MessageBoxButtons.OK, essageBoxIcon.Error);
            }
            finally
            {
                // Quit Excel application
                excel.Quit();

                // Release COM objects (very important!)
                if (excel != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                if (workSheet != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);

                // Empty variables
                excel = null;
                workSheet = null;

                // Force garbage collector cleaning
                GC.Collect();
            }
        }
    }
}
