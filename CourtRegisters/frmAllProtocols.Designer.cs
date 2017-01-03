namespace CourtRegisters
{
    partial class frmAllProtocols
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
            this.components = new System.ComponentModel.Container();
            this.tblRegisterProtocolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCSI = new System.Windows.Forms.ComboBox();
            this.lblProtocols = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvProtocols = new System.Windows.Forms.DataGridView();
            this.chbCanceled = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canceled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegisterProtocolBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocols)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRegisterProtocolBindingSource
            // 
            this.tblRegisterProtocolBindingSource.DataSource = typeof(CourtRegisters.tblRegisterProtocol);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbCanceled);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCSI);
            this.panel1.Controls.Add(this.lblProtocols);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 71);
            this.panel1.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(499, 9);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(152, 20);
            this.dtpTo.TabIndex = 19;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Име на СИ:";
            // 
            // cbCSI
            // 
            this.cbCSI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSI.FormattingEnabled = true;
            this.cbCSI.Location = new System.Drawing.Point(84, 9);
            this.cbCSI.Name = "cbCSI";
            this.cbCSI.Size = new System.Drawing.Size(187, 21);
            this.cbCSI.TabIndex = 17;
            // 
            // lblProtocols
            // 
            this.lblProtocols.AutoSize = true;
            this.lblProtocols.Location = new System.Drawing.Point(281, 13);
            this.lblProtocols.Name = "lblProtocols";
            this.lblProtocols.Size = new System.Drawing.Size(23, 13);
            this.lblProtocols.TabIndex = 16;
            this.lblProtocols.Text = "От:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(310, 9);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(152, 20);
            this.dtpFrom.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(784, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 51);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Принтирай";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(666, 37);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(112, 23);
            this.btnClearFilter.TabIndex = 13;
            this.btnClearFilter.Text = "Изчисти Филтър";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(666, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Филтър";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvProtocols
            // 
            this.dgvProtocols.AllowUserToAddRows = false;
            this.dgvProtocols.AllowUserToDeleteRows = false;
            this.dgvProtocols.AllowUserToOrderColumns = true;
            this.dgvProtocols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProtocols.AutoGenerateColumns = false;
            this.dgvProtocols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IncomeNumber,
            this.CaseNumber,
            this.PostingDate,
            this.tblCSI,
            this.Canceled,
            this.Remarks,
            this.IdCSI,
            this.Edit});
            this.dgvProtocols.DataSource = this.tblRegisterProtocolBindingSource;
            this.dgvProtocols.Location = new System.Drawing.Point(0, 77);
            this.dgvProtocols.Name = "dgvProtocols";
            this.dgvProtocols.ReadOnly = true;
            this.dgvProtocols.Size = new System.Drawing.Size(878, 357);
            this.dgvProtocols.TabIndex = 0;
            this.dgvProtocols.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProtocols_CellContentClick);
            // 
            // chbCanceled
            // 
            this.chbCanceled.AutoSize = true;
            this.chbCanceled.Location = new System.Drawing.Point(7, 41);
            this.chbCanceled.Name = "chbCanceled";
            this.chbCanceled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbCanceled.Size = new System.Drawing.Size(92, 17);
            this.chbCanceled.TabIndex = 20;
            this.chbCanceled.Text = "Само спрени";
            this.chbCanceled.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // IncomeNumber
            // 
            this.IncomeNumber.DataPropertyName = "IncomeNumber";
            this.IncomeNumber.HeaderText = "Входящ №";
            this.IncomeNumber.Name = "IncomeNumber";
            this.IncomeNumber.ReadOnly = true;
            this.IncomeNumber.Width = 70;
            // 
            // CaseNumber
            // 
            this.CaseNumber.DataPropertyName = "CaseNumber";
            this.CaseNumber.HeaderText = "№ на дело";
            this.CaseNumber.Name = "CaseNumber";
            this.CaseNumber.ReadOnly = true;
            // 
            // PostingDate
            // 
            this.PostingDate.DataPropertyName = "PostingDate";
            this.PostingDate.HeaderText = "Дата на постъпване";
            this.PostingDate.Name = "PostingDate";
            this.PostingDate.ReadOnly = true;
            // 
            // tblCSI
            // 
            this.tblCSI.DataPropertyName = "tblCSI";
            this.tblCSI.HeaderText = "СИ насрочил публичната прода";
            this.tblCSI.Name = "tblCSI";
            this.tblCSI.ReadOnly = true;
            this.tblCSI.Width = 230;
            // 
            // Canceled
            // 
            this.Canceled.DataPropertyName = "Canceled";
            this.Canceled.HeaderText = "Спряна продажба";
            this.Canceled.Name = "Canceled";
            this.Canceled.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "ЗАБЕЛЕЖКА";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 130;
            // 
            // IdCSI
            // 
            this.IdCSI.DataPropertyName = "IdCSI";
            this.IdCSI.HeaderText = "IdCSI";
            this.IdCSI.Name = "IdCSI";
            this.IdCSI.ReadOnly = true;
            this.IdCSI.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Редакция";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // frmAllProtocols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProtocols);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllProtocols";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Всички Протоколи за деня";
            this.Load += new System.EventHandler(this.frmAllProtocols_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegisterProtocolBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProtocols;
        private System.Windows.Forms.BindingSource tblRegisterProtocolBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblProtocols;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCSI;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbCanceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCSI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Canceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCSI;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}