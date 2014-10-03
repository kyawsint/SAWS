namespace workshopesd
{
    partial class VideoLookUp
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
            this.dgvlookup = new System.Windows.Forms.DataGridView();
            this.btnselect = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlookup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlookup
            // 
            this.dgvlookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlookup.Location = new System.Drawing.Point(12, 44);
            this.dgvlookup.MultiSelect = false;
            this.dgvlookup.Name = "dgvlookup";
            this.dgvlookup.ReadOnly = true;
            this.dgvlookup.Size = new System.Drawing.Size(498, 303);
            this.dgvlookup.TabIndex = 0;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(83, 354);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 1;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(254, 353);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(396, 354);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 3;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(51, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(0, 13);
            this.lbltitle.TabIndex = 4;
            // 
            // VideoLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 396);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.dgvlookup);
            this.Name = "VideoLookUp";
            this.Text = "VideoLookUp";
            this.Load += new System.EventHandler(this.VideoLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.DataGridView dgvlookup;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbltitle;
    }
}