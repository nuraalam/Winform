namespace WindowsFormsApplication1
{
    partial class MainUi
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
            this.employeeEntryButton = new System.Windows.Forms.Button();
            this.showEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeEntryButton
            // 
            this.employeeEntryButton.Location = new System.Drawing.Point(95, 63);
            this.employeeEntryButton.Name = "employeeEntryButton";
            this.employeeEntryButton.Size = new System.Drawing.Size(159, 57);
            this.employeeEntryButton.TabIndex = 0;
            this.employeeEntryButton.Text = "Employee Entry";
            this.employeeEntryButton.UseVisualStyleBackColor = true;
            this.employeeEntryButton.Click += new System.EventHandler(this.employeeEntryButton_Click);
            // 
            // showEmployeeButton
            // 
            this.showEmployeeButton.Location = new System.Drawing.Point(95, 147);
            this.showEmployeeButton.Name = "showEmployeeButton";
            this.showEmployeeButton.Size = new System.Drawing.Size(159, 52);
            this.showEmployeeButton.TabIndex = 1;
            this.showEmployeeButton.Text = "Show Employees";
            this.showEmployeeButton.UseVisualStyleBackColor = true;
            this.showEmployeeButton.Click += new System.EventHandler(this.showEmployeeButton_Click);
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 295);
            this.Controls.Add(this.showEmployeeButton);
            this.Controls.Add(this.employeeEntryButton);
            this.Name = "MainUi";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeEntryButton;
        private System.Windows.Forms.Button showEmployeeButton;
    }
}

