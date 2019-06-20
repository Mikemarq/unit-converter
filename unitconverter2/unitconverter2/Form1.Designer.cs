namespace unitconverter2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLengthFrom = new System.Windows.Forms.TextBox();
            this.txtLengthTo = new System.Windows.Forms.TextBox();
            this.lblLengthTo = new System.Windows.Forms.Label();
            this.lblLengthFrom = new System.Windows.Forms.Label();
            this.lstLengthTo = new System.Windows.Forms.ListBox();
            this.lstLengthFrom = new System.Windows.Forms.ListBox();
            this.btnLengthTo = new System.Windows.Forms.Button();
            this.btnLengthFrom = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLengthFrom);
            this.tabPage1.Controls.Add(this.btnLengthTo);
            this.tabPage1.Controls.Add(this.lstLengthFrom);
            this.tabPage1.Controls.Add(this.lstLengthTo);
            this.tabPage1.Controls.Add(this.lblLengthFrom);
            this.tabPage1.Controls.Add(this.lblLengthTo);
            this.tabPage1.Controls.Add(this.txtLengthTo);
            this.tabPage1.Controls.Add(this.txtLengthFrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Length";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Weight";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLengthFrom
            // 
            this.txtLengthFrom.Location = new System.Drawing.Point(39, 57);
            this.txtLengthFrom.Name = "txtLengthFrom";
            this.txtLengthFrom.Size = new System.Drawing.Size(100, 20);
            this.txtLengthFrom.TabIndex = 0;
            // 
            // txtLengthTo
            // 
            this.txtLengthTo.Location = new System.Drawing.Point(288, 57);
            this.txtLengthTo.Name = "txtLengthTo";
            this.txtLengthTo.Size = new System.Drawing.Size(100, 20);
            this.txtLengthTo.TabIndex = 1;
            // 
            // lblLengthTo
            // 
            this.lblLengthTo.AutoSize = true;
            this.lblLengthTo.Location = new System.Drawing.Point(285, 41);
            this.lblLengthTo.Name = "lblLengthTo";
            this.lblLengthTo.Size = new System.Drawing.Size(20, 13);
            this.lblLengthTo.TabIndex = 2;
            this.lblLengthTo.Text = "To";
            // 
            // lblLengthFrom
            // 
            this.lblLengthFrom.AutoSize = true;
            this.lblLengthFrom.Location = new System.Drawing.Point(39, 41);
            this.lblLengthFrom.Name = "lblLengthFrom";
            this.lblLengthFrom.Size = new System.Drawing.Size(30, 13);
            this.lblLengthFrom.TabIndex = 3;
            this.lblLengthFrom.Text = "From";
            // 
            // lstLengthTo
            // 
            this.lstLengthTo.FormattingEnabled = true;
            this.lstLengthTo.Items.AddRange(new object[] {
            "Meter",
            "Kilometer",
            "Centimeter",
            "Millimeter",
            "Micrometer",
            "Nanometer",
            "Mile",
            "Yard",
            "Foot",
            "Inch"});
            this.lstLengthTo.Location = new System.Drawing.Point(288, 94);
            this.lstLengthTo.Name = "lstLengthTo";
            this.lstLengthTo.Size = new System.Drawing.Size(120, 134);
            this.lstLengthTo.TabIndex = 4;
            // 
            // lstLengthFrom
            // 
            this.lstLengthFrom.FormattingEnabled = true;
            this.lstLengthFrom.Items.AddRange(new object[] {
            "Meter",
            "Kilometer",
            "Centimeter",
            "Millimeter",
            "Micrometer",
            "Nanometer",
            "Mile",
            "Yard",
            "Foot",
            "Inch"});
            this.lstLengthFrom.Location = new System.Drawing.Point(39, 94);
            this.lstLengthFrom.Name = "lstLengthFrom";
            this.lstLengthFrom.Size = new System.Drawing.Size(120, 134);
            this.lstLengthFrom.TabIndex = 5;
            // 
            // btnLengthTo
            // 
            this.btnLengthTo.Location = new System.Drawing.Point(288, 234);
            this.btnLengthTo.Name = "btnLengthTo";
            this.btnLengthTo.Size = new System.Drawing.Size(120, 42);
            this.btnLengthTo.TabIndex = 6;
            this.btnLengthTo.Text = "Clear";
            this.btnLengthTo.UseVisualStyleBackColor = true;
            // 
            // btnLengthFrom
            // 
            this.btnLengthFrom.Location = new System.Drawing.Point(39, 234);
            this.btnLengthFrom.Name = "btnLengthFrom";
            this.btnLengthFrom.Size = new System.Drawing.Size(120, 42);
            this.btnLengthFrom.TabIndex = 7;
            this.btnLengthFrom.Text = "Convert";
            this.btnLengthFrom.UseVisualStyleBackColor = true;
            this.btnLengthFrom.Click += new System.EventHandler(this.BtnLengthFrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLengthFrom;
        private System.Windows.Forms.Button btnLengthTo;
        private System.Windows.Forms.ListBox lstLengthFrom;
        private System.Windows.Forms.ListBox lstLengthTo;
        private System.Windows.Forms.Label lblLengthFrom;
        private System.Windows.Forms.Label lblLengthTo;
        private System.Windows.Forms.TextBox txtLengthTo;
        private System.Windows.Forms.TextBox txtLengthFrom;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

