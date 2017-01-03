namespace CourtRegisters
{
    partial class frmProtocol
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCSI = new System.Windows.Forms.ComboBox();
            this.lblCSIName = new System.Windows.Forms.Label();
            this.txtCaseNumberPart = new System.Windows.Forms.MaskedTextBox();
            this.txtCaseCodePart = new System.Windows.Forms.MaskedTextBox();
            this.txtCaseSIPart = new System.Windows.Forms.MaskedTextBox();
            this.txtCaseYearPart = new System.Windows.Forms.MaskedTextBox();
            this.txtCaseFirstPart = new System.Windows.Forms.MaskedTextBox();
            this.chbCanceled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистър на протоколите за деня на \r\nразгласяване на обявленията и актове за \r\nпо" +
    "ставяне на обявления";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(332, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy \'г.\'";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата на постъпване:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(142, 238);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(304, 48);
            this.txtRemark.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ЗАБЕЛЕЖКА:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "№ на \r\nизпълнителното \r\nдело:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "(*) Задължителни полета";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(186, 328);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(129, 23);
            this.btnSaveAndNew.TabIndex = 8;
            this.btnSaveAndNew.Text = "Запиши и създай нов";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(53, 328);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(116, 23);
            this.btnSaveAndClose.TabIndex = 100;
            this.btnSaveAndClose.Text = "Запиши и затвори";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Име на СИ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "№ на СИ, насрочил \r\nпубличната продан:";
            // 
            // cbCSI
            // 
            this.cbCSI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSI.FormattingEnabled = true;
            this.cbCSI.Location = new System.Drawing.Point(142, 130);
            this.cbCSI.Name = "cbCSI";
            this.cbCSI.Size = new System.Drawing.Size(143, 21);
            this.cbCSI.TabIndex = 1;
            this.cbCSI.SelectedIndexChanged += new System.EventHandler(this.cbCSI_SelectedIndexChanged);
            // 
            // lblCSIName
            // 
            this.lblCSIName.AutoSize = true;
            this.lblCSIName.Location = new System.Drawing.Point(139, 162);
            this.lblCSIName.Name = "lblCSIName";
            this.lblCSIName.Size = new System.Drawing.Size(0, 13);
            this.lblCSIName.TabIndex = 0;
            // 
            // txtCaseNumberPart
            // 
            this.txtCaseNumberPart.Location = new System.Drawing.Point(295, 208);
            this.txtCaseNumberPart.Mask = "00000";
            this.txtCaseNumberPart.Name = "txtCaseNumberPart";
            this.txtCaseNumberPart.Size = new System.Drawing.Size(67, 20);
            this.txtCaseNumberPart.TabIndex = 6;
            // 
            // txtCaseCodePart
            // 
            this.txtCaseCodePart.Location = new System.Drawing.Point(258, 208);
            this.txtCaseCodePart.Mask = "00";
            this.txtCaseCodePart.Name = "txtCaseCodePart";
            this.txtCaseCodePart.Size = new System.Drawing.Size(31, 20);
            this.txtCaseCodePart.TabIndex = 5;
            this.txtCaseCodePart.Text = "04";
            // 
            // txtCaseSIPart
            // 
            this.txtCaseSIPart.Location = new System.Drawing.Point(216, 208);
            this.txtCaseSIPart.Mask = "000";
            this.txtCaseSIPart.Name = "txtCaseSIPart";
            this.txtCaseSIPart.Size = new System.Drawing.Size(36, 20);
            this.txtCaseSIPart.TabIndex = 4;
            // 
            // txtCaseYearPart
            // 
            this.txtCaseYearPart.Location = new System.Drawing.Point(179, 208);
            this.txtCaseYearPart.Mask = "00";
            this.txtCaseYearPart.Name = "txtCaseYearPart";
            this.txtCaseYearPart.Size = new System.Drawing.Size(31, 20);
            this.txtCaseYearPart.TabIndex = 3;
            // 
            // txtCaseFirstPart
            // 
            this.txtCaseFirstPart.Location = new System.Drawing.Point(142, 208);
            this.txtCaseFirstPart.Mask = "00";
            this.txtCaseFirstPart.Name = "txtCaseFirstPart";
            this.txtCaseFirstPart.Size = new System.Drawing.Size(31, 20);
            this.txtCaseFirstPart.TabIndex = 2;
            this.txtCaseFirstPart.Text = "20";
            // 
            // chbCanceled
            // 
            this.chbCanceled.AutoSize = true;
            this.chbCanceled.ForeColor = System.Drawing.Color.Red;
            this.chbCanceled.Location = new System.Drawing.Point(328, 297);
            this.chbCanceled.Name = "chbCanceled";
            this.chbCanceled.Size = new System.Drawing.Size(116, 17);
            this.chbCanceled.TabIndex = 102;
            this.chbCanceled.Text = "Спряна продажба";
            this.chbCanceled.UseVisualStyleBackColor = true;
            // 
            // frmProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(468, 376);
            this.Controls.Add(this.chbCanceled);
            this.Controls.Add(this.txtCaseFirstPart);
            this.Controls.Add(this.txtCaseNumberPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCaseCodePart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCaseYearPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCaseSIPart);
            this.Controls.Add(this.cbCSI);
            this.Controls.Add(this.lblCSIName);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProtocol";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmProtocol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCSI;
        private System.Windows.Forms.Label lblCSIName;
        private System.Windows.Forms.MaskedTextBox txtCaseNumberPart;
        private System.Windows.Forms.MaskedTextBox txtCaseCodePart;
        private System.Windows.Forms.MaskedTextBox txtCaseSIPart;
        private System.Windows.Forms.MaskedTextBox txtCaseYearPart;
        private System.Windows.Forms.MaskedTextBox txtCaseFirstPart;
        private System.Windows.Forms.CheckBox chbCanceled;
    }
}