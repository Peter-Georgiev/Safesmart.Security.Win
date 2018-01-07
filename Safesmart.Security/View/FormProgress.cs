using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLogin
{
    public partial class FormProgress : Form
    {
        public FormProgress(int length = 10)
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            timerProgress.Enabled = true;

            // Display the ProgressBar control.
            progressBar.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar.Minimum = 0;
            // Set Maximum to the total number of files to copy.
            progressBar.Maximum = length;
            // Set the initial value of the ProgressBar.
            progressBar.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar.Step = 1;

            // Loop through all files to copy.
            for (int x = 0; x < length; x++)
            {
                progressBar.PerformStep();
            }


        }

        public void FormProgressStart(int length)
        {
            // Display the ProgressBar control.
            progressBar.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar.Minimum = 0;
            // Set Maximum to the total number of files to copy.
            progressBar.Maximum = length;
            // Set the initial value of the ProgressBar.
            progressBar.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar.Step = 1;

            // Loop through all files to copy.
            for (int x = 0; x < length; x++)
            {
                progressBar.PerformStep();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            //labelProgress.Text = ((progressBar.Value / 100) * 100).ToString() + "%";
        }

        public void FormFor()
        {
            while (true)
            {
                byte length = 100;

                // Display the ProgressBar control.
                progressBar.Visible = true;
                // Set Minimum to 1 to represent the first file being copied.
                progressBar.Minimum = 0;
                // Set Maximum to the total number of files to copy.
                progressBar.Maximum = length;
                // Set the initial value of the ProgressBar.
                progressBar.Value = 1;
                // Set the Step property to a value of 1 to represent each file being copied.
                progressBar.Step = 1;

                // Loop through all files to copy.
                for (int x = 0; x < length; x++)
                {
                    progressBar.PerformStep();
                }
            }
        }
    }
}
