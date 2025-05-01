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
            ux_CreateStoreItem = new Button();
            ux_EditStoreItemQuantity = new Button();
            ux_EditStoreItemUnitListPrice = new Button();
            ux_DeleteStoreItem = new Button();
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
            // ux_CreateStoreItem
            // 
            ux_CreateStoreItem.Location = new Point(61, 71);
            ux_CreateStoreItem.Name = "ux_CreateStoreItem";
            ux_CreateStoreItem.Size = new Size(111, 23);
            ux_CreateStoreItem.TabIndex = 2;
            ux_CreateStoreItem.Text = "Add Store Item";
            ux_CreateStoreItem.UseVisualStyleBackColor = true;
            ux_CreateStoreItem.Click += ux_CreateStoreItem_Click;
            // 
            // ux_EditStoreItemQuantity
            // 
            ux_EditStoreItemQuantity.Location = new Point(273, 71);
            ux_EditStoreItemQuantity.Name = "ux_EditStoreItemQuantity";
            ux_EditStoreItemQuantity.Size = new Size(94, 23);
            ux_EditStoreItemQuantity.TabIndex = 3;
            ux_EditStoreItemQuantity.Text = "Edit Quantity";
            ux_EditStoreItemQuantity.UseVisualStyleBackColor = true;
            ux_EditStoreItemQuantity.Click += ux_EditStoreItemQuantity_Click;
            // 
            // ux_EditStoreItemUnitListPrice
            // 
            ux_EditStoreItemUnitListPrice.Location = new Point(514, 71);
            ux_EditStoreItemUnitListPrice.Name = "ux_EditStoreItemUnitListPrice";
            ux_EditStoreItemUnitListPrice.Size = new Size(128, 23);
            ux_EditStoreItemUnitListPrice.TabIndex = 4;
            ux_EditStoreItemUnitListPrice.Text = "Edit Unit List Price";
            ux_EditStoreItemUnitListPrice.UseVisualStyleBackColor = true;
            ux_EditStoreItemUnitListPrice.Click += ux_EditStoreItemUnitListPrice_Click;
            // 
            // ux_DeleteStoreItem
            // 
            ux_DeleteStoreItem.Location = new Point(754, 71);
            ux_DeleteStoreItem.Name = "ux_DeleteStoreItem";
            ux_DeleteStoreItem.Size = new Size(75, 23);
            ux_DeleteStoreItem.TabIndex = 5;
            ux_DeleteStoreItem.Text = "Delete Row";
            ux_DeleteStoreItem.UseVisualStyleBackColor = true;
            ux_DeleteStoreItem.Click += ux_DeleteStoreItem_Click;
            // 
            // StoreItemTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 550);
            Controls.Add(ux_DeleteStoreItem);
            Controls.Add(ux_EditStoreItemUnitListPrice);
            Controls.Add(ux_EditStoreItemQuantity);
            Controls.Add(ux_CreateStoreItem);
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
        private Button ux_CreateStoreItem;
        private Button ux_EditStoreItemQuantity;
        private Button ux_EditStoreItemUnitListPrice;
        private Button ux_DeleteStoreItem;
    }
}