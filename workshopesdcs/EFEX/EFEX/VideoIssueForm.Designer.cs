namespace EFEX
{
    partial class VideoIssueForm
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
            this.btncusdet = new System.Windows.Forms.Button();
            this.btnmovdet = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dtpduedate = new System.Windows.Forms.DateTimePicker();
            this.dtpdateissue = new System.Windows.Forms.DateTimePicker();
            this.txtmovietitle = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.txtvideocode = new System.Windows.Forms.TextBox();
            this.lblremark = new System.Windows.Forms.Label();
            this.lblduedate = new System.Windows.Forms.Label();
            this.lbldateissue = new System.Windows.Forms.Label();
            this.lblcusid = new System.Windows.Forms.Label();
            this.lblvideocode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncusdet
            // 
            this.btncusdet.Location = new System.Drawing.Point(304, 87);
            this.btncusdet.Name = "btncusdet";
            this.btncusdet.Size = new System.Drawing.Size(32, 23);
            this.btncusdet.TabIndex = 31;
            this.btncusdet.Text = "...";
            this.btncusdet.UseVisualStyleBackColor = true;
            this.btncusdet.Click += new System.EventHandler(this.btncusdet_Click);
            // 
            // btnmovdet
            // 
            this.btnmovdet.Location = new System.Drawing.Point(304, 28);
            this.btnmovdet.Name = "btnmovdet";
            this.btnmovdet.Size = new System.Drawing.Size(32, 23);
            this.btnmovdet.TabIndex = 30;
            this.btnmovdet.Text = "...";
            this.btnmovdet.UseVisualStyleBackColor = true;
            this.btnmovdet.Click += new System.EventHandler(this.btnmovdet_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(198, 344);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 29;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dtpduedate
            // 
            this.dtpduedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpduedate.Location = new System.Drawing.Point(198, 193);
            this.dtpduedate.Name = "dtpduedate";
            this.dtpduedate.Size = new System.Drawing.Size(100, 20);
            this.dtpduedate.TabIndex = 28;
            this.dtpduedate.Value = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            // 
            // dtpdateissue
            // 
            this.dtpdateissue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateissue.Location = new System.Drawing.Point(198, 158);
            this.dtpdateissue.Name = "dtpdateissue";
            this.dtpdateissue.Size = new System.Drawing.Size(100, 20);
            this.dtpdateissue.TabIndex = 27;
            // 
            // txtmovietitle
            // 
            this.txtmovietitle.Location = new System.Drawing.Point(198, 57);
            this.txtmovietitle.Name = "txtmovietitle";
            this.txtmovietitle.ReadOnly = true;
            this.txtmovietitle.Size = new System.Drawing.Size(204, 20);
            this.txtmovietitle.TabIndex = 26;
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(198, 89);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(100, 20);
            this.txtcusid.TabIndex = 25;
            this.txtcusid.Leave += new System.EventHandler(this.txtcusid_Leave);
            // 
            // txtcusname
            // 
            this.txtcusname.Location = new System.Drawing.Point(198, 120);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.ReadOnly = true;
            this.txtcusname.Size = new System.Drawing.Size(204, 20);
            this.txtcusname.TabIndex = 24;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(198, 225);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(204, 102);
            this.txtremark.TabIndex = 23;
            // 
            // txtvideocode
            // 
            this.txtvideocode.Location = new System.Drawing.Point(198, 30);
            this.txtvideocode.Name = "txtvideocode";
            this.txtvideocode.Size = new System.Drawing.Size(100, 20);
            this.txtvideocode.TabIndex = 22;
            this.txtvideocode.TextChanged += new System.EventHandler(this.txtvideocode_TextChanged);
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Location = new System.Drawing.Point(94, 225);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(53, 13);
            this.lblremark.TabIndex = 21;
            this.lblremark.Text = "Remark : ";
            // 
            // lblduedate
            // 
            this.lblduedate.AutoSize = true;
            this.lblduedate.Location = new System.Drawing.Point(94, 200);
            this.lblduedate.Name = "lblduedate";
            this.lblduedate.Size = new System.Drawing.Size(62, 13);
            this.lblduedate.TabIndex = 20;
            this.lblduedate.Text = "Due Date : ";
            // 
            // lbldateissue
            // 
            this.lbldateissue.AutoSize = true;
            this.lbldateissue.Location = new System.Drawing.Point(94, 158);
            this.lbldateissue.Name = "lbldateissue";
            this.lbldateissue.Size = new System.Drawing.Size(79, 13);
            this.lbldateissue.TabIndex = 19;
            this.lbldateissue.Text = "Date of Issue : ";
            // 
            // lblcusid
            // 
            this.lblcusid.AutoSize = true;
            this.lblcusid.Location = new System.Drawing.Point(94, 89);
            this.lblcusid.Name = "lblcusid";
            this.lblcusid.Size = new System.Drawing.Size(74, 13);
            this.lblcusid.TabIndex = 18;
            this.lblcusid.Text = "Customer ID : ";
            // 
            // lblvideocode
            // 
            this.lblvideocode.AutoSize = true;
            this.lblvideocode.Location = new System.Drawing.Point(94, 30);
            this.lblvideocode.Name = "lblvideocode";
            this.lblvideocode.Size = new System.Drawing.Size(71, 13);
            this.lblvideocode.TabIndex = 17;
            this.lblvideocode.Text = "Video Code : ";
            // 
            // VideoIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 433);
            this.Controls.Add(this.btncusdet);
            this.Controls.Add(this.btnmovdet);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dtpduedate);
            this.Controls.Add(this.dtpdateissue);
            this.Controls.Add(this.txtmovietitle);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.txtcusname);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.txtvideocode);
            this.Controls.Add(this.lblremark);
            this.Controls.Add(this.lblduedate);
            this.Controls.Add(this.lbldateissue);
            this.Controls.Add(this.lblcusid);
            this.Controls.Add(this.lblvideocode);
            this.Name = "VideoIssueForm";
            this.Text = "VideoIssueForm";
            this.Load += new System.EventHandler(this.VideoIssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncusdet;
        private System.Windows.Forms.Button btnmovdet;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DateTimePicker dtpduedate;
        private System.Windows.Forms.DateTimePicker dtpdateissue;
        public System.Windows.Forms.TextBox txtmovietitle;
        public System.Windows.Forms.TextBox txtcusid;
        public System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.TextBox txtremark;
        public System.Windows.Forms.TextBox txtvideocode;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.Label lblduedate;
        private System.Windows.Forms.Label lbldateissue;
        private System.Windows.Forms.Label lblcusid;
        private System.Windows.Forms.Label lblvideocode;
    }
}