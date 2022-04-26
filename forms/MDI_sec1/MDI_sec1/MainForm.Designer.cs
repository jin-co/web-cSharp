
namespace MDI_sec1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inclass01CalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futureValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutidimentionalArraysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringManipulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assignmentsToolStripMenuItem,
            this.inClassToolStripMenuItem,
            this.workToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(203, 34);
            this.SaveMenuItem.Text = "&Save";
            // 
            // assignmentsToolStripMenuItem
            // 
            this.assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            this.assignmentsToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.assignmentsToolStripMenuItem.Text = "Assignments";
            // 
            // inClassToolStripMenuItem
            // 
            this.inClassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclass01CalculatorToolStripMenuItem});
            this.inClassToolStripMenuItem.Name = "inClassToolStripMenuItem";
            this.inClassToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.inClassToolStripMenuItem.Text = "In-Class";
            // 
            // inclass01CalculatorToolStripMenuItem
            // 
            this.inclass01CalculatorToolStripMenuItem.Name = "inclass01CalculatorToolStripMenuItem";
            this.inclass01CalculatorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inclass01CalculatorToolStripMenuItem.Text = "inclass01_Calculator";
            this.inclass01CalculatorToolStripMenuItem.Click += new System.EventHandler(this.inclass01CalculatorToolStripMenuItem_Click);
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futureValueToolStripMenuItem,
            this.mutidimentionalArraysToolStripMenuItem,
            this.stringManipulationToolStripMenuItem});
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.workToolStripMenuItem.Text = "Work";
            // 
            // futureValueToolStripMenuItem
            // 
            this.futureValueToolStripMenuItem.Name = "futureValueToolStripMenuItem";
            this.futureValueToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.futureValueToolStripMenuItem.Text = "FutureValue";
            this.futureValueToolStripMenuItem.Click += new System.EventHandler(this.futureValueToolStripMenuItem_Click);
            // 
            // mutidimentionalArraysToolStripMenuItem
            // 
            this.mutidimentionalArraysToolStripMenuItem.Name = "mutidimentionalArraysToolStripMenuItem";
            this.mutidimentionalArraysToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.mutidimentionalArraysToolStripMenuItem.Text = "Mutidimentional Arrays";
            this.mutidimentionalArraysToolStripMenuItem.Click += new System.EventHandler(this.mutidimentionalArraysToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // stringManipulationToolStripMenuItem
            // 
            this.stringManipulationToolStripMenuItem.Name = "stringManipulationToolStripMenuItem";
            this.stringManipulationToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.stringManipulationToolStripMenuItem.Text = "String Manipulation";
            this.stringManipulationToolStripMenuItem.Click += new System.EventHandler(this.stringManipulationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 733);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inclass01CalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futureValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutidimentionalArraysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringManipulationToolStripMenuItem;
    }
}

