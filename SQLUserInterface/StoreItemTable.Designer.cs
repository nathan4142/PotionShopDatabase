namespace SQLUserInterface
{
    partial class StoreItemTable
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
            label1 = new Label();
            ux_StoreItemsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ux_StoreItemsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(360, 44);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "List of Store Items";
            // 
            // ux_StoreItemsTable
            // 
            ux_StoreItemsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_StoreItemsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_StoreItemsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_StoreItemsTable.Location = new Point(61, 100);
            ux_StoreItemsTable.Name = "ux_StoreItemsTable";
            ux_StoreItemsTable.Size = new Size(768, 413);
            ux_StoreItemsTable.TabIndex = 1;
            // 
            // StoreItemTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 550);
            Controls.Add(ux_StoreItemsTable);
            Controls.Add(label1);
            Name = "StoreItemTable";
            Text = "StoreItemTable";
            ((System.ComponentModel.ISupportInitialize)ux_StoreItemsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ux_StoreItemsTable;
    }
}