namespace workshopgui
{
    partial class CatchAGenie
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
            this.piclamp = new System.Windows.Forms.PictureBox();
            this.picgenie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgenie)).BeginInit();
            this.SuspendLayout();
            // 
            // piclamp
            // 
            this.piclamp.Image = global::workshopgui.Properties.Resources.magic_lamp;
            this.piclamp.Location = new System.Drawing.Point(147, 311);
            this.piclamp.Name = "piclamp";
            this.piclamp.Size = new System.Drawing.Size(73, 66);
            this.piclamp.TabIndex = 0;
            this.piclamp.TabStop = false;
            this.piclamp.Click += new System.EventHandler(this.piclamp_Click);
            this.piclamp.DoubleClick += new System.EventHandler(this.piclamp_DoubleClick);
            // 
            // picgenie
            // 
            this.picgenie.Image = global::workshopgui.Properties.Resources.Genie;
            this.picgenie.Location = new System.Drawing.Point(265, 149);
            this.picgenie.Name = "picgenie";
            this.picgenie.Size = new System.Drawing.Size(94, 124);
            this.picgenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgenie.TabIndex = 1;
            this.picgenie.TabStop = false;
            this.picgenie.Click += new System.EventHandler(this.piclamp_Click);
            this.picgenie.DoubleClick += new System.EventHandler(this.piclamp_DoubleClick);
            // 
            // CatchAGenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 535);
            this.Controls.Add(this.picgenie);
            this.Controls.Add(this.piclamp);
            this.Name = "CatchAGenie";
            this.Text = "CatchAGenie";
            this.Load += new System.EventHandler(this.CatchAGenie_Load);
            this.Click += new System.EventHandler(this.piclamp_Click);
            this.DoubleClick += new System.EventHandler(this.piclamp_DoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Genie_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.piclamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgenie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox piclamp;
        private System.Windows.Forms.PictureBox picgenie;
    }
}