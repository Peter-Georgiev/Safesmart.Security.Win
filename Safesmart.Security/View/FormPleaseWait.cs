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
    public partial class FormPleaseWait : Form
    {
        private string startSearchData;
        private string endSearchData;
        private string startSearchTime;
        private string endSearchTime;
        private int ordinalOptional;
        private string searchDepartment;
        private string searchUserName;


        public FormPleaseWait()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;


        }

        private void FormPleaseWait_Load(object sender, EventArgs e)
        {
            
        }
    }
}
