namespace WindowsLogin
{
    partial class FormViewEventRecordr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewEventRecordr));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listViewEventRecord = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.endSearchDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startSearchDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelStartSearchData = new System.Windows.Forms.Label();
            this.labelEndSearchData = new System.Windows.Forms.Label();
            this.comboBoxInOutDoor = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartmen = new System.Windows.Forms.ComboBox();
            this.comboBoxEmploee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(14, 59);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 59);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // listViewEventRecord
            // 
            this.listViewEventRecord.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewEventRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEventRecord.GridLines = true;
            this.listViewEventRecord.HoverSelection = true;
            this.listViewEventRecord.Location = new System.Drawing.Point(14, 85);
            this.listViewEventRecord.Name = "listViewEventRecord";
            this.listViewEventRecord.Size = new System.Drawing.Size(823, 539);
            this.listViewEventRecord.TabIndex = 2;
            this.listViewEventRecord.UseCompatibleStateImageBehavior = false;
            this.listViewEventRecord.View = System.Windows.Forms.View.Details;
            this.listViewEventRecord.SelectedIndexChanged += new System.EventHandler(this.ListViewEventRecord_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ИМЕ ПРЕЗИМЕ ФАМИЛИЯ";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ДАТА ЧАС";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ПОРТАЛ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ВХОД/ИЗХОД";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ОТДЕЛ";
            this.columnHeader5.Width = 226;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(314, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // endSearchDataTimePicker
            // 
            this.endSearchDataTimePicker.Checked = false;
            this.endSearchDataTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.endSearchDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endSearchDataTimePicker.Location = new System.Drawing.Point(211, 22);
            this.endSearchDataTimePicker.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.endSearchDataTimePicker.Name = "endSearchDataTimePicker";
            this.endSearchDataTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endSearchDataTimePicker.Size = new System.Drawing.Size(143, 20);
            this.endSearchDataTimePicker.TabIndex = 4;
            this.endSearchDataTimePicker.Value = new System.DateTime(2018, 1, 5, 10, 0, 0, 0);
            this.endSearchDataTimePicker.ValueChanged += new System.EventHandler(this.EndSearchData_ValueChanged);
            // 
            // startSearchDataTimePicker
            // 
            this.startSearchDataTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.startSearchDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startSearchDataTimePicker.Location = new System.Drawing.Point(14, 20);
            this.startSearchDataTimePicker.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.startSearchDataTimePicker.Name = "startSearchDataTimePicker";
            this.startSearchDataTimePicker.Size = new System.Drawing.Size(143, 20);
            this.startSearchDataTimePicker.TabIndex = 5;
            this.startSearchDataTimePicker.Value = new System.DateTime(2017, 1, 1, 7, 55, 0, 0);
            this.startSearchDataTimePicker.ValueChanged += new System.EventHandler(this.StartSearchData_ValueChanged);
            // 
            // labelStartSearchData
            // 
            this.labelStartSearchData.Location = new System.Drawing.Point(11, 4);
            this.labelStartSearchData.Name = "labelStartSearchData";
            this.labelStartSearchData.Size = new System.Drawing.Size(146, 13);
            this.labelStartSearchData.TabIndex = 0;
            this.labelStartSearchData.Text = "Въведи начална дата и час";
            // 
            // labelEndSearchData
            // 
            this.labelEndSearchData.Location = new System.Drawing.Point(208, 5);
            this.labelEndSearchData.Name = "labelEndSearchData";
            this.labelEndSearchData.Size = new System.Drawing.Size(146, 13);
            this.labelEndSearchData.TabIndex = 6;
            this.labelEndSearchData.Text = "Въведи крайна дата и час";
            // 
            // comboBoxInOutDoor
            // 
            this.comboBoxInOutDoor.AccessibleDescription = "";
            this.comboBoxInOutDoor.AccessibleName = "";
            this.comboBoxInOutDoor.DisplayMember = "(none)";
            this.comboBoxInOutDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInOutDoor.FormattingEnabled = true;
            this.comboBoxInOutDoor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxInOutDoor.Location = new System.Drawing.Point(449, 20);
            this.comboBoxInOutDoor.Name = "comboBoxInOutDoor";
            this.comboBoxInOutDoor.Size = new System.Drawing.Size(72, 21);
            this.comboBoxInOutDoor.Sorted = true;
            this.comboBoxInOutDoor.TabIndex = 7;
            this.comboBoxInOutDoor.Tag = "";
            this.comboBoxInOutDoor.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBoxDepartmen
            // 
            this.comboBoxDepartmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartmen.FormattingEnabled = true;
            this.comboBoxDepartmen.Location = new System.Drawing.Point(582, 20);
            this.comboBoxDepartmen.Name = "comboBoxDepartmen";
            this.comboBoxDepartmen.Size = new System.Drawing.Size(255, 21);
            this.comboBoxDepartmen.TabIndex = 8;
            this.comboBoxDepartmen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDepartmen_SelectedIndexChanged);
            // 
            // comboBoxEmploee
            // 
            this.comboBoxEmploee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmploee.FormattingEnabled = true;
            this.comboBoxEmploee.Location = new System.Drawing.Point(582, 58);
            this.comboBoxEmploee.Name = "comboBoxEmploee";
            this.comboBoxEmploee.Size = new System.Drawing.Size(255, 21);
            this.comboBoxEmploee.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Избери отдели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Избор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "име фамилия презиме";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportToExcel.Location = new System.Drawing.Point(208, 59);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(89, 23);
            this.btnExportToExcel.TabIndex = 13;
            this.btnExportToExcel.Text = "Ехпорт в excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Избери вход или изход";
            // 
            // FormViewEventRecordr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 639);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmploee);
            this.Controls.Add(this.comboBoxDepartmen);
            this.Controls.Add(this.comboBoxInOutDoor);
            this.Controls.Add(this.labelEndSearchData);
            this.Controls.Add(this.labelStartSearchData);
            this.Controls.Add(this.startSearchDataTimePicker);
            this.Controls.Add(this.endSearchDataTimePicker);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listViewEventRecord);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormViewEventRecordr";
            this.Text = "FormViewEventRecordr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewEventRecordr_FormClosing);
            this.Load += new System.EventHandler(this.FormViewEventRecordr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView listViewEventRecord;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker endSearchDataTimePicker;
        private System.Windows.Forms.DateTimePicker startSearchDataTimePicker;
        private System.Windows.Forms.Label labelStartSearchData;
        private System.Windows.Forms.Label labelEndSearchData;
        private System.Windows.Forms.ComboBox comboBoxInOutDoor;
        private System.Windows.Forms.ComboBox comboBoxDepartmen;
        private System.Windows.Forms.ComboBox comboBoxEmploee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label4;
    }
}