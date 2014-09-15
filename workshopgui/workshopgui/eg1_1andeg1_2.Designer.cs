namespace workshopgui
{
    partial class eg1_1andeg1_2
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lblsubmit = new System.Windows.Forms.Label();
            this.btnbutton2 = new System.Windows.Forms.Button();
            this.btnbutton1 = new System.Windows.Forms.Button();
            this.lblnamemsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(77, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(114, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter your name : ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(198, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(184, 20);
            this.txtname.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(80, 89);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lblsubmit
            // 
            this.lblsubmit.AutoSize = true;
            this.lblsubmit.Location = new System.Drawing.Point(80, 163);
            this.lblsubmit.Name = "lblsubmit";
            this.lblsubmit.Size = new System.Drawing.Size(0, 13);
            this.lblsubmit.TabIndex = 3;
            this.lblsubmit.Visible = false;
            // 
            // btnbutton2
            // 
            this.btnbutton2.Location = new System.Drawing.Point(216, 265);
            this.btnbutton2.Name = "btnbutton2";
            this.btnbutton2.Size = new System.Drawing.Size(75, 23);
            this.btnbutton2.TabIndex = 4;
            this.btnbutton2.Text = "Cancel";
            this.btnbutton2.UseVisualStyleBackColor = true;
            // 
            // btnbutton1
            // 
            this.btnbutton1.BackColor = System.Drawing.Color.SeaGreen;
            this.btnbutton1.Location = new System.Drawing.Point(80, 265);
            this.btnbutton1.Name = "btnbutton1";
            this.btnbutton1.Size = new System.Drawing.Size(75, 23);
            this.btnbutton1.TabIndex = 5;
            this.btnbutton1.Text = "OK";
            this.btnbutton1.UseVisualStyleBackColor = false;
            this.btnbutton1.Click += new System.EventHandler(this.btnbutton1_Click);
            // 
            // lblnamemsg
            // 
            this.lblnamemsg.AutoSize = true;
            this.lblnamemsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamemsg.ForeColor = System.Drawing.Color.Red;
            this.lblnamemsg.Location = new System.Drawing.Point(389, 45);
            this.lblnamemsg.Name = "lblnamemsg";
            this.lblnamemsg.Size = new System.Drawing.Size(13, 16);
            this.lblnamemsg.TabIndex = 6;
            this.lblnamemsg.Text = "*";
            this.lblnamemsg.Visible = false;
            // 
            // WorkShop1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(520, 396);
            this.Controls.Add(this.lblnamemsg);
            this.Controls.Add(this.btnbutton1);
            this.Controls.Add(this.btnbutton2);
            this.Controls.Add(this.lblsubmit);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.MaximizeBox = false;
            this.Name = "WorkShop1";
            this.Text = "MyFirstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lblsubmit;
        private System.Windows.Forms.Button btnbutton2;
        private System.Windows.Forms.Button btnbutton1;
        private System.Windows.Forms.Label lblnamemsg;
    }
}