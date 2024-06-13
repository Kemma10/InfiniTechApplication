namespace InfiniTechApplication
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCtrlShiftSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripMenuItem,
            this.openStripMenuItem,
            this.saveStripMenuItem,
            this.saveAsCtrlShiftSToolStripMenuItem,
            this.printStripMenuItem,
            this.exitStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newStripMenuItem
            // 
            this.newStripMenuItem.Name = "newStripMenuItem";
            this.newStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.newStripMenuItem.Text = "New";
            this.newStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // openStripMenuItem
            // 
            this.openStripMenuItem.Name = "openStripMenuItem";
            this.openStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.openStripMenuItem.Text = "Open";
            this.openStripMenuItem.Click += new System.EventHandler(this.openStripMenuItem_Click);
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveStripMenuItem.Text = "Save";
            this.saveStripMenuItem.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // saveAsCtrlShiftSToolStripMenuItem
            // 
            this.saveAsCtrlShiftSToolStripMenuItem.Name = "saveAsCtrlShiftSToolStripMenuItem";
            this.saveAsCtrlShiftSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsCtrlShiftSToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveAsCtrlShiftSToolStripMenuItem.Text = "Save As";
            this.saveAsCtrlShiftSToolStripMenuItem.Click += new System.EventHandler(this.saveAsCtrlShiftSToolStripMenuItem_Click);
            // 
            // printStripMenuItem
            // 
            this.printStripMenuItem.Name = "printStripMenuItem";
            this.printStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.printStripMenuItem.Text = "Print";
            this.printStripMenuItem.Click += new System.EventHandler(this.printStripMenuItem_Click);
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.exitStripMenuItem.Text = "Exit";
            this.exitStripMenuItem.Click += new System.EventHandler(this.exitStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(568, 518);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 546);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsCtrlShiftSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
    }
}

