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
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.rbString = new System.Windows.Forms.RadioButton();
            this.rbDataPointer = new System.Windows.Forms.RadioButton();
            this.gbNumber = new System.Windows.Forms.GroupBox();
            this.cbMaxInteger = new System.Windows.Forms.CheckBox();
            this.cbMinInteger = new System.Windows.Forms.CheckBox();
            this.tbMaxInteger = new System.Windows.Forms.TextBox();
            this.tbMinInteger = new System.Windows.Forms.TextBox();
            this.gbString = new System.Windows.Forms.GroupBox();
            this.cbMaxLength = new System.Windows.Forms.CheckBox();
            this.cbMinLength = new System.Windows.Forms.CheckBox();
            this.tbMinLength = new System.Windows.Forms.TextBox();
            this.tbMaxLength = new System.Windows.Forms.TextBox();
            this.gbDataPointer = new System.Windows.Forms.GroupBox();
            this.rbTime = new System.Windows.Forms.RadioButton();
            this.rbWeekday = new System.Windows.Forms.RadioButton();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbNumber.SuspendLayout();
            this.gbString.SuspendLayout();
            this.gbDataPointer.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 353);
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
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Checked = true;
            this.rbNumber.Location = new System.Drawing.Point(12, 109);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(47, 16);
            this.rbNumber.TabIndex = 5;
            this.rbNumber.TabStop = true;
            this.rbNumber.Text = "숫자";
            this.rbNumber.UseVisualStyleBackColor = true;
            this.rbNumber.CheckedChanged += new System.EventHandler(this.rbNumber_CheckedChanged);
            // 
            // rbString
            // 
            this.rbString.AutoSize = true;
            this.rbString.Location = new System.Drawing.Point(222, 109);
            this.rbString.Name = "rbString";
            this.rbString.Size = new System.Drawing.Size(59, 16);
            this.rbString.TabIndex = 6;
            this.rbString.Text = "문자열";
            this.rbString.UseVisualStyleBackColor = true;
            this.rbString.CheckedChanged += new System.EventHandler(this.rbString_CheckedChanged);
            // 
            // rbDataPointer
            // 
            this.rbDataPointer.AutoSize = true;
            this.rbDataPointer.Location = new System.Drawing.Point(466, 109);
            this.rbDataPointer.Name = "rbDataPointer";
            this.rbDataPointer.Size = new System.Drawing.Size(95, 16);
            this.rbDataPointer.TabIndex = 7;
            this.rbDataPointer.Text = "데이터포인터";
            this.rbDataPointer.UseVisualStyleBackColor = true;
            this.rbDataPointer.CheckedChanged += new System.EventHandler(this.rbDataPointer_CheckedChanged);
            // 
            // gbNumber
            // 
            this.gbNumber.Controls.Add(this.cbMaxInteger);
            this.gbNumber.Controls.Add(this.cbMinInteger);
            this.gbNumber.Controls.Add(this.tbMaxInteger);
            this.gbNumber.Controls.Add(this.tbMinInteger);
            this.gbNumber.Location = new System.Drawing.Point(12, 131);
            this.gbNumber.Name = "gbNumber";
            this.gbNumber.Size = new System.Drawing.Size(204, 216);
            this.gbNumber.TabIndex = 8;
            this.gbNumber.TabStop = false;
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
            // tbMaxInteger
            // 
            this.tbMaxInteger.Location = new System.Drawing.Point(103, 45);
            this.tbMaxInteger.Name = "tbMaxInteger";
            this.tbMaxInteger.Size = new System.Drawing.Size(90, 21);
            this.tbMaxInteger.TabIndex = 1;
            // 
            // tbMinInteger
            // 
            this.tbMinInteger.Location = new System.Drawing.Point(103, 18);
            this.tbMinInteger.Name = "tbMinInteger";
            this.tbMinInteger.Size = new System.Drawing.Size(90, 21);
            this.tbMinInteger.TabIndex = 0;
            // 
            // gbString
            // 
            this.gbString.Controls.Add(this.cbMaxLength);
            this.gbString.Controls.Add(this.cbMinLength);
            this.gbString.Controls.Add(this.tbMinLength);
            this.gbString.Controls.Add(this.tbMaxLength);
            this.gbString.Enabled = false;
            this.gbString.Location = new System.Drawing.Point(222, 131);
            this.gbString.Name = "gbString";
            this.gbString.Size = new System.Drawing.Size(238, 216);
            this.gbString.TabIndex = 9;
            this.gbString.TabStop = false;
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
            // tbMinLength
            // 
            this.tbMinLength.Location = new System.Drawing.Point(123, 16);
            this.tbMinLength.Name = "tbMinLength";
            this.tbMinLength.Size = new System.Drawing.Size(90, 21);
            this.tbMinLength.TabIndex = 6;
            // 
            // tbMaxLength
            // 
            this.tbMaxLength.Location = new System.Drawing.Point(123, 43);
            this.tbMaxLength.Name = "tbMaxLength";
            this.tbMaxLength.Size = new System.Drawing.Size(90, 21);
            this.tbMaxLength.TabIndex = 7;
            // 
            // gbDataPointer
            // 
            this.gbDataPointer.Controls.Add(this.label1);
            this.gbDataPointer.Controls.Add(this.cmbLinkTable);
            this.gbDataPointer.Enabled = false;
            this.gbDataPointer.Location = new System.Drawing.Point(466, 131);
            this.gbDataPointer.Name = "gbDataPointer";
            this.gbDataPointer.Size = new System.Drawing.Size(228, 216);
            this.gbDataPointer.TabIndex = 9;
            this.gbDataPointer.TabStop = false;
            // 
            // rbTime
            // 
            this.rbTime.AutoSize = true;
            this.rbTime.Location = new System.Drawing.Point(716, 109);
            this.rbTime.Name = "rbTime";
            this.rbTime.Size = new System.Drawing.Size(47, 16);
            this.rbTime.TabIndex = 10;
            this.rbTime.Text = "시간";
            this.rbTime.UseVisualStyleBackColor = true;
            this.rbTime.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // rbWeekday
            // 
            this.rbWeekday.AutoSize = true;
            this.rbWeekday.Location = new System.Drawing.Point(828, 109);
            this.rbWeekday.Name = "rbWeekday";
            this.rbWeekday.Size = new System.Drawing.Size(47, 16);
            this.rbWeekday.TabIndex = 11;
            this.rbWeekday.TabStop = true;
            this.rbWeekday.Text = "요일";
            this.rbWeekday.UseVisualStyleBackColor = true;
            this.rbWeekday.CheckedChanged += new System.EventHandler(this.rbWeekday_CheckedChanged);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(87, 12);
            this.tbDesc.MaxLength = 4096;
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(578, 68);
            this.tbDesc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "설명";
            // 
            // FormColumnConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.rbWeekday);
            this.Controls.Add(this.rbTime);
            this.Controls.Add(this.gbDataPointer);
            this.Controls.Add(this.gbString);
            this.Controls.Add(this.gbNumber);
            this.Controls.Add(this.rbDataPointer);
            this.Controls.Add(this.rbString);
            this.Controls.Add(this.rbNumber);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColumnConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormColumnConfig";
            this.gbNumber.ResumeLayout(false);
            this.gbNumber.PerformLayout();
            this.gbString.ResumeLayout(false);
            this.gbString.PerformLayout();
            this.gbDataPointer.ResumeLayout(false);
            this.gbDataPointer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLinkTable;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.RadioButton rbDataPointer;
        private System.Windows.Forms.GroupBox gbNumber;
        private System.Windows.Forms.GroupBox gbString;
        private System.Windows.Forms.GroupBox gbDataPointer;
        private System.Windows.Forms.CheckBox cbMaxInteger;
        private System.Windows.Forms.CheckBox cbMinInteger;
        private System.Windows.Forms.TextBox tbMaxInteger;
        private System.Windows.Forms.TextBox tbMinInteger;
        private System.Windows.Forms.CheckBox cbMaxLength;
        private System.Windows.Forms.CheckBox cbMinLength;
        private System.Windows.Forms.TextBox tbMinLength;
        private System.Windows.Forms.TextBox tbMaxLength;
        private System.Windows.Forms.RadioButton rbTime;
        private System.Windows.Forms.RadioButton rbWeekday;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label2;
    }
}