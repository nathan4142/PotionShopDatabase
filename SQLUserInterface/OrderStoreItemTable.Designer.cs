namespace SQLUserInterface
{
    partial class OrderStoreItemTable
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
            ux_OrderStoreItemTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ux_OrderStoreItemTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(827, 35);
            label1.TabIndex = 0;
            label1.Text = "List of Order Store Items";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_OrderStoreItemTable
            // 
            ux_OrderStoreItemTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_OrderStoreItemTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_OrderStoreItemTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_OrderStoreItemTable.Location = new Point(11, 129);
            ux_OrderStoreItemTable.MultiSelect = false;
            ux_OrderStoreItemTable.Name = "ux_OrderStoreItemTable";
            ux_OrderStoreItemTable.RowHeadersVisible = false;
            ux_OrderStoreItemTable.RowHeadersWidth = 51;
            ux_OrderStoreItemTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_OrderStoreItemTable.Size = new Size(866, 339);
            ux_OrderStoreItemTable.TabIndex = 4;
            // 
            // OrderStoreItemTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ux_OrderStoreItemTable);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderStoreItemTable";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_OrderStoreItemTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ux_AddItem;
        private Button ux_EditItem;
        private Button ux_DeleteItem;
        private DataGridView ux_OrderStoreItemTable;
    }
}