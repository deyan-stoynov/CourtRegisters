namespace CourtRegisters
{
    partial class frmAllBidders
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
            this.dgvBidders = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmsCopyCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копирайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblRegisterBidderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCSI = new System.Windows.Forms.ComboBox();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidders)).BeginInit();
            this.cmsCopyCell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegisterBidderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBidders
            // 
            this.dgvBidders.AllowUserToAddRows = false;
            this.dgvBidders.AllowUserToDeleteRows = false;
            this.dgvBidders.AllowUserToOrderColumns = true;
            this.dgvBidders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBidders.AutoGenerateColumns = false;
            this.dgvBidders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBidders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IncomeNumber,
            this.tblCSI,
            this.CaseNumber,
            this.IdCSI,
            this.BidderName,
            this.BidderAddress,
            this.PostingDate,
            this.Edit});
            this.dgvBidders.ContextMenuStrip = this.cmsCopyCell;
            this.dgvBidders.DataSource = this.tblRegisterBidderBindingSource;
            this.dgvBidders.Location = new System.Drawing.Point(0, 46);
            this.dgvBidders.MultiSelect = false;
            this.dgvBidders.Name = "dgvBidders";
            this.dgvBidders.ReadOnly = true;
            this.dgvBidders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBidders.Size = new System.Drawing.Size(815, 216);
            this.dgvBidders.TabIndex = 2;
            this.dgvBidders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBidders_CellContentClick);
            this.dgvBidders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBidders_CellContentDoubleClick);
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
            // 
            // tblCSI
            // 
            this.tblCSI.DataPropertyName = "tblCSI";
            this.tblCSI.HeaderText = "Име на СИ";
            this.tblCSI.Name = "tblCSI";
            this.tblCSI.ReadOnly = true;
            this.tblCSI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CaseNumber
            // 
            this.CaseNumber.DataPropertyName = "CaseNumber";
            this.CaseNumber.HeaderText = "№ на дело";
            this.CaseNumber.Name = "CaseNumber";
            this.CaseNumber.ReadOnly = true;
            // 
            // IdCSI
            // 
            this.IdCSI.DataPropertyName = "IdCSI";
            this.IdCSI.HeaderText = "IdCSI";
            this.IdCSI.Name = "IdCSI";
            this.IdCSI.ReadOnly = true;
            this.IdCSI.Visible = false;
            // 
            // BidderName
            // 
            this.BidderName.DataPropertyName = "BidderName";
            this.BidderName.HeaderText = "Име на наддавача";
            this.BidderName.Name = "BidderName";
            this.BidderName.ReadOnly = true;
            // 
            // BidderAddress
            // 
            this.BidderAddress.DataPropertyName = "BidderAddress";
            this.BidderAddress.HeaderText = "Адрес на наддавача";
            this.BidderAddress.Name = "BidderAddress";
            this.BidderAddress.ReadOnly = true;
            // 
            // PostingDate
            // 
            this.PostingDate.DataPropertyName = "PostingDate";
            this.PostingDate.HeaderText = "Дата";
            this.PostingDate.Name = "PostingDate";
            this.PostingDate.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Редакция";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // cmsCopyCell
            // 
            this.cmsCopyCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копирайToolStripMenuItem});
            this.cmsCopyCell.Name = "cmsCopyCell";
            this.cmsCopyCell.ShowImageMargin = false;
            this.cmsCopyCell.Size = new System.Drawing.Size(98, 26);
            this.cmsCopyCell.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCopyCell_Opening);
            // 
            // копирайToolStripMenuItem
            // 
            this.копирайToolStripMenuItem.Name = "копирайToolStripMenuItem";
            this.копирайToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.копирайToolStripMenuItem.Text = "Копирай";
            // 
            // tblRegisterBidderBindingSource
            // 
            this.tblRegisterBidderBindingSource.DataSource = typeof(CourtRegisters.tblRegisterBidder);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCSI);
            this.panel1.Controls.Add(this.txtCaseNumber);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 39);
            this.panel1.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(723, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Принтирай";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(605, 8);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(112, 23);
            this.btnClearFilter.TabIndex = 13;
            this.btnClearFilter.Text = "Изчисти Филтър";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(524, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Филтър";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Име на СИ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер на дело:";
            // 
            // cbCSI
            // 
            this.cbCSI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSI.FormattingEnabled = true;
            this.cbCSI.Location = new System.Drawing.Point(81, 9);
            this.cbCSI.Name = "cbCSI";
            this.cbCSI.Size = new System.Drawing.Size(187, 21);
            this.cbCSI.TabIndex = 9;
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Location = new System.Drawing.Point(379, 9);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCaseNumber.TabIndex = 8;
            // 
            // frmAllBidders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBidders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllBidders";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Всички наддаватели";
            this.Load += new System.EventHandler(this.frmAllBidders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidders)).EndInit();
            this.cmsCopyCell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegisterBidderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBidders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCSIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tblRegisterBidderBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCSIDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsCopyCell;
        private System.Windows.Forms.ToolStripMenuItem копирайToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCSI;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidderAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostingDate;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}