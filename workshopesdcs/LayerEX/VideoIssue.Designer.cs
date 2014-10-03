namespace LayerEX
{
    partial class VideoIssue
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
            this.btncusdet.Location = new System.Drawing.Point(289, 109);
            this.btncusdet.Name = "btncusdet";
            this.btncusdet.Size = new System.Drawing.Size(32, 23);
            this.btncusdet.TabIndex = 46;
            this.btncusdet.Text = "...";
            this.btncusdet.UseVisualStyleBackColor = true;
            // 
            // btnmovdet
            // 
            this.btnmovdet.Location = new System.Drawing.Point(289, 50);
            this.btnmovdet.Name = "btnmovdet";
            this.btnmovdet.Size = new System.Drawing.Size(32, 23);
            this.btnmovdet.TabIndex = 45;
            this.btnmovdet.Text = "...";
            this.btnmovdet.UseVisualStyleBackColor = true;
            this.btnmovdet.Click += new System.EventHandler(this.btnmovdet_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(183, 366);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 44;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // dtpduedate
            // 
            this.dtpduedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpduedate.Location = new System.Drawing.Point(183, 215);
            this.dtpduedate.Name = "dtpduedate";
            this.dtpduedate.Size = new System.Drawing.Size(100, 20);
            this.dtpduedate.TabIndex = 43;
            this.dtpduedate.Value = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            // 
            // dtpdateissue
            // 
            this.dtpdateissue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateissue.Location = new System.Drawing.Point(183, 180);
            this.dtpdateissue.Name = "dtpdateissue";
            this.dtpdateissue.Size = new System.Drawing.Size(100, 20);
            this.dtpdateissue.TabIndex = 42;
            // 
            // txtmovietitle
            // 
            this.txtmovietitle.Location = new System.Drawing.Point(183, 79);
            this.txtmovietitle.Name = "txtmovietitle";
            this.txtmovietitle.ReadOnly = true;
            this.txtmovietitle.Size = new System.Drawing.Size(204, 20);
            this.txtmovietitle.TabIndex = 41;
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(183, 111);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(100, 20);
            this.txtcusid.TabIndex = 40;
            // 
            // txtcusname
            // 
            this.txtcusname.Location = new System.Drawing.Point(183, 142);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.ReadOnly = true;
            this.txtcusname.Size = new System.Drawing.Size(204, 20);
            this.txtcusname.TabIndex = 39;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(183, 247);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(204, 102);
            this.txtremark.TabIndex = 38;
            // 
            // txtvideocode
            // 
            this.txtvideocode.Location = new System.Drawing.Point(183, 52);
            this.txtvideocode.Name = "txtvideocode";
            this.txtvideocode.Size = new System.Drawing.Size(100, 20);
            this.txtvideocode.TabIndex = 37;
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Location = new System.Drawing.Point(79, 247);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(53, 13);
            this.lblremark.TabIndex = 36;
            this.lblremark.Text = "Remark : ";
            // 
            // lblduedate
            // 
            this.lblduedate.AutoSize = true;
            this.lblduedate.Location = new System.Drawing.Point(79, 222);
            this.lblduedate.Name = "lblduedate";
            this.lblduedate.Size = new System.Drawing.Size(62, 13);
            this.lblduedate.TabIndex = 35;
            this.lblduedate.Text = "Due Date : ";
            // 
            // lbldateissue
            // 
            this.lbldateissue.AutoSize = true;
            this.lbldateissue.Location = new System.Drawing.Point(79, 180);
            this.lbldateissue.Name = "lbldateissue";
            this.lbldateissue.Size = new System.Drawing.Size(79, 13);
            this.lbldateissue.TabIndex = 34;
            this.lbldateissue.Text = "Date of Issue : ";
            // 
            // lblcusid
            // 
            this.lblcusid.AutoSize = true;
            this.lblcusid.Location = new System.Drawing.Point(79, 111);
            this.lblcusid.Name = "lblcusid";
            this.lblcusid.Size = new System.Drawing.Size(74, 13);
            this.lblcusid.TabIndex = 33;
            this.lblcusid.Text = "Customer ID : ";
            // 
            // lblvideocode
            // 
            this.lblvideocode.AutoSize = true;
            this.lblvideocode.Location = new System.Drawing.Point(79, 52);
            this.lblvideocode.Name = "lblvideocode";
            this.lblvideocode.Size = new System.Drawing.Size(71, 13);
            this.lblvideocode.TabIndex = 32;
            this.lblvideocode.Text = "Video Code : ";
            // 
            // VideoIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 438);
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
            this.Name = "VideoIssue";
            this.Text = "VideoIssue";
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