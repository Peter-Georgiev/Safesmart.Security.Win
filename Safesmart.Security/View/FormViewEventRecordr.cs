using Safesmart.Security.Translations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsLogin.FormStatus;

namespace WindowsLogin
{

    public partial class FormViewEventRecordr : Form
    {
        List<PrintList> print = new List<PrintList>();
        TranslationText translationText = new TranslationText();

        public FormViewEventRecordr()
        {
            InitializeComponent();
            MaximizeBox = false;

            StartSearchDataTimePickerSetDate();

            FormView();
        }

        private void StartSearchDataTimePickerSetDate()
        {
            DateTime today = DateTime.Today.AddDays(0 - DateTime.Today.Day);
            this.startSearchDataTimePicker.Value = today;
        }

        private Task ProcessData(EventRecord eventRecord, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = eventRecord.CardLow.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() => {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    if (i < 20)
                    {
                        Thread.Sleep(10);
                    }
                }
            });
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.listViewEventRecord.Items.Clear();

                AssController assController = new AssController();

                Dictionary<int, string> doorCtrlID = assController.DoorCtrlID();
                Dictionary<int, string> doorOrdinal = assController.DoorOrdinal();

                SearchDataTime searchDataTime = 
                    new SearchDataTime(this.startSearchDataTimePicker.Text, this.endSearchDataTimePicker.Text);

                string startSearchData = searchDataTime.StartData();
                string endSearchData = searchDataTime.EndData();
                string startSearchTime = searchDataTime.StartTime();
                string endSearchTime = searchDataTime.EndTime();

                int ctrlIDOptional = 3;
                int ordinalOptional = assController.OrdinalOptional(this.comboBoxInOutDoor.Text);
                int searchDepartment = assController.SearchDepartment(this.comboBoxDepartmen.Text);            

                //First Name Second Name Last Name 
                string searchUserName = assController.SearchUserName(this.comboBoxEmploee.Text);

                //checket error
                ErrorMessage errorMessage = new ErrorMessage();
                errorMessage.ShowErrorMessage(startSearchData, endSearchData, startSearchTime, 
                    endSearchTime, ordinalOptional, searchDepartment, searchUserName);
        
                EventRecord eventRecord = assController.EventRecordRead(startSearchData, endSearchData, 
                    startSearchTime, endSearchTime, ctrlIDOptional, ordinalOptional);

                //progress bar            
                Progress<ProgressReport> progress = new Progress<ProgressReport>();
                progress.ProgressChanged += (o, report) => {
                    lblStatus.Text = string.Format($"{translationText.Get("process")}...{report.PercentComplete}%");
                    progressBar.Value = report.PercentComplete;
                    progressBar.Update();
                };
                await ProcessData(eventRecord, progress);
                lblStatus.Text = translationText.Get("done");

                Dictionary<int, Employee> cardEmployeeDepart = new Dictionary<int, Employee>();
                cardEmployeeDepart = assController.CardEmployeeDepart(searchUserName, searchDepartment);

                print = new List<PrintList>();

                int index = 0;
                foreach (var cardLow in eventRecord.CardLow)
                {
                    if (!cardEmployeeDepart.ContainsKey(cardLow))
                    {
                        index++;
                        continue;
                    }

                    PrintList prnName = new PrintList
                    {
                        EmployeeName = cardEmployeeDepart[cardLow].EmployeeName,
                        DateTime = eventRecord.AriseTime[index],
                        CtrlID = doorCtrlID[eventRecord.CtrlID[index]],
                        Ordinal = doorOrdinal[eventRecord.Ordinal[index]],
                        DepartmentName = cardEmployeeDepart[cardLow].DepartmentName
                    };

                    index++;
                    print.Add(prnName);
                }

                if (print.Count == 0)
                {
                    throw new Exception(translationText.Get("emptyOfficers"));
                }

                ViewFormEvent(print);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.comboBoxDepartmen.Items.Clear();
            this.comboBoxInOutDoor.Items.Clear();
            this.comboBoxEmploee.Items.Clear();
            this.listViewEventRecord.Items.Clear();
            this.lblStatus.Text = translationText.Get("process");
            this.progressBar.Value = 0;

            StartSearchDataTimePickerSetDate();
            this.endSearchDataTimePicker.Value = DateTime.Now;

            FormView();
        }

        private void BtnExportToExel_Click(object sender, EventArgs e)
        {
            try
            {
                if (print.Count == 0)
                {
                    throw new Exception(translationText.Get("emptyExcel"));
                }

                List<PrintList> printSort = print
                        .OrderBy(name => name.EmployeeName)
                        .ThenBy(dateTime => dateTime.DateTime)
                        .ToList();

                ExcelExport excelExport = new ExcelExport();
                excelExport.ExportToExcel(printSort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void ListViewEventRecord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormViewEventRecordr_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void StartSearchData_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EndSearchData_ValueChanged(object sender, EventArgs e)
        {

        }        

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FormView()
        {
            AssController assController = new AssController();

            //InDoor && OutDoor
            Dictionary<int, string> doorOrdinal = assController.DoorOrdinal();

            foreach (var pvk in doorOrdinal)
            {
                this.comboBoxInOutDoor.Items.Add(pvk.Value);
            }

            this.comboBoxInOutDoor.DropDownStyle = ComboBoxStyle.DropDownList;

            //DEPARTMENT
            Dictionary<int, string> department = assController.Department();

            this.comboBoxDepartmen.Items.Add(translationText.Get("allDepartments"));

            foreach (var pvk in department.OrderBy(x => x.Value))
            {
                this.comboBoxDepartmen.Items.Add(pvk.Value);
            }

            this.comboBoxDepartmen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDepartmen.SelectedIndex = 0;
        }
        
        private void ComboBoxDepartmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssController assController = new AssController();
            //Employee
            int searchDepartment = assController.SearchDepartment(this.comboBoxDepartmen.Text);
            Dictionary<int, Employee> cardEmployeeDepart = 
                assController.CardEmployeeDepart(String.Empty, searchDepartment);

            this.comboBoxEmploee.Items.Clear();

            if (cardEmployeeDepart.Count > 0)
            {
                this.comboBoxEmploee.Items.Add(translationText.Get("allOfficers"));
            }

            foreach (var pvk in cardEmployeeDepart.OrderBy(x => x.Value.EmployeeName))
            {
                this.comboBoxEmploee.Items.Add(pvk.Value.EmployeeName.ToString());
            }

            this.comboBoxEmploee.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxEmploee.SelectedIndex = 0;
        }

        private void ViewFormEvent(List<PrintList> print)
        {
            foreach (var p in print)
            {
                ListViewItem listViewItem = new ListViewItem(p.EmployeeName.ToString());
                listViewItem.SubItems.Add(p.DateTime.ToString());
                listViewItem.SubItems.Add(p.CtrlID.ToString());
                listViewItem.SubItems.Add(p.Ordinal.ToString());
                listViewItem.SubItems.Add(p.DepartmentName.ToString());

                this.listViewEventRecord.Items.Add(listViewItem);
            }            
        }

        private void FormViewEventRecordr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
