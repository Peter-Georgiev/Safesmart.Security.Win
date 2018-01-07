using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {

        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT `UserId`, `UserName` " + 
                "FROM `User` " +
                "WHERE `UserName`='"+textBoxUsername.Text.Trim()+"' " +
                "AND `UserPassword`='"+textBoxPassword.Text.Trim()+"'";

            ConnectMDB myDataTable = new ConnectMDB(query);

            if (myDataTable.ConnectDB() == null)
            {
                this.Close();
            }

            int userCount = myDataTable.ConnectDB().AsEnumerable().ToArray().Count();            

            if (userCount == 1)
            {
                User user = new User
                {
                    UserId = myDataTable.ConnectDB().AsEnumerable()
                    .Select(i => i.Field<int>("UserID"))
                    .ToArray()[0],
                    UserName = myDataTable.ConnectDB().AsEnumerable()
                    .Select(i => i.Field<string>("UserName"))
                    .ToArray()[0]
                };

                //FormMain formMain = new FormMain();
                FormViewEventRecordr formViewEventRecordr = new FormViewEventRecordr();
                this.Hide();

                //formMain.Show();
                formViewEventRecordr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
