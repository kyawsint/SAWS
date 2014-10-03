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
            ((System.ComponentModel.ISupportInitialize)(this.dgvlookup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlookup
            // 
            this.dgvlookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlookup.Location = new System.Drawing.Point(12, 12);
            this.dgvlookup.MultiSelect = false;
            this.dgvlookup.Name = "dgvlookup";
            this.dgvlookup.Size = new System.Drawing.Size(498, 303);
            this.dgvlookup.TabIndex = 0;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(83, 343);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 1;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(254, 342);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // VideoLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 396);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.dgvlookup);
            this.Name = "VideoLookUp";
            this.Text = "VideoLookUp";
            this.Load += new System.EventHandler(this.VideoLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlookup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlookup;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btncancel;
    }
}