namespace CourtRegisters
{
    partial class frmAllSaleLocation
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
            this.tblRegisterPublicSalesRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBidders = new System.Windows.Forms.DataGridView();
            this.chbCanceled = new System.Windows.Forms.CheckBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicSaleDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicSaleLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canceled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegisterPublicSalesRoomBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidders)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRegisterPublicSalesRoomBindingSource
            // 
            this.tblRegisterPublicSalesRoomBindingSource.DataSource = typeof(CourtRegisters.tblRegisterPublicSalesRoom);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbCanceled);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 41);
            this.panel1.TabIndex = 4;
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
            this.IdCSI,
            this.PublicSaleDateTime,
            this.PublicSaleLocation,
            this.PostingDate,
            this.Canceled,
            this.Remarks,
            this.tblCSI,
            this.Edit});
            this.dgvBidders.DataSource = this.tblRegisterPublicSalesRoomBindingSource;
            this.dgvBidders.Location = new System.Drawing.Point(0, 47);
            this.dgvBidders.MultiSelect = false;
            this.dgvBidders.Name = "dgvBidders";
            this.dgvBidders.ReadOnly = true;
            this.dgvBidders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBidders.Size = new System.Drawing.Size(907, 366);
            this.dgvBidders.TabIndex = 3;
            this.dgvBidders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBidders_CellContentClick);
            // 
            // chbCanceled
            // 
            this.chbCanceled.AutoSize = true;
            this.chbCanceled.Location = new System.Drawing.Point(12, 14);
            this.chbCanceled.Name = "chbCanceled";
            this.chbCanceled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbCanceled.Size = new System.Drawing.Size(92, 17);
            this.chbCanceled.TabIndex = 23;
            this.chbCanceled.Text = "Само спрени";
            this.chbCanceled.UseVisualStyleBackColor = true;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(773, 10);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(112, 23);
            this.btnClearFilter.TabIndex = 22;
            this.btnClearFilter.Text = "Изчисти Филтър";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(655, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 23);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Филтър";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.IncomeNumber.Width = 55;
            // 
            // IdCSI
            // 
            this.IdCSI.DataPropertyName = "IdCSI";
            this.IdCSI.HeaderText = "IdCSI";
            this.IdCSI.Name = "IdCSI";
            this.IdCSI.ReadOnly = true;
            this.IdCSI.Visible = false;
            // 
            // PublicSaleDateTime
            // 
            this.PublicSaleDateTime.DataPropertyName = "PublicSaleDateTime";
            this.PublicSaleDateTime.HeaderText = "Дата и час на публичната продан";
            this.PublicSaleDateTime.Name = "PublicSaleDateTime";
            this.PublicSaleDateTime.ReadOnly = true;
            this.PublicSaleDateTime.Width = 150;
            // 
            // PublicSaleLocation
            // 
            this.PublicSaleLocation.DataPropertyName = "PublicSaleLocation";
            this.PublicSaleLocation.HeaderText = "Местонахождение на зала";
            this.PublicSaleLocation.Name = "PublicSaleLocation";
            this.PublicSaleLocation.ReadOnly = true;
            this.PublicSaleLocation.Width = 150;
            // 
            // PostingDate
            // 
            this.PostingDate.DataPropertyName = "PostingDate";
            this.PostingDate.HeaderText = "Дата на постъпване";
            this.PostingDate.Name = "PostingDate";
            this.PostingDate.ReadOnly = true;
            // 
            // Canceled
            // 
            this.Canceled.DataPropertyName = "Canceled";
            this.Canceled.HeaderText = "Отменена";
            this.Canceled.Name = "Canceled";
            this.Canceled.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Забележка";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 150;
            // 
            // tblCSI
            // 
            this.tblCSI.DataPropertyName = "tblCSI";
            this.tblCSI.HeaderText = "СИ насрочил публичната продан";
            this.tblCSI.Name = "tblCSI";
            this.tblCSI.ReadOnly = true;
            this.tblCSI.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Редакция";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 70;
            // 
            // frmAllSaleLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBidders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllSaleLocation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Всички разпределения на помещения";
            this.Load += new System.EventHandler(this.frmAllSaleLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegisterPublicSalesRoomBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBidders;
        private System.Windows.Forms.BindingSource tblRegisterPublicSalesRoomBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbCanceled;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicSaleDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicSaleLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostingDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Canceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCSI;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}