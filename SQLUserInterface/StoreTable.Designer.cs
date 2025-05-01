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
            ux_StoreTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.Location = new Point(44, 31);
            label1.Name = "label1";
            label1.Size = new Size(724, 26);
            label1.TabIndex = 0;
            label1.Text = "List of All Stores";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            ux_StoreTable.Size = new Size(758, 254);
            ux_StoreTable.TabIndex = 4;
            // 
            // StoreTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ux_StoreTable);
            Controls.Add(label1);
            Name = "StoreTable";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ux_StoreTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView ux_StoreTable;
    }
}
