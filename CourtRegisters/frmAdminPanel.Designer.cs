namespace CourtRegisters
{
    partial class frmAdminPanel
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
            this.txtCourt = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelGenFile = new System.Windows.Forms.Panel();
            this.panelPassword.SuspendLayout();
            this.panelGenFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код на Съд:";
            // 
            // txtCourt
            // 
            this.txtCourt.Location = new System.Drawing.Point(168, 5);
            this.txtCourt.Name = "txtCourt";
            this.txtCourt.Size = new System.Drawing.Size(114, 20);
            this.txtCourt.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(288, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Генерирай Файл";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(288, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Влез";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(114, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Парола:";
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.btnLogin);
            this.panelPassword.Controls.Add(this.label2);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPassword.Location = new System.Drawing.Point(0, 0);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(495, 34);
            this.panelPassword.TabIndex = 6;
            // 
            // panelGenFile
            // 
            this.panelGenFile.Controls.Add(this.btnGenerate);
            this.panelGenFile.Controls.Add(this.label1);
            this.panelGenFile.Controls.Add(this.txtCourt);
            this.panelGenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenFile.Location = new System.Drawing.Point(0, 34);
            this.panelGenFile.Name = "panelGenFile";
            this.panelGenFile.Size = new System.Drawing.Size(495, 38);
            this.panelGenFile.TabIndex = 7;
            this.panelGenFile.Visible = false;
            // 
            // frmAdminPanel
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 76);
            this.Controls.Add(this.panelGenFile);
            this.Controls.Add(this.panelPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminPanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администриране";
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelGenFile.ResumeLayout(false);
            this.panelGenFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourt;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelGenFile;
    }
}