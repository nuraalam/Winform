namespace WindowsFormsApplication1.UI
{
    partial class ShowEmployeeUi
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
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.showEmployeeButton = new System.Windows.Forms.Button();
            this.employeelistView = new System.Windows.Forms.ListView();
            this.EmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Items.AddRange(new object[] {
            "Korim",
            "Rohim"});
            this.managerComboBox.Location = new System.Drawing.Point(46, 41);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(214, 21);
            this.managerComboBox.TabIndex = 0;
            // 
            // showEmployeeButton
            // 
            this.showEmployeeButton.Location = new System.Drawing.Point(46, 83);
            this.showEmployeeButton.Name = "showEmployeeButton";
            this.showEmployeeButton.Size = new System.Drawing.Size(214, 46);
            this.showEmployeeButton.TabIndex = 1;
            this.showEmployeeButton.Text = "Show Employee";
            this.showEmployeeButton.UseVisualStyleBackColor = true;
            this.showEmployeeButton.Click += new System.EventHandler(this.showEmployeeButton_Click);
            // 
            // employeelistView
            // 
            this.employeelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeId,
            this.employeeName,
            this.designation,
            this.managerId});
            this.employeelistView.GridLines = true;
            this.employeelistView.Location = new System.Drawing.Point(35, 191);
            this.employeelistView.Name = "employeelistView";
            this.employeelistView.Size = new System.Drawing.Size(423, 125);
            this.employeelistView.TabIndex = 2;
            this.employeelistView.UseCompatibleStateImageBehavior = false;
            this.employeelistView.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Text = "Employee ID";
            this.EmployeeId.Width = 102;
            // 
            // employeeName
            // 
            this.employeeName.Text = "Employee Name";
            this.employeeName.Width = 109;
            // 
            // designation
            // 
            this.designation.Text = "Designation";
            this.designation.Width = 128;
            // 
            // managerId
            // 
            this.managerId.Text = "Manager ID";
            // 
            // ShowEmployeeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 343);
            this.Controls.Add(this.employeelistView);
            this.Controls.Add(this.showEmployeeButton);
            this.Controls.Add(this.managerComboBox);
            this.Name = "ShowEmployeeUi";
            this.Text = "ShowEmployeeUi";
            this.Load += new System.EventHandler(this.ShowEmployeeUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.Button showEmployeeButton;
        private System.Windows.Forms.ListView employeelistView;
        private System.Windows.Forms.ColumnHeader EmployeeId;
        private System.Windows.Forms.ColumnHeader employeeName;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader managerId;
    }
}