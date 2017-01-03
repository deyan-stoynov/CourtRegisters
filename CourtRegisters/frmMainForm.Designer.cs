namespace CourtRegisters
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.регистърЗаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разпределениеНаПомещениятаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколитеЗаДеняНаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постъпилитеНаддавателниПредложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиПротоколиЗаДеняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наддавателиПоДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиЧСИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистърЗаToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.иToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(257, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // регистърЗаToolStripMenuItem
            // 
            this.регистърЗаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разпределениеНаПомещениятаToolStripMenuItem,
            this.протоколитеЗаДеняНаToolStripMenuItem,
            this.постъпилитеНаддавателниПредложенияToolStripMenuItem});
            this.регистърЗаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("регистърЗаToolStripMenuItem.Image")));
            this.регистърЗаToolStripMenuItem.Name = "регистърЗаToolStripMenuItem";
            this.регистърЗаToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.регистърЗаToolStripMenuItem.Text = "Регистър за:";
            // 
            // разпределениеНаПомещениятаToolStripMenuItem
            // 
            this.разпределениеНаПомещениятаToolStripMenuItem.Name = "разпределениеНаПомещениятаToolStripMenuItem";
            this.разпределениеНаПомещениятаToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.разпределениеНаПомещениятаToolStripMenuItem.Text = "Разпределение на помещенията...";
            this.разпределениеНаПомещениятаToolStripMenuItem.Click += new System.EventHandler(this.разпределениеНаПомещениятаToolStripMenuItem_Click);
            // 
            // протоколитеЗаДеняНаToolStripMenuItem
            // 
            this.протоколитеЗаДеняНаToolStripMenuItem.Name = "протоколитеЗаДеняНаToolStripMenuItem";
            this.протоколитеЗаДеняНаToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.протоколитеЗаДеняНаToolStripMenuItem.Text = "Протоколите за деня на разгласяване..";
            this.протоколитеЗаДеняНаToolStripMenuItem.Click += new System.EventHandler(this.протоколитеЗаДеняНаToolStripMenuItem_Click);
            // 
            // постъпилитеНаддавателниПредложенияToolStripMenuItem
            // 
            this.постъпилитеНаддавателниПредложенияToolStripMenuItem.Name = "постъпилитеНаддавателниПредложенияToolStripMenuItem";
            this.постъпилитеНаддавателниПредложенияToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.постъпилитеНаддавателниПредложенияToolStripMenuItem.Text = "Постъпилите наддавателни предложения...";
            this.постъпилитеНаддавателниПредложенияToolStripMenuItem.Click += new System.EventHandler(this.постъпилитеНаддавателниПредложенияToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всичкиToolStripMenuItem1,
            this.всичкиПротоколиЗаДеняToolStripMenuItem,
            this.всичкиToolStripMenuItem,
            this.наддавателиПоДатаToolStripMenuItem,
            this.всичкиЧСИToolStripMenuItem});
            this.справкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкиToolStripMenuItem.Image")));
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // всичкиToolStripMenuItem1
            // 
            this.всичкиToolStripMenuItem1.Name = "всичкиToolStripMenuItem1";
            this.всичкиToolStripMenuItem1.Size = new System.Drawing.Size(285, 22);
            this.всичкиToolStripMenuItem1.Text = "Всички разпределения на помещения";
            this.всичкиToolStripMenuItem1.Click += new System.EventHandler(this.всичкиToolStripMenuItem1_Click);
            // 
            // всичкиПротоколиЗаДеняToolStripMenuItem
            // 
            this.всичкиПротоколиЗаДеняToolStripMenuItem.Name = "всичкиПротоколиЗаДеняToolStripMenuItem";
            this.всичкиПротоколиЗаДеняToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.всичкиПротоколиЗаДеняToolStripMenuItem.Text = "Всички Протоколи за деня";
            this.всичкиПротоколиЗаДеняToolStripMenuItem.Click += new System.EventHandler(this.всичкиПротоколиЗаДеняToolStripMenuItem_Click);
            // 
            // всичкиToolStripMenuItem
            // 
            this.всичкиToolStripMenuItem.Name = "всичкиToolStripMenuItem";
            this.всичкиToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.всичкиToolStripMenuItem.Text = "Всички Наддаватели";
            this.всичкиToolStripMenuItem.Click += new System.EventHandler(this.всичкиToolStripMenuItem_Click);
            // 
            // наддавателиПоДатаToolStripMenuItem
            // 
            this.наддавателиПоДатаToolStripMenuItem.Name = "наддавателиПоДатаToolStripMenuItem";
            this.наддавателиПоДатаToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.наддавателиПоДатаToolStripMenuItem.Text = "Наддаватели по дата";
            this.наддавателиПоДатаToolStripMenuItem.Click += new System.EventHandler(this.наддавателиПоДатаToolStripMenuItem_Click);
            // 
            // всичкиЧСИToolStripMenuItem
            // 
            this.всичкиЧСИToolStripMenuItem.Name = "всичкиЧСИToolStripMenuItem";
            this.всичкиЧСИToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.всичкиЧСИToolStripMenuItem.Text = "Всички СИ";
            this.всичкиЧСИToolStripMenuItem.Click += new System.EventHandler(this.всичкиЧСИToolStripMenuItem_Click);
            // 
            // иToolStripMenuItem
            // 
            this.иToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("иToolStripMenuItem.Image")));
            this.иToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.иToolStripMenuItem.Name = "иToolStripMenuItem";
            this.иToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.иToolStripMenuItem.Text = "Изход";
            this.иToolStripMenuItem.Click += new System.EventHandler(this.иToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 48);
            this.ControlBox = false;
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForm";
            this.Text = "Регистри";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainForm_KeyDown);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem регистърЗаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разпределениеНаПомещениятаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постъпилитеНаддавателниПредложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколитеЗаДеняНаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem всичкиПротоколиЗаДеняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наддавателиПоДатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиЧСИToolStripMenuItem;
    }
}

