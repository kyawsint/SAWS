namespace workshopesd
{
    partial class Eg5
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.txtmc = new System.Windows.Forms.TextBox();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.lblmc = new System.Windows.Forms.Label();
            this.lblcusname = new System.Windows.Forms.Label();
            this.lblcusid = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "Ready . . .";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Ready . . .";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(401, 264);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search : ";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(494, 264);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(28, 23);
            this.btnnext.TabIndex = 31;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(311, 264);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 29;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(538, 264);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(30, 23);
            this.btnlast.TabIndex = 32;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(318, 36);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Text = "Find";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Location = new System.Drawing.Point(68, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(156, 39);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(139, 20);
            this.txtsearch.TabIndex = 4;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(211, 264);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(119, 264);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 27;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(80, 264);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(21, 23);
            this.btnprevious.TabIndex = 26;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // txtmc
            // 
            this.txtmc.Location = new System.Drawing.Point(254, 219);
            this.txtmc.Name = "txtmc";
            this.txtmc.Size = new System.Drawing.Size(165, 20);
            this.txtmc.TabIndex = 22;
            // 
            // txtcusname
            // 
            this.txtcusname.Location = new System.Drawing.Point(254, 176);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(165, 20);
            this.txtcusname.TabIndex = 21;
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(254, 132);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(165, 20);
            this.txtcusid.TabIndex = 20;
            // 
            // lblmc
            // 
            this.lblmc.AutoSize = true;
            this.lblmc.Location = new System.Drawing.Point(132, 219);
            this.lblmc.Name = "lblmc";
            this.lblmc.Size = new System.Drawing.Size(99, 13);
            this.lblmc.TabIndex = 25;
            this.lblmc.Text = "Member Category : ";
            // 
            // lblcusname
            // 
            this.lblcusname.AutoSize = true;
            this.lblcusname.Location = new System.Drawing.Point(132, 176);
            this.lblcusname.Name = "lblcusname";
            this.lblcusname.Size = new System.Drawing.Size(91, 13);
            this.lblcusname.TabIndex = 24;
            this.lblcusname.Text = "Customer Name : ";
            // 
            // lblcusid
            // 
            this.lblcusid.AutoSize = true;
            this.lblcusid.Location = new System.Drawing.Point(132, 139);
            this.lblcusid.Name = "lblcusid";
            this.lblcusid.Size = new System.Drawing.Size(74, 13);
            this.lblcusid.TabIndex = 23;
            this.lblcusid.Text = "Customer ID : ";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(30, 264);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(34, 23);
            this.btnfirst.TabIndex = 19;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // Eg5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 402);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.txtmc);
            this.Controls.Add(this.txtcusname);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.lblmc);
            this.Controls.Add(this.lblcusname);
            this.Controls.Add(this.lblcusid);
            this.Controls.Add(this.btnfirst);
            this.Name = "Eg5";
            this.Text = "KYAW";
            this.Load += new System.EventHandler(this.Eg5_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.TextBox txtmc;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label lblmc;
        private System.Windows.Forms.Label lblcusname;
        private System.Windows.Forms.Label lblcusid;
        private System.Windows.Forms.Button btnfirst;
    }
}