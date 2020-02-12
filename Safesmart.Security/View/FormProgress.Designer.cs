namespace WindowsLogin
{
    partial class FormStatus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatus));
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(435, 59);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 13);
            this.labelProgress.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(30, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(440, 23);
            this.progressBar.TabIndex = 1;
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 86);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress...0%";
            this.Load += new System.EventHandler(this.FormProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProgress;
    }
}