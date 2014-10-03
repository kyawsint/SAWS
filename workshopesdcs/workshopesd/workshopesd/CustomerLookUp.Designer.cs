namespace workshopesd
{
    partial class CustomerLookUp
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.dgvclookup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclookup)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(43, 36);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(0, 13);
            this.lbltitle.TabIndex = 9;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(388, 372);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 8;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(246, 371);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(75, 372);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 6;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // dgvclookup
            // 
            this.dgvclookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclookup.Location = new System.Drawing.Point(27, 62);
            this.dgvclookup.MultiSelect = false;
            this.dgvclookup.Name = "dgvclookup";
            this.dgvclookup.ReadOnly = true;
            this.dgvclookup.Size = new System.Drawing.Size(498, 303);
            this.dgvclookup.TabIndex = 5;
            // 
            // CustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 412);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.dgvclookup);
            this.Name = "CustomerLookUp";
            this.Text = "CustomerLookUp";
            this.Load += new System.EventHandler(this.CustomerLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnselect;
        public System.Windows.Forms.DataGridView dgvclookup;
    }
}