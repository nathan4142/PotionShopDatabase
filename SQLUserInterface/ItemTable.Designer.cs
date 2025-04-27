namespace SQLUserInterface
{
    partial class ItemTable
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
            ux_AddItem = new Button();
            ux_EditItem = new Button();
            ux_DeleteItem = new Button();
            ux_ItemTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ux_ItemTable).BeginInit();
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
            label1.Text = "List of All Items";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_AddItem
            // 
            ux_AddItem.Location = new Point(10, 58);
            ux_AddItem.Margin = new Padding(3, 2, 3, 2);
            ux_AddItem.Name = "ux_AddItem";
            ux_AddItem.Size = new Size(110, 22);
            ux_AddItem.TabIndex = 1;
            ux_AddItem.Text = "Add Item";
            ux_AddItem.UseVisualStyleBackColor = true;
            // 
            // ux_EditItem
            // 
            ux_EditItem.Location = new Point(347, 58);
            ux_EditItem.Margin = new Padding(3, 2, 3, 2);
            ux_EditItem.Name = "ux_EditItem";
            ux_EditItem.Size = new Size(109, 22);
            ux_EditItem.TabIndex = 2;
            ux_EditItem.Text = "Edit Item";
            ux_EditItem.UseVisualStyleBackColor = true;
            // 
            // ux_DeleteItem
            // 
            ux_DeleteItem.Location = new Point(642, 58);
            ux_DeleteItem.Margin = new Padding(3, 2, 3, 2);
            ux_DeleteItem.Name = "ux_DeleteItem";
            ux_DeleteItem.Size = new Size(126, 22);
            ux_DeleteItem.TabIndex = 3;
            ux_DeleteItem.Text = "Delete Item";
            ux_DeleteItem.UseVisualStyleBackColor = true;
            // 
            // ux_ItemTable
            // 
            ux_ItemTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_ItemTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_ItemTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_ItemTable.Location = new Point(10, 97);
            ux_ItemTable.Margin = new Padding(3, 2, 3, 2);
            ux_ItemTable.MultiSelect = false;
            ux_ItemTable.Name = "ux_ItemTable";
            ux_ItemTable.RowHeadersVisible = false;
            ux_ItemTable.RowHeadersWidth = 51;
            ux_ItemTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_ItemTable.Size = new Size(758, 254);
            ux_ItemTable.TabIndex = 4;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ux_ItemTable);
            Controls.Add(ux_DeleteItem);
            Controls.Add(ux_EditItem);
            Controls.Add(ux_AddItem);
            Controls.Add(label1);
            Name = "Items";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_ItemTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ux_AddItem;
        private Button ux_EditItem;
        private Button ux_DeleteItem;
        private DataGridView ux_ItemTable;
    }
}