namespace WindowsFormsApplication1.UI
{
    partial class EmployeeEntryUi
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
            this.emplyeeNameTextBox = new System.Windows.Forms.TextBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emplyeeNameTextBox
            // 
            this.emplyeeNameTextBox.Location = new System.Drawing.Point(45, 65);
            this.emplyeeNameTextBox.Name = "emplyeeNameTextBox";
            this.emplyeeNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.emplyeeNameTextBox.TabIndex = 0;
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(45, 124);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(181, 20);
            this.designationTextBox.TabIndex = 1;
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Items.AddRange(new object[] {
            "Korim",
            "Rohim"});
            this.managerComboBox.Location = new System.Drawing.Point(45, 176);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(181, 21);
            this.managerComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manager";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(151, 216);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EmployeeEntryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerComboBox);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.emplyeeNameTextBox);
            this.Name = "EmployeeEntryUi";
            this.Text = "EmployeeEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emplyeeNameTextBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
    }
}