namespace Dex
{
    partial class FormColumnConfig
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbLinkTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMinInteger = new System.Windows.Forms.TextBox();
            this.tbMaxInteger = new System.Windows.Forms.TextBox();
            this.cbMinInteger = new System.Windows.Forms.CheckBox();
            this.cbMaxInteger = new System.Windows.Forms.CheckBox();
            this.cbMaxLength = new System.Windows.Forms.CheckBox();
            this.cbMinLength = new System.Windows.Forms.CheckBox();
            this.tbMaxLength = new System.Windows.Forms.TextBox();
            this.tbMinLength = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbLinkTable
            // 
            this.cmbLinkTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinkTable.FormattingEnabled = true;
            this.cmbLinkTable.Location = new System.Drawing.Point(89, 26);
            this.cmbLinkTable.Name = "cmbLinkTable";
            this.cmbLinkTable.Size = new System.Drawing.Size(121, 20);
            this.cmbLinkTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "링크테이블";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "숫자";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(223, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "문자열";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(467, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 16);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "데이터포인터";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaxInteger);
            this.groupBox1.Controls.Add(this.cbMinInteger);
            this.groupBox1.Controls.Add(this.tbMaxInteger);
            this.groupBox1.Controls.Add(this.tbMinInteger);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 216);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaxLength);
            this.groupBox2.Controls.Add(this.cbMinLength);
            this.groupBox2.Controls.Add(this.tbMinLength);
            this.groupBox2.Controls.Add(this.tbMaxLength);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(223, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 216);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbLinkTable);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(467, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 216);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // tbMinInteger
            // 
            this.tbMinInteger.Location = new System.Drawing.Point(103, 18);
            this.tbMinInteger.Name = "tbMinInteger";
            this.tbMinInteger.Size = new System.Drawing.Size(90, 21);
            this.tbMinInteger.TabIndex = 0;
            // 
            // tbMaxInteger
            // 
            this.tbMaxInteger.Location = new System.Drawing.Point(103, 45);
            this.tbMaxInteger.Name = "tbMaxInteger";
            this.tbMaxInteger.Size = new System.Drawing.Size(90, 21);
            this.tbMaxInteger.TabIndex = 1;
            // 
            // cbMinInteger
            // 
            this.cbMinInteger.AutoSize = true;
            this.cbMinInteger.Location = new System.Drawing.Point(11, 20);
            this.cbMinInteger.Name = "cbMinInteger";
            this.cbMinInteger.Size = new System.Drawing.Size(60, 16);
            this.cbMinInteger.TabIndex = 4;
            this.cbMinInteger.Text = "최소값";
            this.cbMinInteger.UseVisualStyleBackColor = true;
            // 
            // cbMaxInteger
            // 
            this.cbMaxInteger.AutoSize = true;
            this.cbMaxInteger.Location = new System.Drawing.Point(11, 45);
            this.cbMaxInteger.Name = "cbMaxInteger";
            this.cbMaxInteger.Size = new System.Drawing.Size(60, 16);
            this.cbMaxInteger.TabIndex = 5;
            this.cbMaxInteger.Text = "최대값";
            this.cbMaxInteger.UseVisualStyleBackColor = true;
            // 
            // cbMaxLength
            // 
            this.cbMaxLength.AutoSize = true;
            this.cbMaxLength.Location = new System.Drawing.Point(31, 43);
            this.cbMaxLength.Name = "cbMaxLength";
            this.cbMaxLength.Size = new System.Drawing.Size(72, 16);
            this.cbMaxLength.TabIndex = 9;
            this.cbMaxLength.Text = "최대길이";
            this.cbMaxLength.UseVisualStyleBackColor = true;
            // 
            // cbMinLength
            // 
            this.cbMinLength.AutoSize = true;
            this.cbMinLength.Location = new System.Drawing.Point(31, 18);
            this.cbMinLength.Name = "cbMinLength";
            this.cbMinLength.Size = new System.Drawing.Size(72, 16);
            this.cbMinLength.TabIndex = 8;
            this.cbMinLength.Text = "최소길이";
            this.cbMinLength.UseVisualStyleBackColor = true;
            // 
            // tbMaxLength
            // 
            this.tbMaxLength.Location = new System.Drawing.Point(123, 43);
            this.tbMaxLength.Name = "tbMaxLength";
            this.tbMaxLength.Size = new System.Drawing.Size(90, 21);
            this.tbMaxLength.TabIndex = 7;
            // 
            // tbMinLength
            // 
            this.tbMinLength.Location = new System.Drawing.Point(123, 16);
            this.tbMinLength.Name = "tbMinLength";
            this.tbMinLength.Size = new System.Drawing.Size(90, 21);
            this.tbMinLength.TabIndex = 6;
            // 
            // FormColumnConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColumnConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormColumnConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLinkTable;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbMaxInteger;
        private System.Windows.Forms.CheckBox cbMinInteger;
        private System.Windows.Forms.TextBox tbMaxInteger;
        private System.Windows.Forms.TextBox tbMinInteger;
        private System.Windows.Forms.CheckBox cbMaxLength;
        private System.Windows.Forms.CheckBox cbMinLength;
        private System.Windows.Forms.TextBox tbMinLength;
        private System.Windows.Forms.TextBox tbMaxLength;
    }
}