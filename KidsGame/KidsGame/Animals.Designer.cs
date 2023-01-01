namespace KidsGame
{
    partial class Animals
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
            this.LearnAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.revisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LearnAnimalToolStripMenuItem,
            this.revisionToolStripMenuItem,
            this.quizToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LearnAnimalToolStripMenuItem
            // 
            this.LearnAnimalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.LearnAnimalToolStripMenuItem.Name = "LearnAnimalToolStripMenuItem";
            this.LearnAnimalToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.LearnAnimalToolStripMenuItem.Text = "Learn";
            this.LearnAnimalToolStripMenuItem.Click += new System.EventHandler(this.LearnAnimalToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // revisionToolStripMenuItem
            // 
            this.revisionToolStripMenuItem.Name = "revisionToolStripMenuItem";
            this.revisionToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.revisionToolStripMenuItem.Text = "Revision";
            this.revisionToolStripMenuItem.Click += new System.EventHandler(this.revisionToolStripMenuItem_Click);
            // 
            // quizToolStripMenuItem1
            // 
            this.quizToolStripMenuItem1.Name = "quizToolStripMenuItem1";
            this.quizToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.quizToolStripMenuItem1.Text = "Quiz";
            this.quizToolStripMenuItem1.Click += new System.EventHandler(this.quizToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Back.FlatAppearance.BorderSize = 3;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(3, 16);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 32);
            this.Back.TabIndex = 0;
            this.Back.Text = "<- Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Animals";
            this.Text = "Animals";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LearnAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
    }
}