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
            SuspendLayout();
            // 
            // ux_tableComboBox
            // 
            ux_tableComboBox.FormattingEnabled = true;
            ux_tableComboBox.Location = new Point(35, 34);
            ux_tableComboBox.Name = "ux_tableComboBox";
            ux_tableComboBox.Size = new Size(151, 28);
            ux_tableComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // ux_openTableButton
            // 
            ux_openTableButton.Location = new Point(192, 33);
            ux_openTableButton.Name = "ux_openTableButton";
            ux_openTableButton.Size = new Size(94, 29);
            ux_openTableButton.TabIndex = 2;
            ux_openTableButton.Text = "View Table";
            ux_openTableButton.UseVisualStyleBackColor = true;
            ux_openTableButton.Click += ux_openTableButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ux_openTableButton);
            Controls.Add(label1);
            Controls.Add(ux_tableComboBox);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ux_tableComboBox;
        private Label label1;
        private Button ux_openTableButton;
    }
}