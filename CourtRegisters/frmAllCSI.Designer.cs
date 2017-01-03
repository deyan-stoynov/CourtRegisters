namespace CourtRegisters
{
    partial class frmAllCSI
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gvCSIs = new System.Windows.Forms.DataGridView();
            this.IdCSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSINumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSIName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCSIs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Създай нов";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gvCSIs
            // 
            this.gvCSIs.AllowUserToAddRows = false;
            this.gvCSIs.AllowUserToDeleteRows = false;
            this.gvCSIs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCSIs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCSIs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCSI,
            this.CSINumber,
            this.CSIName,
            this.IsActive,
            this.Edit,
            this.Delete});
            this.gvCSIs.Location = new System.Drawing.Point(0, 36);
            this.gvCSIs.Name = "gvCSIs";
            this.gvCSIs.ReadOnly = true;
            this.gvCSIs.Size = new System.Drawing.Size(704, 491);
            this.gvCSIs.TabIndex = 0;
            this.gvCSIs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCSIs_CellContentClick);
            // 
            // IdCSI
            // 
            this.IdCSI.DataPropertyName = "IdCSI";
            this.IdCSI.HeaderText = "IdCSI";
            this.IdCSI.Name = "IdCSI";
            this.IdCSI.ReadOnly = true;
            this.IdCSI.Visible = false;
            // 
            // CSINumber
            // 
            this.CSINumber.DataPropertyName = "CSINumber";
            this.CSINumber.HeaderText = "Номер на СИ";
            this.CSINumber.Name = "CSINumber";
            this.CSINumber.ReadOnly = true;
            // 
            // CSIName
            // 
            this.CSIName.DataPropertyName = "CSIName";
            this.CSIName.HeaderText = "Име на СИ";
            this.CSIName.Name = "CSIName";
            this.CSIName.ReadOnly = true;
            this.CSIName.Width = 250;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Активен";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Редакция";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Изтриване";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmAllCSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 527);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gvCSIs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllCSI";
            this.ShowIcon = false;
            this.Text = "Всички СИ";
            this.Load += new System.EventHandler(this.frmAllCSI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCSIs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCSIs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSINumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSIName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}