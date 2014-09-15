namespace workshopgui
{
    partial class ContextMenuStrip
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeBigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::workshopgui.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(254, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBigToolStripMenuItem,
            this.makeNormalToolStripMenuItem,
            this.makeSmallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            // 
            // makeBigToolStripMenuItem
            // 
            this.makeBigToolStripMenuItem.Name = "makeBigToolStripMenuItem";
            this.makeBigToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.makeBigToolStripMenuItem.Text = "Make Big";
            this.makeBigToolStripMenuItem.Click += new System.EventHandler(this.makeBigToolStripMenuItem_Click);
            // 
            // makeNormalToolStripMenuItem
            // 
            this.makeNormalToolStripMenuItem.Name = "makeNormalToolStripMenuItem";
            this.makeNormalToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.makeNormalToolStripMenuItem.Text = "Make Normal";
            this.makeNormalToolStripMenuItem.Click += new System.EventHandler(this.makeNormalToolStripMenuItem_Click);
            // 
            // makeSmallToolStripMenuItem
            // 
            this.makeSmallToolStripMenuItem.Name = "makeSmallToolStripMenuItem";
            this.makeSmallToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.makeSmallToolStripMenuItem.Text = "Make Small";
            this.makeSmallToolStripMenuItem.Click += new System.EventHandler(this.makeSmallToolStripMenuItem_Click);
            // 
            // ContextMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 509);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ContextMenuStrip";
            this.Text = "ContextMenuStrip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSmallToolStripMenuItem;
    }
}