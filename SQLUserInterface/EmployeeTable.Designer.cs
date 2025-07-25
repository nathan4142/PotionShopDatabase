﻿namespace SQLUserInterface
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
            ux_EditEmployeeHours = new Button();
            ux_DeleteEmployee = new Button();
            ux_EmployeeTable = new DataGridView();
            ux_EditEmployeeGoldStars = new Button();
            ux_EditEmployeePosition = new Button();
            ux_EditEmployeeSalary = new Button();
            ((System.ComponentModel.ISupportInitialize)ux_EmployeeTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(44, 31);
            label1.Name = "label1";
            label1.Size = new Size(724, 26);
            label1.TabIndex = 0;
            label1.Text = "List of All Employees";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_AddEmployee
            // 
            ux_AddEmployee.Location = new Point(10, 58);
            ux_AddEmployee.Margin = new Padding(3, 2, 3, 2);
            ux_AddEmployee.Name = "ux_AddEmployee";
            ux_AddEmployee.Size = new Size(110, 22);
            ux_AddEmployee.TabIndex = 1;
            ux_AddEmployee.Text = "Add Employee";
            ux_AddEmployee.UseVisualStyleBackColor = true;
            ux_AddEmployee.Click += ux_AddEmployee_Click;
            // 
            // ux_EditEmployeeHours
            // 
            ux_EditEmployeeHours.Font = new Font("Segoe UI", 7F);
            ux_EditEmployeeHours.Location = new Point(136, 58);
            ux_EditEmployeeHours.Margin = new Padding(3, 2, 3, 2);
            ux_EditEmployeeHours.Name = "ux_EditEmployeeHours";
            ux_EditEmployeeHours.Size = new Size(114, 22);
            ux_EditEmployeeHours.TabIndex = 2;
            ux_EditEmployeeHours.Text = "Edit Employee Hours";
            ux_EditEmployeeHours.UseVisualStyleBackColor = true;
            ux_EditEmployeeHours.Click += ux_EditEmployeeHours_Click;
            // 
            // ux_DeleteEmployee
            // 
            ux_DeleteEmployee.Location = new Point(642, 58);
            ux_DeleteEmployee.Margin = new Padding(3, 2, 3, 2);
            ux_DeleteEmployee.Name = "ux_DeleteEmployee";
            ux_DeleteEmployee.Size = new Size(126, 22);
            ux_DeleteEmployee.TabIndex = 3;
            ux_DeleteEmployee.Text = "Delete Employee";
            ux_DeleteEmployee.UseVisualStyleBackColor = true;
            ux_DeleteEmployee.Click += ux_DeleteEmployee_Click;
            // 
            // ux_EmployeeTable
            // 
            ux_EmployeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_EmployeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_EmployeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_EmployeeTable.Location = new Point(10, 97);
            ux_EmployeeTable.Margin = new Padding(3, 2, 3, 2);
            ux_EmployeeTable.MultiSelect = false;
            ux_EmployeeTable.Name = "ux_EmployeeTable";
            ux_EmployeeTable.RowHeadersVisible = false;
            ux_EmployeeTable.RowHeadersWidth = 51;
            ux_EmployeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_EmployeeTable.Size = new Size(758, 254);
            ux_EmployeeTable.TabIndex = 4;
            // 
            // ux_EditEmployeeGoldStars
            // 
            ux_EditEmployeeGoldStars.Font = new Font("Segoe UI", 7F);
            ux_EditEmployeeGoldStars.Location = new Point(256, 58);
            ux_EditEmployeeGoldStars.Margin = new Padding(3, 2, 3, 2);
            ux_EditEmployeeGoldStars.Name = "ux_EditEmployeeGoldStars";
            ux_EditEmployeeGoldStars.Size = new Size(132, 22);
            ux_EditEmployeeGoldStars.TabIndex = 5;
            ux_EditEmployeeGoldStars.Text = "Edit Employee Gold Stars";
            ux_EditEmployeeGoldStars.UseVisualStyleBackColor = true;
            ux_EditEmployeeGoldStars.Click += ux_EditEmployeeGoldStars_Click;
            // 
            // ux_EditEmployeePosition
            // 
            ux_EditEmployeePosition.Font = new Font("Segoe UI", 7F);
            ux_EditEmployeePosition.Location = new Point(393, 58);
            ux_EditEmployeePosition.Margin = new Padding(3, 2, 3, 2);
            ux_EditEmployeePosition.Name = "ux_EditEmployeePosition";
            ux_EditEmployeePosition.Size = new Size(122, 22);
            ux_EditEmployeePosition.TabIndex = 6;
            ux_EditEmployeePosition.Text = "Edit Employee Position";
            ux_EditEmployeePosition.UseVisualStyleBackColor = true;
            ux_EditEmployeePosition.Click += ux_EditEmployeePosition_Click;
            // 
            // ux_EditEmployeeSalary
            // 
            ux_EditEmployeeSalary.Font = new Font("Segoe UI", 7F);
            ux_EditEmployeeSalary.Location = new Point(520, 58);
            ux_EditEmployeeSalary.Margin = new Padding(3, 2, 3, 2);
            ux_EditEmployeeSalary.Name = "ux_EditEmployeeSalary";
            ux_EditEmployeeSalary.Size = new Size(117, 22);
            ux_EditEmployeeSalary.TabIndex = 7;
            ux_EditEmployeeSalary.Text = "Edit Employee Salary";
            ux_EditEmployeeSalary.UseVisualStyleBackColor = true;
            ux_EditEmployeeSalary.Click += ux_EditEmployeeSalary_Click;
            // 
            // EmployeeTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ux_EditEmployeeSalary);
            Controls.Add(ux_EditEmployeePosition);
            Controls.Add(ux_EditEmployeeGoldStars);
            Controls.Add(ux_EmployeeTable);
            Controls.Add(ux_DeleteEmployee);
            Controls.Add(ux_EditEmployeeHours);
            Controls.Add(ux_AddEmployee);
            Controls.Add(label1);
            Name = "EmployeeTable";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_EmployeeTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ux_AddEmployee;
        private Button ux_EditEmployeeHours;
        private Button ux_DeleteEmployee;
        private DataGridView ux_EmployeeTable;
        private Button ux_EditEmployeeGoldStars;
        private Button ux_EditEmployeePosition;
        private Button ux_EditEmployeeSalary;
    }
}