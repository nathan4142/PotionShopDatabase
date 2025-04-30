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
            ux_firstDateTimePicker = new DateTimePicker();
            label1 = new Label();
            ux_secondDateTimePicker = new DateTimePicker();
            ux_getMonthlyRankButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ux_numGoldStars).BeginInit();
            SuspendLayout();
            // 
            // ux_StoreTable
            // 
            ux_StoreTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ux_StoreTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ux_StoreTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ux_StoreTable.Location = new Point(11, 153);
            ux_StoreTable.MultiSelect = false;
            ux_StoreTable.Name = "ux_StoreTable";
            ux_StoreTable.RowHeadersVisible = false;
            ux_StoreTable.RowHeadersWidth = 51;
            ux_StoreTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_StoreTable.Size = new Size(1314, 631);
            ux_StoreTable.TabIndex = 4;
            // 
            // ux_findCoolestStores
            // 
            ux_findCoolestStores.Location = new Point(11, 120);
            ux_findCoolestStores.Name = "ux_findCoolestStores";
            ux_findCoolestStores.Size = new Size(187, 29);
            ux_findCoolestStores.TabIndex = 6;
            ux_findCoolestStores.Text = "Find Coolest Stores";
            ux_findCoolestStores.UseVisualStyleBackColor = true;
            ux_findCoolestStores.Click += ux_findCoolestStores_Click;
            // 
            // ux_numGoldStars
            // 
            ux_numGoldStars.Location = new Point(205, 123);
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
            // ux_firstDateTimePicker
            // 
            ux_firstDateTimePicker.Location = new Point(11, 16);
            ux_firstDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            ux_firstDateTimePicker.Name = "ux_firstDateTimePicker";
            ux_firstDateTimePicker.Size = new Size(223, 27);
            ux_firstDateTimePicker.TabIndex = 9;
            ux_firstDateTimePicker.Value = new DateTime(1760, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 24);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 10;
            label1.Text = "to";
            // 
            // ux_secondDateTimePicker
            // 
            ux_secondDateTimePicker.Location = new Point(270, 16);
            ux_secondDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            ux_secondDateTimePicker.Name = "ux_secondDateTimePicker";
            ux_secondDateTimePicker.Size = new Size(228, 27);
            ux_secondDateTimePicker.TabIndex = 11;
            ux_secondDateTimePicker.Value = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            // 
            // ux_getMonthlyRankButton
            // 
            ux_getMonthlyRankButton.Location = new Point(11, 55);
            ux_getMonthlyRankButton.Margin = new Padding(3, 4, 3, 4);
            ux_getMonthlyRankButton.Name = "ux_getMonthlyRankButton";
            ux_getMonthlyRankButton.Size = new Size(487, 31);
            ux_getMonthlyRankButton.TabIndex = 12;
            ux_getMonthlyRankButton.Text = "Get Monthly Rank of Stores By Sales";
            ux_getMonthlyRankButton.UseVisualStyleBackColor = true;
            ux_getMonthlyRankButton.Click += ux_getMonthlyRankButton_Click;
            // 
            // AggregateTables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 892);
            Controls.Add(ux_getMonthlyRankButton);
            Controls.Add(ux_secondDateTimePicker);
            Controls.Add(label1);
            Controls.Add(ux_firstDateTimePicker);
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
        private DateTimePicker ux_firstDateTimePicker;
        private Label label1;
        private DateTimePicker ux_secondDateTimePicker;
        private Button ux_getMonthlyRankButton;
    }
}