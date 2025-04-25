namespace SQLUserInterface
{
    partial class AggregateTables
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
            ux_StoreTable = new DataGridView();
            ux_findCoolestStores = new Button();
            ux_numGoldStars = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ux_numGoldStars).BeginInit();
            SuspendLayout();
            // 
            // ux_StoreTable
            // 
            ux_StoreTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_StoreTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_StoreTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_StoreTable.Location = new Point(12, 153);
            ux_StoreTable.MultiSelect = false;
            ux_StoreTable.Name = "ux_StoreTable";
            ux_StoreTable.RowHeadersVisible = false;
            ux_StoreTable.RowHeadersWidth = 51;
            ux_StoreTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_StoreTable.Size = new Size(866, 338);
            ux_StoreTable.TabIndex = 4;
            // 
            // ux_findCoolestStores
            // 
            ux_findCoolestStores.Location = new Point(12, 120);
            ux_findCoolestStores.Name = "ux_findCoolestStores";
            ux_findCoolestStores.Size = new Size(187, 29);
            ux_findCoolestStores.TabIndex = 6;
            ux_findCoolestStores.Text = "Find Coolest Stores";
            ux_findCoolestStores.UseVisualStyleBackColor = true;
            ux_findCoolestStores.Click += ux_findCoolestStores_Click;
            // 
            // ux_numGoldStars
            // 
            ux_numGoldStars.Location = new Point(205, 122);
            ux_numGoldStars.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            ux_numGoldStars.Name = "ux_numGoldStars";
            ux_numGoldStars.Size = new Size(61, 27);
            ux_numGoldStars.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 124);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 8;
            label2.Text = "Gold Stars";
            // 
            // AggregateTables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(ux_numGoldStars);
            Controls.Add(ux_findCoolestStores);
            Controls.Add(ux_StoreTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AggregateTables";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ux_numGoldStars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView ux_StoreTable;
        private Button ux_findCoolestStores;
        private NumericUpDown ux_numGoldStars;
        private Label label2;
    }
}