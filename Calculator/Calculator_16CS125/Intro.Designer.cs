namespace Calculator_16CS125
{
    partial class Intro
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmeticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trignometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arithmeticToolStripMenuItem,
            this.trignometricToolStripMenuItem,
            this.factorialToolStripMenuItem,
            this.primeNumbersToolStripMenuItem,
            this.bMIToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // arithmeticToolStripMenuItem
            // 
            this.arithmeticToolStripMenuItem.Name = "arithmeticToolStripMenuItem";
            this.arithmeticToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.arithmeticToolStripMenuItem.Text = "Arithmetic";
            this.arithmeticToolStripMenuItem.Click += new System.EventHandler(this.arithmeticToolStripMenuItem_Click);
            // 
            // trignometricToolStripMenuItem
            // 
            this.trignometricToolStripMenuItem.Name = "trignometricToolStripMenuItem";
            this.trignometricToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.trignometricToolStripMenuItem.Text = "Trignometric";
            this.trignometricToolStripMenuItem.Click += new System.EventHandler(this.trignometricToolStripMenuItem_Click);
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // primeNumbersToolStripMenuItem
            // 
            this.primeNumbersToolStripMenuItem.Name = "primeNumbersToolStripMenuItem";
            this.primeNumbersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.primeNumbersToolStripMenuItem.Text = "Prime Numbers";
            this.primeNumbersToolStripMenuItem.Click += new System.EventHandler(this.primeNumbersToolStripMenuItem_Click);
            // 
            // bMIToolStripMenuItem
            // 
            this.bMIToolStripMenuItem.Name = "bMIToolStripMenuItem";
            this.bMIToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bMIToolStripMenuItem.Text = "BMI";
            this.bMIToolStripMenuItem.Click += new System.EventHandler(this.bMIToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1});
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.closeToolStripMenuItem.Text = "close";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Intro";
            this.Text = "Intro";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arithmeticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trignometricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
    }
}



