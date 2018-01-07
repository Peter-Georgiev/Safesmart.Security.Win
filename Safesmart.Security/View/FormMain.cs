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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void ListUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            FormViewEventRecordr formViewEventRecordr = new FormViewEventRecordr();
            formViewEventRecordr.Hide();
            formViewEventRecordr.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Close();
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
