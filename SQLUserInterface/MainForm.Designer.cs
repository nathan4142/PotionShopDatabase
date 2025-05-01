namespace SQLUserInterface
{
    partial class MainForm
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
            ux_tableComboBox = new ComboBox();
            label1 = new Label();
            ux_openTableButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // ux_tableComboBox
            // 
            ux_tableComboBox.FormattingEnabled = true;
            ux_tableComboBox.Location = new Point(263, 135);
            ux_tableComboBox.Margin = new Padding(3, 2, 3, 2);
            ux_tableComboBox.Name = "ux_tableComboBox";
            ux_tableComboBox.Size = new Size(133, 23);
            ux_tableComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // ux_openTableButton
            // 
            ux_openTableButton.Location = new Point(417, 135);
            ux_openTableButton.Margin = new Padding(3, 2, 3, 2);
            ux_openTableButton.Name = "ux_openTableButton";
            ux_openTableButton.Size = new Size(82, 22);
            ux_openTableButton.TabIndex = 2;
            ux_openTableButton.Text = "View Table";
            ux_openTableButton.UseVisualStyleBackColor = true;
            ux_openTableButton.Click += ux_openTableButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 3;
            label2.Text = "Select a table to view";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(ux_openTableButton);
            Controls.Add(label1);
            Controls.Add(ux_tableComboBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ux_tableComboBox;
        private Label label1;
        private Button ux_openTableButton;
        private Label label2;
    }
}