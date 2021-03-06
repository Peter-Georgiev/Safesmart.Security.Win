﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLogin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string query = "SELECT `UserId`, `UserName` " +
                "FROM `User`";
            ConnectMDB myDataTable = new ConnectMDB(query);

            if (myDataTable.ConnectDB() != null)
            {
                //Application.Run(new FormProgress());

                //Application.Run(new FormPleaseWait());

                Application.Run(new FormLogin());

                //Application.Run(new FormViewEventRecordr());
            }
        }
    }
}
