namespace SQLUserInterface
{
    partial class EmployeeTable
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ux_AddEmployee = new Button();
            ux_EditEmployee = new Button();
            ux_DeleteEmployee = new Button();
            ux_EmployeeTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ux_EmployeeTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(828, 34);
            label1.TabIndex = 0;
            label1.Text = "List of All Employees";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_AddEmployee
            // 
            ux_AddEmployee.Location = new Point(12, 78);
            ux_AddEmployee.Name = "ux_AddEmployee";
            ux_AddEmployee.Size = new Size(126, 29);
            ux_AddEmployee.TabIndex = 1;
            ux_AddEmployee.Text = "Add Employee";
            ux_AddEmployee.UseVisualStyleBackColor = true;
            // 
            // ux_EditEmployee
            // 
            ux_EditEmployee.Location = new Point(397, 78);
            ux_EditEmployee.Name = "ux_EditEmployee";
            ux_EditEmployee.Size = new Size(125, 29);
            ux_EditEmployee.TabIndex = 2;
            ux_EditEmployee.Text = "Edit Employee";
            ux_EditEmployee.UseVisualStyleBackColor = true;
            // 
            // ux_DeleteEmployee
            // 
            ux_DeleteEmployee.Location = new Point(734, 78);
            ux_DeleteEmployee.Name = "ux_DeleteEmployee";
            ux_DeleteEmployee.Size = new Size(144, 29);
            ux_DeleteEmployee.TabIndex = 3;
            ux_DeleteEmployee.Text = "Delete Employee";
            ux_DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // ux_EmployeeTable
            // 
            ux_EmployeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_EmployeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_EmployeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_EmployeeTable.Location = new Point(12, 129);
            ux_EmployeeTable.MultiSelect = false;
            ux_EmployeeTable.Name = "ux_EmployeeTable";
            ux_EmployeeTable.RowHeadersVisible = false;
            ux_EmployeeTable.RowHeadersWidth = 51;
            ux_EmployeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_EmployeeTable.Size = new Size(866, 338);
            ux_EmployeeTable.TabIndex = 4;
            // 
            // EmployeeTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ux_EmployeeTable);
            Controls.Add(ux_DeleteEmployee);
            Controls.Add(ux_EditEmployee);
            Controls.Add(ux_AddEmployee);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeTable";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_EmployeeTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ux_AddEmployee;
        private Button ux_EditEmployee;
        private Button ux_DeleteEmployee;
        private DataGridView ux_EmployeeTable;
    }
}