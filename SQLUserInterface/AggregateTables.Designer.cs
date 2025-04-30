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
            ux_StoreTable.Location = new Point(10, 115);
            ux_StoreTable.Margin = new Padding(3, 2, 3, 2);
            ux_StoreTable.MultiSelect = false;
            ux_StoreTable.Name = "ux_StoreTable";
            ux_StoreTable.RowHeadersVisible = false;
            ux_StoreTable.RowHeadersWidth = 51;
            ux_StoreTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ux_StoreTable.Size = new Size(1150, 473);
            ux_StoreTable.TabIndex = 4;
            // 
            // ux_findCoolestStores
            // 
            ux_findCoolestStores.Location = new Point(10, 90);
            ux_findCoolestStores.Margin = new Padding(3, 2, 3, 2);
            ux_findCoolestStores.Name = "ux_findCoolestStores";
            ux_findCoolestStores.Size = new Size(164, 22);
            ux_findCoolestStores.TabIndex = 6;
            ux_findCoolestStores.Text = "Find Coolest Stores";
            ux_findCoolestStores.UseVisualStyleBackColor = true;
            ux_findCoolestStores.Click += ux_findCoolestStores_Click;
            // 
            // ux_numGoldStars
            // 
            ux_numGoldStars.Location = new Point(179, 92);
            ux_numGoldStars.Margin = new Padding(3, 2, 3, 2);
            ux_numGoldStars.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            ux_numGoldStars.Name = "ux_numGoldStars";
            ux_numGoldStars.Size = new Size(53, 23);
            ux_numGoldStars.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 93);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Gold Stars";
            // 
            // ux_firstDateTimePicker
            // 
            ux_firstDateTimePicker.Location = new Point(10, 12);
            ux_firstDateTimePicker.Name = "ux_firstDateTimePicker";
            ux_firstDateTimePicker.Size = new Size(196, 23);
            ux_firstDateTimePicker.TabIndex = 9;
            ux_firstDateTimePicker.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 18);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "to";
            // 
            // ux_secondDateTimePicker
            // 
            ux_secondDateTimePicker.Location = new Point(236, 12);
            ux_secondDateTimePicker.Name = "ux_secondDateTimePicker";
            ux_secondDateTimePicker.Size = new Size(200, 23);
            ux_secondDateTimePicker.TabIndex = 11;
            ux_secondDateTimePicker.Value = new DateTime(1776, 12, 31, 0, 0, 0, 0);
            // 
            // ux_getMonthlyRankButton
            // 
            ux_getMonthlyRankButton.Location = new Point(10, 41);
            ux_getMonthlyRankButton.Name = "ux_getMonthlyRankButton";
            ux_getMonthlyRankButton.Size = new Size(426, 23);
            ux_getMonthlyRankButton.TabIndex = 12;
            ux_getMonthlyRankButton.Text = "Get Monthly Rank of Stores By Sales";
            ux_getMonthlyRankButton.UseVisualStyleBackColor = true;
            ux_getMonthlyRankButton.Click += ux_getMonthlyRankButton_Click;
            // 
            // AggregateTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 669);
            Controls.Add(ux_getMonthlyRankButton);
            Controls.Add(ux_secondDateTimePicker);
            Controls.Add(label1);
            Controls.Add(ux_firstDateTimePicker);
            Controls.Add(label2);
            Controls.Add(ux_numGoldStars);
            Controls.Add(ux_findCoolestStores);
            Controls.Add(ux_StoreTable);
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