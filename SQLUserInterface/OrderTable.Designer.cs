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
            ux_AddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)ux_OrderTable).BeginInit();
            SuspendLayout();
            // 
            // ux_OrderLabel
            // 
            ux_OrderLabel.AutoSize = true;
            ux_OrderLabel.Font = new Font("Segoe UI", 14F);
            ux_OrderLabel.Location = new Point(519, 123);
            ux_OrderLabel.Name = "ux_OrderLabel";
            ux_OrderLabel.Size = new Size(190, 32);
            ux_OrderLabel.TabIndex = 0;
            ux_OrderLabel.Text = "List of All Orders";
            ux_OrderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_OrderTable
            // 
            ux_OrderTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_OrderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_OrderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_OrderTable.Location = new Point(88, 228);
            ux_OrderTable.Margin = new Padding(3, 4, 3, 4);
            ux_OrderTable.Name = "ux_OrderTable";
            ux_OrderTable.RowHeadersWidth = 51;
            ux_OrderTable.Size = new Size(1064, 593);
            ux_OrderTable.TabIndex = 1;
            // 
            // ux_AddOrder
            // 
            ux_AddOrder.Location = new Point(545, 173);
            ux_AddOrder.Margin = new Padding(3, 4, 3, 4);
            ux_AddOrder.Name = "ux_AddOrder";
            ux_AddOrder.Size = new Size(128, 31);
            ux_AddOrder.TabIndex = 2;
            ux_AddOrder.Text = "Add Order";
            ux_AddOrder.UseVisualStyleBackColor = true;
            ux_AddOrder.Click += ux_AddOrder_Click;
            // 
            // OrderTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 891);
            Controls.Add(ux_AddOrder);
            Controls.Add(ux_OrderTable);
            Controls.Add(ux_OrderLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderTable";
            ((System.ComponentModel.ISupportInitialize)ux_OrderTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ux_OrderLabel;
        private DataGridView ux_OrderTable;
        private Button ux_AddOrder;
    }
}
