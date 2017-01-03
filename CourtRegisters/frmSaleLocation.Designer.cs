namespace CourtRegisters
{
    partial class frmSaleLocation
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
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaleLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSaleTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.dtpPostingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCSI = new System.Windows.Forms.ComboBox();
            this.lblCSIName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Location = new System.Drawing.Point(211, 368);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(129, 23);
            this.btnSaveAndNew.TabIndex = 6;
            this.btnSaveAndNew.Text = "Запиши и създай нов";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "(*) Задължителни полета";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(147, 272);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(341, 48);
            this.txtRemark.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ЗАБЕЛЕЖКА:";
            // 
            // txtSaleLocation
            // 
            this.txtSaleLocation.Enabled = false;
            this.txtSaleLocation.Location = new System.Drawing.Point(147, 218);
            this.txtSaleLocation.Multiline = true;
            this.txtSaleLocation.Name = "txtSaleLocation";
            this.txtSaleLocation.Size = new System.Drawing.Size(341, 48);
            this.txtSaleLocation.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Местонахождение\r\nна зала:";
            // 
            // dtpSaleTime
            // 
            this.dtpSaleTime.CustomFormat = "dd.MM.yyyy \'г.\' HH:mm \'ч.\'";
            this.dtpSaleTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpSaleTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleTime.Location = new System.Drawing.Point(147, 192);
            this.dtpSaleTime.Name = "dtpSaleTime";
            this.dtpSaleTime.Size = new System.Drawing.Size(143, 20);
            this.dtpSaleTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата и час на \r\nпубличната продан:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(88, 368);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(116, 23);
            this.btnSaveAndClose.TabIndex = 100;
            this.btnSaveAndClose.Text = "Запиши и затвори";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpPostingDate
            // 
            this.dtpPostingDate.CustomFormat = "dd.MM.yyyy \'г.\'";
            this.dtpPostingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPostingDate.Enabled = false;
            this.dtpPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPostingDate.Location = new System.Drawing.Point(147, 326);
            this.dtpPostingDate.Name = "dtpPostingDate";
            this.dtpPostingDate.Size = new System.Drawing.Size(143, 20);
            this.dtpPostingDate.TabIndex = 0;
            this.dtpPostingDate.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата на постъпване:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистър за Разпределение на помещенията,\r\nопределени от адм. секретар за провежд" +
    "ане\r\nна публичните продани от СИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Име на СИ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "№ на СИ, насрочил \r\nпубличната продан:";
            // 
            // cbCSI
            // 
            this.cbCSI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSI.FormattingEnabled = true;
            this.cbCSI.Location = new System.Drawing.Point(147, 132);
            this.cbCSI.Name = "cbCSI";
            this.cbCSI.Size = new System.Drawing.Size(143, 21);
            this.cbCSI.TabIndex = 1;
            this.cbCSI.SelectedIndexChanged += new System.EventHandler(this.cbCSI_SelectedIndexChanged);
            // 
            // lblCSIName
            // 
            this.lblCSIName.AutoSize = true;
            this.lblCSIName.Location = new System.Drawing.Point(144, 167);
            this.lblCSIName.Name = "lblCSIName";
            this.lblCSIName.Size = new System.Drawing.Size(0, 13);
            this.lblCSIName.TabIndex = 0;
            // 
            // frmSaleLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(510, 416);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCSI);
            this.Controls.Add(this.lblCSIName);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSaleLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpSaleTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.dtpPostingDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaleLocation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "        ";
            this.Load += new System.EventHandler(this.frmSaleLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.DateTimePicker dtpPostingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSaleTime;
        private System.Windows.Forms.TextBox txtSaleLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCSI;
        private System.Windows.Forms.Label lblCSIName;
    }
}