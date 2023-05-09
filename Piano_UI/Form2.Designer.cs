namespace Piano_UI
{
    partial class Form2
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
            popupSongName = new TextBox();
            OK = new Button();
            CANCEL = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter a Name for your Song";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // popupSongName
            // 
            popupSongName.Location = new Point(12, 44);
            popupSongName.Name = "popupSongName";
            popupSongName.Size = new Size(242, 23);
            popupSongName.TabIndex = 1;
            // 
            // OK
            // 
            OK.DialogResult = DialogResult.OK;
            OK.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OK.Location = new Point(12, 89);
            OK.Name = "OK";
            OK.Size = new Size(114, 59);
            OK.TabIndex = 2;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            // 
            // CANCEL
            // 
            CANCEL.DialogResult = DialogResult.Cancel;
            CANCEL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CANCEL.Location = new Point(142, 89);
            CANCEL.Name = "CANCEL";
            CANCEL.Size = new Size(112, 59);
            CANCEL.TabIndex = 3;
            CANCEL.Text = "CANCEL";
            CANCEL.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 160);
            Controls.Add(CANCEL);
            Controls.Add(OK);
            Controls.Add(popupSongName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Song Name";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox popupSongName;
        private Button OK;
        private Button CANCEL;
    }
}