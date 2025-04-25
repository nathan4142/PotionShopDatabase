namespace SQLUserInterface
{
    partial class ChatIsThisReal
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
            ux_chatBox = new ListBox();
            SuspendLayout();
            // 
            // ux_chatBox
            // 
            ux_chatBox.FormattingEnabled = true;
            ux_chatBox.ItemHeight = 15;
            ux_chatBox.Location = new Point(12, 12);
            ux_chatBox.Name = "ux_chatBox";
            ux_chatBox.Size = new Size(776, 424);
            ux_chatBox.TabIndex = 0;
            // 
            // ChatIsThisReal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ux_chatBox);
            KeyPreview = true;
            Name = "ChatIsThisReal";
            Text = "ChatIsThisReal";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ux_chatBox;
    }
}