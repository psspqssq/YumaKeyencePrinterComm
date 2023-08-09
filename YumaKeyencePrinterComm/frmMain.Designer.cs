namespace YumaKeyencePrinterComm
{
    partial class frmMain
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
            txtPath = new TextBox();
            label1 = new Label();
            btnFile = new Button();
            lblCode = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(82, 12);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(160, 23);
            txtPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Source File";
            // 
            // btnFile
            // 
            btnFile.Location = new Point(248, 12);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(38, 24);
            btnFile.TabIndex = 2;
            btnFile.Text = "...";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.Location = new Point(129, 78);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(0, 21);
            lblCode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 60);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Code";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 114);
            Controls.Add(label2);
            Controls.Add(lblCode);
            Controls.Add(btnFile);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Name = "frmMain";
            Text = "Printer Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private Label label1;
        private Button btnFile;
        private Label lblCode;
        private Label label2;
    }
}