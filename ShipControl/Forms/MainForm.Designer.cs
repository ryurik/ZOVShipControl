namespace ShipControl
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMainStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItemShips = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItemShipsControl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAboutMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainStrip
            // 
            this.menuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItemFile,
            this.menuToolStripMenuItemShips,
            this.toolStripMenuItemAboutMain});
            this.menuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.menuMainStrip.Name = "menuMainStrip";
            this.menuMainStrip.Size = new System.Drawing.Size(1219, 24);
            this.menuMainStrip.TabIndex = 0;
            this.menuMainStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItemFile
            // 
            this.menuToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItemExit});
            this.menuToolStripMenuItemFile.Name = "menuToolStripMenuItemFile";
            this.menuToolStripMenuItemFile.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItemFile.Text = "Файл";
            // 
            // menuToolStripMenuItemExit
            // 
            this.menuToolStripMenuItemExit.Name = "menuToolStripMenuItemExit";
            this.menuToolStripMenuItemExit.Size = new System.Drawing.Size(107, 22);
            this.menuToolStripMenuItemExit.Text = "Выход";
            this.menuToolStripMenuItemExit.Click += new System.EventHandler(this.menuToolStripMenuItemExit_Click);
            // 
            // menuToolStripMenuItemShips
            // 
            this.menuToolStripMenuItemShips.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItemShipsControl});
            this.menuToolStripMenuItemShips.Name = "menuToolStripMenuItemShips";
            this.menuToolStripMenuItemShips.Size = new System.Drawing.Size(67, 20);
            this.menuToolStripMenuItemShips.Text = "Отгрузки";
            // 
            // menuToolStripMenuItemShipsControl
            // 
            this.menuToolStripMenuItemShipsControl.Name = "menuToolStripMenuItemShipsControl";
            this.menuToolStripMenuItemShipsControl.Size = new System.Drawing.Size(172, 22);
            this.menuToolStripMenuItemShipsControl.Text = "Контроль отгрузок";
            this.menuToolStripMenuItemShipsControl.Click += new System.EventHandler(this.menuToolStripMenuItemShipsControl_Click);
            // 
            // toolStripMenuItemAboutMain
            // 
            this.toolStripMenuItemAboutMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemToolStripMenuItemAbout});
            this.toolStripMenuItemAboutMain.Name = "toolStripMenuItemAboutMain";
            this.toolStripMenuItemAboutMain.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItemAboutMain.Text = "?";
            // 
            // menuItemToolStripMenuItemAbout
            // 
            this.menuItemToolStripMenuItemAbout.Name = "menuItemToolStripMenuItemAbout";
            this.menuItemToolStripMenuItemAbout.Size = new System.Drawing.Size(152, 22);
            this.menuItemToolStripMenuItemAbout.Text = "О программе";
            this.menuItemToolStripMenuItemAbout.Click += new System.EventHandler(this.menuItemToolStripMenuItemAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 556);
            this.Controls.Add(this.menuMainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMainStrip;
            this.Name = "MainForm";
            this.Text = "Контроль отгрузок";
            this.menuMainStrip.ResumeLayout(false);
            this.menuMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItemShips;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItemShipsControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAboutMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolStripMenuItemAbout;
    }
}

