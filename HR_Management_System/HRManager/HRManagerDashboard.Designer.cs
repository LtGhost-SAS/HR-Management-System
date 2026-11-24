namespace HRManagementSystem.HRManager
{
    partial class HRManagerDashboard
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
            this.manageEmpButton = new System.Windows.Forms.Button();
            this.manageSalaryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageEmpButton
            // 
            this.manageEmpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.manageEmpButton.Location = new System.Drawing.Point(575, 138);
            this.manageEmpButton.Name = "manageEmpButton";
            this.manageEmpButton.Size = new System.Drawing.Size(134, 64);
            this.manageEmpButton.TabIndex = 0;
            this.manageEmpButton.Text = "MANAGE EMPLOYEE";
            this.manageEmpButton.UseVisualStyleBackColor = false;
            this.manageEmpButton.Click += new System.EventHandler(this.manageEmpButton_Click);
            // 
            // manageSalaryButton
            // 
            this.manageSalaryButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.manageSalaryButton.Location = new System.Drawing.Point(575, 271);
            this.manageSalaryButton.Name = "manageSalaryButton";
            this.manageSalaryButton.Size = new System.Drawing.Size(134, 54);
            this.manageSalaryButton.TabIndex = 1;
            this.manageSalaryButton.Text = "MANAGE SALARY";
            this.manageSalaryButton.UseVisualStyleBackColor = false;
            this.manageSalaryButton.Click += new System.EventHandler(this.manageSalaryButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Location = new System.Drawing.Point(31, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 42);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.profileButton.Location = new System.Drawing.Point(1241, 26);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(96, 42);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "PROFILE";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // HRManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1360, 585);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.manageSalaryButton);
            this.Controls.Add(this.manageEmpButton);
            this.Name = "HRManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRManagerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageEmpButton;
        private System.Windows.Forms.Button manageSalaryButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button profileButton;
    }
}