namespace SQLUserInterface
{
    partial class OrderTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ux_OrderLabel = new Label();
            ux_OrderTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ux_OrderTable).BeginInit();
            SuspendLayout();
            // 
            // ux_OrderLabel
            // 
            ux_OrderLabel.AutoSize = true;
            ux_OrderLabel.Font = new Font("Segoe UI", 14F);
            ux_OrderLabel.Location = new Point(454, 92);
            ux_OrderLabel.Name = "ux_OrderLabel";
            ux_OrderLabel.Size = new Size(151, 25);
            ux_OrderLabel.TabIndex = 0;
            ux_OrderLabel.Text = "List of All Orders";
            ux_OrderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_OrderTable
            // 
            ux_OrderTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_OrderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_OrderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_OrderTable.Location = new Point(77, 171);
            ux_OrderTable.Name = "ux_OrderTable";
            ux_OrderTable.Size = new Size(931, 445);
            ux_OrderTable.TabIndex = 1;
            // 
            // OrderTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 668);
            Controls.Add(ux_OrderTable);
            Controls.Add(ux_OrderLabel);
            Name = "OrderTable";
            ((System.ComponentModel.ISupportInitialize)ux_OrderTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ux_OrderLabel;
        private DataGridView ux_OrderTable;
    }
}
