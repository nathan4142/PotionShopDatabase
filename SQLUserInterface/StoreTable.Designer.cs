using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQLUserInterface
{
    partial class StoreTable
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
            ux_AddStore = new Button();
            ux_EditStore = new Button();
            ux_DeleteStore = new Button();
            ux_StoreTable = new DataGridView();
            ux_findCoolestStores = new Button();
            ux_numGoldStars = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ux_numGoldStars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(828, 34);
            label1.TabIndex = 0;
            label1.Text = "List of All Stores";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ux_AddStore
            // 
            ux_AddStore.Location = new Point(12, 78);
            ux_AddStore.Name = "ux_AddStore";
            ux_AddStore.Size = new Size(94, 29);
            ux_AddStore.TabIndex = 1;
            ux_AddStore.Text = "Add Store";
            ux_AddStore.UseVisualStyleBackColor = true;
            // 
            // ux_EditStore
            // 
            ux_EditStore.Location = new Point(397, 78);
            ux_EditStore.Name = "ux_EditStore";
            ux_EditStore.Size = new Size(94, 29);
            ux_EditStore.TabIndex = 2;
            ux_EditStore.Text = "Edit Store";
            ux_EditStore.UseVisualStyleBackColor = true;
            // 
            // ux_DeleteStore
            // 
            ux_DeleteStore.Location = new Point(760, 78);
            ux_DeleteStore.Name = "ux_DeleteStore";
            ux_DeleteStore.Size = new Size(118, 29);
            ux_DeleteStore.TabIndex = 3;
            ux_DeleteStore.Text = "Delete Store";
            ux_DeleteStore.UseVisualStyleBackColor = true;
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
            // StoreTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(ux_numGoldStars);
            Controls.Add(ux_findCoolestStores);
            Controls.Add(ux_StoreTable);
            Controls.Add(ux_DeleteStore);
            Controls.Add(ux_EditStore);
            Controls.Add(ux_AddStore);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StoreTable";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ux_numGoldStars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ux_AddStore;
        private Button ux_EditStore;
        private Button ux_DeleteStore;
        private DataGridView ux_StoreTable;
        private Button ux_findCoolestStores;
        private NumericUpDown ux_numGoldStars;
        private Label label2;
    }
}
